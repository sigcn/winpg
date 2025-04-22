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
            components = new System.ComponentModel.Container();
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
            peerBindingSource = new BindingSource(components);
            LabelNetwork = new Label();
            cyberSwitchStart = new ReaLTaiizor.Controls.CyberSwitch();
            TabControlMain.SuspendLayout();
            tablogs.SuspendLayout();
            tabsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)peerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tablogs);
            TabControlMain.Controls.Add(tabpeers);
            TabControlMain.Controls.Add(tabsettings);
            TabControlMain.Location = new Point(12, 52);
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
            ButtonSave.Location = new Point(47, 230);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(233, 26);
            ButtonSave.TabIndex = 19;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // LabelMTU
            // 
            LabelMTU.AutoSize = true;
            LabelMTU.Location = new Point(47, 190);
            LabelMTU.Name = "LabelMTU";
            LabelMTU.Size = new Size(36, 17);
            LabelMTU.TabIndex = 18;
            LabelMTU.Text = "MTU";
            // 
            // TextMTU
            // 
            TextMTU.Location = new Point(96, 187);
            TextMTU.Name = "TextMTU";
            TextMTU.Size = new Size(184, 23);
            TextMTU.TabIndex = 17;
            TextMTU.Text = "1371";
            // 
            // LabelServer
            // 
            LabelServer.AutoSize = true;
            LabelServer.Location = new Point(47, 105);
            LabelServer.Name = "LabelServer";
            LabelServer.Size = new Size(45, 17);
            LabelServer.TabIndex = 16;
            LabelServer.Text = "Server";
            // 
            // LabelServerValue
            // 
            LabelServerValue.AutoSize = true;
            LabelServerValue.Location = new Point(96, 105);
            LabelServerValue.Name = "LabelServerValue";
            LabelServerValue.Size = new Size(122, 17);
            LabelServerValue.TabIndex = 15;
            LabelServerValue.Text = "wss://openpg.in/pg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 161);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 14;
            label3.Text = "IPv6";
            // 
            // TextIPv6
            // 
            TextIPv6.Location = new Point(96, 158);
            TextIPv6.Name = "TextIPv6";
            TextIPv6.Size = new Size(184, 23);
            TextIPv6.TabIndex = 13;
            TextIPv6.Text = "fd99::25/64";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 132);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 12;
            label2.Text = "IPv4";
            // 
            // TextIPv4
            // 
            TextIPv4.Location = new Point(96, 129);
            TextIPv4.Name = "TextIPv4";
            TextIPv4.Size = new Size(184, 23);
            TextIPv4.TabIndex = 11;
            TextIPv4.Text = "100.99.0.25/24";
            // 
            // ButtonSignout
            // 
            ButtonSignout.Font = new Font("Microsoft YaHei UI", 9F);
            ButtonSignout.Location = new Point(47, 388);
            ButtonSignout.Name = "ButtonSignout";
            ButtonSignout.Size = new Size(233, 26);
            ButtonSignout.TabIndex = 10;
            ButtonSignout.Text = "Sign out";
            ButtonSignout.UseVisualStyleBackColor = true;
            ButtonSignout.Click += ButtonSignout_Click;
            // 
            // peerBindingSource
            // 
            peerBindingSource.DataSource = typeof(Models.Peer);
            // 
            // LabelNetwork
            // 
            LabelNetwork.AutoSize = true;
            LabelNetwork.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            LabelNetwork.Location = new Point(16, 12);
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
            cyberSwitchStart.Location = new Point(305, 9);
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 554);
            Controls.Add(cyberSwitchStart);
            Controls.Add(LabelNetwork);
            Controls.Add(TabControlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)peerBindingSource).EndInit();
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
        private BindingSource peerBindingSource;
        private TabPage tabpeers;
        private ReaLTaiizor.Controls.CyberSwitch cyberSwitchStart;
    }
}