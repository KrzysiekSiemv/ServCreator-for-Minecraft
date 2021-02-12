using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace ServCreator
{
    public partial class AddServerForm : Form
    {
        public AddServerForm()
        {
            InitializeComponent();
        }

        private void selectPath(object sender, EventArgs e)
        {
            if (serverPathSelector.ShowDialog() == DialogResult.OK)
                serverPathBox.Text = serverPathSelector.SelectedPath;
        }

        private void addServer(object sender, EventArgs e)
        {
            if (File.Exists(serverPathBox.Text + "\\start.bat"))
                CreateServManager();
            else if (checkBox1.Checked)
            {
                CreateStart();
                CreateServManager();
            }
            else
                MessageBox.Show("The file \"start.bat\" was not found. Create a new one.", "start.bat not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void CreateServManager()
        {
            if (serverPathBox.Text != "" && serverEngineCB.Text != "" && serverVersionCB.Text != "" && serverNameBox.Text != "")
            {
                Server server = new Server();
                server.Name = serverNameBox.Text;
                server.Path = serverPathBox.Text;
                server.Engine = serverEngineCB.Text;
                server.Version = serverVersionCB.Text;
                StreamWriter configWriter = new StreamWriter(serverPathBox.Text + "\\servmanager.srv");
                configWriter.Write(JsonConvert.SerializeObject(server));
                configWriter.Close();
                MessageBox.Show("Server " + serverNameBox.Text + " has been added. You'll be moved to Control Panel");

                ControlPanelForm controlPanel = new ControlPanelForm(serverPathBox.Text + "\\servmanager.srv");
                controlPanel.Show();

                this.Visible = false;
            }
            else
                MessageBox.Show("The required fields have not been completed! Complete them and try again.", "Required fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void CreateStart()
        {
            if (minRAM.Value <= maxRAM.Value && maxRAM.Value >= minRAM.Value && minRAM.Value != 0)
            {
                StreamWriter startWriter = new StreamWriter(serverPathBox.Text + "\\start.bat");
                startWriter.Write("@echo off" + Environment.NewLine + "java -Xms" + minRAM.Value + "M -Xmx" + maxRAM.Value + "M " + argumentsTB.Text + " -jar server.jar nogui");
                startWriter.Close();
            } else
                MessageBox.Show("The required fields have not been completed! Complete them and try again.", "Required fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AddServerForm_Load(object sender, EventArgs e)
        {
            string json = new WebClient().DownloadString("https://raw.githubusercontent.com/KrzysiekSiemv/ServCreator-for-Minecraft/main/creator.json");
            Creator x = JsonConvert.DeserializeObject<Creator>(json);

            for (int i = 0; i < x.Versions.Length; i++)
                serverVersionCB.Items.Add(x.Versions[i]);

            for (int i = 0; i < x.Engines.Length; i++)
                serverEngineCB.Items.Add(x.Engines[i]);

            serverEngineCB.SelectedIndex = 0;
            serverVersionCB.SelectedIndex = 1;
        }


        public class Creator
        {
            [JsonProperty]
            public string[] Versions { get; set; }

            [JsonProperty]
            public string[] Engines { get; set; }
        }

        private void AddServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
        }
    }
}
