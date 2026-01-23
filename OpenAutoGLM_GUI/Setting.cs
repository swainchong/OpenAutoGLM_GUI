using SB.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace OpenAutoGLM_GUI
{
    public partial class Setting : Form
    {
        string configPath = AppDomain.CurrentDomain.BaseDirectory + "config.ini";
        public Setting()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            adbSite.Links[0].LinkData = "https://developer.android.com/studio/releases/platform-tools";
            autoglmSite.Links[0].LinkData = "https://github.com/zai-org/Open-AutoGLM";
            ReadConfig();
        }
        private void ReadConfig()
        {
            openFileDialog1.FileName = null;
            if (!File.Exists(configPath))
            {
                IniHelper.AddSectionWithKeyValues(configPath, "Settings", new Dictionary<string, string>
                {
                    { "adb_path", "C:\\Program Files (x86)\\android-sdk\\platform-tools\\adb.exe" },
                    { "mainpy_dir", "" },
                    { "url", "https://open.bigmodel.cn/api/paas/v4" },
                    { "model", "autoglm-phone" },
                    { "api_key", "" }
                });
            }
            path.Text = IniHelper.ReadString(configPath, "Settings", "mainpy_dir", "");
            url.Text = IniHelper.ReadString(configPath, "Settings", "url", "");
            model.Text = IniHelper.ReadString(configPath, "Settings", "model", "");
            api_key.Text = IniHelper.ReadString(configPath, "Settings", "api_key", "");
            adbPath.Text = IniHelper.ReadString(configPath, "Settings", "adb_path", "");
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Text = openFileDialog1.FileName;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                IniHelper.WriteString(configPath, "Settings", "mainpy_dir", path.Text);
                IniHelper.WriteString(configPath, "Settings", "url", url.Text);
                IniHelper.WriteString(configPath, "Settings", "model", model.Text);
                IniHelper.WriteString(configPath, "Settings", "api_key", api_key.Text);
                IniHelper.WriteString(configPath, "Settings", "adb_path", adbPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving configuration: " + ex.Message);
                return;
            }
            finally
            {
                Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browse2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adbPath.Text = openFileDialog1.FileName;
            }
        }

        private void adbSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData.ToString();

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
