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
            StreamReader jsonToString = new StreamReader(configFilePath);
            config = jsonToString.ReadToEnd();
            Server server = JsonConvert.DeserializeObject<Server>(config);

            serverPath = server.Path;
            serverName = server.Name;
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
                    string line = process.StandardOutput.ReadLine();
                    richTextBox1.Text += line;
                }
            });

            thread.Start();
        }

        private void ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            process.Kill();   
            Application.Exit();
        }
    }
}
