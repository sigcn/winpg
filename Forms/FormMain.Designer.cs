using WinPG.Properties;

namespace WinPG.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            TabControlMain = new TabControl();
            tablogs = new TabPage();
            TextLogs = new RichTextBox();
            tabpeers = new TabPage();
            tabsettings = new TabPage();
            label7 = new Label();
            ButtonSave = new Button();
            LabelMTU = new Label();
            TextMTU = new TextBox();
            LabelServer = new Label();
            LabelServerValue = new Label();
            label3 = new Label();
            TextIPv6 = new TextBox();
            label2 = new Label();
            TextIPv4 = new TextBox();
            ButtonSignout = new Button();
            LabelNetwork = new Label();
            cyberSwitchStart = new ReaLTaiizor.Controls.CyberSwitch();
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            TabControlMain.SuspendLayout();
            tablogs.SuspendLayout();
            tabsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tablogs);
            TabControlMain.Controls.Add(tabpeers);
            TabControlMain.Controls.Add(tabsettings);
            TabControlMain.Location = new Point(12, 67);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(331, 490);
            TabControlMain.TabIndex = 6;
            TabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
            // 
            // tablogs
            // 
            tablogs.Controls.Add(TextLogs);
            tablogs.Location = new Point(4, 26);
            tablogs.Name = "tablogs";
            tablogs.Padding = new Padding(3);
            tablogs.Size = new Size(323, 460);
            tablogs.TabIndex = 1;
            tablogs.Text = "Logs";
            tablogs.UseVisualStyleBackColor = true;
            // 
            // TextLogs
            // 
            TextLogs.BackColor = SystemColors.ControlLightLight;
            TextLogs.BorderStyle = BorderStyle.None;
            TextLogs.Font = new Font("Microsoft YaHei UI", 8F);
            TextLogs.Location = new Point(-3, 0);
            TextLogs.Name = "TextLogs";
            TextLogs.ReadOnly = true;
            TextLogs.Size = new Size(325, 462);
            TextLogs.TabIndex = 0;
            TextLogs.Text = "";
            TextLogs.WordWrap = false;
            TextLogs.SelectionIndent = 5;
            // 
            // tabpeers
            // 
            tabpeers.AutoScroll = true;
            tabpeers.Location = new Point(4, 26);
            tabpeers.Name = "tabpeers";
            tabpeers.Padding = new Padding(3);
            tabpeers.Size = new Size(323, 460);
            tabpeers.TabIndex = 0;
            tabpeers.Text = "Peers";
            tabpeers.UseVisualStyleBackColor = true;
            // 
            // tabsettings
            // 
            tabsettings.Controls.Add(label7);
            tabsettings.Controls.Add(ButtonSave);
            tabsettings.Controls.Add(LabelMTU);
            tabsettings.Controls.Add(TextMTU);
            tabsettings.Controls.Add(LabelServer);
            tabsettings.Controls.Add(LabelServerValue);
            tabsettings.Controls.Add(label3);
            tabsettings.Controls.Add(TextIPv6);
            tabsettings.Controls.Add(label2);
            tabsettings.Controls.Add(TextIPv4);
            tabsettings.Controls.Add(ButtonSignout);
            tabsettings.Location = new Point(4, 26);
            tabsettings.Name = "tabsettings";
            tabsettings.Size = new Size(323, 460);
            tabsettings.TabIndex = 2;
            tabsettings.Text = "Settings";
            tabsettings.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold);
            label7.Location = new Point(110, 32);
            label7.Name = "label7";
            label7.Size = new Size(94, 27);
            label7.TabIndex = 20;
            label7.Text = "Settings";
            // 
            // ButtonSave
            // 
            ButtonSave.Font = new Font("Microsoft YaHei UI", 9F);
            ButtonSave.Location = new Point(37, 206);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(247, 26);
            ButtonSave.TabIndex = 19;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // LabelMTU
            // 
            LabelMTU.AutoSize = true;
            LabelMTU.Location = new Point(37, 166);
            LabelMTU.Name = "LabelMTU";
            LabelMTU.Size = new Size(36, 17);
            LabelMTU.TabIndex = 18;
            LabelMTU.Text = "MTU";
            // 
            // TextMTU
            // 
            TextMTU.Location = new Point(86, 163);
            TextMTU.Name = "TextMTU";
            TextMTU.Size = new Size(198, 23);
            TextMTU.TabIndex = 17;
            TextMTU.Text = "1371";
            // 
            // LabelServer
            // 
            LabelServer.AutoSize = true;
            LabelServer.Location = new Point(37, 81);
            LabelServer.Name = "LabelServer";
            LabelServer.Size = new Size(45, 17);
            LabelServer.TabIndex = 16;
            LabelServer.Text = "Server";
            // 
            // LabelServerValue
            // 
            LabelServerValue.AutoSize = true;
            LabelServerValue.Location = new Point(86, 81);
            LabelServerValue.Name = "LabelServerValue";
            LabelServerValue.Size = new Size(122, 17);
            LabelServerValue.TabIndex = 15;
            LabelServerValue.Text = "wss://openpg.in/pg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 137);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 14;
            label3.Text = "IPv6";
            // 
            // TextIPv6
            // 
            TextIPv6.Location = new Point(86, 134);
            TextIPv6.Name = "TextIPv6";
            TextIPv6.Size = new Size(198, 23);
            TextIPv6.TabIndex = 13;
            TextIPv6.Text = "fd99::25/64";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 108);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 12;
            label2.Text = "IPv4";
            // 
            // TextIPv4
            // 
            TextIPv4.Location = new Point(86, 105);
            TextIPv4.Name = "TextIPv4";
            TextIPv4.Size = new Size(198, 23);
            TextIPv4.TabIndex = 11;
            TextIPv4.Text = "100.99.0.25/24";
            // 
            // ButtonSignout
            // 
            ButtonSignout.Font = new Font("Microsoft YaHei UI", 9F);
            ButtonSignout.Location = new Point(37, 388);
            ButtonSignout.Name = "ButtonSignout";
            ButtonSignout.Size = new Size(247, 26);
            ButtonSignout.TabIndex = 10;
            ButtonSignout.Text = "Sign out";
            ButtonSignout.UseVisualStyleBackColor = true;
            ButtonSignout.Click += ButtonSignout_Click;
            // 
            // LabelNetwork
            // 
            LabelNetwork.AutoSize = true;
            LabelNetwork.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            LabelNetwork.Location = new Point(11, 38);
            LabelNetwork.Name = "LabelNetwork";
            LabelNetwork.Size = new Size(60, 17);
            LabelNetwork.TabIndex = 9;
            LabelNetwork.Text = "Network";
            // 
            // cyberSwitchStart
            // 
            cyberSwitchStart.Alpha = 50;
            cyberSwitchStart.BackColor = Color.Transparent;
            cyberSwitchStart.Background = true;
            cyberSwitchStart.Background_WidthPen = 2F;
            cyberSwitchStart.BackgroundPen = true;
            cyberSwitchStart.Checked = true;
            cyberSwitchStart.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberSwitchStart.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberSwitchStart.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberSwitchStart.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberSwitchStart.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            cyberSwitchStart.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            cyberSwitchStart.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberSwitchStart.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberSwitchStart.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberSwitchStart.ColorValue = Color.FromArgb(29, 200, 238);
            cyberSwitchStart.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberSwitchStart.Font = new Font("Arial", 11F);
            cyberSwitchStart.ForeColor = Color.FromArgb(245, 245, 245);
            cyberSwitchStart.Lighting = false;
            cyberSwitchStart.LinearGradient_Background = false;
            cyberSwitchStart.LinearGradient_Value = false;
            cyberSwitchStart.LinearGradientPen = false;
            cyberSwitchStart.Location = new Point(305, 35);
            cyberSwitchStart.Name = "cyberSwitchStart";
            cyberSwitchStart.PenWidth = 10;
            cyberSwitchStart.RGB = false;
            cyberSwitchStart.Rounding = true;
            cyberSwitchStart.RoundingInt = 90;
            cyberSwitchStart.Size = new Size(35, 20);
            cyberSwitchStart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberSwitchStart.TabIndex = 10;
            cyberSwitchStart.Tag = "Cyber";
            cyberSwitchStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberSwitchStart.Timer_RGB = 300;
            cyberSwitchStart.CheckedChanged += CyberSwitchStart_CheckedChanged;
            // 
            // controlBox1
            // 
            controlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBox1.BackColor = SystemColors.Control;
            controlBox1.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox1.DefaultLocation = false;
            controlBox1.EnableHoverHighlight = true;
            controlBox1.EnableMaximizeButton = false;
            controlBox1.EnableMinimizeButton = true;
            controlBox1.ForeColor = Color.FromArgb(155, 155, 155);
            controlBox1.Location = new Point(258, 4);
            controlBox1.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox1.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox1.Name = "controlBox1";
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 11;
            controlBox1.Text = "controlBox1";
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Resources.logo;
            hopePictureBox1.Location = new Point(10, 7);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(18, 18);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 12;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 565);
            Controls.Add(hopePictureBox1);
            Controls.Add(controlBox1);
            Controls.Add(cyberSwitchStart);
            Controls.Add(LabelNetwork);
            Controls.Add(TabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinPG";
            Load += FormMain_Load;
            TabControlMain.ResumeLayout(false);
            tablogs.ResumeLayout(false);
            tabsettings.ResumeLayout(false);
            tabsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TabControl TabControlMain;
        private TabPage tablogs;
        private RichTextBox TextLogs;
        private Label LabelNetwork;
        private Button ButtonSignout;
        private TabPage tabsettings;
        private Label label2;
        private TextBox TextIPv4;
        private Label label3;
        private TextBox TextIPv6;
        private Label LabelServer;
        private Label LabelServerValue;
        private Label LabelMTU;
        private TextBox TextMTU;
        private Button ButtonSave;
        private Label label7;
        private TabPage tabpeers;
        private ReaLTaiizor.Controls.CyberSwitch cyberSwitchStart;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}