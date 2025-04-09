using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPG.Forms
{
    public partial class FormMain : Form
    {
        private Process? process;
        private readonly NotifyIcon trayIcon;
        private readonly ContextMenuStrip trayMenu;
        private readonly FormLogin formLogin;
        public FormMain(FormLogin formLogin)
        {
            this.formLogin = formLogin;
            InitializeComponent();
            // init data
            string json = File.ReadAllText("psns.json");
            NetworkSecret networkSecret = JsonSerializer.Deserialize<NetworkSecret>(json) ?? new NetworkSecret
            {
                Secret = string.Empty,
                Network = string.Empty
            };
            LabelNetwork.Text = networkSecret.Network;

            // tray
            new ToolTip().SetToolTip(pictureBox1, "start");
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Exit", null, ExitClick);

            trayIcon = new NotifyIcon
            {
                Icon = resources.GetObject("$this.Icon") as Icon,
                Visible = true,
                ContextMenuStrip = trayMenu,
                Text = "WinPG"
            };

            trayIcon.MouseClick += TrayIcon_Click;
            this.FormClosing += MainForm_FormClosing;
        }
        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && trayIcon.Visible)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        private void TrayIcon_Click(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ExitClick(object? sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }


        private void StartVPN(object? sender, EventArgs e)
        {
            process = new();
            process.StartInfo.FileName = "pgcli.exe";
            process.StartInfo.Arguments = $"vpn -s {Properties.Settings.Default.Server} -f psns.json";
            if (Properties.Settings.Default.MTU > 0)
            {
                process.StartInfo.Arguments += $" --mtu {Properties.Settings.Default.MTU}";
            }
            if (!String.IsNullOrEmpty(Properties.Settings.Default.IPv4))
            {
                process.StartInfo.Arguments += $" -4 \"{Properties.Settings.Default.IPv4}\"";
            }
            if (!String.IsNullOrEmpty(Properties.Settings.Default.IPv6))
            {
                process.StartInfo.Arguments += $" -6 \"{Properties.Settings.Default.IPv6}\"";
            }
            TextLogs.Invoke((MethodInvoker)(() => TextLogs.AppendText(process.StartInfo.Arguments + Environment.NewLine)));
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    TextLogs.Invoke((MethodInvoker)(() => TextLogs.AppendText(e.Data + Environment.NewLine)));
                }
            };
            process.ErrorDataReceived += (s, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    TextLogs.Invoke((MethodInvoker)(() => TextLogs.AppendText(e.Data + Environment.NewLine)));
                }
            };

            try
            {
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

            Application.ApplicationExit -= StopVPN;
            Application.ApplicationExit += StopVPN;
            pictureBox1.Image = Properties.Resources.stop;
            pictureBox1.Click -= StartVPN;
            pictureBox1.Click += StopVPN;
            label1.Text = "Started";
            label1.ForeColor = Color.Green;
            new ToolTip().SetToolTip(pictureBox1, "stop");
        }

        private void StopVPN(object? s, EventArgs e)
        {
            try
            {
                if (process != null && !process.HasExited)
                {
                    process.Kill();
                    process.Dispose();
                }

            }
            catch (Exception) { }
            pictureBox1.Image = Properties.Resources.start;
            pictureBox1.Click -= StopVPN;
            pictureBox1.Click += StartVPN;
            label1.Text = "Stopped";
            label1.ForeColor = Color.Red;
            new ToolTip().SetToolTip(pictureBox1, "start");
        }

        private void ButtonSignout_Click(object sender, EventArgs e)
        {
            this.StopVPN(sender, e);
            trayIcon.Visible = false;
            trayIcon.Dispose();
            this.Close();
            File.Delete("psns.json");
            formLogin.Show();
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IPv4 = TextIPv4.Text;
            Properties.Settings.Default.IPv6 = TextIPv6.Text;
            try
            {
                Properties.Settings.Default.MTU = int.Parse(TextMTU.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            MessageBox.Show("OK");
        }

        private void TabControlMain_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (TabControlMain.SelectedIndex == 2)
            {
                TextIPv4.Text = Properties.Settings.Default.IPv4;
                TextIPv6.Text = Properties.Settings.Default.IPv6;
                TextMTU.Text = Properties.Settings.Default.MTU + "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.StartVPN(sender, e);
        }
    }
}
