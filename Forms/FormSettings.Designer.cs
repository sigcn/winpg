using WinPG.Properties;

namespace WinPG.Forms
{
    partial class FormSettings
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
            TextBoxServer = new TextBox();
            ButtonSave = new Button();
            label1 = new Label();
            panel1 = new ReaLTaiizor.Controls.Panel();
            controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TextBoxServer
            // 
            TextBoxServer.Location = new Point(69, 68);
            TextBoxServer.Name = "TextBoxServer";
            TextBoxServer.Size = new Size(200, 23);
            TextBoxServer.TabIndex = 0;
            TextBoxServer.Text = "wss://openpg.in/pg";
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(69, 97);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(200, 23);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 72);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 2;
            label1.Text = "Server";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.EdgeColor = SystemColors.Control;
            panel1.Location = new Point(147, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(100, 25);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 19;
            panel1.Text = "panel1";
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
            controlBox1.TabIndex = 18;
            controlBox1.Text = "controlBox1";
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Resources.logo;
            hopePictureBox1.Location = new Point(14, 8);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(18, 18);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 17;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 184);
            Controls.Add(panel1);
            Controls.Add(controlBox1);
            Controls.Add(hopePictureBox1);
            Controls.Add(label1);
            Controls.Add(ButtonSave);
            Controls.Add(TextBoxServer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxServer;
        private Button ButtonSave;
        private Label label1;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}