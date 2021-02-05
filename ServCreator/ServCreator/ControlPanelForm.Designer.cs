
namespace ServCreator
{
    partial class ControlPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanelForm));
            this.editProperties = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.commandInput = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.servMgmtBox = new System.Windows.Forms.GroupBox();
            this.playerMgmtBox = new System.Windows.Forms.GroupBox();
            this.nicknameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reasonPlayerTxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.banPlayerBtn = new System.Windows.Forms.Button();
            this.kickBtn = new System.Windows.Forms.Button();
            this.ipBanBox = new System.Windows.Forms.GroupBox();
            this.banIPBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reasonIpTxt = new System.Windows.Forms.RichTextBox();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.servMgmtBox.SuspendLayout();
            this.playerMgmtBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ipBanBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // editProperties
            // 
            this.editProperties.ForeColor = System.Drawing.Color.Black;
            this.editProperties.Location = new System.Drawing.Point(6, 48);
            this.editProperties.Name = "editProperties";
            this.editProperties.Size = new System.Drawing.Size(145, 23);
            this.editProperties.TabIndex = 0;
            this.editProperties.Text = "Edit properties";
            this.editProperties.UseVisualStyleBackColor = true;
            this.editProperties.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputText
            // 
            this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText.Location = new System.Drawing.Point(175, 12);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(613, 462);
            this.outputText.TabIndex = 1;
            this.outputText.Text = "";
            this.outputText.TextChanged += new System.EventHandler(this.outputChanged);
            // 
            // commandInput
            // 
            this.commandInput.Location = new System.Drawing.Point(175, 482);
            this.commandInput.Name = "commandInput";
            this.commandInput.Size = new System.Drawing.Size(518, 20);
            this.commandInput.TabIndex = 2;
            this.commandInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.submitCommand);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(699, 480);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(89, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // startBtn
            // 
            this.startBtn.ForeColor = System.Drawing.Color.Black;
            this.startBtn.Location = new System.Drawing.Point(6, 19);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(68, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.ForeColor = System.Drawing.Color.Black;
            this.stopBtn.Location = new System.Drawing.Point(83, 19);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(68, 23);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // servMgmtBox
            // 
            this.servMgmtBox.Controls.Add(this.startBtn);
            this.servMgmtBox.Controls.Add(this.stopBtn);
            this.servMgmtBox.Controls.Add(this.editProperties);
            this.servMgmtBox.ForeColor = System.Drawing.Color.White;
            this.servMgmtBox.Location = new System.Drawing.Point(12, 12);
            this.servMgmtBox.Name = "servMgmtBox";
            this.servMgmtBox.Size = new System.Drawing.Size(157, 82);
            this.servMgmtBox.TabIndex = 6;
            this.servMgmtBox.TabStop = false;
            this.servMgmtBox.Text = "Server Management";
            // 
            // playerMgmtBox
            // 
            this.playerMgmtBox.Controls.Add(this.groupBox3);
            this.playerMgmtBox.Controls.Add(this.opBtn);
            this.playerMgmtBox.Controls.Add(this.label1);
            this.playerMgmtBox.Controls.Add(this.nicknameTb);
            this.playerMgmtBox.Enabled = false;
            this.playerMgmtBox.ForeColor = System.Drawing.Color.White;
            this.playerMgmtBox.Location = new System.Drawing.Point(12, 100);
            this.playerMgmtBox.Name = "playerMgmtBox";
            this.playerMgmtBox.Size = new System.Drawing.Size(157, 213);
            this.playerMgmtBox.TabIndex = 7;
            this.playerMgmtBox.TabStop = false;
            this.playerMgmtBox.Text = "Player Management";
            // 
            // nicknameTb
            // 
            this.nicknameTb.Location = new System.Drawing.Point(6, 35);
            this.nicknameTb.Name = "nicknameTb";
            this.nicknameTb.Size = new System.Drawing.Size(145, 20);
            this.nicknameTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Nickname:";
            // 
            // opBtn
            // 
            this.opBtn.ForeColor = System.Drawing.Color.Black;
            this.opBtn.Location = new System.Drawing.Point(6, 62);
            this.opBtn.Name = "opBtn";
            this.opBtn.Size = new System.Drawing.Size(145, 23);
            this.opBtn.TabIndex = 2;
            this.opBtn.Text = "Give OP";
            this.opBtn.UseVisualStyleBackColor = true;
            this.opBtn.Click += new System.EventHandler(this.opBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kickBtn);
            this.groupBox3.Controls.Add(this.banPlayerBtn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.reasonPlayerTxt);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ban or Kick Player";
            // 
            // reasonPlayerTxt
            // 
            this.reasonPlayerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reasonPlayerTxt.Location = new System.Drawing.Point(6, 36);
            this.reasonPlayerTxt.Name = "reasonPlayerTxt";
            this.reasonPlayerTxt.Size = new System.Drawing.Size(133, 42);
            this.reasonPlayerTxt.TabIndex = 0;
            this.reasonPlayerTxt.Text = "";
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
            // banPlayerBtn
            // 
            this.banPlayerBtn.ForeColor = System.Drawing.Color.Black;
            this.banPlayerBtn.Location = new System.Drawing.Point(6, 85);
            this.banPlayerBtn.Name = "banPlayerBtn";
            this.banPlayerBtn.Size = new System.Drawing.Size(62, 23);
            this.banPlayerBtn.TabIndex = 2;
            this.banPlayerBtn.Text = "Ban";
            this.banPlayerBtn.UseVisualStyleBackColor = true;
            this.banPlayerBtn.Click += new System.EventHandler(this.banPlayerBtn_Click);
            // 
            // kickBtn
            // 
            this.kickBtn.ForeColor = System.Drawing.Color.Black;
            this.kickBtn.Location = new System.Drawing.Point(77, 85);
            this.kickBtn.Name = "kickBtn";
            this.kickBtn.Size = new System.Drawing.Size(62, 23);
            this.kickBtn.TabIndex = 3;
            this.kickBtn.Text = "Kick";
            this.kickBtn.UseVisualStyleBackColor = true;
            // 
            // ipBanBox
            // 
            this.ipBanBox.Controls.Add(this.label4);
            this.ipBanBox.Controls.Add(this.ipTxt);
            this.ipBanBox.Controls.Add(this.banIPBtn);
            this.ipBanBox.Controls.Add(this.label3);
            this.ipBanBox.Controls.Add(this.reasonIpTxt);
            this.ipBanBox.Enabled = false;
            this.ipBanBox.ForeColor = System.Drawing.Color.White;
            this.ipBanBox.Location = new System.Drawing.Point(12, 321);
            this.ipBanBox.Name = "ipBanBox";
            this.ipBanBox.Size = new System.Drawing.Size(157, 153);
            this.ipBanBox.TabIndex = 4;
            this.ipBanBox.TabStop = false;
            this.ipBanBox.Text = "Ban for Player IP";
            // 
            // banIPBtn
            // 
            this.banIPBtn.ForeColor = System.Drawing.Color.Black;
            this.banIPBtn.Location = new System.Drawing.Point(6, 123);
            this.banIPBtn.Name = "banIPBtn";
            this.banIPBtn.Size = new System.Drawing.Size(145, 23);
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
            this.reasonIpTxt.Size = new System.Drawing.Size(145, 42);
            this.reasonIpTxt.TabIndex = 0;
            this.reasonIpTxt.Text = "";
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(6, 36);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(145, 20);
            this.ipTxt.TabIndex = 3;
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
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.ipBanBox);
            this.Controls.Add(this.playerMgmtBox);
            this.Controls.Add(this.servMgmtBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.commandInput);
            this.Controls.Add(this.outputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlPanelForm";
            this.Text = "Control Panel - ServManager for Minecraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanelForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlPanelForm_Load);
            this.servMgmtBox.ResumeLayout(false);
            this.playerMgmtBox.ResumeLayout(false);
            this.playerMgmtBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ipBanBox.ResumeLayout(false);
            this.ipBanBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editProperties;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.TextBox commandInput;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.GroupBox servMgmtBox;
        private System.Windows.Forms.GroupBox playerMgmtBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button kickBtn;
        private System.Windows.Forms.Button banPlayerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox reasonPlayerTxt;
        private System.Windows.Forms.Button opBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nicknameTb;
        private System.Windows.Forms.GroupBox ipBanBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.Button banIPBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox reasonIpTxt;
    }
}