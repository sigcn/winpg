using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPG.Properties;

namespace WinPG.Forms
{
    public partial class FormSettings : Form
    {

        private FormLogin formLogin;
        public FormSettings(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            this.FormClosing += FormSettings_FormClosing;
        }

        private void FormSettings_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formLogin.Show();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Settings.Default.Server = TextBoxServer.Text;
            Settings.Default.Save();
            this.Close();
            formLogin.OnShown(sender, e);
            formLogin.Show();
        }
    }
}
