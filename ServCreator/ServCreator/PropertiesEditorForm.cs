using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ServCreator
{
    public partial class PropertiesEditorForm : Form
    {
        public string pathToEdit;
        StreamWriter writer;
        public PropertiesEditorForm(string path, string name)
        {
            InitializeComponent();
            pathToEdit = path;
            label1.Text = "  You're editing properties for " + name;
        }

        private void PropertiesEditorForm_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(pathToEdit);
            richTextBox1.Text = streamReader.ReadToEnd();
            streamReader.Close();

        }

        void saveIt()
        {
            writer = new StreamWriter(pathToEdit);
            writer.Write(richTextBox1.Text);
            writer.Close();
        }

        void simpleSave()
        {
            var nowalinia = Environment.NewLine;

            writer = new StreamWriter(pathToEdit);
            string serverproperties =
                "#Minecraft server properties" + nowalinia +
                "#" + DateTime.Now + nowalinia +
                "spawn-protection=" + spawnProtection.Value + nowalinia +
                "generator-settings=" + generatorSettings.Text + nowalinia +
                "force-gamemode=" + forceGamemode.Checked.ToString().ToLower() + nowalinia +
                "allow-nether=" + allowNether.Checked.ToString().ToLower() + nowalinia +
                "gamemode=" + gamemode.Text + nowalinia +
                "difficulty=" + difficulty.Text + nowalinia +
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
            MessageBox.Show("Server Properties has been saved.");
        }

        private void button1_Click(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 1)
                saveIt();
            else
                simpleSave();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                saveIt();
            else
                simpleSave();
            
            this.Close(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://minecraft.tools/en/motd.php");
        }
    }
}