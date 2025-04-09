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
            tabpeers = new TabPage();
            tablogs = new TabPage();
            TextLogs = new TextBox();
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LabelNetwork = new Label();
            TabControlMain.SuspendLayout();
            tablogs.SuspendLayout();
            tabsettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)peerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(tabpeers);
            TabControlMain.Controls.Add(tablogs);
            TabControlMain.Controls.Add(tabsettings);
            TabControlMain.Location = new Point(12, 52);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(331, 490);
            TabControlMain.TabIndex = 6;
            TabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
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
            TextLogs.Font = new Font("Microsoft YaHei UI", 8F);
            TextLogs.Location = new Point(-3, 0);
            TextLogs.Multiline = true;
            TextLogs.Name = "TextLogs";
            TextLogs.ReadOnly = true;
            TextLogs.ScrollBars = ScrollBars.Both;
            TextLogs.Size = new Size(325, 462);
            TextLogs.TabIndex = 0;
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
            ButtonSignout.Text = "Sign Out";
            ButtonSignout.UseVisualStyleBackColor = true;
            ButtonSignout.Click += ButtonSignout_Click;
            // 
            // peerBindingSource
            // 
            peerBindingSource.DataSource = typeof(Models.Peer);
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.start;
            pictureBox1.Location = new Point(319, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += StartVPN;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(252, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 8;
            label1.Text = "Stopped";
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 554);
            Controls.Add(LabelNetwork);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
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
            tablogs.PerformLayout();
            tabsettings.ResumeLayout(false);
            tabsettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)peerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl TabControlMain;
        private TabPage tablogs;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox TextLogs;
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
    }
}