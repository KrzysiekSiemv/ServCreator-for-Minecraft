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

        private void button1_Click(object sender, EventArgs e) { saveIt(); }
        private void button2_Click(object sender, EventArgs e) { saveIt(); this.Close(); }
    }
}