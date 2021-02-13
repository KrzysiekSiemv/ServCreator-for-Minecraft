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
        private void teleportBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("tp " + nicknameTb.Text + " " + teleportBox.Text); }
        private void setXpBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("xp set " + nicknameTb.Text + " " + xpBox.Value.ToString()); }
        private void addXpBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("xp add " + nicknameTb.Text + " " + xpBox.Value.ToString()); }
        private void giveBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("give " + nicknameTb.Text + " " + giveItemBox.Text + " " + giveAmountBox.Value.ToString()); }
        private void timeSetBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("time set " + timeBox.Value.ToString()); }
        private void timeAddBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("time add " + timeBox.Value.ToString()); }
        private void dayBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("time set 1000"); }
        private void nightBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("time set 13000"); }
        private void noonBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("time set 6000"); }
        private void midnightBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("time set 18000"); }
        private void weatherBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("weather " + weatherBox.Text); }

        private void whiteListBox_CheckedChanged(object sender, EventArgs e)
        {
            if(whiteListBox.Checked)
                process.StandardInput.WriteLine("whitelist on");
            else
                process.StandardInput.WriteLine("whitelist off");
        }

        private void reloadBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("whitelist reload"); }
        private void printListBtn_Click(object sender, EventArgs e) { process.StandardInput.WriteLine("whitelist list"); }
    }
}
