using System.Diagnostics;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace winpg
{
    public partial class FormLogin : Form
    {
        private static readonly HttpClient client = new();

        public FormLogin()
        {
            InitializeComponent();
        }

        private async void renderOIDCSignin()
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

                if(providers.Data != null)
                {
                    LabelSigninOpt.Visible = true;
                }

                var top = 0;
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


        private void Form1_Load(object sender, EventArgs e)
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
            renderOIDCSignin();
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
