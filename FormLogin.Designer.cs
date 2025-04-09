namespace winpg
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
            pictureBox2 = new PictureBox();
            PanelOIDC = new Panel();
            LabelSigninOpt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TextJSONSecret
            // 
            TextJSONSecret.ForeColor = SystemColors.WindowText;
            TextJSONSecret.Location = new Point(42, 114);
            TextJSONSecret.Multiline = true;
            TextJSONSecret.Name = "TextJSONSecret";
            TextJSONSecret.PlaceholderText = "JSON Secret ";
            TextJSONSecret.Size = new Size(237, 44);
            TextJSONSecret.TabIndex = 0;
            // 
            // signin
            // 
            signin.Location = new Point(42, 164);
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
            logotext.Location = new Point(122, 46);
            logotext.Name = "logotext";
            logotext.Size = new Size(113, 26);
            logotext.TabIndex = 3;
            logotext.Text = "PeerGuard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(86, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.settings_3;
            pictureBox2.Location = new Point(290, 425);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // PanelOIDC
            // 
            PanelOIDC.Location = new Point(42, 234);
            PanelOIDC.Name = "PanelOIDC";
            PanelOIDC.Size = new Size(237, 200);
            PanelOIDC.TabIndex = 6;
            // 
            // LabelSigninOpt
            // 
            LabelSigninOpt.AutoSize = true;
            LabelSigninOpt.Font = new Font("Microsoft YaHei UI", 7F, FontStyle.Bold);
            LabelSigninOpt.Location = new Point(152, 204);
            LabelSigninOpt.Name = "LabelSigninOpt";
            LabelSigninOpt.Size = new Size(22, 15);
            LabelSigninOpt.TabIndex = 7;
            LabelSigninOpt.Text = "OR";
            LabelSigninOpt.Visible = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 460);
            Controls.Add(LabelSigninOpt);
            Controls.Add(PanelOIDC);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(logotext);
            Controls.Add(signin);
            Controls.Add(TextJSONSecret);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormLogin";
            Padding = new Padding(5);
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinPG";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextJSONSecret;
        private Button signin;
        private Label logotext;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel PanelOIDC;
        private Label LabelSigninOpt;
    }
}
