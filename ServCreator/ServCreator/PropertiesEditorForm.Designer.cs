
namespace ServCreator
{
    partial class PropertiesEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesEditorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.simple = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.motd = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.onlineMode = new System.Windows.Forms.CheckBox();
            this.generateStructures = new System.Windows.Forms.CheckBox();
            this.whiteList = new System.Windows.Forms.CheckBox();
            this.spawnAnimals = new System.Windows.Forms.CheckBox();
            this.viewDistance = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.levelName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.allowFlight = new System.Windows.Forms.CheckBox();
            this.spawnNpcs = new System.Windows.Forms.CheckBox();
            this.serverIp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.serverPort = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.maxWorldSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.maxPlayers = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.enableCommandBlocks = new System.Windows.Forms.CheckBox();
            this.enableStatus = new System.Windows.Forms.CheckBox();
            this.hardcore = new System.Windows.Forms.CheckBox();
            this.enablePvp = new System.Windows.Forms.CheckBox();
            this.spawnMonsters = new System.Windows.Forms.CheckBox();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gamemode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.allowNether = new System.Windows.Forms.CheckBox();
            this.forceGamemode = new System.Windows.Forms.CheckBox();
            this.generatorSettings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spawnProtection = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.advanced = new System.Windows.Forms.TabPage();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.simple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWorldSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnProtection)).BeginInit();
            this.advanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "  You\'re editing properties for {SERVER_NAME}";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 382);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(523, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 382);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 40);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(342, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save and Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(445, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(497, 350);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.simple);
            this.tabControl1.Controls.Add(this.advanced);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 382);
            this.tabControl1.TabIndex = 5;
            // 
            // simple
            // 
            this.simple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.simple.Controls.Add(this.linkLabel1);
            this.simple.Controls.Add(this.motd);
            this.simple.Controls.Add(this.label12);
            this.simple.Controls.Add(this.onlineMode);
            this.simple.Controls.Add(this.generateStructures);
            this.simple.Controls.Add(this.whiteList);
            this.simple.Controls.Add(this.spawnAnimals);
            this.simple.Controls.Add(this.viewDistance);
            this.simple.Controls.Add(this.label11);
            this.simple.Controls.Add(this.levelName);
            this.simple.Controls.Add(this.label10);
            this.simple.Controls.Add(this.allowFlight);
            this.simple.Controls.Add(this.spawnNpcs);
            this.simple.Controls.Add(this.serverIp);
            this.simple.Controls.Add(this.label9);
            this.simple.Controls.Add(this.serverPort);
            this.simple.Controls.Add(this.label8);
            this.simple.Controls.Add(this.maxWorldSize);
            this.simple.Controls.Add(this.label7);
            this.simple.Controls.Add(this.maxPlayers);
            this.simple.Controls.Add(this.label6);
            this.simple.Controls.Add(this.enableCommandBlocks);
            this.simple.Controls.Add(this.enableStatus);
            this.simple.Controls.Add(this.hardcore);
            this.simple.Controls.Add(this.enablePvp);
            this.simple.Controls.Add(this.spawnMonsters);
            this.simple.Controls.Add(this.difficulty);
            this.simple.Controls.Add(this.label5);
            this.simple.Controls.Add(this.gamemode);
            this.simple.Controls.Add(this.label4);
            this.simple.Controls.Add(this.allowNether);
            this.simple.Controls.Add(this.forceGamemode);
            this.simple.Controls.Add(this.generatorSettings);
            this.simple.Controls.Add(this.label3);
            this.simple.Controls.Add(this.spawnProtection);
            this.simple.Controls.Add(this.label2);
            this.simple.ForeColor = System.Drawing.Color.White;
            this.simple.Location = new System.Drawing.Point(4, 22);
            this.simple.Name = "simple";
            this.simple.Padding = new System.Windows.Forms.Padding(3);
            this.simple.Size = new System.Drawing.Size(503, 356);
            this.simple.TabIndex = 1;
            this.simple.Text = "Simple configuration";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(402, 225);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 13);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "MOTD Creator";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // motd
            // 
            this.motd.Location = new System.Drawing.Point(261, 126);
            this.motd.Name = "motd";
            this.motd.Size = new System.Drawing.Size(229, 96);
            this.motd.TabIndex = 34;
            this.motd.Text = "A Minecraft Server";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Message of the Day (motd):";
            // 
            // onlineMode
            // 
            this.onlineMode.AutoSize = true;
            this.onlineMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.onlineMode.Location = new System.Drawing.Point(401, 82);
            this.onlineMode.Name = "onlineMode";
            this.onlineMode.Size = new System.Drawing.Size(89, 17);
            this.onlineMode.TabIndex = 32;
            this.onlineMode.Text = "Online-Mode:";
            this.onlineMode.UseVisualStyleBackColor = true;
            // 
            // generateStructures
            // 
            this.generateStructures.AutoSize = true;
            this.generateStructures.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generateStructures.Checked = true;
            this.generateStructures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateStructures.Location = new System.Drawing.Point(258, 81);
            this.generateStructures.Name = "generateStructures";
            this.generateStructures.Size = new System.Drawing.Size(124, 17);
            this.generateStructures.TabIndex = 31;
            this.generateStructures.Text = "Generate Structures:";
            this.generateStructures.UseVisualStyleBackColor = true;
            // 
            // whiteList
            // 
            this.whiteList.AutoSize = true;
            this.whiteList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.whiteList.Location = new System.Drawing.Point(418, 59);
            this.whiteList.Name = "whiteList";
            this.whiteList.Size = new System.Drawing.Size(72, 17);
            this.whiteList.TabIndex = 30;
            this.whiteList.Text = "White-list:";
            this.whiteList.UseVisualStyleBackColor = true;
            // 
            // spawnAnimals
            // 
            this.spawnAnimals.AutoSize = true;
            this.spawnAnimals.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spawnAnimals.Checked = true;
            this.spawnAnimals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spawnAnimals.Location = new System.Drawing.Point(281, 59);
            this.spawnAnimals.Name = "spawnAnimals";
            this.spawnAnimals.Size = new System.Drawing.Size(101, 17);
            this.spawnAnimals.TabIndex = 29;
            this.spawnAnimals.Text = "Spawn Animals:";
            this.spawnAnimals.UseVisualStyleBackColor = true;
            // 
            // viewDistance
            // 
            this.viewDistance.Location = new System.Drawing.Point(369, 33);
            this.viewDistance.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.viewDistance.Name = "viewDistance";
            this.viewDistance.Size = new System.Drawing.Size(60, 20);
            this.viewDistance.TabIndex = 28;
            this.viewDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "View distance:";
            // 
            // levelName
            // 
            this.levelName.Location = new System.Drawing.Point(369, 6);
            this.levelName.Name = "levelName";
            this.levelName.Size = new System.Drawing.Size(121, 20);
            this.levelName.TabIndex = 26;
            this.levelName.Text = "world";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Level Name:";
            // 
            // allowFlight
            // 
            this.allowFlight.AutoSize = true;
            this.allowFlight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allowFlight.Location = new System.Drawing.Point(170, 309);
            this.allowFlight.Name = "allowFlight";
            this.allowFlight.Size = new System.Drawing.Size(82, 17);
            this.allowFlight.TabIndex = 24;
            this.allowFlight.Text = "Allow Flight:";
            this.allowFlight.UseVisualStyleBackColor = true;
            // 
            // spawnNpcs
            // 
            this.spawnNpcs.AutoSize = true;
            this.spawnNpcs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spawnNpcs.Checked = true;
            this.spawnNpcs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spawnNpcs.Location = new System.Drawing.Point(53, 309);
            this.spawnNpcs.Name = "spawnNpcs";
            this.spawnNpcs.Size = new System.Drawing.Size(92, 17);
            this.spawnNpcs.TabIndex = 23;
            this.spawnNpcs.Text = "Spawn NPCs:";
            this.spawnNpcs.UseVisualStyleBackColor = true;
            // 
            // serverIp
            // 
            this.serverIp.Location = new System.Drawing.Point(131, 283);
            this.serverIp.MaxLength = 15;
            this.serverIp.Name = "serverIp";
            this.serverIp.Size = new System.Drawing.Size(121, 20);
            this.serverIp.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Server IP:";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(131, 257);
            this.serverPort.Maximum = new decimal(new int[] {
            69420,
            0,
            0,
            0});
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(60, 20);
            this.serverPort.TabIndex = 20;
            this.serverPort.Value = new decimal(new int[] {
            25565,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Server Port:";
            // 
            // maxWorldSize
            // 
            this.maxWorldSize.Location = new System.Drawing.Point(131, 231);
            this.maxWorldSize.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.maxWorldSize.Name = "maxWorldSize";
            this.maxWorldSize.Size = new System.Drawing.Size(121, 20);
            this.maxWorldSize.TabIndex = 18;
            this.maxWorldSize.Value = new decimal(new int[] {
            29999984,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max World Size:";
            // 
            // maxPlayers
            // 
            this.maxPlayers.Location = new System.Drawing.Point(131, 205);
            this.maxPlayers.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxPlayers.Name = "maxPlayers";
            this.maxPlayers.Size = new System.Drawing.Size(60, 20);
            this.maxPlayers.TabIndex = 16;
            this.maxPlayers.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max Players:";
            // 
            // enableCommandBlocks
            // 
            this.enableCommandBlocks.AutoSize = true;
            this.enableCommandBlocks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableCommandBlocks.Location = new System.Drawing.Point(105, 182);
            this.enableCommandBlocks.Name = "enableCommandBlocks";
            this.enableCommandBlocks.Size = new System.Drawing.Size(147, 17);
            this.enableCommandBlocks.TabIndex = 14;
            this.enableCommandBlocks.Text = "Enable Command Blocks:";
            this.enableCommandBlocks.UseVisualStyleBackColor = true;
            // 
            // enableStatus
            // 
            this.enableStatus.AutoSize = true;
            this.enableStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableStatus.Checked = true;
            this.enableStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableStatus.Location = new System.Drawing.Point(159, 159);
            this.enableStatus.Name = "enableStatus";
            this.enableStatus.Size = new System.Drawing.Size(93, 17);
            this.enableStatus.TabIndex = 13;
            this.enableStatus.Text = "Enable status:";
            this.enableStatus.UseVisualStyleBackColor = true;
            // 
            // hardcore
            // 
            this.hardcore.AutoSize = true;
            this.hardcore.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hardcore.Location = new System.Drawing.Point(72, 159);
            this.hardcore.Name = "hardcore";
            this.hardcore.Size = new System.Drawing.Size(73, 17);
            this.hardcore.TabIndex = 12;
            this.hardcore.Text = "Hardcore:";
            this.hardcore.UseVisualStyleBackColor = true;
            // 
            // enablePvp
            // 
            this.enablePvp.AutoSize = true;
            this.enablePvp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enablePvp.Checked = true;
            this.enablePvp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enablePvp.Location = new System.Drawing.Point(167, 136);
            this.enablePvp.Name = "enablePvp";
            this.enablePvp.Size = new System.Drawing.Size(85, 17);
            this.enablePvp.TabIndex = 11;
            this.enablePvp.Text = "Enable PvP:";
            this.enablePvp.UseVisualStyleBackColor = true;
            // 
            // spawnMonsters
            // 
            this.spawnMonsters.AutoSize = true;
            this.spawnMonsters.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spawnMonsters.Checked = true;
            this.spawnMonsters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spawnMonsters.Location = new System.Drawing.Point(37, 136);
            this.spawnMonsters.Name = "spawnMonsters";
            this.spawnMonsters.Size = new System.Drawing.Size(108, 17);
            this.spawnMonsters.TabIndex = 10;
            this.spawnMonsters.Text = "Spawn Monsters:";
            this.spawnMonsters.UseVisualStyleBackColor = true;
            // 
            // difficulty
            // 
            this.difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulty.FormattingEnabled = true;
            this.difficulty.Items.AddRange(new object[] {
            "peaceful",
            "easy",
            "normal",
            "hard"});
            this.difficulty.Location = new System.Drawing.Point(131, 109);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(121, 21);
            this.difficulty.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Difficulty:";
            // 
            // gamemode
            // 
            this.gamemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamemode.FormattingEnabled = true;
            this.gamemode.Items.AddRange(new object[] {
            "survival",
            "adventure",
            "creative"});
            this.gamemode.Location = new System.Drawing.Point(131, 82);
            this.gamemode.Name = "gamemode";
            this.gamemode.Size = new System.Drawing.Size(121, 21);
            this.gamemode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gamemode:";
            // 
            // allowNether
            // 
            this.allowNether.AutoSize = true;
            this.allowNether.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allowNether.Checked = true;
            this.allowNether.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowNether.Location = new System.Drawing.Point(163, 59);
            this.allowNether.Name = "allowNether";
            this.allowNether.Size = new System.Drawing.Size(89, 17);
            this.allowNether.TabIndex = 5;
            this.allowNether.Text = "Allow Nether:";
            this.allowNether.UseVisualStyleBackColor = true;
            // 
            // forceGamemode
            // 
            this.forceGamemode.AutoSize = true;
            this.forceGamemode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forceGamemode.Location = new System.Drawing.Point(32, 59);
            this.forceGamemode.Name = "forceGamemode";
            this.forceGamemode.Size = new System.Drawing.Size(113, 17);
            this.forceGamemode.TabIndex = 4;
            this.forceGamemode.Text = "Force Gamemode:";
            this.forceGamemode.UseVisualStyleBackColor = true;
            // 
            // generatorSettings
            // 
            this.generatorSettings.Location = new System.Drawing.Point(131, 33);
            this.generatorSettings.Name = "generatorSettings";
            this.generatorSettings.Size = new System.Drawing.Size(121, 20);
            this.generatorSettings.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Generator Settings:";
            // 
            // spawnProtection
            // 
            this.spawnProtection.Location = new System.Drawing.Point(131, 7);
            this.spawnProtection.Name = "spawnProtection";
            this.spawnProtection.Size = new System.Drawing.Size(60, 20);
            this.spawnProtection.TabIndex = 1;
            this.spawnProtection.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Spawn Protection:";
            // 
            // advanced
            // 
            this.advanced.Controls.Add(this.richTextBox1);
            this.advanced.Location = new System.Drawing.Point(4, 22);
            this.advanced.Name = "advanced";
            this.advanced.Padding = new System.Windows.Forms.Padding(3);
            this.advanced.Size = new System.Drawing.Size(503, 356);
            this.advanced.TabIndex = 0;
            this.advanced.Text = "Full server.properties file";
            this.advanced.UseVisualStyleBackColor = true;
            // 
            // PropertiesEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(532, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PropertiesEditorForm";
            this.Text = "Server Properties Editor - ServManager";
            this.Load += new System.EventHandler(this.PropertiesEditorForm_Load);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.simple.ResumeLayout(false);
            this.simple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWorldSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnProtection)).EndInit();
            this.advanced.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage simple;
        private System.Windows.Forms.TabPage advanced;
        private System.Windows.Forms.CheckBox enableStatus;
        private System.Windows.Forms.CheckBox hardcore;
        private System.Windows.Forms.CheckBox enablePvp;
        private System.Windows.Forms.CheckBox spawnMonsters;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gamemode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox allowNether;
        private System.Windows.Forms.CheckBox forceGamemode;
        private System.Windows.Forms.TextBox generatorSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spawnProtection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox enableCommandBlocks;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RichTextBox motd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox onlineMode;
        private System.Windows.Forms.CheckBox generateStructures;
        private System.Windows.Forms.CheckBox whiteList;
        private System.Windows.Forms.CheckBox spawnAnimals;
        private System.Windows.Forms.NumericUpDown viewDistance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox levelName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox allowFlight;
        private System.Windows.Forms.CheckBox spawnNpcs;
        private System.Windows.Forms.TextBox serverIp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown serverPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown maxWorldSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown maxPlayers;
    }
}