using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace ServCreator
{
    public partial class ControlPanelForm : Form
    {
        public Process process;

        public string configFilePath;
        public string config;

        public string serverPath;
        public string serverName;
        public ControlPanelForm(string configFile)
        {
            InitializeComponent();
            configFilePath = configFile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(serverPath + "\\server.properties"))
            {
                PropertiesEditorForm propertiesEditor = new PropertiesEditorForm(serverPath + "\\server.properties", serverName);
                propertiesEditor.Show();
            }
            else
                MessageBox.Show("File \"server.properties\" doesn't exist. Have you ever run this server?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ControlPanelForm_Load(object sender, EventArgs e)
        {
            string ip = null;
            string port = null;
            StreamReader jsonToString = new StreamReader(configFilePath);
            config = jsonToString.ReadToEnd();
            Server server = JsonConvert.DeserializeObject<Server>(config);

            serverPath = server.Path;
            serverName = server.Name;

            if(File.Exists(serverPath + "\\server.properties"))
            {
                StreamReader streamReader = new StreamReader(serverPath + "\\server.properties");

                string ipLine;
                string portLine;

                while((ipLine = streamReader.ReadLine()) != null)
                {
                    if (ipLine.Contains("server-ip=")) {
                        ip = ipLine.Replace("server-ip=", "").ToString();
                    }
                }

                serverLabel.Text = serverName + Environment.NewLine + ip;
            }
        }



        [JsonObject(MemberSerialization.OptIn)]
        public class Server
        {
            [JsonProperty]
            public string Name { get; set; }

            [JsonProperty]
            public string Path { get; set; }

            [JsonProperty]
            public string Version { get; set; }

            [JsonProperty]
            public string Engine { get; set; }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            enableBoxes(true);
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = serverPath,
                    FileName = serverPath + "\\start.bat",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };

            Thread thread = new Thread(() =>
            {
                process.Start();

                while (!process.StandardOutput.EndOfStream)
                {
                    string output = process.StandardOutput.ReadLine();
                    BeginInvoke(new Action(() =>
                    {
                        outputText.Text += output + Environment.NewLine;
                    }));
                }

                while (!process.StandardError.EndOfStream)
                {
                    string line = process.StandardError.ReadToEnd();
                    BeginInvoke(new Action(() =>
                    {
                        outputText.Text += line + Environment.NewLine;
                    }));
                }
            });

            thread.Start();
        }

        private void ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.Start("cmd.exe", "/c taskkill /f /im java.exe");
            Application.Exit();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            process.StandardInput.WriteLine(commandInput.Text);
        }

        private void outputChanged(object sender, EventArgs e)
        {
            outputText.SelectionStart = outputText.Text.Length;
            outputText.ScrollToCaret();
            commandInput.Focus();
        }

        private void submitCommand(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                process.StandardInput.WriteLine(commandInput.Text);
                commandInput.Text = "";
                commandInput.Focus();
            }
        }

        void enableBoxes(bool value)
        {
            playerMgmtBox.Enabled = value;
            ipBanBox.Enabled = value;
            stopBtn.Enabled = value;
            startBtn.Enabled = !value;
        }

        private void stopBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("stop"); enableBoxes(false); }
        private void opBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("op " + nicknameTb.Text); }

        private void banPlayerBtn_Click(object sender, EventArgs e)
        {
            if(reasonPlayerTxt.Text != "")
                process.StandardInput.WriteLine("ban " + nicknameTb.Text + " " + reasonPlayerTxt.Text);
            else
                process.StandardInput.WriteLine("ban " + nicknameTb.Text);
        }

        private void banIPBtn_Click(object sender, EventArgs e)
        {
            if (reasonIpTxt.Text != "")
                process.StandardInput.WriteLine("ban " + ipTxt.Text + " " + reasonIpTxt.Text);
            else
                process.StandardInput.WriteLine("ban " + ipTxt.Text);
        }
    }
}
