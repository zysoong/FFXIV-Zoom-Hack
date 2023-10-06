using FFXIVZoomHack.Properties;
using ProcessMemoryApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FFXIVZoomHack
{
    public struct ProcessModuleAddress
    {
        public long pBaseOffset;
        public long pModule;
    }

    public partial class Form1 : Form
    {
        [DllImport("USER32.DLL")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private readonly AppSettings _settings;
        private readonly Dictionary<ProcessMemoryReader, ProcessModuleAddress> _processCollection;

        private bool _shouldQuitNextTimeProcessEmpty;

        //DX11 Only
        const long pCurrentZoom = 0x114;
        const long pMinZoom = 0x118;
        const long pMaxZoom = 0x11C;
        const long pCurrentFOV = 0x120;
        const long pMinFOV = 0x124;
        const long pMaxFOV = 0x128;
        const long pCurrentFov = 0x120;
        const long pYMin = 0x148;
        const long pYMax = 0x14C;
        const long pHeight = 0x224;
        const long pMode = 0x170;

        private NotifyIcon _notifyIcon;
        
        public Form1()
        {
            _settings = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(AppSettings.SettingsFile));
            _processCollection = new Dictionary<ProcessMemoryReader, ProcessModuleAddress>();
            InitializeComponent();

            _notifyIcon = new NotifyIcon(components);
            _notifyIcon.Text = "FFXIV Zoom Hack";
            _notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            _notifyIcon.BalloonTipText = "Double click to open app";
            _notifyIcon.BalloonTipTitle = "FFXIV Zoom Hack";
            _notifyIcon.ShowBalloonTip(1000);
            using (var icon = GetType().Assembly.GetManifestResourceStream($"{GetType().Namespace}.zoom_kNq_icon.ico"))
            {
                _notifyIcon.Icon = new Icon(icon);
            }

            _notifyIcon.DoubleClick += (sender, args) =>
            {
                Show();
                WindowState = FormWindowState.Normal;
                _notifyIcon.Visible = false;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //just need call once

            _shouldQuitNextTimeProcessEmpty = false;

            _autoApplyCheckbox.Checked = _settings.AutoApply;
            _autoQuitCheckbox.Checked = _settings.AutoQuit;
            _zoomUpDown.Value = (decimal)_settings.DesiredZoom;
            _fovUpDown.Value = (decimal)_settings.DesiredFov;
        }

        private void FovChanged(object sender, EventArgs e)
        {
            _settings.DesiredFov = (float)_fovUpDown.Value;
            SettingSave(_settings);
            ApplyChanges();
        }

        private void ZoomChanged(object sender, EventArgs e)
        {
            _settings.DesiredZoom = (float)_zoomUpDown.Value;
            SettingSave(_settings);
            ApplyChanges();
        }

        private void Timer1Tick(object sender, EventArgs args)
        {
            ReadyIndicator.Image = _processCollection.Count == 0 ? Resources.RedLight : Resources.GreenLight;

            try
            {
                var activePids = Process.GetProcessesByName("ffxiv_dx11").ToList().Select(x => x.Id).ToList();

                for (var i = 0; i < activePids.Count; i++)
                {
                    //Add new process
                    if (!_processCollection.Keys.Select(x => x.process.Id).Contains(activePids[i]))
                    {
                        var mReader = new ProcessMemoryReader(activePids[i]);
                        var module = new ProcessModuleAddress();
                        module.pBaseOffset = (long)mReader.ScanPtrBySig("48833D********007411488B0D********4885C97405E8********488D0D")[0];
                        module.pModule = mReader.ReadInt64((IntPtr)((long)mReader.process.Modules[0].BaseAddress + module.pBaseOffset));
                        _processCollection.Add(mReader, module);
                    }
                    //update combo box
                    try
                    {
                        _processList.Items[i] = activePids[i];
                    }
                    catch
                    {
                        _processList.Items.Add(activePids[i]);
                    }
                }

                //delete closed process
                foreach (ProcessMemoryReader mReader in _processCollection.Keys)
                {
                    if (!activePids.Contains(mReader.process.Id))
                    {
                        _processCollection.Remove(mReader);
                    }
                }

                //clear combo box
                while (true)
                {
                    if (_processList.Items.Count == activePids.Count) break;
                    else _processList.Items.RemoveAt(_processList.Items.Count - 1);
                }

                if (_processList.Items.Count > 0 && _processList.SelectedItem == null)
                {
                    _processList.SelectedIndex = 0;
                }

                if (_settings.AutoApply && activePids.Count != 0)
                {
                    ApplyChanges();
                }

                if (!activePids.Any() && _settings.AutoQuit && _shouldQuitNextTimeProcessEmpty)
                {
                    Close();
                }
                else if (activePids.Any())
                {
                    _shouldQuitNextTimeProcessEmpty = true;
                }
            }
            catch (Exception ex)
            {
                var logFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FFXIVZoomHack", "log.txt");
                using (var sw = File.AppendText(logFile))
                {
                    sw.WriteLine(ex.Message);
                }
            }
        }

        private void ApplyChanges()
        {
            var ZoomBytes = BitConverter.GetBytes(Convert.ToSingle(_zoomUpDown.Value));
            var FOVBytes = BitConverter.GetBytes(Convert.ToSingle(_fovUpDown.Value));

            var YMinBytes = BitConverter.GetBytes(Convert.ToSingle(_yMinUpDown.Value));
            var YMaxBytes = BitConverter.GetBytes(Convert.ToSingle(_yMaxUpDown.Value));

            var HeightBytes = BitConverter.GetBytes(Convert.ToSingle(_heightUpDown.Value));

            Parallel.ForEach(_processCollection.Keys, mReader => {
                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pMinZoom), BitConverter.GetBytes(Convert.ToSingle(0.001)));
                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pMaxZoom), BitConverter.GetBytes(Convert.ToSingle(20)));
                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pCurrentZoom), ZoomBytes);

                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pMinFOV), BitConverter.GetBytes(Convert.ToSingle(0.69)));
                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pMaxFOV), BitConverter.GetBytes(Convert.ToSingle(0.78)));
                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pCurrentFOV), FOVBytes);

                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pYMin), YMinBytes);
                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pYMax), YMaxBytes);

                mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pHeight), HeightBytes);

                //mReader.WriteByteArray((IntPtr)(_processCollection[mReader].pModule + pMode), BitConverter.GetBytes(Convert.ToSingle(1)));

            });
        }

        private static void SettingSave(AppSettings settings)
        {
            var option = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            var jsonText = JsonSerializer.Serialize(settings, option);
            File.WriteAllText(AppSettings.SettingsFile, jsonText);
        }

        private void AutoApplyCheckChanged(object sender, EventArgs e)
        {
            _settings.AutoApply = _autoApplyCheckbox.Checked;
            SettingSave(_settings);
            if (_settings.AutoApply && _processCollection.Keys.Count() != 0)
            {
                ApplyChanges();
            }
        }

        private void AutoQuitCheckChanged(object sender, EventArgs e)
        {
            _settings.AutoQuit = _autoQuitCheckbox.Checked;
            SettingSave(_settings);
        }

        private void _gotoProcessButton_Click(object sender, EventArgs e)
        {
            if (_processList.SelectedItem == null)
            {
                return;
            }

            var selectedPid = (int)_processList.SelectedItem;
            using (var process = Process.GetProcessById(selectedPid))
            {
                var handle = process.MainWindowHandle;
                if (handle != IntPtr.Zero)
                {
                    SetForegroundWindow(handle);
                }
            }
        }
        
        private void _zoomDefaultButton_Click(object sender, EventArgs e)
        {
            _zoomUpDown.Value = 20m;
        }

        private void _fovDefaultButton_Click(object sender, EventArgs e)
        {
            _fovUpDown.Value = .78m;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
             if (WindowState == FormWindowState.Minimized)  
             {  
                  Hide();  
                  _notifyIcon.Visible = true;                  
             }   
        }

        private void ReadyIndicator_Click(object sender, EventArgs e)
        {

        }

        private void _zoomSettingsBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _yMinUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.DesiredYMin = (float)_yMinUpDown.Value;
            SettingSave(_settings);
            ApplyChanges();
        }

        private void _heightUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.DesiredHeight = (float)_heightUpDown.Value;
            SettingSave(_settings);
            ApplyChanges();
        }

        private void _yMaxUpDown_ValueChanged(object sender, EventArgs e)
        {
            _settings.DesiredYMax = (float)_yMaxUpDown.Value;
            SettingSave(_settings);
            ApplyChanges();
        }

        private void _yMinDefaultButton_Click(object sender, EventArgs e)
        {

        }

        private void _profile1_Click(object sender, EventArgs e)
        {
            _zoomUpDown.Value = 2.00m;
            _fovUpDown.Value = 0.78m;
            _heightUpDown.Value = 0.0m;
            _yMinUpDown.Value = 0.64m;
            _yMaxUpDown.Value = 0.05m;
        }

        private void _profile2_Click(object sender, EventArgs e)
        {
            _zoomUpDown.Value = 2.4m;
            _fovUpDown.Value = 0.78m;
            _heightUpDown.Value = 0.00m;
            _yMinUpDown.Value = 0.48m;
            _yMaxUpDown.Value = 0.13m;
        }

        private void _profile3_Click(object sender, EventArgs e)
        {
            _zoomUpDown.Value = 1.6m;
            _fovUpDown.Value = 0.78m;
            _heightUpDown.Value = 0.10m;
            _yMinUpDown.Value = 0.80m;
            _yMaxUpDown.Value = -0.16m;
        }

        private void _yMaxDefaultButton_Click(object sender, EventArgs e)
        {

        }

        private void _default_Click(object sender, EventArgs e)
        {
            _zoomUpDown.Value = 6.0m;
            _fovUpDown.Value = 0.78m;
            _heightUpDown.Value = 0.0m;
            _yMinUpDown.Value = -1.48m;
            _yMaxUpDown.Value = 0.78m;
        }
    }
}