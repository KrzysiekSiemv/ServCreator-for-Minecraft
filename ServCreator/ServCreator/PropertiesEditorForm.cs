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

namespace ServCreator
{
    public partial class PropertiesEditorForm : Form
    {
        string pathToEdit;
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
            StreamWriter streamWriter = new StreamWriter(pathToEdit);
            streamWriter.Write(richTextBox1.Text);
            streamWriter.Close();
        }

        private void button1_Click(object sender, EventArgs e) { saveIt(); }
        private void button2_Click(object sender, EventArgs e) { saveIt(); this.Close(); }
    }
}
