using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinPG.Forms
{
    public partial class FormLogin : NoneBorderForm
    {
        private static readonly HttpClient client = new();

        public FormLogin()
        {
            InitializeComponent();
            this.Shown += OnShown;
            this.MouseDown += this.MoveForm;
            this.ApplyFormEffects();
        }

        private async void RenderOIDCSignin()
        {
            try
            {
                UriBuilder apiURL = new(Properties.Settings.Default.Server)
                {
                    Path = "/oidc/providers"
                };
                Providers? providers = await client.GetFromJsonAsync<Providers>(apiURL.ToString());
                if (providers == null)
                {
                    MessageBox.Show("The response from the server was null.");
                    return;
                }

                LabelSigninOpt.Visible = providers.Data != null;

                var top = 0;
                PanelOIDC.Invoke(() => PanelOIDC.Controls.Clear());
                foreach (string provider in providers.Data ?? [])
                {
                    Button button = new()
                    {
                        Text = $"Sign in with {provider}",
                        Top = top,
                        Size = new Size(237, 26),
                        UseVisualStyleBackColor = true,
                        Margin = new Padding(0, 10, 0, 10),
                    };
                    button.Click += (s, e) =>
                    {
                        // generate state
                        string state = Guid.NewGuid().ToString();

                        // get secret
                        UriBuilder secretURL = new(Properties.Settings.Default.Server)
                        {
                            Path = "/oidc/secret",
                            Query = $"state={state}",
                        };
                        if (secretURL.Scheme == "ws")
                        {
                            secretURL.Scheme = "http";
                        }
                        else if (secretURL.Scheme == "wss")
                        {
                            secretURL.Scheme = "https";
                        }

                        client.GetStringAsync(secretURL.ToString()).ContinueWith(t =>
                        {
                            if (t.IsFaulted)
                            {
                                MessageBox.Show($"Error: {t.Exception?.Message}");
                                return;
                            }
                            string secret = t.Result;
                            // save secret to psns.json file
                            File.WriteAllText("psns.json", secret);
                            this.Invoke(() =>
                            {
                                this.Hide();
                                new FormMain(this).Show();
                            });

                        });

                        // open brower
                        UriBuilder apiURL = new(Properties.Settings.Default.Server)
                        {
                            Path = $"/oidc/{provider}",
                            Query = $"state={state}",
                        };
                        if (apiURL.Scheme == "ws")
                        {
                            apiURL.Scheme = "http";
                        }
                        else if (apiURL.Scheme == "wss")
                        {
                            apiURL.Scheme = "https";
                        }
                        Process.Start(new ProcessStartInfo(apiURL.ToString()) { UseShellExecute = true });
                    };
                    PanelOIDC.Controls.Add(button);
                    top += 32;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}");
            }
        }


        public void OnShown(object? sender, EventArgs e)
        {
            if (File.Exists("psns.json"))
            {
                string json = File.ReadAllText("psns.json");
                NetworkSecret? networkSecret = JsonSerializer.Deserialize<NetworkSecret>(json);
                if (networkSecret != null && networkSecret.Expire > DateTime.UtcNow)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        this.Hide();
                        new FormMain(this).Show();
                    });
                }
            }
            RenderOIDCSignin();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                NetworkSecret ns = JsonSerializer.Deserialize<NetworkSecret>(TextJSONSecret.Text) ?? new NetworkSecret
                {
                    Secret = string.Empty,
                    Network = string.Empty
                };
                if (String.IsNullOrEmpty(ns.Secret))
                {
                    MessageBox.Show("Invalid JSON secret");
                    return;
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show("Invalid JSON secret: " + ex.Message);
                return;
            }
            File.WriteAllText("psns.json", TextJSONSecret.Text);
            this.Hide();
            new FormMain(this).Show();
        }

        private void PictureBoxSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSettings formSettings = new(this);
            formSettings.Show();
        }
    }

    public class Providers
    {
        public int Code { get; set; }
        public string[]? Data { get; set; }
    }

    public class NetworkSecret {
        [JsonPropertyName("secret")]
        public required string Secret { get; set; }
        [JsonPropertyName("network")]
        public required string Network { get; set; }
        [JsonPropertyName("expire")]
        public DateTime Expire { get; set; }
    }
}
