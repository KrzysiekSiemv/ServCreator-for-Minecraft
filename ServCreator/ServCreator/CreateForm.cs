using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace ServCreator
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void checkJavaVersion(object sender, EventArgs e)
        {
            Process checkJava = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c java -version",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardError = true
                }
            };

            checkJava.Start();

            string version = checkJava.StandardError.ReadToEnd();
            MessageBox.Show(version, "Java Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createServer(object sender, EventArgs e)
        {
            if (serverEngineCB.Text != "" && serverNameTB.Text != "" && serverPathTB.Text != "" && serverVersionCB.Text != "" && minRAM.Value <= maxRAM.Value && maxRAM.Value >= minRAM.Value && minRAM.Value != 0)
            {
                // Pobieranie pliku serwerowego
                progressBar1.Visible = true;
                WebClient downloader = new WebClient();
                downloader.DownloadProgressChanged += (s, v) => { progressBar1.Value = v.ProgressPercentage; };
                downloader.DownloadFileCompleted += (s, v) => { 
                    progressBar1.Visible = false;
                    MessageBox.Show("Serwer " + serverNameTB.Text + " został utworzony w folderze: " + serverPathTB.Text + ". Za chwilę zostaniesz przekierowany do panelu kontrolnego.");
                };
                downloader.DownloadFileAsync(new Uri("https://file.siemv.pl/gry/minecraft/server/" + serverVersionCB.Text + "/" + serverEngineCB.Text + "/" + "server.jar"), serverPathTB.Text + "\\server.jar");

                // Tworzenie pliku EULA
                StreamWriter eulaWriter = new StreamWriter(serverPathTB.Text + "\\eula.txt");
                eulaWriter.Write("#By changing the setting below to TRUE you are indicating your agreement to our EULA (https://account.mojang.com/documents/minecraft_eula)." + Environment.NewLine + "#" + DateTime.Now + Environment.NewLine + "eula=true");
                eulaWriter.Close();

                // Tworzenie pliku startowego serwera
                StreamWriter startWriter = new StreamWriter(serverPathTB.Text + "\\start.bat");
                startWriter.Write("@echo off" + Environment.NewLine + "java -Xms" + minRAM.Value + "M -Xmx" + maxRAM.Value + "M " + argumentsTB.Text + " -jar server.jar nogui");
                startWriter.Close();

                // Tworzenie pliku dla ServManager
                Server server = new Server();
                server.Name = serverNameTB.Text;
                server.Path = serverPathTB.Text;
                server.Engine = serverEngineCB.Text;
                server.Version = serverVersionCB.Text;
                StreamWriter configWriter = new StreamWriter(serverPathTB.Text + "\\servmanager.json");
                configWriter.Write(JsonConvert.SerializeObject(server));
                configWriter.Close();

                ControlPanelForm controlPanel = new ControlPanelForm(serverPathTB.Text + "\\servmanager.json");
                controlPanel.Show();

                this.Close();
            }
            else
                MessageBox.Show("Nie wypełniono wymaganych pól! Uzupełnij je i dopiero wtedy możesz utworzyć serwer");
        }

        private void selectPath(object sender, EventArgs e)
        {
            if (pathSelector.ShowDialog() == DialogResult.OK)
                serverPathTB.Text = pathSelector.SelectedPath;
        }

        public class Servers
        {
            [JsonProperty]
            public Server server { get; set; }
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

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
