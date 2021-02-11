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
        static Properties.Settings conf = new Properties.Settings();
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
                StreamWriter configWriter = new StreamWriter(serverPathTB.Text + "\\servmanager.srv");
                configWriter.Write(JsonConvert.SerializeObject(server));
                configWriter.Close();

                // Tworzenie pliku server.properties
                var nowalinia = Environment.NewLine;

                StreamWriter writer = new StreamWriter(serverPathTB.Text + "\\server.properties");
                string serverproperties =
                    "#Minecraft server properties" + nowalinia +
                    "#" + DateTime.Now + nowalinia +
                    "spawn-protection=" + spawnProtection.Value + nowalinia +
                    "generator-settings=" + generatorSettings.Text + nowalinia +
                    "force-gamemode=" + forceGamemode.Checked.ToString().ToLower() + nowalinia +
                    "allow-nether=" + allowNether.Checked.ToString().ToLower() + nowalinia +
                    "gamemode=" + gamemode.SelectedIndex.ToString() + nowalinia +
                    "difficulty=" + difficulty.SelectedIndex.ToString() + nowalinia +
                    "spawn-monstars=" + spawnMonsters.Checked.ToString().ToLower() + nowalinia +
                    "pvp=" + enablePvp.Checked.ToString().ToLower() + nowalinia +
                    "level-type=default" + nowalinia +
                    "hardcore=" + hardcore.Checked.ToString().ToLower() + nowalinia +
                    "enable-status=" + enableStatus.Checked.ToString().ToLower() + nowalinia +
                    "enable-command-block=" + enableCommandBlocks.Checked.ToString().ToLower() + nowalinia +
                    "max-players=" + maxPlayers.Value + nowalinia +
                    "max-world-size=" + maxWorldSize.Value + nowalinia +
                    "server-port=" + serverPort.Value + nowalinia +
                    "server-ip=" + serverIp.Text + nowalinia +
                    "max-build-height=" + maxBuildingHeight.Value.ToString() + nowalinia +
                    "spawn-npcs=" + spawnNpcs.Checked.ToString().ToLower() + nowalinia +
                    "allow-flight=" + allowFlight.Checked.ToString().ToLower() + nowalinia +
                    "level-name=" + levelName.Text + nowalinia +
                    "view-distance=" + viewDistance.Value + nowalinia +
                    "spawn-animals=" + spawnAnimals.Checked.ToString().ToLower() + nowalinia +
                    "white-list=" + whiteList.Checked.ToString().ToLower() + nowalinia +
                    "generate-structures=" + generateStructures.Checked.ToString().ToLower() + nowalinia +
                    "online-mode=" + onlineMode.Checked.ToString().ToLower() + nowalinia +
                    "motd=" + motd.Text + nowalinia;
                writer.Write(serverproperties);
                writer.Close();

                downloader.DownloadFileCompleted += (s, v) => {
                    progressBar1.Visible = false;
                    MessageBox.Show("Server " + serverNameTB.Text + " has been created in: " + serverPathTB.Text + ". After pressing the OK button you'll be taken to the control panel.");

                    ControlPanelForm controlPanel = new ControlPanelForm(serverPathTB.Text + "\\servmanager.srv");
                    controlPanel.Show();

                    this.Close();
                };
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

        public class Creator
        {
            [JsonProperty]
            public string Versions { get; set; }

            [JsonProperty]
            public string Engines { get; set; }
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            serverEngineCB.SelectedIndex = 0;
            serverVersionCB.SelectedIndex = 0;

            string json = new WebClient().DownloadString("https://raw.githubusercontent.com/KrzysiekSiemv/ServCreator-for-Minecraft/main/creator.json");
            var x = JsonConvert.DeserializeObject<Creator>(json);
            foreach (var engine in x.Engines) { serverEngineCB.Items.Add(engine); }
            foreach (var version in x.Versions) { serverVersionCB.Items.Add(version); }
            
        }

        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://minecraft.gamepedia.com/Server.properties");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://account.mojang.com/documents/minecraft_eula");
        }
    }
}
