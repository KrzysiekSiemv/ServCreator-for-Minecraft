using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ServCreator
{
    public partial class Form1 : Form
    {
        static Properties.Settings conf = new Properties.Settings();
        public Form1() { InitializeComponent(); }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CreateForm createFrm = new CreateForm();
            createFrm.Show();
            this.Visible = false;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ControlPanelForm controlPanel = new ControlPanelForm(openFileDialog1.FileName);
                controlPanel.Show();
                this.Visible = false;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process process = new Process { 
                StartInfo = new ProcessStartInfo() { 
                    FileName = "cmd.exe", Arguments = "/c taskkill /f /im java.exe", UseShellExecute = false, CreateNoWindow = true 
            }};
            
            process.Start();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddServerForm addServer = new AddServerForm();
            addServer.Show();
            this.Visible = false;
        }
    }
}
