using System;
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

        Server server;
        ServerManagementForm easyManagementFrm;
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

            GetFreshConfig();

            Form1 frm1 = new Form1();
            frm1.Visible = false;

            serverPath = server.Path;
            serverName = server.Name;

            if (File.Exists(serverPath + "\\server.properties"))
            {
                StreamReader streamReader = new StreamReader(serverPath + "\\server.properties");

                string ipLine;

                while ((ipLine = streamReader.ReadLine()) != null)
                {
                    if (ipLine.Contains("server-ip="))
                    {
                        ip = ipLine.Replace("server-ip=", "").ToString();
                    }
                }

                serverLabel.Text = serverName + Environment.NewLine + ip;
                streamReader.Close();
            }

            if (server.Engine != "vanilla")
                pluginsBtn.Visible = true;
        }

        public void GetFreshConfig()
        {
            StreamReader jsonToString = new StreamReader(configFilePath);
            config = jsonToString.ReadToEnd();
            server = JsonConvert.DeserializeObject<Server>(config);
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
            outputText.Text = "Loading server. Please wait...";
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
            easyManagementFrm = new ServerManagementForm(process);
        }

        private void ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e) { Application.Exit(); }
        private void submit_Click(object sender, EventArgs e) { process.StandardInput.WriteLine(commandInput.Text); commandInput.Text = ""; commandInput.Focus(); }
        private void easyManagement(object sender, EventArgs e) { easyManagementFrm.Show(); }
        private void outputChanged(object sender, EventArgs e) { outputText.SelectionStart = outputText.Text.Length; outputText.ScrollToCaret(); }

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
            stopBtn.Enabled = value;
            killBtn.Enabled = value;
            startBtn.Enabled = !value;
            easyManagementBtn.Enabled = value;
        }

        private void stopBtn_Click(object sender, EventArgs e) 
        { 
            process.StandardInput.WriteLine("stop"); 
            enableBoxes(false); 
            outputText.Text += "Server has been stoped.";
            easyManagementFrm.Close();
        }

        private void killBtn_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c taskkill /f /im java.exe");
            enableBoxes(false);
            outputText.Text += "Server has been killed.";
            easyManagementFrm.Close();
        }

        private void commandInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void pluginsBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", serverPath + "\\plugins");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpgradeServerEngineForm upgrader = new UpgradeServerEngineForm(configFilePath);
            upgrader.controlPanel = this;
            upgrader.Show();
            this.Enabled = false;
        }
    }
}
