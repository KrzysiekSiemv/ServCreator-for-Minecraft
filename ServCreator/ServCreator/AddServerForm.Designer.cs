
namespace ServCreator
{
    partial class AddServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.serverNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverEngineCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serverVersionCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxRAM = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.minRAM = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.argumentsTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.pathSelectBtn = new System.Windows.Forms.Button();
            this.serverPathBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serverPathSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name:";
            // 
            // serverNameBox
            // 
            this.serverNameBox.Location = new System.Drawing.Point(15, 125);
            this.serverNameBox.Name = "serverNameBox";
            this.serverNameBox.Size = new System.Drawing.Size(359, 25);
            this.serverNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Engine*:";
            // 
            // serverEngineCB
            // 
            this.serverEngineCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverEngineCB.FormattingEnabled = true;
            this.serverEngineCB.Location = new System.Drawing.Point(15, 77);
            this.serverEngineCB.Name = "serverEngineCB";
            this.serverEngineCB.Size = new System.Drawing.Size(142, 25);
            this.serverEngineCB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Version*:";
            // 
            // serverVersionCB
            // 
            this.serverVersionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverVersionCB.FormattingEnabled = true;
            this.serverVersionCB.Items.AddRange(new object[] {
            ""});
            this.serverVersionCB.Location = new System.Drawing.Point(163, 77);
            this.serverVersionCB.Name = "serverVersionCB";
            this.serverVersionCB.Size = new System.Drawing.Size(211, 25);
            this.serverVersionCB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "ServManager requires \"start.bat\" file with arguments, that \r\nyou\'re running serve" +
    "r your local server.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxRAM);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.minRAM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.argumentsTB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 124);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // maxRAM
            // 
            this.maxRAM.Location = new System.Drawing.Point(191, 41);
            this.maxRAM.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.maxRAM.Name = "maxRAM";
            this.maxRAM.Size = new System.Drawing.Size(171, 25);
            this.maxRAM.TabIndex = 20;
            this.maxRAM.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Maximum RAM (in MB)*:";
            // 
            // minRAM
            // 
            this.minRAM.Location = new System.Drawing.Point(6, 41);
            this.minRAM.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.minRAM.Name = "minRAM";
            this.minRAM.Size = new System.Drawing.Size(177, 25);
            this.minRAM.TabIndex = 18;
            this.minRAM.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Minimum RAM (in MB)*:";
            // 
            // argumentsTB
            // 
            this.argumentsTB.Location = new System.Drawing.Point(6, 89);
            this.argumentsTB.Name = "argumentsTB";
            this.argumentsTB.Size = new System.Drawing.Size(356, 25);
            this.argumentsTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Additional arguments:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Create \"start.bat\"";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(307, 324);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 25);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addServer);
            // 
            // pathSelectBtn
            // 
            this.pathSelectBtn.ForeColor = System.Drawing.Color.Black;
            this.pathSelectBtn.Location = new System.Drawing.Point(299, 29);
            this.pathSelectBtn.Name = "pathSelectBtn";
            this.pathSelectBtn.Size = new System.Drawing.Size(75, 25);
            this.pathSelectBtn.TabIndex = 16;
            this.pathSelectBtn.Text = "Select";
            this.pathSelectBtn.UseVisualStyleBackColor = true;
            this.pathSelectBtn.Click += new System.EventHandler(this.selectPath);
            // 
            // serverPathBox
            // 
            this.serverPathBox.Location = new System.Drawing.Point(15, 29);
            this.serverPathBox.Name = "serverPathBox";
            this.serverPathBox.Size = new System.Drawing.Size(278, 25);
            this.serverPathBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Path*:";
            // 
            // serverPathSelector
            // 
            this.serverPathSelector.Description = "Select a path, where your installed server is...";
            this.serverPathSelector.ShowNewFolderButton = false;
            // 
            // AddServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(394, 360);
            this.Controls.Add(this.pathSelectBtn);
            this.Controls.Add(this.serverPathBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverEngineCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverVersionCB);
            this.Controls.Add(this.serverNameBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Server - ServManager for Minecraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddServerForm_FormClosing);
            this.Load += new System.EventHandler(this.AddServerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serverEngineCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox serverVersionCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown maxRAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown minRAM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox argumentsTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button pathSelectBtn;
        private System.Windows.Forms.TextBox serverPathBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog serverPathSelector;
    }
}