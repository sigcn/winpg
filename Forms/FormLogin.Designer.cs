namespace WinPG.Forms
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            TextJSONSecret = new TextBox();
            signin = new Button();
            logotext = new Label();
            pictureBox1 = new PictureBox();
            PictureBoxSettings = new PictureBox();
            PanelOIDC = new Panel();
            LabelSigninOpt = new Label();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            panel1 = new ReaLTaiizor.Controls.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextJSONSecret
            // 
            TextJSONSecret.ForeColor = SystemColors.WindowText;
            TextJSONSecret.Location = new Point(26, 126);
            TextJSONSecret.Multiline = true;
            TextJSONSecret.Name = "TextJSONSecret";
            TextJSONSecret.PlaceholderText = "JSON Secret ";
            TextJSONSecret.Size = new Size(237, 44);
            TextJSONSecret.TabIndex = 0;
            // 
            // signin
            // 
            signin.Location = new Point(26, 176);
            signin.Name = "signin";
            signin.Size = new Size(237, 26);
            signin.TabIndex = 1;
            signin.Text = "Sign in";
            signin.UseVisualStyleBackColor = true;
            signin.Click += SignIn_Click;
            // 
            // logotext
            // 
            logotext.AutoSize = true;
            logotext.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            logotext.Location = new Point(106, 58);
            logotext.Name = "logotext";
            logotext.Size = new Size(113, 26);
            logotext.TabIndex = 3;
            logotext.Text = "PeerGuard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(70, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // PictureBoxSettings
            // 
            PictureBoxSettings.Image = Properties.Resources.settings_404040;
            PictureBoxSettings.Location = new Point(81, 3);
            PictureBoxSettings.Name = "PictureBoxSettings";
            PictureBoxSettings.Size = new Size(18, 18);
            PictureBoxSettings.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxSettings.TabIndex = 5;
            PictureBoxSettings.TabStop = false;
            PictureBoxSettings.Click += PictureBoxSettings_Click;
            // 
            // PanelOIDC
            // 
            PanelOIDC.Location = new Point(26, 246);
            PanelOIDC.Name = "PanelOIDC";
            PanelOIDC.Size = new Size(237, 187);
            PanelOIDC.TabIndex = 6;
            // 
            // LabelSigninOpt
            // 
            LabelSigninOpt.AutoSize = true;
            LabelSigninOpt.Font = new Font("Microsoft YaHei UI", 7F, FontStyle.Bold);
            LabelSigninOpt.Location = new Point(136, 216);
            LabelSigninOpt.Name = "LabelSigninOpt";
            LabelSigninOpt.Size = new Size(22, 15);
            LabelSigninOpt.TabIndex = 7;
            LabelSigninOpt.Text = "OR";
            LabelSigninOpt.Visible = false;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Properties.Resources.logo;
            hopePictureBox1.Location = new Point(10, 8);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(18, 18);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 14;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // controlBox1
            // 
            controlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlBox1.BackColor = SystemColors.Control;
            controlBox1.CloseHoverColor = Color.FromArgb(230, 17, 35);
            controlBox1.DefaultLocation = false;
            controlBox1.EnableHoverHighlight = true;
            controlBox1.EnableMaximizeButton = false;
            controlBox1.EnableMinimizeButton = false;
            controlBox1.ForeColor = Color.FromArgb(64, 64, 64);
            controlBox1.Location = new Point(195, 5);
            controlBox1.MaximizeHoverColor = Color.FromArgb(74, 74, 74);
            controlBox1.MinimizeHoverColor = Color.FromArgb(63, 63, 65);
            controlBox1.Name = "controlBox1";
            controlBox1.Size = new Size(90, 25);
            controlBox1.TabIndex = 15;
            controlBox1.Text = "controlBox1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(PictureBoxSettings);
            panel1.EdgeColor = SystemColors.Control;
            panel1.Location = new Point(153, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(100, 25);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 16;
            panel1.Text = "panel1";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 435);
            Controls.Add(panel1);
            Controls.Add(controlBox1);
            Controls.Add(hopePictureBox1);
            Controls.Add(LabelSigninOpt);
            Controls.Add(PanelOIDC);
            Controls.Add(pictureBox1);
            Controls.Add(logotext);
            Controls.Add(signin);
            Controls.Add(TextJSONSecret);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormLogin";
            Padding = new Padding(5);
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinPG";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextJSONSecret;
        private Button signin;
        private Label logotext;
        private PictureBox pictureBox1;
        private PictureBox PictureBoxSettings;
        private Panel PanelOIDC;
        private Label LabelSigninOpt;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.Panel panel1;
    }
}
