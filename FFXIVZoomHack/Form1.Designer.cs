namespace FFXIVZoomHack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._autoApplyCheckbox = new System.Windows.Forms.CheckBox();
            this._zoomSettingsBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this._profile2 = new System.Windows.Forms.Button();
            this._profile1 = new System.Windows.Forms.Button();
            this._panYUpDown = new System.Windows.Forms.NumericUpDown();
            this._heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._yMaxDefaultButton = new System.Windows.Forms.Button();
            this._yMinDefaultButton = new System.Windows.Forms.Button();
            this._yMaxUpDown = new System.Windows.Forms.NumericUpDown();
            this._yMinUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._fovUpDown = new System.Windows.Forms.NumericUpDown();
            this._zoomUpDown = new System.Windows.Forms.NumericUpDown();
            this._fovDefaultButton = new System.Windows.Forms.Button();
            this._zoomDefaultButton = new System.Windows.Forms.Button();
            this._fovLabel = new System.Windows.Forms.Label();
            this._zoomLabel = new System.Windows.Forms.Label();
            this._processListBox = new System.Windows.Forms.GroupBox();
            this.ReadyIndicator = new System.Windows.Forms.PictureBox();
            this._autoQuitCheckbox = new System.Windows.Forms.CheckBox();
            this._gotoProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._processList = new System.Windows.Forms.ComboBox();
            this._autoQuitTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._profile3 = new System.Windows.Forms.Button();
            this._zoomSettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._panYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._yMaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._yMinUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._fovUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._zoomUpDown)).BeginInit();
            this._processListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadyIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // _autoApplyCheckbox
            // 
            this._autoApplyCheckbox.AutoSize = true;
            this._autoApplyCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._autoApplyCheckbox.Location = new System.Drawing.Point(10, 25);
            this._autoApplyCheckbox.Name = "_autoApplyCheckbox";
            this._autoApplyCheckbox.Size = new System.Drawing.Size(219, 24);
            this._autoApplyCheckbox.TabIndex = 0;
            this._autoApplyCheckbox.Text = "Automatically apply on load";
            this._autoApplyCheckbox.UseVisualStyleBackColor = true;
            this._autoApplyCheckbox.CheckedChanged += new System.EventHandler(this.AutoApplyCheckChanged);
            // 
            // _zoomSettingsBox
            // 
            this._zoomSettingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._zoomSettingsBox.Controls.Add(this._profile3);
            this._zoomSettingsBox.Controls.Add(this.button1);
            this._zoomSettingsBox.Controls.Add(this._profile2);
            this._zoomSettingsBox.Controls.Add(this._profile1);
            this._zoomSettingsBox.Controls.Add(this._panYUpDown);
            this._zoomSettingsBox.Controls.Add(this._heightUpDown);
            this._zoomSettingsBox.Controls.Add(this.label5);
            this._zoomSettingsBox.Controls.Add(this.label4);
            this._zoomSettingsBox.Controls.Add(this._yMaxDefaultButton);
            this._zoomSettingsBox.Controls.Add(this._yMinDefaultButton);
            this._zoomSettingsBox.Controls.Add(this._yMaxUpDown);
            this._zoomSettingsBox.Controls.Add(this._yMinUpDown);
            this._zoomSettingsBox.Controls.Add(this.label3);
            this._zoomSettingsBox.Controls.Add(this.label2);
            this._zoomSettingsBox.Controls.Add(this._fovUpDown);
            this._zoomSettingsBox.Controls.Add(this._zoomUpDown);
            this._zoomSettingsBox.Controls.Add(this._fovDefaultButton);
            this._zoomSettingsBox.Controls.Add(this._zoomDefaultButton);
            this._zoomSettingsBox.Controls.Add(this._fovLabel);
            this._zoomSettingsBox.Controls.Add(this._zoomLabel);
            this._zoomSettingsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._zoomSettingsBox.Location = new System.Drawing.Point(14, 124);
            this._zoomSettingsBox.Name = "_zoomSettingsBox";
            this._zoomSettingsBox.Size = new System.Drawing.Size(474, 334);
            this._zoomSettingsBox.TabIndex = 1;
            this._zoomSettingsBox.TabStop = false;
            this._zoomSettingsBox.Text = "Zoom Settings";
            this._zoomSettingsBox.Enter += new System.EventHandler(this._zoomSettingsBox_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this._default_Click);
            // 
            // _profile2
            // 
            this._profile2.Location = new System.Drawing.Point(178, 289);
            this._profile2.Name = "_profile2";
            this._profile2.Size = new System.Drawing.Size(70, 26);
            this._profile2.TabIndex = 19;
            this._profile2.Text = "Profile2";
            this._profile2.UseVisualStyleBackColor = true;
            this._profile2.Click += new System.EventHandler(this._profile2_Click);
            // 
            // _profile1
            // 
            this._profile1.Location = new System.Drawing.Point(92, 289);
            this._profile1.Name = "_profile1";
            this._profile1.Size = new System.Drawing.Size(80, 26);
            this._profile1.TabIndex = 18;
            this._profile1.Text = "Profile1";
            this._profile1.UseVisualStyleBackColor = true;
            this._profile1.Click += new System.EventHandler(this._profile1_Click);
            // 
            // _panYUpDown
            // 
            this._panYUpDown.DecimalPlaces = 2;
            this._panYUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._panYUpDown.Location = new System.Drawing.Point(243, 223);
            this._panYUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            131072});
            this._panYUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._panYUpDown.Name = "_panYUpDown";
            this._panYUpDown.Size = new System.Drawing.Size(215, 26);
            this._panYUpDown.TabIndex = 17;
            this._panYUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // _heightUpDown
            // 
            this._heightUpDown.DecimalPlaces = 2;
            this._heightUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this._heightUpDown.Location = new System.Drawing.Point(10, 223);
            this._heightUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._heightUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this._heightUpDown.Name = "_heightUpDown";
            this._heightUpDown.Size = new System.Drawing.Size(215, 26);
            this._heightUpDown.TabIndex = 16;
            this._heightUpDown.ValueChanged += new System.EventHandler(this._heightUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "PanY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Height";
            // 
            // _yMaxDefaultButton
            // 
            this._yMaxDefaultButton.Location = new System.Drawing.Point(362, 130);
            this._yMaxDefaultButton.Name = "_yMaxDefaultButton";
            this._yMaxDefaultButton.Size = new System.Drawing.Size(96, 26);
            this._yMaxDefaultButton.TabIndex = 13;
            this._yMaxDefaultButton.Text = "Default";
            this._yMaxDefaultButton.UseVisualStyleBackColor = true;
            this._yMaxDefaultButton.Click += new System.EventHandler(this._yMaxDefaultButton_Click);
            // 
            // _yMinDefaultButton
            // 
            this._yMinDefaultButton.Location = new System.Drawing.Point(129, 130);
            this._yMinDefaultButton.Name = "_yMinDefaultButton";
            this._yMinDefaultButton.Size = new System.Drawing.Size(96, 26);
            this._yMinDefaultButton.TabIndex = 12;
            this._yMinDefaultButton.Text = "Default";
            this._yMinDefaultButton.UseVisualStyleBackColor = true;
            this._yMinDefaultButton.Click += new System.EventHandler(this._yMinDefaultButton_Click);
            // 
            // _yMaxUpDown
            // 
            this._yMaxUpDown.DecimalPlaces = 7;
            this._yMaxUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._yMaxUpDown.Location = new System.Drawing.Point(243, 162);
            this._yMaxUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this._yMaxUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            this._yMaxUpDown.Name = "_yMaxUpDown";
            this._yMaxUpDown.Size = new System.Drawing.Size(215, 26);
            this._yMaxUpDown.TabIndex = 11;
            this._yMaxUpDown.Value = new decimal(new int[] {
            785398,
            0,
            0,
            393216});
            this._yMaxUpDown.ValueChanged += new System.EventHandler(this._yMaxUpDown_ValueChanged);
            // 
            // _yMinUpDown
            // 
            this._yMinUpDown.DecimalPlaces = 7;
            this._yMinUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._yMinUpDown.Location = new System.Drawing.Point(10, 162);
            this._yMinUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this._yMinUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            this._yMinUpDown.Name = "_yMinUpDown";
            this._yMinUpDown.Size = new System.Drawing.Size(215, 26);
            this._yMinUpDown.TabIndex = 10;
            this._yMinUpDown.Value = new decimal(new int[] {
            1483530,
            0,
            0,
            -2147090432});
            this._yMinUpDown.ValueChanged += new System.EventHandler(this._yMinUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "YMax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "YMin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // _fovUpDown
            // 
            this._fovUpDown.DecimalPlaces = 2;
            this._fovUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._fovUpDown.Location = new System.Drawing.Point(243, 83);
            this._fovUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            131072});
            this._fovUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._fovUpDown.Name = "_fovUpDown";
            this._fovUpDown.Size = new System.Drawing.Size(215, 26);
            this._fovUpDown.TabIndex = 7;
            this._fovUpDown.Value = new decimal(new int[] {
            78,
            0,
            0,
            131072});
            this._fovUpDown.ValueChanged += new System.EventHandler(this.FovChanged);
            // 
            // _zoomUpDown
            // 
            this._zoomUpDown.DecimalPlaces = 3;
            this._zoomUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._zoomUpDown.Location = new System.Drawing.Point(10, 83);
            this._zoomUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._zoomUpDown.Name = "_zoomUpDown";
            this._zoomUpDown.Size = new System.Drawing.Size(215, 26);
            this._zoomUpDown.TabIndex = 6;
            this._zoomUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this._zoomUpDown.ValueChanged += new System.EventHandler(this.ZoomChanged);
            // 
            // _fovDefaultButton
            // 
            this._fovDefaultButton.Location = new System.Drawing.Point(362, 45);
            this._fovDefaultButton.Name = "_fovDefaultButton";
            this._fovDefaultButton.Size = new System.Drawing.Size(96, 26);
            this._fovDefaultButton.TabIndex = 5;
            this._fovDefaultButton.Text = "Default";
            this._fovDefaultButton.UseVisualStyleBackColor = true;
            this._fovDefaultButton.Click += new System.EventHandler(this._fovDefaultButton_Click);
            // 
            // _zoomDefaultButton
            // 
            this._zoomDefaultButton.Location = new System.Drawing.Point(129, 45);
            this._zoomDefaultButton.Name = "_zoomDefaultButton";
            this._zoomDefaultButton.Size = new System.Drawing.Size(96, 26);
            this._zoomDefaultButton.TabIndex = 4;
            this._zoomDefaultButton.Text = "Default";
            this._zoomDefaultButton.UseVisualStyleBackColor = true;
            this._zoomDefaultButton.Click += new System.EventHandler(this._zoomDefaultButton_Click);
            // 
            // _fovLabel
            // 
            this._fovLabel.AutoSize = true;
            this._fovLabel.Location = new System.Drawing.Point(239, 45);
            this._fovLabel.Name = "_fovLabel";
            this._fovLabel.Size = new System.Drawing.Size(99, 20);
            this._fovLabel.TabIndex = 2;
            this._fovLabel.Text = "Field of View";
            // 
            // _zoomLabel
            // 
            this._zoomLabel.AutoSize = true;
            this._zoomLabel.Location = new System.Drawing.Point(6, 45);
            this._zoomLabel.Name = "_zoomLabel";
            this._zoomLabel.Size = new System.Drawing.Size(50, 20);
            this._zoomLabel.TabIndex = 1;
            this._zoomLabel.Text = "Zoom";
            // 
            // _processListBox
            // 
            this._processListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._processListBox.Controls.Add(this.ReadyIndicator);
            this._processListBox.Controls.Add(this._autoQuitCheckbox);
            this._processListBox.Controls.Add(this._gotoProcessButton);
            this._processListBox.Controls.Add(this.label1);
            this._processListBox.Controls.Add(this._processList);
            this._processListBox.Controls.Add(this._autoApplyCheckbox);
            this._processListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._processListBox.Location = new System.Drawing.Point(14, 10);
            this._processListBox.Name = "_processListBox";
            this._processListBox.Size = new System.Drawing.Size(474, 94);
            this._processListBox.TabIndex = 2;
            this._processListBox.TabStop = false;
            this._processListBox.Text = "Processes";
            // 
            // ReadyIndicator
            // 
            this.ReadyIndicator.Location = new System.Drawing.Point(446, 57);
            this.ReadyIndicator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReadyIndicator.Name = "ReadyIndicator";
            this.ReadyIndicator.Size = new System.Drawing.Size(22, 26);
            this.ReadyIndicator.TabIndex = 12;
            this.ReadyIndicator.TabStop = false;
            this.ReadyIndicator.Click += new System.EventHandler(this.ReadyIndicator_Click);
            // 
            // _autoQuitCheckbox
            // 
            this._autoQuitCheckbox.AutoSize = true;
            this._autoQuitCheckbox.Location = new System.Drawing.Point(243, 25);
            this._autoQuitCheckbox.Name = "_autoQuitCheckbox";
            this._autoQuitCheckbox.Size = new System.Drawing.Size(217, 24);
            this._autoQuitCheckbox.TabIndex = 11;
            this._autoQuitCheckbox.Text = "Quit when processes close";
            this._autoQuitTooltip.SetToolTip(this._autoQuitCheckbox, "Automatically close FFXIV Zoom Hack after \r\npreviously detected instances of FFXI" +
        "V are closed");
            this._autoQuitCheckbox.UseVisualStyleBackColor = true;
            this._autoQuitCheckbox.CheckedChanged += new System.EventHandler(this.AutoQuitCheckChanged);
            // 
            // _gotoProcessButton
            // 
            this._gotoProcessButton.Location = new System.Drawing.Point(285, 57);
            this._gotoProcessButton.Name = "_gotoProcessButton";
            this._gotoProcessButton.Size = new System.Drawing.Size(143, 26);
            this._gotoProcessButton.TabIndex = 8;
            this._gotoProcessButton.Text = "Bring to Front";
            this._gotoProcessButton.UseVisualStyleBackColor = true;
            this._gotoProcessButton.Click += new System.EventHandler(this._gotoProcessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Processes";
            // 
            // _processList
            // 
            this._processList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._processList.FormattingEnabled = true;
            this._processList.Location = new System.Drawing.Point(95, 55);
            this._processList.Name = "_processList";
            this._processList.Size = new System.Drawing.Size(172, 28);
            this._processList.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // _profile3
            // 
            this._profile3.Location = new System.Drawing.Point(254, 289);
            this._profile3.Name = "_profile3";
            this._profile3.Size = new System.Drawing.Size(70, 26);
            this._profile3.TabIndex = 21;
            this._profile3.Text = "Profile3";
            this._profile3.UseVisualStyleBackColor = true;
            this._profile3.Click += new System.EventHandler(this._profile3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 470);
            this.Controls.Add(this._processListBox);
            this.Controls.Add(this._zoomSettingsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 509);
            this.MinimumSize = new System.Drawing.Size(515, 509);
            this.Name = "Form1";
            this.Text = "FFXIV Zoom Hack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this._zoomSettingsBox.ResumeLayout(false);
            this._zoomSettingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._panYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._yMaxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._yMinUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._fovUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._zoomUpDown)).EndInit();
            this._processListBox.ResumeLayout(false);
            this._processListBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadyIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox _autoApplyCheckbox;
        private System.Windows.Forms.CheckBox _autoQuitCheckbox;
        private System.Windows.Forms.ToolTip _autoQuitTooltip;
        private System.Windows.Forms.GroupBox _zoomSettingsBox;
        private System.Windows.Forms.GroupBox _processListBox;
        private System.Windows.Forms.Label _fovLabel;
        private System.Windows.Forms.Label _zoomLabel;
        private System.Windows.Forms.Button _fovDefaultButton;
        private System.Windows.Forms.Button _zoomDefaultButton;
        private System.Windows.Forms.NumericUpDown _fovUpDown;
        private System.Windows.Forms.NumericUpDown _zoomUpDown;
        private System.Windows.Forms.Button _gotoProcessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _processList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ReadyIndicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _yMaxUpDown;
        private System.Windows.Forms.NumericUpDown _yMinUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _yMaxDefaultButton;
        private System.Windows.Forms.Button _yMinDefaultButton;
        private System.Windows.Forms.NumericUpDown _panYUpDown;
        private System.Windows.Forms.NumericUpDown _heightUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _profile2;
        private System.Windows.Forms.Button _profile1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button _profile3;
    }
}

