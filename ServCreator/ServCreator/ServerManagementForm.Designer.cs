
namespace ServCreator
{
    partial class ServerManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerManagementForm));
            this.ipBanBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.banIPBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reasonIpTxt = new System.Windows.Forms.RichTextBox();
            this.playerMgmtBox = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nicknameTb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deopBtn = new System.Windows.Forms.Button();
            this.opBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gmBtn = new System.Windows.Forms.Button();
            this.gmBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.wlDelBtn = new System.Windows.Forms.Button();
            this.wlAddBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kickBtn = new System.Windows.Forms.Button();
            this.banPlayerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reasonPlayerTxt = new System.Windows.Forms.RichTextBox();
            this.unbanIpBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ipBanBox.SuspendLayout();
            this.playerMgmtBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipBanBox
            // 
            this.ipBanBox.Controls.Add(this.unbanIpBtn);
            this.ipBanBox.Controls.Add(this.label4);
            this.ipBanBox.Controls.Add(this.ipTxt);
            this.ipBanBox.Controls.Add(this.banIPBtn);
            this.ipBanBox.Controls.Add(this.label3);
            this.ipBanBox.Controls.Add(this.reasonIpTxt);
            this.ipBanBox.ForeColor = System.Drawing.Color.White;
            this.ipBanBox.Location = new System.Drawing.Point(322, 19);
            this.ipBanBox.Name = "ipBanBox";
            this.ipBanBox.Size = new System.Drawing.Size(157, 135);
            this.ipBanBox.TabIndex = 8;
            this.ipBanBox.TabStop = false;
            this.ipBanBox.Text = "Ban for Player IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP Address:";
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(6, 36);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(145, 20);
            this.ipTxt.TabIndex = 3;
            // 
            // banIPBtn
            // 
            this.banIPBtn.ForeColor = System.Drawing.Color.Black;
            this.banIPBtn.Location = new System.Drawing.Point(6, 103);
            this.banIPBtn.Name = "banIPBtn";
            this.banIPBtn.Size = new System.Drawing.Size(68, 23);
            this.banIPBtn.TabIndex = 2;
            this.banIPBtn.Text = "Ban";
            this.banIPBtn.UseVisualStyleBackColor = true;
            this.banIPBtn.Click += new System.EventHandler(this.banIPBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reason:";
            // 
            // reasonIpTxt
            // 
            this.reasonIpTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reasonIpTxt.Location = new System.Drawing.Point(6, 75);
            this.reasonIpTxt.Name = "reasonIpTxt";
            this.reasonIpTxt.Size = new System.Drawing.Size(145, 21);
            this.reasonIpTxt.TabIndex = 0;
            this.reasonIpTxt.Text = "";
            // 
            // playerMgmtBox
            // 
            this.playerMgmtBox.Controls.Add(this.ipBanBox);
            this.playerMgmtBox.Controls.Add(this.groupBox5);
            this.playerMgmtBox.Controls.Add(this.groupBox4);
            this.playerMgmtBox.Controls.Add(this.groupBox2);
            this.playerMgmtBox.Controls.Add(this.groupBox1);
            this.playerMgmtBox.Controls.Add(this.groupBox3);
            this.playerMgmtBox.ForeColor = System.Drawing.Color.White;
            this.playerMgmtBox.Location = new System.Drawing.Point(12, 12);
            this.playerMgmtBox.Name = "playerMgmtBox";
            this.playerMgmtBox.Size = new System.Drawing.Size(488, 213);
            this.playerMgmtBox.TabIndex = 9;
            this.playerMgmtBox.TabStop = false;
            this.playerMgmtBox.Text = "Player Management";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nicknameTb);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 50);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Player Nickname";
            // 
            // nicknameTb
            // 
            this.nicknameTb.Location = new System.Drawing.Point(6, 21);
            this.nicknameTb.Name = "nicknameTb";
            this.nicknameTb.Size = new System.Drawing.Size(133, 20);
            this.nicknameTb.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deopBtn);
            this.groupBox4.Controls.Add(this.opBtn);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(322, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 47);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operator";
            // 
            // deopBtn
            // 
            this.deopBtn.ForeColor = System.Drawing.Color.Black;
            this.deopBtn.Location = new System.Drawing.Point(83, 16);
            this.deopBtn.Name = "deopBtn";
            this.deopBtn.Size = new System.Drawing.Size(68, 23);
            this.deopBtn.TabIndex = 3;
            this.deopBtn.Text = "Delete";
            this.deopBtn.UseVisualStyleBackColor = true;
            this.deopBtn.Click += new System.EventHandler(this.deopBtn_Click);
            // 
            // opBtn
            // 
            this.opBtn.ForeColor = System.Drawing.Color.Black;
            this.opBtn.Location = new System.Drawing.Point(6, 16);
            this.opBtn.Name = "opBtn";
            this.opBtn.Size = new System.Drawing.Size(68, 23);
            this.opBtn.TabIndex = 2;
            this.opBtn.Text = "Give";
            this.opBtn.UseVisualStyleBackColor = true;
            this.opBtn.Click += new System.EventHandler(this.opBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gmBtn);
            this.groupBox2.Controls.Add(this.gmBox);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(157, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gamemode";
            // 
            // gmBtn
            // 
            this.gmBtn.ForeColor = System.Drawing.Color.Black;
            this.gmBtn.Location = new System.Drawing.Point(6, 47);
            this.gmBtn.Name = "gmBtn";
            this.gmBtn.Size = new System.Drawing.Size(147, 23);
            this.gmBtn.TabIndex = 1;
            this.gmBtn.Text = "Set Gamemode";
            this.gmBtn.UseVisualStyleBackColor = true;
            this.gmBtn.Click += new System.EventHandler(this.gmBtn_Click);
            // 
            // gmBox
            // 
            this.gmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gmBox.FormattingEnabled = true;
            this.gmBox.Items.AddRange(new object[] {
            "survival",
            "creative",
            "adventure",
            "spectator"});
            this.gmBox.Location = new System.Drawing.Point(6, 19);
            this.gmBox.Name = "gmBox";
            this.gmBox.Size = new System.Drawing.Size(147, 21);
            this.gmBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.wlDelBtn);
            this.groupBox1.Controls.Add(this.wlAddBtn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(157, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "White-list";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable White-list";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // wlDelBtn
            // 
            this.wlDelBtn.ForeColor = System.Drawing.Color.Black;
            this.wlDelBtn.Location = new System.Drawing.Point(85, 19);
            this.wlDelBtn.Name = "wlDelBtn";
            this.wlDelBtn.Size = new System.Drawing.Size(68, 23);
            this.wlDelBtn.TabIndex = 3;
            this.wlDelBtn.Text = "Delete";
            this.wlDelBtn.UseVisualStyleBackColor = true;
            this.wlDelBtn.Click += new System.EventHandler(this.wlDelBtn_Click);
            // 
            // wlAddBtn
            // 
            this.wlAddBtn.ForeColor = System.Drawing.Color.Black;
            this.wlAddBtn.Location = new System.Drawing.Point(6, 19);
            this.wlAddBtn.Name = "wlAddBtn";
            this.wlAddBtn.Size = new System.Drawing.Size(68, 23);
            this.wlAddBtn.TabIndex = 2;
            this.wlAddBtn.Text = "Add";
            this.wlAddBtn.UseVisualStyleBackColor = true;
            this.wlAddBtn.Click += new System.EventHandler(this.wlAddBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.kickBtn);
            this.groupBox3.Controls.Add(this.banPlayerBtn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.reasonPlayerTxt);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ban or Kick Player";
            // 
            // kickBtn
            // 
            this.kickBtn.ForeColor = System.Drawing.Color.Black;
            this.kickBtn.Location = new System.Drawing.Point(6, 72);
            this.kickBtn.Name = "kickBtn";
            this.kickBtn.Size = new System.Drawing.Size(133, 23);
            this.kickBtn.TabIndex = 3;
            this.kickBtn.Text = "Kick";
            this.kickBtn.UseVisualStyleBackColor = true;
            this.kickBtn.Click += new System.EventHandler(this.kickBtn_Click);
            // 
            // banPlayerBtn
            // 
            this.banPlayerBtn.ForeColor = System.Drawing.Color.Black;
            this.banPlayerBtn.Location = new System.Drawing.Point(6, 101);
            this.banPlayerBtn.Name = "banPlayerBtn";
            this.banPlayerBtn.Size = new System.Drawing.Size(62, 23);
            this.banPlayerBtn.TabIndex = 2;
            this.banPlayerBtn.Text = "Ban";
            this.banPlayerBtn.UseVisualStyleBackColor = true;
            this.banPlayerBtn.Click += new System.EventHandler(this.banPlayerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reason:";
            // 
            // reasonPlayerTxt
            // 
            this.reasonPlayerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reasonPlayerTxt.Location = new System.Drawing.Point(6, 36);
            this.reasonPlayerTxt.Name = "reasonPlayerTxt";
            this.reasonPlayerTxt.Size = new System.Drawing.Size(133, 30);
            this.reasonPlayerTxt.TabIndex = 0;
            this.reasonPlayerTxt.Text = "";
            // 
            // unbanIpBtn
            // 
            this.unbanIpBtn.ForeColor = System.Drawing.Color.Black;
            this.unbanIpBtn.Location = new System.Drawing.Point(83, 102);
            this.unbanIpBtn.Name = "unbanIpBtn";
            this.unbanIpBtn.Size = new System.Drawing.Size(68, 23);
            this.unbanIpBtn.TabIndex = 5;
            this.unbanIpBtn.Text = "Unban";
            this.unbanIpBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(77, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Unban";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ServerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(509, 235);
            this.Controls.Add(this.playerMgmtBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 274);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(525, 274);
            this.Name = "ServerManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage with Server - ServManager for Minecraft";
            this.Load += new System.EventHandler(this.ServerManagementForm_Load);
            this.ipBanBox.ResumeLayout(false);
            this.ipBanBox.PerformLayout();
            this.playerMgmtBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ipBanBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.Button banIPBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox reasonIpTxt;
        private System.Windows.Forms.GroupBox playerMgmtBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button kickBtn;
        private System.Windows.Forms.Button banPlayerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox reasonPlayerTxt;
        private System.Windows.Forms.Button opBtn;
        private System.Windows.Forms.TextBox nicknameTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button wlAddBtn;
        private System.Windows.Forms.Button wlDelBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deopBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button gmBtn;
        private System.Windows.Forms.ComboBox gmBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button unbanIpBtn;
        private System.Windows.Forms.Button button1;
    }
}