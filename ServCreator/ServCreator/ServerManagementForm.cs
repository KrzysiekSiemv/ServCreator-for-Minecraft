using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ServCreator
{
    public partial class ServerManagementForm : Form
    {
        Process process;
        public ServerManagementForm(Process server)
        {
            InitializeComponent();
            process = server;
        }

        private void ServerManagementForm_Load(object sender, EventArgs e) { gmBox.SelectedIndex = 0; }


        private void banPlayerBtn_Click(object sender, EventArgs e)
        {
            if (reasonPlayerTxt.Text != "")
                process.StandardInput.WriteLine("ban " + nicknameTb.Text + " " + reasonPlayerTxt.Text);
            else
                process.StandardInput.WriteLine("ban " + nicknameTb.Text);
        }

        private void banIPBtn_Click(object sender, EventArgs e)
        {
            if (reasonIpTxt.Text != "")
                process.StandardInput.WriteLine("ban " + ipTxt.Text + " " + reasonIpTxt.Text);
            else
                process.StandardInput.WriteLine("ban " + ipTxt.Text);
        }

        private void kickBtn_Click(object sender, EventArgs e)
        {
            if (reasonPlayerTxt.Text != "")
                process.StandardInput.WriteLine("kick " + nicknameTb.Text + " " + reasonPlayerTxt.Text);
            else
                process.StandardInput.WriteLine("kick " + nicknameTb.Text);
        }

        private void opBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("op " + nicknameTb.Text); }

        private void gmBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("gamemode " + gmBox.Text + " " + nicknameTb.Text); }

        private void wlAddBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("whitelist add " + nicknameTb.Text); }

        private void wlDelBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("whitelist remove " + nicknameTb.Text); }

        private void deopBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("deop " + nicknameTb.Text); }
    }
}
