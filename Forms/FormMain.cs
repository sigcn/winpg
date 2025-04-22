using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPG.Models;

namespace WinPG.Forms
{
    public partial class FormMain : NoneBorderForm
    {
        private PGVPN pgvpn = new();
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
            this.TopMost = true;
            this.TopMost = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.TabControlMain_SelectedIndexChanged(sender, e);
        }

        private void ExitClick(object? sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }


        private async void StartVPN()
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
                await Task.Run(process.Start);
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
        }

        private void StopVPN(object? s, EventArgs? e)
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
            this.TabControlMain_SelectedIndexChanged(s, e);
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
            Properties.Settings.Default.Save();
            MessageBox.Show("OK");
        }

        private void TabControlMain_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            if (TabControlMain.SelectedIndex == 1)
            {
                RenderPeers();
                return;
            }
            if (TabControlMain.SelectedIndex == 2)
            {
                LabelServerValue.Text = Properties.Settings.Default.Server;
                TextIPv4.Text = Properties.Settings.Default.IPv4;
                TextIPv6.Text = Properties.Settings.Default.IPv6;
                TextMTU.Text = Properties.Settings.Default.MTU + "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.MouseDown += this.MoveForm;
            this.ApplyFormEffects();
            this.StartVPN();
            Task.Delay(1000).ContinueWith(t =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    this.TabControlMain_SelectedIndexChanged(sender, e);
                }));
            });
        }

        private void CyberSwitchStart_CheckedChanged()
        {
            if (cyberSwitchStart.Checked)
            {
                this.StartVPN();
                return;
            }
            this.StopVPN(null, null);
        }

        private void RenderPeers()
        {
            pgvpn.QueryPeers().ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    MessageBox.Show($"Error: {t.Exception?.Message}");
                    return;
                }
                Peer[]? peers = t.Result;
                if (peers == null)
                {
                    MessageBox.Show("No peers found");
                    return;
                }

                var top = 0;
                this.Invoke((MethodInvoker)(() =>
                {
                    tabpeers.Controls.Clear();
                }));
                foreach (Peer peer in peers) {
                    Label LabelPeerID = new()
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold),
                        Location = new Point(0, 8),
                        Name = "LabelPeerID",
                        Size = new Size(22, 17),
                        TabIndex = 0,
                        Text = peer.ID
                    };
                    Label LabelPeerIPv4 = new()
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold),
                        Location = new Point(0, 30),
                        Name = "LabelPeerIPv4",
                        Size = new Size(34, 17),
                        TabIndex = 1,
                        Text = "IPv4",
                    };
                    Label LabelPeerIPv4Value = new()
                    {
                        AutoSize = true,
                        Location = new Point(50, 30),
                        Name = "LabelPeerIPv4Value",
                        Size = new Size(66, 17),
                        TabIndex = 3,
                        Text = peer.IPv4
                    };
                    Label LabelPeerIPv6 = new()
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold),
                        Location = new Point(0, 48),
                        Name = "LabelPeerIPv6",
                        Size = new Size(34, 17),
                        TabIndex = 2,
                        Text = "IPv6"
                    };
                    Label LabelPeerIPv6Value = new()
                    {
                        AutoSize = true,
                        Location = new Point(50, 48),
                        Name = "LabelPeerIPv6Value",
                        Size = new Size(47, 17),
                        TabIndex = 4,
                        Text = peer.IPv6
                    };
                    Label LabelPeerVersion = new()
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold),
                        Location = new Point(0, 66),
                        Name = "LabelPeerVersion",
                        Size = new Size(55, 17),
                        TabIndex = 9,
                        Text = "Version"
                    };
                    Label LabelPeerVersionValue = new()
                    {
                        AutoSize = true,
                        Location = new Point(50, 66),
                        Name = "LabelPeerVersionValue",
                        Size = new Size(48, 17),
                        TabIndex = 10,
                        Text = peer.Version
                    };
                    Label LabelPeerNAT = new()
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold),
                        Location = new Point(192, 30),
                        Name = "LabelPeerNAT",
                        Size = new Size(35, 17),
                        TabIndex = 5,
                        Text = "NAT"
                    };
                    Label LabelPeerNATValue = new()
                    {
                        AutoSize = true,
                        Location = new Point(242, 30),
                        Name = "LabelPeerNATValue",
                        Size = new Size(34, 17),
                        TabIndex = 7,
                        Text = peer.NAT
                    };
                    Label LabelPeerMode = new()
                    {
                        AutoSize = true,
                        Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold),
                        Location = new Point(192, 48),
                        Name = "LabelPeerMode",
                        Size = new Size(43, 17),
                        TabIndex = 6,
                        Text = "Mode"
                    };
                    Label LabelPeerModeValue = new()
                    {
                        AutoSize = true,
                        Location = new Point(242, 48),
                        Name = "LabelPeerModeValue",
                        Size = new Size(29, 17),
                        TabIndex = 8,
                        Text = peer.Mode
                    };


                    Panel PanelPeer = new()
                    {
                        Size = new Size(306, 91),
                        Top = top,
                    };
                    PanelPeer.Controls.Add(LabelPeerVersionValue);
                    PanelPeer.Controls.Add(LabelPeerVersion);
                    PanelPeer.Controls.Add(LabelPeerModeValue);
                    PanelPeer.Controls.Add(LabelPeerNATValue);
                    PanelPeer.Controls.Add(LabelPeerMode);
                    PanelPeer.Controls.Add(LabelPeerNAT);
                    PanelPeer.Controls.Add(LabelPeerIPv6Value);
                    PanelPeer.Controls.Add(LabelPeerIPv4Value);
                    PanelPeer.Controls.Add(LabelPeerIPv6);
                    PanelPeer.Controls.Add(LabelPeerIPv4);
                    PanelPeer.Controls.Add(LabelPeerID);

                    tabpeers.Invoke((MethodInvoker)(() =>
                    {
                        tabpeers.Controls.Add(PanelPeer);
                    }));
                    top += 91;
                }
            });
        }
    }
}
