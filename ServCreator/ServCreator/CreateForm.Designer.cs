
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label13 = new System.Windows.Forms.Label();
            this.maxPlayers = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.enableCommandBlocks = new System.Windows.Forms.CheckBox();
            this.enableStatus = new System.Windows.Forms.CheckBox();
            this.hardcore = new System.Windows.Forms.CheckBox();
            this.enablePvp = new System.Windows.Forms.CheckBox();
            this.spawnMonsters = new System.Windows.Forms.CheckBox();
            this.difficulty = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gamemode = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.allowNether = new System.Windows.Forms.CheckBox();
            this.forceGamemode = new System.Windows.Forms.CheckBox();
            this.generatorSettings = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.spawnProtection = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.maxBuildingHeight = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.levelType = new System.Windows.Forms.TextBox();
            this.levelSeed = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.minRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRAM)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWorldSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnProtection)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBuildingHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Engine*:";
            // 
            // serverEngineCB
            // 
            this.serverEngineCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverEngineCB.FormattingEnabled = true;
            this.serverEngineCB.Items.AddRange(new object[] {
            "vanilla",
            "craftbukkit",
            "spigot"});
            this.serverEngineCB.Location = new System.Drawing.Point(6, 41);
            this.serverEngineCB.Name = "serverEngineCB";
            this.serverEngineCB.Size = new System.Drawing.Size(142, 25);
            this.serverEngineCB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version*:";
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
            "1.7.2"});
            this.serverVersionCB.Location = new System.Drawing.Point(154, 41);
            this.serverVersionCB.Name = "serverVersionCB";
            this.serverVersionCB.Size = new System.Drawing.Size(214, 25);
            this.serverVersionCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server Path*:";
            // 
            // selectBtn
            // 
            this.selectBtn.ForeColor = System.Drawing.Color.Black;
            this.selectBtn.Location = new System.Drawing.Point(268, 86);
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
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server Name (in ServManager)*:";
            // 
            // serverNameTB
            // 
            this.serverNameTB.Location = new System.Drawing.Point(6, 137);
            this.serverNameTB.Name = "serverNameTB";
            this.serverNameTB.Size = new System.Drawing.Size(362, 25);
            this.serverNameTB.TabIndex = 8;
            this.serverNameTB.Text = "New Server";
            // 
            // argumentsTB
            // 
            this.argumentsTB.Location = new System.Drawing.Point(6, 233);
            this.argumentsTB.Name = "argumentsTB";
            this.argumentsTB.Size = new System.Drawing.Size(362, 25);
            this.argumentsTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Additional arguments:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Minimum RAM (in MB)*:";
            // 
            // minRAM
            // 
            this.minRAM.Location = new System.Drawing.Point(6, 185);
            this.minRAM.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.minRAM.Name = "minRAM";
            this.minRAM.Size = new System.Drawing.Size(177, 25);
            this.minRAM.TabIndex = 12;
            this.minRAM.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // maxRAM
            // 
            this.maxRAM.Location = new System.Drawing.Point(191, 185);
            this.maxRAM.Maximum = new decimal(new int[] {
            102400,
            0,
            0,
            0});
            this.maxRAM.Name = "maxRAM";
            this.maxRAM.Size = new System.Drawing.Size(177, 25);
            this.maxRAM.TabIndex = 14;
            this.maxRAM.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Maximum RAM (in MB)*:";
            // 
            // createBtn
            // 
            this.createBtn.ForeColor = System.Drawing.Color.Black;
            this.createBtn.Location = new System.Drawing.Point(917, 398);
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
            this.checkJavaBtn.Location = new System.Drawing.Point(767, 398);
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
            this.serverPathTB.Location = new System.Drawing.Point(6, 89);
            this.serverPathTB.Name = "serverPathTB";
            this.serverPathTB.Size = new System.Drawing.Size(256, 25);
            this.serverPathTB.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(600, 398);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(161, 28);
            this.progressBar1.TabIndex = 18;
            this.progressBar1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.serverEngineCB);
            this.groupBox1.Controls.Add(this.serverPathTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.serverVersionCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maxRAM);
            this.groupBox1.Controls.Add(this.selectBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minRAM);
            this.groupBox1.Controls.Add(this.serverNameTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.argumentsTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(600, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 272);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(346, 313);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 13);
            this.linkLabel1.TabIndex = 71;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "MOTD Creator";
            // 
            // motd
            // 
            this.motd.Location = new System.Drawing.Point(170, 329);
            this.motd.Name = "motd";
            this.motd.Size = new System.Drawing.Size(403, 73);
            this.motd.TabIndex = 70;
            this.motd.Text = "A Minecraft Server";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "Message of the Day (motd):";
            // 
            // onlineMode
            // 
            this.onlineMode.AutoSize = true;
            this.onlineMode.Location = new System.Drawing.Point(6, 159);
            this.onlineMode.Name = "onlineMode";
            this.onlineMode.Size = new System.Drawing.Size(104, 21);
            this.onlineMode.TabIndex = 68;
            this.onlineMode.Text = "Online-Mode";
            this.onlineMode.UseVisualStyleBackColor = true;
            // 
            // generateStructures
            // 
            this.generateStructures.AutoSize = true;
            this.generateStructures.Checked = true;
            this.generateStructures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateStructures.Location = new System.Drawing.Point(6, 132);
            this.generateStructures.Name = "generateStructures";
            this.generateStructures.Size = new System.Drawing.Size(142, 21);
            this.generateStructures.TabIndex = 67;
            this.generateStructures.Text = "Generate Structures";
            this.generateStructures.UseVisualStyleBackColor = true;
            // 
            // whiteList
            // 
            this.whiteList.AutoSize = true;
            this.whiteList.Location = new System.Drawing.Point(6, 213);
            this.whiteList.Name = "whiteList";
            this.whiteList.Size = new System.Drawing.Size(81, 21);
            this.whiteList.TabIndex = 66;
            this.whiteList.Text = "White-list";
            this.whiteList.UseVisualStyleBackColor = true;
            // 
            // spawnAnimals
            // 
            this.spawnAnimals.AutoSize = true;
            this.spawnAnimals.Checked = true;
            this.spawnAnimals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spawnAnimals.Location = new System.Drawing.Point(119, 159);
            this.spawnAnimals.Name = "spawnAnimals";
            this.spawnAnimals.Size = new System.Drawing.Size(114, 21);
            this.spawnAnimals.TabIndex = 65;
            this.spawnAnimals.Text = "Spawn Animals";
            this.spawnAnimals.UseVisualStyleBackColor = true;
            // 
            // viewDistance
            // 
            this.viewDistance.Location = new System.Drawing.Point(9, 185);
            this.viewDistance.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.viewDistance.Name = "viewDistance";
            this.viewDistance.Size = new System.Drawing.Size(155, 25);
            this.viewDistance.TabIndex = 64;
            this.viewDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "View distance:";
            // 
            // levelName
            // 
            this.levelName.Location = new System.Drawing.Point(9, 137);
            this.levelName.Name = "levelName";
            this.levelName.Size = new System.Drawing.Size(155, 25);
            this.levelName.TabIndex = 62;
            this.levelName.Text = "world";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "Level Name:";
            // 
            // allowFlight
            // 
            this.allowFlight.AutoSize = true;
            this.allowFlight.Location = new System.Drawing.Point(6, 24);
            this.allowFlight.Name = "allowFlight";
            this.allowFlight.Size = new System.Drawing.Size(93, 21);
            this.allowFlight.TabIndex = 60;
            this.allowFlight.Text = "Allow Flight";
            this.allowFlight.UseVisualStyleBackColor = true;
            // 
            // spawnNpcs
            // 
            this.spawnNpcs.AutoSize = true;
            this.spawnNpcs.Checked = true;
            this.spawnNpcs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spawnNpcs.Location = new System.Drawing.Point(139, 186);
            this.spawnNpcs.Name = "spawnNpcs";
            this.spawnNpcs.Size = new System.Drawing.Size(100, 21);
            this.spawnNpcs.TabIndex = 59;
            this.spawnNpcs.Text = "Spawn NPCs";
            this.spawnNpcs.UseVisualStyleBackColor = true;
            // 
            // serverIp
            // 
            this.serverIp.Location = new System.Drawing.Point(173, 185);
            this.serverIp.MaxLength = 15;
            this.serverIp.Name = "serverIp";
            this.serverIp.Size = new System.Drawing.Size(145, 25);
            this.serverIp.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Server IP:";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(173, 137);
            this.serverPort.Maximum = new decimal(new int[] {
            69420,
            0,
            0,
            0});
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(145, 25);
            this.serverPort.TabIndex = 56;
            this.serverPort.Value = new decimal(new int[] {
            25565,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Server Port:";
            // 
            // maxWorldSize
            // 
            this.maxWorldSize.Location = new System.Drawing.Point(173, 89);
            this.maxWorldSize.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.maxWorldSize.Name = "maxWorldSize";
            this.maxWorldSize.Size = new System.Drawing.Size(145, 25);
            this.maxWorldSize.TabIndex = 54;
            this.maxWorldSize.Value = new decimal(new int[] {
            29999984,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Max World Size:";
            // 
            // maxPlayers
            // 
            this.maxPlayers.Location = new System.Drawing.Point(173, 41);
            this.maxPlayers.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxPlayers.Name = "maxPlayers";
            this.maxPlayers.Size = new System.Drawing.Size(145, 25);
            this.maxPlayers.TabIndex = 52;
            this.maxPlayers.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(170, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Max Players:";
            // 
            // enableCommandBlocks
            // 
            this.enableCommandBlocks.AutoSize = true;
            this.enableCommandBlocks.Location = new System.Drawing.Point(6, 78);
            this.enableCommandBlocks.Name = "enableCommandBlocks";
            this.enableCommandBlocks.Size = new System.Drawing.Size(170, 21);
            this.enableCommandBlocks.TabIndex = 50;
            this.enableCommandBlocks.Text = "Enable Command Blocks";
            this.enableCommandBlocks.UseVisualStyleBackColor = true;
            // 
            // enableStatus
            // 
            this.enableStatus.AutoSize = true;
            this.enableStatus.Checked = true;
            this.enableStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableStatus.Location = new System.Drawing.Point(108, 51);
            this.enableStatus.Name = "enableStatus";
            this.enableStatus.Size = new System.Drawing.Size(104, 21);
            this.enableStatus.TabIndex = 49;
            this.enableStatus.Text = "Enable status";
            this.enableStatus.UseVisualStyleBackColor = true;
            // 
            // hardcore
            // 
            this.hardcore.AutoSize = true;
            this.hardcore.Location = new System.Drawing.Point(157, 132);
            this.hardcore.Name = "hardcore";
            this.hardcore.Size = new System.Drawing.Size(82, 21);
            this.hardcore.TabIndex = 48;
            this.hardcore.Text = "Hardcore";
            this.hardcore.UseVisualStyleBackColor = true;
            // 
            // enablePvp
            // 
            this.enablePvp.AutoSize = true;
            this.enablePvp.Checked = true;
            this.enablePvp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enablePvp.Location = new System.Drawing.Point(6, 51);
            this.enablePvp.Name = "enablePvp";
            this.enablePvp.Size = new System.Drawing.Size(90, 21);
            this.enablePvp.TabIndex = 47;
            this.enablePvp.Text = "Enable PvP";
            this.enablePvp.UseVisualStyleBackColor = true;
            // 
            // spawnMonsters
            // 
            this.spawnMonsters.AutoSize = true;
            this.spawnMonsters.Checked = true;
            this.spawnMonsters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spawnMonsters.Location = new System.Drawing.Point(6, 186);
            this.spawnMonsters.Name = "spawnMonsters";
            this.spawnMonsters.Size = new System.Drawing.Size(124, 21);
            this.spawnMonsters.TabIndex = 46;
            this.spawnMonsters.Text = "Spawn Monsters";
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
            this.difficulty.Location = new System.Drawing.Point(9, 281);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(155, 25);
            this.difficulty.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 17);
            this.label15.TabIndex = 44;
            this.label15.Text = "Difficulty:";
            // 
            // gamemode
            // 
            this.gamemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamemode.FormattingEnabled = true;
            this.gamemode.Items.AddRange(new object[] {
            "survival",
            "adventure",
            "creative"});
            this.gamemode.Location = new System.Drawing.Point(9, 233);
            this.gamemode.Name = "gamemode";
            this.gamemode.Size = new System.Drawing.Size(155, 25);
            this.gamemode.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 43;
            this.label16.Text = "Gamemode:";
            // 
            // allowNether
            // 
            this.allowNether.AutoSize = true;
            this.allowNether.Checked = true;
            this.allowNether.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowNether.Location = new System.Drawing.Point(108, 24);
            this.allowNether.Name = "allowNether";
            this.allowNether.Size = new System.Drawing.Size(102, 21);
            this.allowNether.TabIndex = 42;
            this.allowNether.Text = "Allow Nether";
            this.allowNether.UseVisualStyleBackColor = true;
            // 
            // forceGamemode
            // 
            this.forceGamemode.AutoSize = true;
            this.forceGamemode.Location = new System.Drawing.Point(6, 105);
            this.forceGamemode.Name = "forceGamemode";
            this.forceGamemode.Size = new System.Drawing.Size(131, 21);
            this.forceGamemode.TabIndex = 41;
            this.forceGamemode.Text = "Force Gamemode";
            this.forceGamemode.UseVisualStyleBackColor = true;
            // 
            // generatorSettings
            // 
            this.generatorSettings.Location = new System.Drawing.Point(9, 89);
            this.generatorSettings.Name = "generatorSettings";
            this.generatorSettings.Size = new System.Drawing.Size(155, 25);
            this.generatorSettings.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "Generator Settings:";
            // 
            // spawnProtection
            // 
            this.spawnProtection.Location = new System.Drawing.Point(9, 41);
            this.spawnProtection.Name = "spawnProtection";
            this.spawnProtection.Size = new System.Drawing.Size(155, 25);
            this.spawnProtection.TabIndex = 38;
            this.spawnProtection.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Spawn Protection:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.levelSeed);
            this.groupBox2.Controls.Add(this.levelType);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.maxBuildingHeight);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.spawnProtection);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.motd);
            this.groupBox2.Controls.Add(this.generatorSettings);
            this.groupBox2.Controls.Add(this.viewDistance);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.levelName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.gamemode);
            this.groupBox2.Controls.Add(this.maxWorldSize);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.serverPort);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.serverIp);
            this.groupBox2.Controls.Add(this.difficulty);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.maxPlayers);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 414);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Properties";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.allowNether);
            this.groupBox3.Controls.Add(this.generateStructures);
            this.groupBox3.Controls.Add(this.forceGamemode);
            this.groupBox3.Controls.Add(this.enablePvp);
            this.groupBox3.Controls.Add(this.allowFlight);
            this.groupBox3.Controls.Add(this.whiteList);
            this.groupBox3.Controls.Add(this.onlineMode);
            this.groupBox3.Controls.Add(this.spawnNpcs);
            this.groupBox3.Controls.Add(this.spawnAnimals);
            this.groupBox3.Controls.Add(this.spawnMonsters);
            this.groupBox3.Controls.Add(this.enableStatus);
            this.groupBox3.Controls.Add(this.enableCommandBlocks);
            this.groupBox3.Controls.Add(this.hardcore);
            this.groupBox3.Location = new System.Drawing.Point(324, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 292);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(597, 344);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(380, 51);
            this.label19.TabIndex = 73;
            this.label19.Text = "This server.properties is universal for every Minecraft version.\r\nSome of options" +
    " can not work in earlier versions properly. You \r\ncan later add or change settin" +
    "gs on properties in Control Panel.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 17);
            this.label20.TabIndex = 73;
            this.label20.Text = "Max Building Height:";
            // 
            // maxBuildingHeight
            // 
            this.maxBuildingHeight.Location = new System.Drawing.Point(9, 329);
            this.maxBuildingHeight.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.maxBuildingHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxBuildingHeight.Name = "maxBuildingHeight";
            this.maxBuildingHeight.Size = new System.Drawing.Size(155, 25);
            this.maxBuildingHeight.TabIndex = 74;
            this.maxBuildingHeight.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(144, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 21);
            this.checkBox1.TabIndex = 69;
            this.checkBox1.Text = "Enable Rcon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(485, -3);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(97, 17);
            this.linkLabel2.TabIndex = 75;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Settings Helper";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(173, 213);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 17);
            this.label21.TabIndex = 76;
            this.label21.Text = "Level Seed:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 357);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 17);
            this.label22.TabIndex = 78;
            this.label22.Text = "Level Type:";
            // 
            // levelType
            // 
            this.levelType.Location = new System.Drawing.Point(9, 377);
            this.levelType.Name = "levelType";
            this.levelType.Size = new System.Drawing.Size(155, 25);
            this.levelType.TabIndex = 79;
            this.levelType.Text = "default";
            // 
            // levelSeed
            // 
            this.levelSeed.Location = new System.Drawing.Point(173, 233);
            this.levelSeed.Name = "levelSeed";
            this.levelSeed.Size = new System.Drawing.Size(145, 25);
            this.levelSeed.TabIndex = 80;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(173, 261);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(129, 17);
            this.label23.TabIndex = 81;
            this.label23.Text = "Op Permission Level:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(173, 281);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 25);
            this.numericUpDown1.TabIndex = 82;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Location = new System.Drawing.Point(600, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 51);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Minecraft - End User License Agreement";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 21);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Accept EULA";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(112, 21);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(114, 17);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Read about EULA ";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(990, 438);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.checkJavaBtn);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateForm";
            this.Text = "Server Creator - ServManager for Minecraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRAM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWorldSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spawnProtection)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBuildingHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown maxPlayers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox enableCommandBlocks;
        private System.Windows.Forms.CheckBox enableStatus;
        private System.Windows.Forms.CheckBox hardcore;
        private System.Windows.Forms.CheckBox enablePvp;
        private System.Windows.Forms.CheckBox spawnMonsters;
        private System.Windows.Forms.ComboBox difficulty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox gamemode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox allowNether;
        private System.Windows.Forms.CheckBox forceGamemode;
        private System.Windows.Forms.TextBox generatorSettings;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown spawnProtection;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.NumericUpDown maxBuildingHeight;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox levelSeed;
        private System.Windows.Forms.TextBox levelType;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}