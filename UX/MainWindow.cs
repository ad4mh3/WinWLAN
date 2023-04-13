using SimpleWifi;
using SimpleWifi.Win32;
using SimpleWifi.Win32.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWLAN.UX
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private Wifi wifi;

        private List<AccessPoint> APs = new List<AccessPoint>();

        private IEnumerable<AccessPoint> accessPoints()
        {
            IntegerInputWindow timeoutInput = new IntegerInputWindow("Select the seconds to scan for:", 1, 120, 10);
            timeoutInput.ShowDialog();

            ManagedNativeWifi.NativeWifi.ScanNetworksAsync(timeout: TimeSpan.FromSeconds(timeoutInput.result));

            Thread.Sleep(timeoutInput.result * 1000); // get milliseconds

            return wifi.GetAccessPoints().OrderByDescending(ap => ap.SignalStrength);
        }

        private void InitWLAN(List<AccessPoint> APList, ListBox UIList)
        {
            try
            {
                wifi = new Wifi();

                if (wifi.NoWifiAvailable)
                {
                    MessageBox.Show("Your device does not support WLAN.");
                }
                else
                {
                    wifi.ConnectionStatusChanged += wifi_ConnectionStatusChanged;
                    
                    APList.Clear();
                    foreach (AccessPoint accessPoint in accessPoints())
                        APList.Add(accessPoint);

                    UIList.Items.Clear();
                    foreach (AccessPoint ap in APList)
                        UIList.Items.Add(ap.Name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// Returns a list of every access point in the AP list
        /// </summary>
        /// <returns></returns>
        private List<string> getAPaslist()
        {
            List<string> apList = new List<string>();

            foreach (AccessPoint ap in APs)
                apList.Add(ap.Name);

            return apList;
        }

        /// <summary>
        /// Returns the access point class of an AP list item
        /// </summary>
        /// <param name="ssid"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private AccessPoint getAPFromSSID(string item)
        {
            foreach (AccessPoint ap in APs)
                if (ap.Name == item)
                    return ap;

            MessageBox.Show("No access point exists with this name.");
            return null;
        }

        private void Connect(AccessPoint selectedAP, string password, bool useSavedPasswordIfAlreadyExists = false, string username = "", string domain = "")
        {
            AuthRequest authRequest = new AuthRequest(selectedAP);
            bool overwrite = true;

            if (authRequest.IsPasswordRequired)
            {
                if (selectedAP.HasProfile)
                {
                    if (useSavedPasswordIfAlreadyExists)
                    {
                        overwrite = false;
                    }
                }

                if (overwrite)
                {
                    if (authRequest.IsUsernameRequired)
                    {
                        authRequest.Username = username;
                    }

                    authRequest.Password = password;

                    if (authRequest.IsDomainSupported)
                    {
                        authRequest.Domain = domain;
                    }
                }
            }

            MessageBox.Show($"Connecting to {selectedAP.Name}. Press 'Ok'.");

            // Call API to connect us
            selectedAP.Connect(authRequest, overwrite);
        }

        internal void wifi_ConnectionStatusChanged(object sender, WifiStatusEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    try
                    {
                        MessageBox.Show($"New WiFi change detected: {e.NewStatus.ToString()}");
                    }
                    catch { }
                });
            }
            catch { }
        }

        private void refreshWifiListBtn_Click(object sender, EventArgs e)
        {
            Title.Text = "Scanning...";
            refreshWifiListBtn.Enabled = false;
            Application.DoEvents();
            InitWLAN(APs, wlanList);
            refreshWifiListBtn.Enabled = true;
            Title.Text = "WinWLAN";
        }

        private void wlanList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AccessPoint sAP = getAPFromSSID(wlanList.GetItemText(wlanList.SelectedItem));

                // Name/SSID
                if (sAP.Name == "")
                    Nametxt.Text = "Hidden SSID";
                else
                    Nametxt.Text = sAP.Name;

                // Name/BSSID
                try
                {
                    BSSIDtxt.Text = Helpers.BSSIDHelper.BSSIDArrayToString(
                                sAP.UnderlyingInterface.GetNetworkBssList(sAP.UnderlyingNetworkObject.dot11Ssid, sAP.UnderlyingNetworkObject.dot11BssType, sAP.UnderlyingNetworkObject.securityEnabled)[0].dot11Bssid
                                ).ToUpper();

                    // Check if LAA or UAA
                    char c = BSSIDtxt.Text[1];
                    if (c == '2' || c == '6' || c == 'A' || c == 'E')
                    {
                        BSSIDTypetxt.Text = "LAA (!)";
                    }
                    else
                    {
                        BSSIDTypetxt.Text = "UAA";
                    }
                }
                catch { }

                // AP Type
                switch (sAP.UnderlyingNetworkObject.dot11BssType)
                {
                    case SimpleWifi.Win32.Interop.Dot11BssType.Infrastructure:
                        APTypetxt.Text = "Infrastructure";
                        break;
                    case SimpleWifi.Win32.Interop.Dot11BssType.Independent:
                        APTypetxt.Text = "Independent";
                        break;
                    case SimpleWifi.Win32.Interop.Dot11BssType.Any:
                        APTypetxt.Text = "Any";
                        break;
                }

                // Connectable/not connectable reason
                Connectabletxt.Text = sAP.UnderlyingNetworkObject.networkConnectable.ToString();
                if (!sAP.UnderlyingNetworkObject.networkConnectable)
                    noConnectReasontxt.Text = sAP.UnderlyingNetworkObject.wlanNotConnectableReason.ToString();

                // Cipher
                Ciphertxt.Text = sAP.UnderlyingNetworkObject.dot11DefaultCipherAlgorithm.ToString() + "/" + sAP.UnderlyingNetworkObject.dot11DefaultAuthAlgorithm.ToString();

                // Signal
                SignalStrengthtxt.Text = sAP.SignalStrength.ToString();

                // Flags
                accessPointFlagstxt.Text = sAP.UnderlyingNetworkObject.flags.ToString();

                // AP PHY types
                List<string> phTypes = new List<string>();
                foreach (SimpleWifi.Win32.Interop.Dot11PhyType x in sAP.UnderlyingNetworkObject.Dot11PhyTypes)
                    phTypes.Add(Helpers.PHYHelper.Lookup(((uint)x)));
                PHYTypetxt.Text = String.Join(", ", phTypes);

                // AP Transfer Rate 
                List<string> speedRates = new List<string>();
                foreach (ushort rate in sAP.UnderlyingInterface.GetNetworkBssList(sAP.UnderlyingNetworkObject.dot11Ssid, sAP.UnderlyingNetworkObject.dot11BssType, sAP.UnderlyingNetworkObject.securityEnabled)[0].wlanRateSet.Rates)
                    speedRates.Add(
                        (ushort)(rate & 0x7FFF) + "Mbps" //(ushort)((rate & 0x7FFF) * 0.5) + "Mbps" ???
                        );
                APRatetxt.Text = String.Join(", ", speedRates);
            }
            catch { }
        }

        private void connectToSelectedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AccessPoint sAP = getAPFromSSID(wlanList.GetItemText(wlanList.SelectedItem));

                // If a profile exists, ask if they want to quick-connect using that profile
                if (sAP.HasProfile)
                {
                    DialogResult dialogResult = MessageBox.Show("A profile already exists for this access point. Use the previously saved profile instead of entering the password?", "WinWLAN", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Connect(sAP, "", true);
                        return;
                    }
                }

                // Get password
                InputWindow passwordInput = new InputWindow("WiFi password:");
                passwordInput.ShowDialog();

                // Check if we should continue
                if(passwordInput.DialogResult != DialogResult.OK)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to cancel connecting to this network?", "WinWLAN", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        return;
                    }
                }

                // Get domain
                InputWindow domainInput = new InputWindow("Enter a domain if required:");
                domainInput.ShowDialog();

                // Get username
                InputWindow usernameInput = new InputWindow("Enter a username if required:");
                usernameInput.ShowDialog();

                // Connect using API
                Connect(sAP, passwordInput.result, false, usernameInput.result, domainInput.result);
            }
            catch { }
        }

        private void LAAUAALearnLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("LAA stands for Locally Administered Address and indicates it is not the real, original MAC address but rather one set within the OS by the system administrator.\n\nUAA stands for Universally Administered Address and indicates this is the real MAC address assigned by the device manufacturer.");
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            InitWLAN(APs, wlanList);
        }

        private void ManagedNativeWifilnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/emoacht/ManagedNativeWifi") { UseShellExecute = true });
        }

        private void simpleWifilnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/mahdi-ataollahi/simplewifi") { UseShellExecute = true });
        }
    }
}
