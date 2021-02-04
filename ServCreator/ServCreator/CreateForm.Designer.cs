
namespace ServCreator
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.serverEngineCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverVersionCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.serverNameTB = new System.Windows.Forms.TextBox();
            this.argumentsTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minRAM = new System.Windows.Forms.NumericUpDown();
            this.maxRAM = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.checkJavaBtn = new System.Windows.Forms.Button();
            this.pathSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.serverPathTB = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.minRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Engine:";
            // 
            // serverEngineCB
            // 
            this.serverEngineCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverEngineCB.FormattingEnabled = true;
            this.serverEngineCB.Items.AddRange(new object[] {
            "vanilla",
            "craftbukkit",
            "spigot"});
            this.serverEngineCB.Location = new System.Drawing.Point(12, 29);
            this.serverEngineCB.Name = "serverEngineCB";
            this.serverEngineCB.Size = new System.Drawing.Size(142, 25);
            this.serverEngineCB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version:";
            // 
            // serverVersionCB
            // 
            this.serverVersionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverVersionCB.FormattingEnabled = true;
            this.serverVersionCB.Items.AddRange(new object[] {
            "1.16.5",
            "1.16.4",
            "1.16.3",
            "1.16.2",
            "1.16.1",
            "1.16",
            "1.15.2",
            "1.15.1",
            "1.15",
            "1.14.4",
            "1.14.3",
            "1.14.2",
            "1.14.1",
            "1.14",
            "1.13.2",
            "1.13.1",
            "1.13",
            "1.12.2",
            "1.12.1",
            "1.12",
            "1.11.2",
            "1.11.1",
            "1.11",
            "1.10.2",
            "1.10.1",
            "1.10",
            "1.9.4",
            "1.9.3",
            "1.9.2",
            "1.9.1",
            "1.9",
            "1.8.9",
            "1.8.8",
            "1.8.7",
            "1.8.6",
            "1.8.5",
            "1.8.4",
            "1.8.3",
            "1.8.2",
            "1.8.1",
            "1.8",
            "1.7.10",
            "1.7.9",
            "1.7.8",
            "1.7.7",
            "1.7.6",
            "1.7.5",
            "1.7.4",
            "1.7.3",
            "1.7.2",
            "1.7.1",
            "1.7",
            "1.6.4",
            "1.6.2",
            "1.6.1",
            "1.6"});
            this.serverVersionCB.Location = new System.Drawing.Point(160, 29);
            this.serverVersionCB.Name = "serverVersionCB";
            this.serverVersionCB.Size = new System.Drawing.Size(214, 25);
            this.serverVersionCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Path:";
            // 
            // selectBtn
            // 
            this.selectBtn.ForeColor = System.Drawing.Color.Black;
            this.selectBtn.Location = new System.Drawing.Point(274, 74);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(100, 28);
            this.selectBtn.TabIndex = 6;
            this.selectBtn.Text = "Select a path...";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectPath);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server Name (in ServManager and Folder):";
            // 
            // serverNameTB
            // 
            this.serverNameTB.Location = new System.Drawing.Point(12, 125);
            this.serverNameTB.Name = "serverNameTB";
            this.serverNameTB.Size = new System.Drawing.Size(362, 25);
            this.serverNameTB.TabIndex = 8;
            // 
            // argumentsTB
            // 
            this.argumentsTB.Location = new System.Drawing.Point(12, 221);
            this.argumentsTB.Name = "argumentsTB";
            this.argumentsTB.Size = new System.Drawing.Size(362, 25);
            this.argumentsTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Additional arguments:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Minimum RAM (in MB):";
            // 
            // minRAM
            // 
            this.minRAM.Location = new System.Drawing.Point(12, 173);
            this.minRAM.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.minRAM.Name = "minRAM";
            this.minRAM.Size = new System.Drawing.Size(177, 25);
            this.minRAM.TabIndex = 12;
            // 
            // maxRAM
            // 
            this.maxRAM.Location = new System.Drawing.Point(197, 173);
            this.maxRAM.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.maxRAM.Name = "maxRAM";
            this.maxRAM.Size = new System.Drawing.Size(177, 25);
            this.maxRAM.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Maximum RAM (in MB):";
            // 
            // createBtn
            // 
            this.createBtn.ForeColor = System.Drawing.Color.Black;
            this.createBtn.Location = new System.Drawing.Point(310, 252);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(64, 28);
            this.createBtn.TabIndex = 15;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createServer);
            // 
            // checkJavaBtn
            // 
            this.checkJavaBtn.ForeColor = System.Drawing.Color.Black;
            this.checkJavaBtn.Location = new System.Drawing.Point(160, 252);
            this.checkJavaBtn.Name = "checkJavaBtn";
            this.checkJavaBtn.Size = new System.Drawing.Size(144, 28);
            this.checkJavaBtn.TabIndex = 16;
            this.checkJavaBtn.Text = "Check Java version";
            this.checkJavaBtn.UseVisualStyleBackColor = true;
            this.checkJavaBtn.Click += new System.EventHandler(this.checkJavaVersion);
            // 
            // pathSelector
            // 
            this.pathSelector.Description = "Select a path, where you want to have a server...";
            // 
            // serverPathTB
            // 
            this.serverPathTB.Location = new System.Drawing.Point(12, 77);
            this.serverPathTB.Name = "serverPathTB";
            this.serverPathTB.Size = new System.Drawing.Size(256, 25);
            this.serverPathTB.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(142, 28);
            this.progressBar1.TabIndex = 18;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(394, 301);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.serverPathTB);
            this.Controls.Add(this.checkJavaBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.maxRAM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minRAM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.argumentsTB);
            this.Controls.Add(this.serverNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverVersionCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverEngineCB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateForm";
            this.Text = "Server Creator - ServManager for Minecraft";
            ((System.ComponentModel.ISupportInitialize)(this.minRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serverEngineCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serverVersionCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverNameTB;
        private System.Windows.Forms.TextBox argumentsTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown minRAM;
        private System.Windows.Forms.NumericUpDown maxRAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button checkJavaBtn;
        private System.Windows.Forms.FolderBrowserDialog pathSelector;
        private System.Windows.Forms.TextBox serverPathTB;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}