using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;

namespace DNS_Changer
{
    public partial class DNS_Changer : Form
    {
        string WifiDns;
        string WifiName;

        public DNS_Changer()
        {
            InitializeComponent();

            var preference = Convert.ToInt32(true); // Make norder darkthemed
            DarkTheme.DwmSetWindowAttribute(this.Handle, DarkTheme.DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, ref preference, sizeof(uint));
        }

        private void DNS_Changer_Load(object sender, EventArgs e)
        {
            WifiInf(out WifiName);

            CheckActivision();
        }

        private void DNS_Changer_Shown(object sender, EventArgs e)
        {
            if (Data.Default.IP1 != "" || Data.Default.IP2 != "") // Load ips
            {
                boxIP1.Focus();
                boxIP1.Texts = Data.Default.IP1;
                boxIP2.Focus();
                boxIP2.Texts = Data.Default.IP2;
            }

            lblText.Focus();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            await ExeCommand($"/c netsh interface ip set dns name=\"{WifiName}\" static {boxIP1.Texts} & netsh interface ip add dns name=\"{WifiName}\" {boxIP2.Texts} index=2");

            CheckActivision();
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            await ExeCommand($"/c netsh interface ip delete dns name=\"{WifiName}\" all");

            lblStatus.Text = "Disconnected";
            lblStatus.ForeColor = Color.FromArgb(255, 80, 80);
            lblIP.Text = "";
        }

        private void WifiInf(out string nic)  // To get current wifi config
        {
            nic = "";
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    foreach (UnicastIPAddressInformation ips in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ips.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !ips.Address.ToString().StartsWith("169")) //to exclude automatic ips
                        {
                            nic = ni.Name;
                        }
                    }
                }
            }
        }

        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            Verb = "runas",
            WindowStyle = ProcessWindowStyle.Hidden,
            FileName = "cmd.exe",
        };

        private async Task ExeCommand(string arg) // Execute a cmd command asynchronously
        {
            try
            {
                startInfo.Arguments = arg;

                await Task.Run(() =>
                {
                    Process process = new Process();
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckActivision() // Check if a custom DNS is enabled
        {
            bool isCustomDNS = DnsInf(out WifiDns);

            if (isCustomDNS)
            {
                lblStatus.Text = "Connected !";
                lblStatus.ForeColor = Color.FromArgb(100, 255, 100);
                lblIP.Text = $"to {WifiDns}";
            }
        }

        private bool DnsInf(out string dns) // To get DNS ip and router ip config
        {
            IPAddress routerIp = null;
            dns = "";

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    IPInterfaceProperties ipProps = ni.GetIPProperties();
                    if (ipProps.GatewayAddresses.Count > 0)
                    {
                        routerIp = ipProps.GatewayAddresses[0].Address;
                    }

                    foreach (IPAddress dnsAddress in ni.GetIPProperties().DnsAddresses)
                    {
                        if (dnsAddress.AddressFamily == AddressFamily.InterNetwork)
                        {
                            dns = dnsAddress.ToString();
                            break;
                        }
                    }
                }
            }

            if (dns != routerIp.ToString())
            {
                return true;
            }

            return false;
        }

        private void DNS_Changer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (boxIP1.Texts != "" || boxIP2.Texts != "") // Save ips
            {
                Data.Default.IP1 = boxIP1.Texts;
                Data.Default.IP2 = boxIP2.Texts;
                Data.Default.Save();
            }
        }

        private void lblIP_MouseHover(object sender, EventArgs e)
        {
            lblIP.Font = new Font(lblIP.Font.Name, 12, FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            lblIP.Font = new Font(lblIP.Font.Name, 12);
        }

        private async void lblIP_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "nslookup";
            p.StartInfo.Arguments = "exit";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            string output = await p.StandardOutput.ReadToEndAsync();
            p.WaitForExit();

            MessageBox.Show(output);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/NeutronOrg/DNS-Changer");
        }
    }
}
