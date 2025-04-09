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
            SuspendLayout();
            // 
            // TextBoxServer
            // 
            TextBoxServer.Location = new Point(77, 54);
            TextBoxServer.Name = "TextBoxServer";
            TextBoxServer.Size = new Size(219, 23);
            TextBoxServer.TabIndex = 0;
            TextBoxServer.Text = Settings.Default.Server;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(77, 83);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(219, 23);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 58);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 2;
            label1.Text = "Server";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 184);
            Controls.Add(label1);
            Controls.Add(ButtonSave);
            Controls.Add(TextBoxServer);
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxServer;
        private Button ButtonSave;
        private Label label1;
    }
}