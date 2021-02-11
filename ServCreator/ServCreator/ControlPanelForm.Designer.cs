
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanelForm));
            this.editProperties = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.commandInput = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.killBtn = new System.Windows.Forms.Button();
            this.servMgmtBox = new System.Windows.Forms.GroupBox();
            this.easyManagementBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.servMgmtBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // editProperties
            // 
            this.editProperties.ForeColor = System.Drawing.Color.Black;
            this.editProperties.Location = new System.Drawing.Point(6, 77);
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
            this.outputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputText.Location = new System.Drawing.Point(179, 12);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(609, 371);
            this.outputText.TabIndex = 1;
            this.outputText.Text = "";
            this.outputText.TextChanged += new System.EventHandler(this.outputChanged);
            // 
            // commandInput
            // 
            this.commandInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandInput.Location = new System.Drawing.Point(0, 0);
            this.commandInput.Name = "commandInput";
            this.commandInput.Size = new System.Drawing.Size(540, 20);
            this.commandInput.TabIndex = 2;
            this.commandInput.TextChanged += new System.EventHandler(this.commandInput_TextChanged);
            this.commandInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.submitCommand);
            // 
            // submit
            // 
            this.submit.Dock = System.Windows.Forms.DockStyle.Right;
            this.submit.Location = new System.Drawing.Point(540, 0);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(69, 20);
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
            this.startBtn.Size = new System.Drawing.Size(145, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // killBtn
            // 
            this.killBtn.BackColor = System.Drawing.Color.Red;
            this.killBtn.Enabled = false;
            this.killBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.killBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.killBtn.ForeColor = System.Drawing.Color.White;
            this.killBtn.Location = new System.Drawing.Point(83, 48);
            this.killBtn.Name = "killBtn";
            this.killBtn.Size = new System.Drawing.Size(68, 23);
            this.killBtn.TabIndex = 5;
            this.killBtn.Text = "Kill";
            this.killBtn.UseVisualStyleBackColor = false;
            this.killBtn.Click += new System.EventHandler(this.killBtn_Click);
            // 
            // servMgmtBox
            // 
            this.servMgmtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.servMgmtBox.Controls.Add(this.easyManagementBtn);
            this.servMgmtBox.Controls.Add(this.stopBtn);
            this.servMgmtBox.Controls.Add(this.startBtn);
            this.servMgmtBox.Controls.Add(this.killBtn);
            this.servMgmtBox.Controls.Add(this.editProperties);
            this.servMgmtBox.ForeColor = System.Drawing.Color.White;
            this.servMgmtBox.Location = new System.Drawing.Point(12, 157);
            this.servMgmtBox.Name = "servMgmtBox";
            this.servMgmtBox.Size = new System.Drawing.Size(157, 140);
            this.servMgmtBox.TabIndex = 6;
            this.servMgmtBox.TabStop = false;
            this.servMgmtBox.Text = "Server Management";
            // 
            // easyManagementBtn
            // 
            this.easyManagementBtn.ForeColor = System.Drawing.Color.Black;
            this.easyManagementBtn.Location = new System.Drawing.Point(6, 107);
            this.easyManagementBtn.Name = "easyManagementBtn";
            this.easyManagementBtn.Size = new System.Drawing.Size(145, 23);
            this.easyManagementBtn.TabIndex = 7;
            this.easyManagementBtn.Text = "Open Easy Management";
            this.easyManagementBtn.UseVisualStyleBackColor = true;
            this.easyManagementBtn.Click += new System.EventHandler(this.easyManagement);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.ForeColor = System.Drawing.Color.Black;
            this.stopBtn.Location = new System.Drawing.Point(6, 48);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(68, 23);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serverLabel.ForeColor = System.Drawing.Color.White;
            this.serverLabel.Location = new System.Drawing.Point(12, 12);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(157, 94);
            this.serverLabel.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Resources Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM Usage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Usage:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.serverLabel);
            this.panel1.Controls.Add(this.servMgmtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 415);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 12);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(179, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 12);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(788, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 391);
            this.panel4.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.systemUsage);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.commandInput);
            this.panel5.Controls.Add(this.submit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(179, 383);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(609, 20);
            this.panel5.TabIndex = 14;
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlPanelForm";
            this.Text = "Control Panel - ServManager for Minecraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanelForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlPanelForm_Load);
            this.servMgmtBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editProperties;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.TextBox commandInput;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button killBtn;
        private System.Windows.Forms.GroupBox servMgmtBox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button easyManagementBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
    }
}