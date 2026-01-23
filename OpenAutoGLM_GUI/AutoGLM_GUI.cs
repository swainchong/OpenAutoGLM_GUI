using CustomAlertBoxDemo;
using SharpAdbClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SB.Helper;

namespace OpenAutoGLM_GUI
{
    public partial class AutoGLM_GUI : Form
    {
        private struct requestPara
        {
            public string mainpy_path { get; set; }
            public string url { get; set; }
            public string model { get; set; }
            public string API { get; set; }
        }
        
        AdbClient _adbClient = new AdbClient();
        ProcessExec _processExec = new ProcessExec();
        DnsEndPoint dnsEndPoint;
        AntdUI.Chat.TextChatItem aiItem = new AntdUI.Chat.TextChatItem("") { Me = false };

        requestPara _requestPara;
        List<DeviceData> devices;
        bool state = true;
        string configPath = AppDomain.CurrentDomain.BaseDirectory + "config.ini";
        string adbPath;
        bool flag = true;

        public AutoGLM_GUI()
        {
            InitializeComponent();
            ReadConfig();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = send;
            send.Icon = Properties.Resources.up;

            _processExec.OutputReceived += OnOutput;
            _processExec.ErrorReceived += OnOutput;
            _processExec.ProcessExited += OnExit;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var adbServerState = RunAdbServer();
            connect.Enabled = adbServerState;
            disconnect.Enabled = adbServerState;
            Test();
        }
        //Update Connected Devices
        private void UpdateDevices()
        {
            RunOnUI(() => devicesList.Items.Clear());
            devices = _adbClient.GetDevices();
            foreach (var device in devices)
            {
                RunOnUI(() =>
                {
                    devicesList.Items.Add($"{device.Name} ({device.Serial})");
                });
            }
            if (devices.Count > 0)
            {
                RunOnUI(() =>
                {
                    devicesList.SelectedIndex = 0;
                });
            }
        }
        //Manual Connect
        private void connect_Click(object sender, EventArgs e)
        {
            if (!ValidIP(ip.Text))
                return;
            dnsEndPoint = new DnsEndPoint(ip.Text, (int)port.Value);
            try
            {
                _adbClient.Connect(dnsEndPoint);
            }
            catch (Exception ex)
            {
                RunOnUI(() => AddAdbRep(ex.Message));
            }

        }
        //Add to log when new device is connected
        private void OnDeviceConnected(object sender, DeviceDataEventArgs e)
        {
            RunOnUI(() => AddAdbRep($"The device {e.Device.Serial} has connected to this PC"));
            UpdateDevices();
        }
        //Add to log when device is disconnected
        private void DeviceDisconnected(object sender, DeviceDataEventArgs e)
        {
            RunOnUI(() => AddAdbRep($"The device {e.Device.Serial} has disconnected"));
            UpdateDevices();
        }
        //Adb log
        private void AddAdbRep(string msg)
        {
            adbResp.AppendText($"{DateTime.Now.ToString()} -->> {msg}" + Environment.NewLine);
        }
        private bool RunAdbServer()
        {
            var dialogResult = DialogResult;
            if (!File.Exists(adbPath))
            {
                dialogResult = MessageBox.Show(
                    $"ADB executable not found at { adbPath } ! \r\nDo you want to download now?\r\nClick \"No\" to choose an existing path in Setting",
                    "Warning",
                    MessageBoxButtons.YesNo
                    );
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://developer.android.com/studio/releases/platform-tools");
                    Application.Exit();
                }
                return false;
            }
            AdbServer server = new AdbServer();
            var result = server.StartServer(adbPath, restartServerIfNewer: false);
            return result == StartServerResult.Started || result == StartServerResult.AlreadyRunning;
        }
        //Start monitoring Devices
        private void Test()
        {
            var monitor = new DeviceMonitor(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)));
            monitor.DeviceConnected += this.OnDeviceConnected;
            monitor.DeviceDisconnected += this.DeviceDisconnected;
            monitor.Start();
        }
        //Modify UI Controls on other thread
        private void RunOnUI(Action action)
        {
            if (action == null) return;
            if (this.IsHandleCreated && this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)(() => { if (!this.IsDisposed) action(); }));
            }
            else
            {
                if (!this.IsDisposed) action();
            }
        }
        //Check whether input IP is available
        private bool ValidIP(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
            {
                MessageBox.Show("IP Address is NULL!");
                return false;
            }
            else
            {
                string pattern = @"^((25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)$";
                if (!Regex.IsMatch(ip, pattern))
                {
                    MessageBox.Show("Invalid IP Address!");
                    return false;
                }
                return true;
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            if (!ValidIP(ip.Text))
                return;
            dnsEndPoint = new DnsEndPoint(ip.Text, (int)port.Value);
            try
            {
                _adbClient.Disconnect(dnsEndPoint);
            }
            catch
            {
                RunOnUI(() => AddAdbRep("Failed! Device may disconnect already"));
            }
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            using (Setting setting = new Setting())
            {
                setting.StartPosition = FormStartPosition.CenterParent;
                setting.ShowDialog(this);
                ReadConfig();
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (state)
            {
                if (input.Text == "" || input.Text == null)
                {
                    this.Alert("Input is empty!", Form_Alert.enmType.Warning);
                    return;
                }
                else if (devicesList.SelectedIndex == -1)
                {
                    this.Alert("No device connected!", Form_Alert.enmType.Error);
                    return;
                }
                chatList1.Items.Add(new AntdUI.Chat.TextChatItem(input.Text) { Me = true });
                _processExec.Start(
                    "python",
                    BuildArguments(input.Text),
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.UserProfile)
                    );
                state = false;
                send.Icon = Properties.Resources.stop;
                input.Text = null;
                aiItem = new AntdUI.Chat.TextChatItem("") { Me = false };
                chatList1.Items.Add(aiItem);
            }
            else StopExec();
        }
        //Custom Alert Box
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public void ReadConfig()
        {
            if (!File.Exists(configPath))
            {
                IniHelper.AddSectionWithKeyValues(configPath, "Settings", 
                    new Dictionary<string, string>
                    {
                        { "adb_path", "C:\\Program Files (x86)\\android-sdk\\platform-tools\\adb.exe" },
                        { "mainpy_dir", "" },
                        { "url", "https://open.bigmodel.cn/api/paas/v4" },
                        { "model", "autoglm-phone" },
                        { "api_key", "" }
                    });
            }
            _requestPara.mainpy_path = IniHelper.ReadString(configPath, "Settings", "mainpy_dir", "");
            _requestPara.url = IniHelper.ReadString(configPath, "Settings", "url", "https://open.bigmodel.cn/api/paas/v4");
            _requestPara.model = IniHelper.ReadString(configPath, "Settings", "model", "autoglm-phone");
            _requestPara.API = IniHelper.ReadString(configPath, "Settings", "api_key", "");
            adbPath = IniHelper.ReadString(configPath, "Settings", "adb_path", "");
        }
        private string BuildArguments(string command)
        {
            string arg = $" -u -X utf8 {_requestPara.mainpy_path}";
            if (useSelect.Checked){
                arg += $" --device-id {devices[devicesList.SelectedIndex].Serial}";
            }
            return
                arg +
                $" --base-url { _requestPara.url }" +
                $" --model { _requestPara.model }" +
                $" --apikey { _requestPara.API }" +
                $" \"{ command }\"";
        }
        private void OnOutput(string data)
        {
            RunOnUI(() =>
            {
                aiItem.Text += data + Environment.NewLine;
                chatList1.Invalidate();
                chatList1.ToBottom();
            });
        }
        private void OnExit()
        {
            state = false;
            RunOnUI(() =>
            {
                send.Icon = Properties.Resources.up;
            });
        }
        private void StopExec()
        {
            _processExec?.Dispose();
            state = true;
            RunOnUI(() =>
            {
                send.Icon = Properties.Resources.up;
            });
        }

        private void AutoGLM_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                MinimizeToTray();
                e.Cancel = true;
                return;
            }
            if (!state)
            {
                var result = MessageBox.Show("A process is running. Are you sure to exit?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    StopExec();
                }
            }   
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreFromTray();
        }
        private void MinimizeToTray()
        {
            Hide();
            //notifyIcon1.Visible = true;
            if (flag) notifyIcon1.ShowBalloonTip(1000, "OpenAutoGLM_GUI", "Application minimized to tray.", ToolTipIcon.Info);
            flag = false;
        }
        private void RestoreFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal;
            //notifyIcon1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            RestoreFromTray();
        }
    }
}
