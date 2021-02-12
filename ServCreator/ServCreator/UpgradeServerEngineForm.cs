using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace ServCreator
{
    public partial class UpgradeServerEngineForm : Form
    {
        string filePath;
        Server server;
        public ControlPanelForm controlPanel;
        public UpgradeServerEngineForm(string configFilePath)
        {
            InitializeComponent();
            filePath = configFilePath;
        }

        private void UpgradeServerEngineForm_Load(object sender, EventArgs e)
        {
            GetItems();
            GettingCurrerntEngine();
            serverEngineCB.SelectedIndex = 0;
            serverVersionCB.SelectedIndex = 1;
        }

        void GetItems()
        {
            string json = new WebClient().DownloadString("https://raw.githubusercontent.com/KrzysiekSiemv/ServCreator-for-Minecraft/main/creator.json");
            Creator x = JsonConvert.DeserializeObject<Creator>(json);

            for (int i = 0; i < x.Versions.Length; i++)
                serverVersionCB.Items.Add(x.Versions[i]);

            for (int i = 0; i < x.Engines.Length; i++)
                serverEngineCB.Items.Add(x.Engines[i]);
        }

        void GettingCurrerntEngine()
        {
            StreamReader reader = new StreamReader(filePath);
            server = JsonConvert.DeserializeObject<Server>(reader.ReadToEnd());

            label1.Text = "Currently installed on " + server.Name; 
            currentEngineLabel.Text = server.Engine + ", " + server.Version;

            reader.Close();
        }

        void GetOtherVersion()
        {
            if (serverEngineCB.Text != "" && serverVersionCB.Text != "")
            {
                serverVersionCB.Enabled = false;
                serverEngineCB.Enabled = false;

                string name = server.Name;
                string path = server.Path;

                File.Delete(server.Path + "\\server.jar");
                // Pobieranie pliku serwerowego
                progressBar1.Visible = true;
                WebClient downloader = new WebClient();
                downloader.DownloadProgressChanged += (s, v) => { progressBar1.Value = v.ProgressPercentage; };
                downloader.DownloadFileAsync(new Uri("https://file.siemv.pl/gry/minecraft/server/" + serverVersionCB.Text + "/" + serverEngineCB.Text + "/" + "server.jar"), server.Path + "\\server.jar");

                server.Name = name;
                server.Path = path;
                server.Engine = serverEngineCB.Text;
                server.Version = serverVersionCB.Text;
                StreamWriter configWriter = new StreamWriter(path + "\\servmanager.srv");
                configWriter.Write(JsonConvert.SerializeObject(server));
                configWriter.Close();

                downloader.DownloadFileCompleted += (s, v) =>
                {
                    progressBar1.Visible = false;
                    MessageBox.Show("Server engine on " + server.Name + " has been changed to: " + serverEngineCB.Text + ", " + serverVersionCB.Text + ". After pressing the OK button you'll be taken back to the control panel.");

                    this.Close();
                };
            } else
            {
                MessageBox.Show("These fields can't be empty.");
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

        public class Creator
        {
            [JsonProperty]
            public string[] Versions { get; set; }

            [JsonProperty]
            public string[] Engines { get; set; }
        }

        private void UpgradeServerEngineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlPanel.Enabled = true;
            controlPanel.GetFreshConfig();
            this.Close();
        }
    }
}
