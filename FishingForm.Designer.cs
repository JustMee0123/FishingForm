namespace Fishing {
    partial class FishingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FishingForm));
            this.tbChangeName = new System.Windows.Forms.TextBox();
            this.contextMenuStats = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnFatiguePath = new System.Windows.Forms.Button();
            this.cbLogToFile = new System.Windows.Forms.CheckBox();
            this.numNavMaxNoCatch = new System.Windows.Forms.NumericUpDown();
            this.numNavMaxRecastDelay = new System.Windows.Forms.NumericUpDown();
            this.cbFatigueFullInventory = new System.Windows.Forms.CheckBox();
            this.lblFishingSkillup = new System.Windows.Forms.Label();
            this.cbGMExecuteCommand = new System.Windows.Forms.CheckBox();
            this.cbRestartatMidnight = new System.Windows.Forms.CheckBox();
            this.cbNavReversePath = new System.Windows.Forms.CheckBox();
            this.contextMenuListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBait = new System.Windows.Forms.Label();
            this.lblRod = new System.Windows.Forms.Label();
            this.lblBaitHeader = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.lblRodHeader = new System.Windows.Forms.Label();
            this.lblZoneHeader = new System.Windows.Forms.Label();
            this.rtbStats = new System.Windows.Forms.RichTextBox();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.pnlWanted = new System.Windows.Forms.Panel();
            this.cbCatchUnknown = new System.Windows.Forms.CheckBox();
            this.lblWantedHeader = new System.Windows.Forms.Label();
            this.lbWanted = new System.Windows.Forms.ListBox();
            this.pnlUnwanted = new System.Windows.Forms.Panel();
            this.lbUnwanted = new System.Windows.Forms.ListBox();
            this.lblUnwantedHeader = new System.Windows.Forms.Label();
            this.btnRefreshLists = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.Extras = new System.Windows.Forms.TabControl();
            this.tabDisplayPageChat = new System.Windows.Forms.TabPage();
            this.btnStartM = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.tbChat = new System.Windows.Forms.TextBox();
            this.btnChatSend = new System.Windows.Forms.Button();
            this.tabChat = new System.Windows.Forms.TabControl();
            this.tabChatPageLog = new System.Windows.Forms.TabPage();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.tabChatPageFishing = new System.Windows.Forms.TabPage();
            this.rtbFish = new System.Windows.Forms.RichTextBox();
            this.tabChatPageTell = new System.Windows.Forms.TabPage();
            this.rtbTell = new System.Windows.Forms.RichTextBox();
            this.tabChatPageParty = new System.Windows.Forms.TabPage();
            this.rtbParty = new System.Windows.Forms.RichTextBox();
            this.tabChatPageLS = new System.Windows.Forms.TabPage();
            this.rtbShell = new System.Windows.Forms.RichTextBox();
            this.tabChatPageSay = new System.Windows.Forms.TabPage();
            this.rtbSay = new System.Windows.Forms.RichTextBox();
            this.tabDisplayPageStats = new System.Windows.Forms.TabPage();
            this.tabDisplayPageInfo = new System.Windows.Forms.TabPage();
            this.lblNoCatchAt = new System.Windows.Forms.Label();
            this.lblNoCatchAtHeader = new System.Windows.Forms.Label();
            this.lblCaseSpace = new System.Windows.Forms.Label();
            this.lblCase = new System.Windows.Forms.Label();
            this.lblEarthTimeHeader = new System.Windows.Forms.Label();
            this.lblEarthTime = new System.Windows.Forms.Label();
            this.lblVanaTimeHeader = new System.Windows.Forms.Label();
            this.lblSackSpace = new System.Windows.Forms.Label();
            this.lblSatchelSpace = new System.Windows.Forms.Label();
            this.lblInventorySpace = new System.Windows.Forms.Label();
            this.lblSackHeader = new System.Windows.Forms.Label();
            this.lblVanaTime = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblSatchelHeader = new System.Windows.Forms.Label();
            this.lblInventoryHeader = new System.Windows.Forms.Label();
            this.lblSkillHeader = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tabDisplayPageOptions = new System.Windows.Forms.TabPage();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tabOptionsPageForm = new System.Windows.Forms.TabPage();
            this.cbSneakFishing = new System.Windows.Forms.CheckBox();
            this.numMaxCatch = new System.Windows.Forms.NumericUpDown();
            this.cbEnableItemizerItemTools = new System.Windows.Forms.CheckBox();
            this.cbMaxCatch = new System.Windows.Forms.CheckBox();
            this.cbTellDetect = new System.Windows.Forms.CheckBox();
            this.gbGeneralFishing = new System.Windows.Forms.GroupBox();
            this.lblCastWait = new System.Windows.Forms.Label();
            this.numMaxNoCatch = new System.Windows.Forms.NumericUpDown();
            this.btnCastReset = new System.Windows.Forms.Button();
            this.numCastIntervalLow = new System.Windows.Forms.NumericUpDown();
            this.lblMaxNoCatch = new System.Windows.Forms.Label();
            this.numCastIntervalHigh = new System.Windows.Forms.NumericUpDown();
            this.trackOpacity = new System.Windows.Forms.TrackBar();
            this.cbStopSound = new System.Windows.Forms.CheckBox();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.btnSettingsReset = new System.Windows.Forms.Button();
            this.cbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.tabOptionsPageFight = new System.Windows.Forms.TabPage();
            this.cbFishHP = new System.Windows.Forms.CheckBox();
            this.numReactionHigh = new System.Windows.Forms.NumericUpDown();
            this.numReactionLow = new System.Windows.Forms.NumericUpDown();
            this.cbReaction = new System.Windows.Forms.CheckBox();
            this.numFakeLargeIntervalLow = new System.Windows.Forms.NumericUpDown();
            this.cbReleaseSmall = new System.Windows.Forms.CheckBox();
            this.numFakeLargeIntervalHigh = new System.Windows.Forms.NumericUpDown();
            this.numFakeSmallIntervalLow = new System.Windows.Forms.NumericUpDown();
            this.cbReleaseLarge = new System.Windows.Forms.CheckBox();
            this.cbIgnoreLargeFish = new System.Windows.Forms.CheckBox();
            this.numFakeSmallIntervalHigh = new System.Windows.Forms.NumericUpDown();
            this.cbIgnoreSmallFish = new System.Windows.Forms.CheckBox();
            this.cbIgnoreItem = new System.Windows.Forms.CheckBox();
            this.cbIgnoreMonster = new System.Windows.Forms.CheckBox();
            this.lblKillSeconds = new System.Windows.Forms.Label();
            this.numQuickKill = new System.Windows.Forms.NumericUpDown();
            this.cbQuickKill = new System.Windows.Forms.CheckBox();
            this.cbAutoKill = new System.Windows.Forms.CheckBox();
            this.cbExtend = new System.Windows.Forms.CheckBox();
            this.tabOptionsPageAdvanced = new System.Windows.Forms.TabPage();
            this.gbLogging = new System.Windows.Forms.GroupBox();
            this.gbGMDetect = new System.Windows.Forms.GroupBox();
            this.cbGMdetectAutostop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFullactionOther = new System.Windows.Forms.TextBox();
            this.rbFullactionOther = new System.Windows.Forms.RadioButton();
            this.rbFullactionWarp = new System.Windows.Forms.RadioButton();
            this.rbFullactionLogout = new System.Windows.Forms.RadioButton();
            this.rbFullactionNone = new System.Windows.Forms.RadioButton();
            this.tabNavigation = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNavSetup = new System.Windows.Forms.TabPage();
            this.btnCurrentCord = new System.Windows.Forms.Button();
            this.btnNavRecordingSave = new System.Windows.Forms.Button();
            this.btnNavRecordingStop = new System.Windows.Forms.Button();
            this.btnRecordNav = new System.Windows.Forms.Button();
            this.btnNavLoadFile = new System.Windows.Forms.Button();
            this.btnStartNav = new System.Windows.Forms.Button();
            this.tabNavEvents = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNavEnableFatiguePath = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblVanaDay = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVanaClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHP = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarST = new System.Windows.Forms.ToolStripProgressBar();
            this.timer_JapaneseTimeCheck = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNavMaxNoCatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNavMaxRecastDelay)).BeginInit();
            this.contextMenuListBox.SuspendLayout();
            this.pnlLog.SuspendLayout();
            this.pnlWanted.SuspendLayout();
            this.pnlUnwanted.SuspendLayout();
            this.Extras.SuspendLayout();
            this.tabDisplayPageChat.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.tabChatPageLog.SuspendLayout();
            this.tabChatPageFishing.SuspendLayout();
            this.tabChatPageTell.SuspendLayout();
            this.tabChatPageParty.SuspendLayout();
            this.tabChatPageLS.SuspendLayout();
            this.tabChatPageSay.SuspendLayout();
            this.tabDisplayPageStats.SuspendLayout();
            this.tabDisplayPageInfo.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.tabDisplayPageOptions.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabOptionsPageForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCatch)).BeginInit();
            this.gbGeneralFishing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxNoCatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCastIntervalLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCastIntervalHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpacity)).BeginInit();
            this.tabOptionsPageFight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReactionHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReactionLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFakeLargeIntervalLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFakeLargeIntervalHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFakeSmallIntervalLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFakeSmallIntervalHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuickKill)).BeginInit();
            this.tabOptionsPageAdvanced.SuspendLayout();
            this.gbLogging.SuspendLayout();
            this.gbGMDetect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigation.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabNavSetup.SuspendLayout();
            this.tabNavEvents.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbChangeName
            // 
            this.tbChangeName.Location = new System.Drawing.Point(105, 44);
            this.tbChangeName.Margin = new System.Windows.Forms.Padding(0);
            this.tbChangeName.Name = "tbChangeName";
            this.tbChangeName.ShortcutsEnabled = false;
            this.tbChangeName.Size = new System.Drawing.Size(10, 20);
            this.tbChangeName.TabIndex = 32;
            this.tbChangeName.TabStop = false;
            this.tbChangeName.Visible = false;
            this.tbChangeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChangeName_KeyPress);
            this.tbChangeName.LostFocus += new System.EventHandler(this.tbChangeName_LostFocus);
            // 
            // contextMenuStats
            // 
            this.contextMenuStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem});
            this.contextMenuStats.Name = "contextMenuLog";
            this.contextMenuStats.Size = new System.Drawing.Size(130, 26);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clearLogToolStripMenuItem.Text = "Clear Stats";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // btnFatiguePath
            // 
            this.btnFatiguePath.Location = new System.Drawing.Point(6, 6);
            this.btnFatiguePath.Name = "btnFatiguePath";
            this.btnFatiguePath.Size = new System.Drawing.Size(75, 23);
            this.btnFatiguePath.TabIndex = 1;
            this.btnFatiguePath.Text = "Fatigue Path";
            this.toolTip.SetToolTip(this.btnFatiguePath, "Load navi file that will be run when max no catch is set. It\'s best to start reco" +
        "rding this file a few yalms before the zone line in the zone right before you fi" +
        "shing spot since to optimize the path.");
            this.btnFatiguePath.UseVisualStyleBackColor = true;
            this.btnFatiguePath.Click += new System.EventHandler(this.btnFatiguePath_Click);
            // 
            // cbLogToFile
            // 
            this.cbLogToFile.AutoSize = true;
            this.cbLogToFile.Location = new System.Drawing.Point(10, 17);
            this.cbLogToFile.Name = "cbLogToFile";
            this.cbLogToFile.Size = new System.Drawing.Size(112, 17);
            this.cbLogToFile.TabIndex = 0;
            this.cbLogToFile.Text = "Log Results to File";
            this.toolTip.SetToolTip(this.cbLogToFile, "Log fishing results to file");
            this.cbLogToFile.UseVisualStyleBackColor = true;
            // 
            // numNavMaxNoCatch
            // 
            this.numNavMaxNoCatch.Enabled = false;
            this.numNavMaxNoCatch.Location = new System.Drawing.Point(253, 45);
            this.numNavMaxNoCatch.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numNavMaxNoCatch.Name = "numNavMaxNoCatch";
            this.numNavMaxNoCatch.Size = new System.Drawing.Size(42, 18);
            this.numNavMaxNoCatch.TabIndex = 2;
            this.toolTip.SetToolTip(this.numNavMaxNoCatch, "Maximum consecutive no catches before running the fatigue path");
            // 
            // numNavMaxRecastDelay
            // 
            this.numNavMaxRecastDelay.Enabled = false;
            this.numNavMaxRecastDelay.Location = new System.Drawing.Point(253, 65);
            this.numNavMaxRecastDelay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numNavMaxRecastDelay.Name = "numNavMaxRecastDelay";
            this.numNavMaxRecastDelay.Size = new System.Drawing.Size(42, 18);
            this.numNavMaxRecastDelay.TabIndex = 6;
            this.toolTip.SetToolTip(this.numNavMaxRecastDelay, "Max Recast Delay in seconds before running fatigue path");
            // 
            // cbFatigueFullInventory
            // 
            this.cbFatigueFullInventory.AutoSize = true;
            this.cbFatigueFullInventory.Enabled = false;
            this.cbFatigueFullInventory.Location = new System.Drawing.Point(158, 25);
            this.cbFatigueFullInventory.Name = "cbFatigueFullInventory";
            this.cbFatigueFullInventory.Size = new System.Drawing.Size(106, 17);
            this.cbFatigueFullInventory.TabIndex = 7;
            this.cbFatigueFullInventory.Text = "On Full Inventory";
            this.toolTip.SetToolTip(this.cbFatigueFullInventory, "This option will only run your path once and will not return you to your fishing " +
        "spot.");
            this.cbFatigueFullInventory.UseVisualStyleBackColor = true;
            // 
            // lblFishingSkillup
            // 
            this.lblFishingSkillup.AutoSize = true;
            this.lblFishingSkillup.Location = new System.Drawing.Point(229, 5);
            this.lblFishingSkillup.Name = "lblFishingSkillup";
            this.lblFishingSkillup.Size = new System.Drawing.Size(28, 13);
            this.lblFishingSkillup.TabIndex = 48;
            this.lblFishingSkillup.Text = "(0.0)";
            this.toolTip.SetToolTip(this.lblFishingSkillup, "Skillups gained during fishing session");
            // 
            // cbGMExecuteCommand
            // 
            this.cbGMExecuteCommand.AutoSize = true;
            this.cbGMExecuteCommand.Location = new System.Drawing.Point(10, 37);
            this.cbGMExecuteCommand.Name = "cbGMExecuteCommand";
            this.cbGMExecuteCommand.Size = new System.Drawing.Size(114, 17);
            this.cbGMExecuteCommand.TabIndex = 11;
            this.cbGMExecuteCommand.Text = "Execute Command";
            this.toolTip.SetToolTip(this.cbGMExecuteCommand, "Execute the full inventory command ");
            this.cbGMExecuteCommand.UseVisualStyleBackColor = true;
            // 
            // cbRestartatMidnight
            // 
            this.cbRestartatMidnight.AutoSize = true;
            this.cbRestartatMidnight.Location = new System.Drawing.Point(137, 9);
            this.cbRestartatMidnight.Name = "cbRestartatMidnight";
            this.cbRestartatMidnight.Size = new System.Drawing.Size(129, 17);
            this.cbRestartatMidnight.TabIndex = 3;
            this.cbRestartatMidnight.Text = "Restart @ JP midnight";
            this.toolTip.SetToolTip(this.cbRestartatMidnight, "Restart fishing at 0:00 JP time");
            this.cbRestartatMidnight.UseVisualStyleBackColor = true;
            this.cbRestartatMidnight.CheckedChanged += new System.EventHandler(this.cbRestartatMidnight_CheckedChanged);
            // 
            // cbNavReversePath
            // 
            this.cbNavReversePath.AutoSize = true;
            this.cbNavReversePath.Location = new System.Drawing.Point(198, 11);
            this.cbNavReversePath.Name = "cbNavReversePath";
            this.cbNavReversePath.Size = new System.Drawing.Size(90, 17);
            this.cbNavReversePath.TabIndex = 12;
            this.cbNavReversePath.Text = "Reverse Path";
            this.toolTip.SetToolTip(this.cbNavReversePath, "Execute path file in reverse order");
            this.cbNavReversePath.UseVisualStyleBackColor = true;
            // 
            // contextMenuListBox
            // 
            this.contextMenuListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeNameToolStripMenuItem});
            this.contextMenuListBox.Name = "contextMenuListBox";
            this.contextMenuListBox.Size = new System.Drawing.Size(151, 26);
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.changeNameToolStripMenuItem.Text = "Change Name";
            this.changeNameToolStripMenuItem.Click += new System.EventHandler(this.changeNameToolStripMenuItem_Click);
            // 
            // lblBait
            // 
            this.lblBait.AutoSize = true;
            this.lblBait.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBait.Location = new System.Drawing.Point(76, 47);
            this.lblBait.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBait.Name = "lblBait";
            this.lblBait.Size = new System.Drawing.Size(13, 13);
            this.lblBait.TabIndex = 15;
            this.lblBait.Text = "--";
            // 
            // lblRod
            // 
            this.lblRod.AutoSize = true;
            this.lblRod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRod.Location = new System.Drawing.Point(76, 28);
            this.lblRod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRod.Name = "lblRod";
            this.lblRod.Size = new System.Drawing.Size(13, 13);
            this.lblRod.TabIndex = 14;
            this.lblRod.Text = "--";
            // 
            // lblBaitHeader
            // 
            this.lblBaitHeader.AutoSize = true;
            this.lblBaitHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaitHeader.Location = new System.Drawing.Point(5, 48);
            this.lblBaitHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblBaitHeader.Name = "lblBaitHeader";
            this.lblBaitHeader.Size = new System.Drawing.Size(32, 12);
            this.lblBaitHeader.TabIndex = 12;
            this.lblBaitHeader.Text = "Bait: ";
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.Location = new System.Drawing.Point(76, 9);
            this.lblZone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(13, 13);
            this.lblZone.TabIndex = 13;
            this.lblZone.Text = "--";
            // 
            // lblRodHeader
            // 
            this.lblRodHeader.AutoSize = true;
            this.lblRodHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodHeader.Location = new System.Drawing.Point(5, 29);
            this.lblRodHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblRodHeader.Name = "lblRodHeader";
            this.lblRodHeader.Size = new System.Drawing.Size(32, 12);
            this.lblRodHeader.TabIndex = 11;
            this.lblRodHeader.Text = "Rod: ";
            // 
            // lblZoneHeader
            // 
            this.lblZoneHeader.AutoSize = true;
            this.lblZoneHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoneHeader.Location = new System.Drawing.Point(5, 10);
            this.lblZoneHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblZoneHeader.Name = "lblZoneHeader";
            this.lblZoneHeader.Size = new System.Drawing.Size(34, 12);
            this.lblZoneHeader.TabIndex = 10;
            this.lblZoneHeader.Text = "Zone:";
            // 
            // rtbStats
            // 
            this.rtbStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbStats.ContextMenuStrip = this.contextMenuStats;
            this.rtbStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStats.Location = new System.Drawing.Point(0, 0);
            this.rtbStats.Margin = new System.Windows.Forms.Padding(0);
            this.rtbStats.Name = "rtbStats";
            this.rtbStats.ReadOnly = true;
            this.rtbStats.Size = new System.Drawing.Size(326, 167);
            this.rtbStats.TabIndex = 10;
            this.rtbStats.Text = "";
            // 
            // pnlLog
            // 
            this.pnlLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLog.Controls.Add(this.pnlWanted);
            this.pnlLog.Controls.Add(this.pnlUnwanted);
            this.pnlLog.Controls.Add(this.btnRefreshLists);
            this.pnlLog.Controls.Add(this.btnStart);
            this.pnlLog.Controls.Add(this.Extras);
            this.pnlLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLog.Location = new System.Drawing.Point(0, 0);
            this.pnlLog.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(478, 217);
            this.pnlLog.TabIndex = 34;
            // 
            // pnlWanted
            // 
            this.pnlWanted.Controls.Add(this.cbCatchUnknown);
            this.pnlWanted.Controls.Add(this.lblWantedHeader);
            this.pnlWanted.Controls.Add(this.lbWanted);
            this.pnlWanted.Location = new System.Drawing.Point(3, 33);
            this.pnlWanted.Name = "pnlWanted";
            this.pnlWanted.Size = new System.Drawing.Size(140, 73);
            this.pnlWanted.TabIndex = 41;
            // 
            // cbCatchUnknown
            // 
            this.cbCatchUnknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCatchUnknown.Location = new System.Drawing.Point(59, 1);
            this.cbCatchUnknown.Margin = new System.Windows.Forms.Padding(0);
            this.cbCatchUnknown.Name = "cbCatchUnknown";
            this.cbCatchUnknown.Size = new System.Drawing.Size(81, 15);
            this.cbCatchUnknown.TabIndex = 10;
            this.cbCatchUnknown.Text = "Unknowns?";
            this.cbCatchUnknown.UseVisualStyleBackColor = true;
            // 
            // lblWantedHeader
            // 
            this.lblWantedHeader.AutoSize = true;
            this.lblWantedHeader.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWantedHeader.Location = new System.Drawing.Point(0, 2);
            this.lblWantedHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblWantedHeader.Name = "lblWantedHeader";
            this.lblWantedHeader.Size = new System.Drawing.Size(45, 13);
            this.lblWantedHeader.TabIndex = 7;
            this.lblWantedHeader.Text = "Wanted";
            // 
            // lbWanted
            // 
            this.lbWanted.BackColor = System.Drawing.SystemColors.Window;
            this.lbWanted.FormattingEnabled = true;
            this.lbWanted.Location = new System.Drawing.Point(0, 16);
            this.lbWanted.Margin = new System.Windows.Forms.Padding(0);
            this.lbWanted.Name = "lbWanted";
            this.lbWanted.Size = new System.Drawing.Size(140, 56);
            this.lbWanted.Sorted = true;
            this.lbWanted.TabIndex = 8;
            this.lbWanted.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            this.lbWanted.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // pnlUnwanted
            // 
            this.pnlUnwanted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUnwanted.Controls.Add(this.lbUnwanted);
            this.pnlUnwanted.Controls.Add(this.lblUnwantedHeader);
            this.pnlUnwanted.Location = new System.Drawing.Point(3, 106);
            this.pnlUnwanted.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUnwanted.Name = "pnlUnwanted";
            this.pnlUnwanted.Size = new System.Drawing.Size(140, 86);
            this.pnlUnwanted.TabIndex = 40;
            // 
            // lbUnwanted
            // 
            this.lbUnwanted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUnwanted.FormattingEnabled = true;
            this.lbUnwanted.IntegralHeight = false;
            this.lbUnwanted.Location = new System.Drawing.Point(0, 16);
            this.lbUnwanted.Margin = new System.Windows.Forms.Padding(0);
            this.lbUnwanted.Name = "lbUnwanted";
            this.lbUnwanted.Size = new System.Drawing.Size(140, 69);
            this.lbUnwanted.Sorted = true;
            this.lbUnwanted.TabIndex = 9;
            this.lbUnwanted.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            this.lbUnwanted.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lblUnwantedHeader
            // 
            this.lblUnwantedHeader.AutoSize = true;
            this.lblUnwantedHeader.ForeColor = System.Drawing.Color.Maroon;
            this.lblUnwantedHeader.Location = new System.Drawing.Point(0, 2);
            this.lblUnwantedHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblUnwantedHeader.Name = "lblUnwantedHeader";
            this.lblUnwantedHeader.Size = new System.Drawing.Size(56, 13);
            this.lblUnwantedHeader.TabIndex = 8;
            this.lblUnwantedHeader.Text = "Unwanted";
            // 
            // btnRefreshLists
            // 
            this.btnRefreshLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnRefreshLists.Image = global::Fishing.Properties.Resources.refresh;
            this.btnRefreshLists.Location = new System.Drawing.Point(113, 0);
            this.btnRefreshLists.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshLists.Name = "btnRefreshLists";
            this.btnRefreshLists.Size = new System.Drawing.Size(31, 30);
            this.btnRefreshLists.TabIndex = 9;
            this.btnRefreshLists.UseVisualStyleBackColor = true;
            this.btnRefreshLists.Click += new System.EventHandler(this.btnRefreshLists_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(2, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 30);
            this.btnStart.TabIndex = 39;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Extras
            // 
            this.Extras.AccessibleName = "";
            this.Extras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Extras.Controls.Add(this.tabDisplayPageChat);
            this.Extras.Controls.Add(this.tabDisplayPageStats);
            this.Extras.Controls.Add(this.tabDisplayPageInfo);
            this.Extras.Controls.Add(this.tabDisplayPageOptions);
            this.Extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Extras.HotTrack = true;
            this.Extras.Location = new System.Drawing.Point(146, 0);
            this.Extras.Margin = new System.Windows.Forms.Padding(0);
            this.Extras.Name = "Extras";
            this.Extras.Padding = new System.Drawing.Point(0, 0);
            this.Extras.SelectedIndex = 0;
            this.Extras.Size = new System.Drawing.Size(334, 192);
            this.Extras.TabIndex = 8;
            // 
            // tabDisplayPageChat
            // 
            this.tabDisplayPageChat.BackColor = System.Drawing.SystemColors.Control;
            this.tabDisplayPageChat.Controls.Add(this.btnStartM);
            this.tabDisplayPageChat.Controls.Add(this.btnResize);
            this.tabDisplayPageChat.Controls.Add(this.tbChat);
            this.tabDisplayPageChat.Controls.Add(this.btnChatSend);
            this.tabDisplayPageChat.Controls.Add(this.tabChat);
            this.tabDisplayPageChat.Location = new System.Drawing.Point(4, 21);
            this.tabDisplayPageChat.Name = "tabDisplayPageChat";
            this.tabDisplayPageChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplayPageChat.Size = new System.Drawing.Size(326, 167);
            this.tabDisplayPageChat.TabIndex = 3;
            this.tabDisplayPageChat.Text = "Chat";
            // 
            // btnStartM
            // 
            this.btnStartM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartM.Image = global::Fishing.Properties.Resources.icon_play;
            this.btnStartM.Location = new System.Drawing.Point(240, -1);
            this.btnStartM.Name = "btnStartM";
            this.btnStartM.Size = new System.Drawing.Size(22, 22);
            this.btnStartM.TabIndex = 4;
            this.btnStartM.UseVisualStyleBackColor = true;
            this.btnStartM.Click += new System.EventHandler(this.btnStartM_Click);
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResize.Location = new System.Drawing.Point(304, -1);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(22, 22);
            this.btnResize.TabIndex = 3;
            this.btnResize.Text = "<";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // tbChat
            // 
            this.tbChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbChat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbChat.Location = new System.Drawing.Point(0, 0);
            this.tbChat.MaxLength = 120;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(240, 20);
            this.tbChat.TabIndex = 2;
            this.tbChat.WordWrap = false;
            this.tbChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbChat_KeyDown);
            this.tbChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChat_KeyPress);
            // 
            // btnChatSend
            // 
            this.btnChatSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChatSend.Location = new System.Drawing.Point(261, -1);
            this.btnChatSend.Name = "btnChatSend";
            this.btnChatSend.Size = new System.Drawing.Size(44, 22);
            this.btnChatSend.TabIndex = 1;
            this.btnChatSend.Text = "Send";
            this.btnChatSend.UseVisualStyleBackColor = true;
            this.btnChatSend.Click += new System.EventHandler(this.btnChatSend_Click);
            // 
            // tabChat
            // 
            this.tabChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabChat.Controls.Add(this.tabChatPageLog);
            this.tabChat.Controls.Add(this.tabChatPageFishing);
            this.tabChat.Controls.Add(this.tabChatPageTell);
            this.tabChat.Controls.Add(this.tabChatPageParty);
            this.tabChat.Controls.Add(this.tabChatPageLS);
            this.tabChat.Controls.Add(this.tabChatPageSay);
            this.tabChat.Location = new System.Drawing.Point(0, 22);
            this.tabChat.Margin = new System.Windows.Forms.Padding(0);
            this.tabChat.Multiline = true;
            this.tabChat.Name = "tabChat";
            this.tabChat.SelectedIndex = 0;
            this.tabChat.Size = new System.Drawing.Size(329, 145);
            this.tabChat.TabIndex = 0;
            this.tabChat.TabStop = false;
            this.tabChat.SelectedIndexChanged += new System.EventHandler(this.tabChat_SelectedIndexChanged);
            // 
            // tabChatPageLog
            // 
            this.tabChatPageLog.BackColor = System.Drawing.Color.Transparent;
            this.tabChatPageLog.Controls.Add(this.rtbChat);
            this.tabChatPageLog.Location = new System.Drawing.Point(4, 21);
            this.tabChatPageLog.Name = "tabChatPageLog";
            this.tabChatPageLog.Size = new System.Drawing.Size(321, 120);
            this.tabChatPageLog.TabIndex = 0;
            this.tabChatPageLog.Text = "Log";
            this.tabChatPageLog.UseVisualStyleBackColor = true;
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChat.ForeColor = System.Drawing.Color.White;
            this.rtbChat.Location = new System.Drawing.Point(0, 0);
            this.rtbChat.Margin = new System.Windows.Forms.Padding(0);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(321, 120);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.TabStop = false;
            this.rtbChat.Text = "";
            this.rtbChat.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbChat_LinkClicked);
            // 
            // tabChatPageFishing
            // 
            this.tabChatPageFishing.Controls.Add(this.rtbFish);
            this.tabChatPageFishing.Location = new System.Drawing.Point(4, 22);
            this.tabChatPageFishing.Name = "tabChatPageFishing";
            this.tabChatPageFishing.Size = new System.Drawing.Size(321, 119);
            this.tabChatPageFishing.TabIndex = 1;
            this.tabChatPageFishing.Text = "Fishing";
            this.tabChatPageFishing.UseVisualStyleBackColor = true;
            // 
            // rtbFish
            // 
            this.rtbFish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rtbFish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFish.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFish.ForeColor = System.Drawing.Color.White;
            this.rtbFish.Location = new System.Drawing.Point(0, 0);
            this.rtbFish.Margin = new System.Windows.Forms.Padding(0);
            this.rtbFish.Name = "rtbFish";
            this.rtbFish.ReadOnly = true;
            this.rtbFish.Size = new System.Drawing.Size(321, 119);
            this.rtbFish.TabIndex = 1;
            this.rtbFish.TabStop = false;
            this.rtbFish.Text = "";
            // 
            // tabChatPageTell
            // 
            this.tabChatPageTell.Controls.Add(this.rtbTell);
            this.tabChatPageTell.Location = new System.Drawing.Point(4, 22);
            this.tabChatPageTell.Name = "tabChatPageTell";
            this.tabChatPageTell.Size = new System.Drawing.Size(321, 119);
            this.tabChatPageTell.TabIndex = 2;
            this.tabChatPageTell.Text = "Tell";
            this.tabChatPageTell.UseVisualStyleBackColor = true;
            // 
            // rtbTell
            // 
            this.rtbTell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rtbTell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTell.ForeColor = System.Drawing.Color.White;
            this.rtbTell.Location = new System.Drawing.Point(0, 0);
            this.rtbTell.Margin = new System.Windows.Forms.Padding(0);
            this.rtbTell.Name = "rtbTell";
            this.rtbTell.ReadOnly = true;
            this.rtbTell.Size = new System.Drawing.Size(321, 119);
            this.rtbTell.TabIndex = 1;
            this.rtbTell.TabStop = false;
            this.rtbTell.Text = "";
            this.rtbTell.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbTell_LinkClicked);
            // 
            // tabChatPageParty
            // 
            this.tabChatPageParty.Controls.Add(this.rtbParty);
            this.tabChatPageParty.Location = new System.Drawing.Point(4, 22);
            this.tabChatPageParty.Name = "tabChatPageParty";
            this.tabChatPageParty.Size = new System.Drawing.Size(321, 119);
            this.tabChatPageParty.TabIndex = 3;
            this.tabChatPageParty.Text = "PT";
            this.tabChatPageParty.UseVisualStyleBackColor = true;
            // 
            // rtbParty
            // 
            this.rtbParty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rtbParty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbParty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbParty.ForeColor = System.Drawing.Color.White;
            this.rtbParty.Location = new System.Drawing.Point(0, 0);
            this.rtbParty.Margin = new System.Windows.Forms.Padding(0);
            this.rtbParty.Name = "rtbParty";
            this.rtbParty.ReadOnly = true;
            this.rtbParty.Size = new System.Drawing.Size(321, 119);
            this.rtbParty.TabIndex = 1;
            this.rtbParty.Text = "";
            this.rtbParty.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbParty_LinkClicked);
            // 
            // tabChatPageLS
            // 
            this.tabChatPageLS.Controls.Add(this.rtbShell);
            this.tabChatPageLS.Location = new System.Drawing.Point(4, 22);
            this.tabChatPageLS.Name = "tabChatPageLS";
            this.tabChatPageLS.Size = new System.Drawing.Size(321, 119);
            this.tabChatPageLS.TabIndex = 4;
            this.tabChatPageLS.Text = "LS";
            this.tabChatPageLS.UseVisualStyleBackColor = true;
            // 
            // rtbShell
            // 
            this.rtbShell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rtbShell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbShell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbShell.ForeColor = System.Drawing.Color.White;
            this.rtbShell.Location = new System.Drawing.Point(0, 0);
            this.rtbShell.Margin = new System.Windows.Forms.Padding(0);
            this.rtbShell.Name = "rtbShell";
            this.rtbShell.ReadOnly = true;
            this.rtbShell.Size = new System.Drawing.Size(321, 119);
            this.rtbShell.TabIndex = 1;
            this.rtbShell.TabStop = false;
            this.rtbShell.Text = "";
            this.rtbShell.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbShell_LinkClicked);
            // 
            // tabChatPageSay
            // 
            this.tabChatPageSay.Controls.Add(this.rtbSay);
            this.tabChatPageSay.Location = new System.Drawing.Point(4, 22);
            this.tabChatPageSay.Name = "tabChatPageSay";
            this.tabChatPageSay.Size = new System.Drawing.Size(321, 119);
            this.tabChatPageSay.TabIndex = 5;
            this.tabChatPageSay.Text = "Say";
            this.tabChatPageSay.UseVisualStyleBackColor = true;
            // 
            // rtbSay
            // 
            this.rtbSay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.rtbSay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSay.ForeColor = System.Drawing.Color.White;
            this.rtbSay.Location = new System.Drawing.Point(0, 0);
            this.rtbSay.Margin = new System.Windows.Forms.Padding(0);
            this.rtbSay.Name = "rtbSay";
            this.rtbSay.ReadOnly = true;
            this.rtbSay.Size = new System.Drawing.Size(321, 119);
            this.rtbSay.TabIndex = 1;
            this.rtbSay.TabStop = false;
            this.rtbSay.Text = "";
            this.rtbSay.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbSay_LinkClicked);
            // 
            // tabDisplayPageStats
            // 
            this.tabDisplayPageStats.BackColor = System.Drawing.Color.Transparent;
            this.tabDisplayPageStats.Controls.Add(this.rtbStats);
            this.tabDisplayPageStats.Location = new System.Drawing.Point(4, 21);
            this.tabDisplayPageStats.Margin = new System.Windows.Forms.Padding(0);
            this.tabDisplayPageStats.Name = "tabDisplayPageStats";
            this.tabDisplayPageStats.Size = new System.Drawing.Size(326, 167);
            this.tabDisplayPageStats.TabIndex = 0;
            this.tabDisplayPageStats.Text = "Stats";
            this.tabDisplayPageStats.UseVisualStyleBackColor = true;
            // 
            // tabDisplayPageInfo
            // 
            this.tabDisplayPageInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabDisplayPageInfo.Controls.Add(this.lblNoCatchAt);
            this.tabDisplayPageInfo.Controls.Add(this.lblNoCatchAtHeader);
            this.tabDisplayPageInfo.Controls.Add(this.lblCaseSpace);
            this.tabDisplayPageInfo.Controls.Add(this.lblCase);
            this.tabDisplayPageInfo.Controls.Add(this.lblFishingSkillup);
            this.tabDisplayPageInfo.Controls.Add(this.lblEarthTimeHeader);
            this.tabDisplayPageInfo.Controls.Add(this.lblEarthTime);
            this.tabDisplayPageInfo.Controls.Add(this.lblVanaTimeHeader);
            this.tabDisplayPageInfo.Controls.Add(this.lblSackSpace);
            this.tabDisplayPageInfo.Controls.Add(this.lblSatchelSpace);
            this.tabDisplayPageInfo.Controls.Add(this.lblInventorySpace);
            this.tabDisplayPageInfo.Controls.Add(this.lblSackHeader);
            this.tabDisplayPageInfo.Controls.Add(this.lblVanaTime);
            this.tabDisplayPageInfo.Controls.Add(this.lblSkill);
            this.tabDisplayPageInfo.Controls.Add(this.lblSatchelHeader);
            this.tabDisplayPageInfo.Controls.Add(this.lblInventoryHeader);
            this.tabDisplayPageInfo.Controls.Add(this.lblSkillHeader);
            this.tabDisplayPageInfo.Controls.Add(this.gbInfo);
            this.tabDisplayPageInfo.Location = new System.Drawing.Point(4, 21);
            this.tabDisplayPageInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tabDisplayPageInfo.Name = "tabDisplayPageInfo";
            this.tabDisplayPageInfo.Size = new System.Drawing.Size(326, 167);
            this.tabDisplayPageInfo.TabIndex = 1;
            this.tabDisplayPageInfo.Text = "Info";
            // 
            // lblNoCatchAt
            // 
            this.lblNoCatchAt.AutoSize = true;
            this.lblNoCatchAt.Location = new System.Drawing.Point(207, 24);
            this.lblNoCatchAt.Name = "lblNoCatchAt";
            this.lblNoCatchAt.Size = new System.Drawing.Size(13, 13);
            this.lblNoCatchAt.TabIndex = 57;
            this.lblNoCatchAt.Text = "--";
            // 
            // lblNoCatchAtHeader
            // 
            this.lblNoCatchAtHeader.AutoSize = true;
            this.lblNoCatchAtHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCatchAtHeader.Location = new System.Drawing.Point(132, 24);
            this.lblNoCatchAtHeader.Name = "lblNoCatchAtHeader";
            this.lblNoCatchAtHeader.Size = new System.Drawing.Size(54, 12);
            this.lblNoCatchAtHeader.TabIndex = 56;
            this.lblNoCatchAtHeader.Text = "No catch:";
            // 
            // lblCaseSpace
            // 
            this.lblCaseSpace.AutoSize = true;
            this.lblCaseSpace.Location = new System.Drawing.Point(200, 42);
            this.lblCaseSpace.Name = "lblCaseSpace";
            this.lblCaseSpace.Size = new System.Drawing.Size(28, 13);
            this.lblCaseSpace.TabIndex = 51;
            this.lblCaseSpace.Text = "-- / --";
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCase.Location = new System.Drawing.Point(132, 43);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(60, 12);
            this.lblCase.TabIndex = 49;
            this.lblCase.Text = "Mog Case:";
            // 
            // lblEarthTimeHeader
            // 
            this.lblEarthTimeHeader.AutoSize = true;
            this.lblEarthTimeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthTimeHeader.Location = new System.Drawing.Point(5, 147);
            this.lblEarthTimeHeader.Name = "lblEarthTimeHeader";
            this.lblEarthTimeHeader.Size = new System.Drawing.Size(36, 12);
            this.lblEarthTimeHeader.TabIndex = 47;
            this.lblEarthTimeHeader.Text = "Earth:";
            // 
            // lblEarthTime
            // 
            this.lblEarthTime.AutoSize = true;
            this.lblEarthTime.Location = new System.Drawing.Point(80, 146);
            this.lblEarthTime.Name = "lblEarthTime";
            this.lblEarthTime.Size = new System.Drawing.Size(13, 13);
            this.lblEarthTime.TabIndex = 46;
            this.lblEarthTime.Text = "--";
            // 
            // lblVanaTimeHeader
            // 
            this.lblVanaTimeHeader.AutoSize = true;
            this.lblVanaTimeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanaTimeHeader.Location = new System.Drawing.Point(5, 129);
            this.lblVanaTimeHeader.Name = "lblVanaTimeHeader";
            this.lblVanaTimeHeader.Size = new System.Drawing.Size(56, 12);
            this.lblVanaTimeHeader.TabIndex = 45;
            this.lblVanaTimeHeader.Text = "Vana\'diel:";
            // 
            // lblSackSpace
            // 
            this.lblSackSpace.AutoSize = true;
            this.lblSackSpace.Location = new System.Drawing.Point(80, 43);
            this.lblSackSpace.Name = "lblSackSpace";
            this.lblSackSpace.Size = new System.Drawing.Size(28, 13);
            this.lblSackSpace.TabIndex = 22;
            this.lblSackSpace.Text = "-- / --";
            // 
            // lblSatchelSpace
            // 
            this.lblSatchelSpace.AutoSize = true;
            this.lblSatchelSpace.Location = new System.Drawing.Point(80, 24);
            this.lblSatchelSpace.Name = "lblSatchelSpace";
            this.lblSatchelSpace.Size = new System.Drawing.Size(28, 13);
            this.lblSatchelSpace.TabIndex = 21;
            this.lblSatchelSpace.Text = "-- / --";
            // 
            // lblInventorySpace
            // 
            this.lblInventorySpace.AutoSize = true;
            this.lblInventorySpace.Location = new System.Drawing.Point(80, 5);
            this.lblInventorySpace.Name = "lblInventorySpace";
            this.lblInventorySpace.Size = new System.Drawing.Size(28, 13);
            this.lblInventorySpace.TabIndex = 20;
            this.lblInventorySpace.Text = "-- / --";
            // 
            // lblSackHeader
            // 
            this.lblSackHeader.AutoSize = true;
            this.lblSackHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSackHeader.Location = new System.Drawing.Point(5, 43);
            this.lblSackHeader.Name = "lblSackHeader";
            this.lblSackHeader.Size = new System.Drawing.Size(59, 12);
            this.lblSackHeader.TabIndex = 19;
            this.lblSackHeader.Text = "Mog Sack:";
            // 
            // lblVanaTime
            // 
            this.lblVanaTime.AutoSize = true;
            this.lblVanaTime.Location = new System.Drawing.Point(80, 128);
            this.lblVanaTime.Name = "lblVanaTime";
            this.lblVanaTime.Size = new System.Drawing.Size(13, 13);
            this.lblVanaTime.TabIndex = 41;
            this.lblVanaTime.Text = "--";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(207, 5);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(13, 13);
            this.lblSkill.TabIndex = 18;
            this.lblSkill.Text = "--";
            // 
            // lblSatchelHeader
            // 
            this.lblSatchelHeader.AutoSize = true;
            this.lblSatchelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatchelHeader.Location = new System.Drawing.Point(5, 24);
            this.lblSatchelHeader.Name = "lblSatchelHeader";
            this.lblSatchelHeader.Size = new System.Drawing.Size(72, 12);
            this.lblSatchelHeader.TabIndex = 18;
            this.lblSatchelHeader.Text = "Mog Satchel:";
            // 
            // lblInventoryHeader
            // 
            this.lblInventoryHeader.AutoSize = true;
            this.lblInventoryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryHeader.Location = new System.Drawing.Point(5, 5);
            this.lblInventoryHeader.Name = "lblInventoryHeader";
            this.lblInventoryHeader.Size = new System.Drawing.Size(58, 12);
            this.lblInventoryHeader.TabIndex = 17;
            this.lblInventoryHeader.Text = "Inventory:";
            // 
            // lblSkillHeader
            // 
            this.lblSkillHeader.AutoSize = true;
            this.lblSkillHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillHeader.Location = new System.Drawing.Point(132, 5);
            this.lblSkillHeader.Name = "lblSkillHeader";
            this.lblSkillHeader.Size = new System.Drawing.Size(71, 12);
            this.lblSkillHeader.TabIndex = 17;
            this.lblSkillHeader.Text = "Fishing Skill:";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblBait);
            this.gbInfo.Controls.Add(this.lblZone);
            this.gbInfo.Controls.Add(this.lblZoneHeader);
            this.gbInfo.Controls.Add(this.lblRod);
            this.gbInfo.Controls.Add(this.lblRodHeader);
            this.gbInfo.Controls.Add(this.lblBaitHeader);
            this.gbInfo.Location = new System.Drawing.Point(4, 57);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gbInfo.Size = new System.Drawing.Size(267, 67);
            this.gbInfo.TabIndex = 17;
            this.gbInfo.TabStop = false;
            // 
            // tabDisplayPageOptions
            // 
            this.tabDisplayPageOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tabDisplayPageOptions.Controls.Add(this.tabOptions);
            this.tabDisplayPageOptions.Location = new System.Drawing.Point(4, 21);
            this.tabDisplayPageOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tabDisplayPageOptions.Name = "tabDisplayPageOptions";
            this.tabDisplayPageOptions.Size = new System.Drawing.Size(326, 167);
            this.tabDisplayPageOptions.TabIndex = 2;
            this.tabDisplayPageOptions.Text = "Options";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tabOptionsPageForm);
            this.tabOptions.Controls.Add(this.tabOptionsPageFight);
            this.tabOptions.Controls.Add(this.tabOptionsPageAdvanced);
            this.tabOptions.Controls.Add(this.tabNavigation);
            this.tabOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOptions.Location = new System.Drawing.Point(0, 0);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(326, 167);
            this.tabOptions.TabIndex = 38;
            // 
            // tabOptionsPageForm
            // 
            this.tabOptionsPageForm.BackColor = System.Drawing.SystemColors.Control;
            this.tabOptionsPageForm.Controls.Add(this.cbSneakFishing);
            this.tabOptionsPageForm.Controls.Add(this.numMaxCatch);
            this.tabOptionsPageForm.Controls.Add(this.cbEnableItemizerItemTools);
            this.tabOptionsPageForm.Controls.Add(this.cbMaxCatch);
            this.tabOptionsPageForm.Controls.Add(this.cbTellDetect);
            this.tabOptionsPageForm.Controls.Add(this.gbGeneralFishing);
            this.tabOptionsPageForm.Controls.Add(this.cbStopSound);
            this.tabOptionsPageForm.Controls.Add(this.btnSettingsSave);
            this.tabOptionsPageForm.Controls.Add(this.btnSettingsReset);
            this.tabOptionsPageForm.Controls.Add(this.cbAlwaysOnTop);
            this.tabOptionsPageForm.Location = new System.Drawing.Point(4, 21);
            this.tabOptionsPageForm.Name = "tabOptionsPageForm";
            this.tabOptionsPageForm.Size = new System.Drawing.Size(318, 142);
            this.tabOptionsPageForm.TabIndex = 3;
            this.tabOptionsPageForm.Text = "General";
            // 
            // cbSneakFishing
            // 
            this.cbSneakFishing.AutoSize = true;
            this.cbSneakFishing.Location = new System.Drawing.Point(145, 25);
            this.cbSneakFishing.Name = "cbSneakFishing";
            this.cbSneakFishing.Size = new System.Drawing.Size(110, 17);
            this.cbSneakFishing.TabIndex = 58;
            this.cbSneakFishing.Text = "Use Sneak fishing";
            this.cbSneakFishing.UseVisualStyleBackColor = true;
            // 
            // numMaxCatch
            // 
            this.numMaxCatch.Location = new System.Drawing.Point(98, 45);
            this.numMaxCatch.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numMaxCatch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxCatch.Name = "numMaxCatch";
            this.numMaxCatch.Size = new System.Drawing.Size(35, 18);
            this.numMaxCatch.TabIndex = 57;
            this.numMaxCatch.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // cbEnableItemizerItemTools
            // 
            this.cbEnableItemizerItemTools.AutoSize = true;
            this.cbEnableItemizerItemTools.Location = new System.Drawing.Point(145, 46);
            this.cbEnableItemizerItemTools.Name = "cbEnableItemizerItemTools";
            this.cbEnableItemizerItemTools.Size = new System.Drawing.Size(130, 17);
            this.cbEnableItemizerItemTools.TabIndex = 49;
            this.cbEnableItemizerItemTools.Text = "Use Itemizer/ItemTools";
            this.cbEnableItemizerItemTools.UseVisualStyleBackColor = true;
            this.cbEnableItemizerItemTools.CheckedChanged += new System.EventHandler(this.cbEnableItemizerItemTools_CheckedChanged);
            // 
            // cbMaxCatch
            // 
            this.cbMaxCatch.AutoSize = true;
            this.cbMaxCatch.Location = new System.Drawing.Point(7, 46);
            this.cbMaxCatch.Name = "cbMaxCatch";
            this.cbMaxCatch.Size = new System.Drawing.Size(88, 17);
            this.cbMaxCatch.TabIndex = 56;
            this.cbMaxCatch.Text = "Limit Catches";
            this.cbMaxCatch.UseVisualStyleBackColor = true;
            // 
            // cbTellDetect
            // 
            this.cbTellDetect.AutoSize = true;
            this.cbTellDetect.Checked = true;
            this.cbTellDetect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTellDetect.Location = new System.Drawing.Point(7, 25);
            this.cbTellDetect.Name = "cbTellDetect";
            this.cbTellDetect.Size = new System.Drawing.Size(89, 17);
            this.cbTellDetect.TabIndex = 48;
            this.cbTellDetect.Text = "Tell Detection";
            this.cbTellDetect.UseVisualStyleBackColor = true;
            // 
            // gbGeneralFishing
            // 
            this.gbGeneralFishing.Controls.Add(this.lblCastWait);
            this.gbGeneralFishing.Controls.Add(this.numMaxNoCatch);
            this.gbGeneralFishing.Controls.Add(this.btnCastReset);
            this.gbGeneralFishing.Controls.Add(this.numCastIntervalLow);
            this.gbGeneralFishing.Controls.Add(this.lblMaxNoCatch);
            this.gbGeneralFishing.Controls.Add(this.numCastIntervalHigh);
            this.gbGeneralFishing.Controls.Add(this.trackOpacity);
            this.gbGeneralFishing.Location = new System.Drawing.Point(3, 61);
            this.gbGeneralFishing.Name = "gbGeneralFishing";
            this.gbGeneralFishing.Size = new System.Drawing.Size(216, 52);
            this.gbGeneralFishing.TabIndex = 47;
            this.gbGeneralFishing.TabStop = false;
            // 
            // lblCastWait
            // 
            this.lblCastWait.AutoSize = true;
            this.lblCastWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblCastWait.Location = new System.Drawing.Point(3, 11);
            this.lblCastWait.Margin = new System.Windows.Forms.Padding(0);
            this.lblCastWait.Name = "lblCastWait";
            this.lblCastWait.Size = new System.Drawing.Size(78, 13);
            this.lblCastWait.TabIndex = 42;
            this.lblCastWait.Text = "Cast wait time: ";
            this.lblCastWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMaxNoCatch
            // 
            this.numMaxNoCatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numMaxNoCatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMaxNoCatch.Location = new System.Drawing.Point(83, 31);
            this.numMaxNoCatch.Margin = new System.Windows.Forms.Padding(0);
            this.numMaxNoCatch.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numMaxNoCatch.Name = "numMaxNoCatch";
            this.numMaxNoCatch.Size = new System.Drawing.Size(38, 18);
            this.numMaxNoCatch.TabIndex = 43;
            this.numMaxNoCatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxNoCatch.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnCastReset
            // 
            this.btnCastReset.Location = new System.Drawing.Point(164, 8);
            this.btnCastReset.Name = "btnCastReset";
            this.btnCastReset.Size = new System.Drawing.Size(47, 20);
            this.btnCastReset.TabIndex = 45;
            this.btnCastReset.Text = "Reset";
            this.btnCastReset.UseVisualStyleBackColor = true;
            this.btnCastReset.Click += new System.EventHandler(this.btnCastReset_Click);
            // 
            // numCastIntervalLow
            // 
            this.numCastIntervalLow.DecimalPlaces = 1;
            this.numCastIntervalLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCastIntervalLow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCastIntervalLow.Location = new System.Drawing.Point(83, 9);
            this.numCastIntervalLow.Margin = new System.Windows.Forms.Padding(0);
            this.numCastIntervalLow.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numCastIntervalLow.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCastIntervalLow.Name = "numCastIntervalLow";
            this.numCastIntervalLow.Size = new System.Drawing.Size(38, 18);
            this.numCastIntervalLow.TabIndex = 40;
            this.numCastIntervalLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCastIntervalLow.Value = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.numCastIntervalLow.ValueChanged += new System.EventHandler(this.numCastIntervalLow_ValueChanged);
            // 
            // lblMaxNoCatch
            // 
            this.lblMaxNoCatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaxNoCatch.AutoSize = true;
            this.lblMaxNoCatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNoCatch.Location = new System.Drawing.Point(3, 33);
            this.lblMaxNoCatch.Margin = new System.Windows.Forms.Padding(0);
            this.lblMaxNoCatch.Name = "lblMaxNoCatch";
            this.lblMaxNoCatch.Size = new System.Drawing.Size(73, 13);
            this.lblMaxNoCatch.TabIndex = 44;
            this.lblMaxNoCatch.Text = "Max no catch:";
            this.lblMaxNoCatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numCastIntervalHigh
            // 
            this.numCastIntervalHigh.DecimalPlaces = 1;
            this.numCastIntervalHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCastIntervalHigh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCastIntervalHigh.Location = new System.Drawing.Point(122, 9);
            this.numCastIntervalHigh.Margin = new System.Windows.Forms.Padding(0);
            this.numCastIntervalHigh.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numCastIntervalHigh.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCastIntervalHigh.Name = "numCastIntervalHigh";
            this.numCastIntervalHigh.Size = new System.Drawing.Size(38, 18);
            this.numCastIntervalHigh.TabIndex = 41;
            this.numCastIntervalHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCastIntervalHigh.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.numCastIntervalHigh.ValueChanged += new System.EventHandler(this.numCastIntervalHigh_ValueChanged);
            // 
            // trackOpacity
            // 
            this.trackOpacity.AutoSize = false;
            this.trackOpacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackOpacity.LargeChange = 1;
            this.trackOpacity.Location = new System.Drawing.Point(133, 29);
            this.trackOpacity.Margin = new System.Windows.Forms.Padding(0);
            this.trackOpacity.Minimum = 1;
            this.trackOpacity.Name = "trackOpacity";
            this.trackOpacity.Size = new System.Drawing.Size(78, 21);
            this.trackOpacity.TabIndex = 33;
            this.trackOpacity.Value = 10;
            this.trackOpacity.Scroll += new System.EventHandler(this.trackOpacity_Scroll);
            // 
            // cbStopSound
            // 
            this.cbStopSound.AutoSize = true;
            this.cbStopSound.Location = new System.Drawing.Point(145, 4);
            this.cbStopSound.Name = "cbStopSound";
            this.cbStopSound.Size = new System.Drawing.Size(106, 17);
            this.cbStopSound.TabIndex = 46;
            this.cbStopSound.Text = "Sounds on errors";
            this.cbStopSound.UseVisualStyleBackColor = true;
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Location = new System.Drawing.Point(7, 116);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(92, 22);
            this.btnSettingsSave.TabIndex = 32;
            this.btnSettingsSave.Text = "Save Settings";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // btnSettingsReset
            // 
            this.btnSettingsReset.Location = new System.Drawing.Point(105, 116);
            this.btnSettingsReset.Name = "btnSettingsReset";
            this.btnSettingsReset.Size = new System.Drawing.Size(92, 22);
            this.btnSettingsReset.TabIndex = 31;
            this.btnSettingsReset.Text = "Reset Settings";
            this.btnSettingsReset.UseVisualStyleBackColor = true;
            this.btnSettingsReset.Click += new System.EventHandler(this.btnSettingsReset_Click);
            // 
            // cbAlwaysOnTop
            // 
            this.cbAlwaysOnTop.AutoSize = true;
            this.cbAlwaysOnTop.Checked = true;
            this.cbAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlwaysOnTop.Location = new System.Drawing.Point(7, 4);
            this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            this.cbAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.cbAlwaysOnTop.TabIndex = 30;
            this.cbAlwaysOnTop.Text = "Always on top";
            this.cbAlwaysOnTop.UseVisualStyleBackColor = true;
            this.cbAlwaysOnTop.CheckedChanged += new System.EventHandler(this.cbAlwaysOnTop_CheckedChanged);
            // 
            // tabOptionsPageFight
            // 
            this.tabOptionsPageFight.BackColor = System.Drawing.SystemColors.Control;
            this.tabOptionsPageFight.Controls.Add(this.cbFishHP);
            this.tabOptionsPageFight.Controls.Add(this.numReactionHigh);
            this.tabOptionsPageFight.Controls.Add(this.numReactionLow);
            this.tabOptionsPageFight.Controls.Add(this.cbReaction);
            this.tabOptionsPageFight.Controls.Add(this.numFakeLargeIntervalLow);
            this.tabOptionsPageFight.Controls.Add(this.cbReleaseSmall);
            this.tabOptionsPageFight.Controls.Add(this.numFakeLargeIntervalHigh);
            this.tabOptionsPageFight.Controls.Add(this.numFakeSmallIntervalLow);
            this.tabOptionsPageFight.Controls.Add(this.cbReleaseLarge);
            this.tabOptionsPageFight.Controls.Add(this.cbIgnoreLargeFish);
            this.tabOptionsPageFight.Controls.Add(this.numFakeSmallIntervalHigh);
            this.tabOptionsPageFight.Controls.Add(this.cbIgnoreSmallFish);
            this.tabOptionsPageFight.Controls.Add(this.cbIgnoreItem);
            this.tabOptionsPageFight.Controls.Add(this.cbIgnoreMonster);
            this.tabOptionsPageFight.Controls.Add(this.lblKillSeconds);
            this.tabOptionsPageFight.Controls.Add(this.numQuickKill);
            this.tabOptionsPageFight.Controls.Add(this.cbQuickKill);
            this.tabOptionsPageFight.Controls.Add(this.cbAutoKill);
            this.tabOptionsPageFight.Controls.Add(this.cbExtend);
            this.tabOptionsPageFight.Location = new System.Drawing.Point(4, 21);
            this.tabOptionsPageFight.Name = "tabOptionsPageFight";
            this.tabOptionsPageFight.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptionsPageFight.Size = new System.Drawing.Size(318, 142);
            this.tabOptionsPageFight.TabIndex = 2;
            this.tabOptionsPageFight.Text = "Fight";
            // 
            // cbFishHP
            // 
            this.cbFishHP.AutoSize = true;
            this.cbFishHP.Location = new System.Drawing.Point(7, 4);
            this.cbFishHP.Name = "cbFishHP";
            this.cbFishHP.Size = new System.Drawing.Size(114, 17);
            this.cbFishHP.TabIndex = 54;
            this.cbFishHP.Text = "Show fish HP[time]";
            this.cbFishHP.UseVisualStyleBackColor = true;
            // 
            // numReactionHigh
            // 
            this.numReactionHigh.DecimalPlaces = 1;
            this.numReactionHigh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numReactionHigh.Location = new System.Drawing.Point(98, 104);
            this.numReactionHigh.Margin = new System.Windows.Forms.Padding(0);
            this.numReactionHigh.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numReactionHigh.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numReactionHigh.Name = "numReactionHigh";
            this.numReactionHigh.Size = new System.Drawing.Size(35, 18);
            this.numReactionHigh.TabIndex = 11;
            this.numReactionHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numReactionHigh.Value = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.numReactionHigh.ValueChanged += new System.EventHandler(this.numReactionHigh_ValueChanged);
            // 
            // numReactionLow
            // 
            this.numReactionLow.DecimalPlaces = 1;
            this.numReactionLow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numReactionLow.Location = new System.Drawing.Point(62, 104);
            this.numReactionLow.Margin = new System.Windows.Forms.Padding(0);
            this.numReactionLow.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            65536});
            this.numReactionLow.Name = "numReactionLow";
            this.numReactionLow.Size = new System.Drawing.Size(35, 18);
            this.numReactionLow.TabIndex = 10;
            this.numReactionLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numReactionLow.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numReactionLow.ValueChanged += new System.EventHandler(this.numReactionLow_ValueChanged);
            // 
            // cbReaction
            // 
            this.cbReaction.AutoSize = true;
            this.cbReaction.Location = new System.Drawing.Point(7, 104);
            this.cbReaction.Name = "cbReaction";
            this.cbReaction.Size = new System.Drawing.Size(56, 17);
            this.cbReaction.TabIndex = 49;
            this.cbReaction.Text = "React:";
            this.cbReaction.UseVisualStyleBackColor = true;
            // 
            // numFakeLargeIntervalLow
            // 
            this.numFakeLargeIntervalLow.Location = new System.Drawing.Point(203, 83);
            this.numFakeLargeIntervalLow.Margin = new System.Windows.Forms.Padding(0);
            this.numFakeLargeIntervalLow.Name = "numFakeLargeIntervalLow";
            this.numFakeLargeIntervalLow.Size = new System.Drawing.Size(35, 18);
            this.numFakeLargeIntervalLow.TabIndex = 39;
            this.numFakeLargeIntervalLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFakeLargeIntervalLow.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numFakeLargeIntervalLow.ValueChanged += new System.EventHandler(this.numFakeLargeIntervalLow_ValueChanged);
            // 
            // cbReleaseSmall
            // 
            this.cbReleaseSmall.AutoSize = true;
            this.cbReleaseSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReleaseSmall.Location = new System.Drawing.Point(7, 84);
            this.cbReleaseSmall.Name = "cbReleaseSmall";
            this.cbReleaseSmall.Size = new System.Drawing.Size(52, 17);
            this.cbReleaseSmall.TabIndex = 41;
            this.cbReleaseSmall.Text = "Fake!";
            this.cbReleaseSmall.UseVisualStyleBackColor = true;
            // 
            // numFakeLargeIntervalHigh
            // 
            this.numFakeLargeIntervalHigh.Location = new System.Drawing.Point(239, 83);
            this.numFakeLargeIntervalHigh.Margin = new System.Windows.Forms.Padding(0);
            this.numFakeLargeIntervalHigh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFakeLargeIntervalHigh.Name = "numFakeLargeIntervalHigh";
            this.numFakeLargeIntervalHigh.Size = new System.Drawing.Size(35, 18);
            this.numFakeLargeIntervalHigh.TabIndex = 40;
            this.numFakeLargeIntervalHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFakeLargeIntervalHigh.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numFakeLargeIntervalHigh.ValueChanged += new System.EventHandler(this.numFakeLargeIntervalHigh_ValueChanged);
            // 
            // numFakeSmallIntervalLow
            // 
            this.numFakeSmallIntervalLow.Location = new System.Drawing.Point(62, 83);
            this.numFakeSmallIntervalLow.Margin = new System.Windows.Forms.Padding(0);
            this.numFakeSmallIntervalLow.Name = "numFakeSmallIntervalLow";
            this.numFakeSmallIntervalLow.Size = new System.Drawing.Size(35, 18);
            this.numFakeSmallIntervalLow.TabIndex = 15;
            this.numFakeSmallIntervalLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFakeSmallIntervalLow.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numFakeSmallIntervalLow.ValueChanged += new System.EventHandler(this.numFakeSmallIntervalLow_ValueChanged);
            // 
            // cbReleaseLarge
            // 
            this.cbReleaseLarge.AutoSize = true;
            this.cbReleaseLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReleaseLarge.Location = new System.Drawing.Point(142, 84);
            this.cbReleaseLarge.Name = "cbReleaseLarge";
            this.cbReleaseLarge.Size = new System.Drawing.Size(58, 17);
            this.cbReleaseLarge.TabIndex = 42;
            this.cbReleaseLarge.Text = "Fake!!!";
            this.cbReleaseLarge.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreLargeFish
            // 
            this.cbIgnoreLargeFish.AutoSize = true;
            this.cbIgnoreLargeFish.Location = new System.Drawing.Point(142, 64);
            this.cbIgnoreLargeFish.Name = "cbIgnoreLargeFish";
            this.cbIgnoreLargeFish.Size = new System.Drawing.Size(108, 17);
            this.cbIgnoreLargeFish.TabIndex = 53;
            this.cbIgnoreLargeFish.Text = "Ignore Large Fish";
            this.cbIgnoreLargeFish.UseVisualStyleBackColor = true;
            // 
            // numFakeSmallIntervalHigh
            // 
            this.numFakeSmallIntervalHigh.Location = new System.Drawing.Point(98, 83);
            this.numFakeSmallIntervalHigh.Margin = new System.Windows.Forms.Padding(0);
            this.numFakeSmallIntervalHigh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFakeSmallIntervalHigh.Name = "numFakeSmallIntervalHigh";
            this.numFakeSmallIntervalHigh.Size = new System.Drawing.Size(35, 18);
            this.numFakeSmallIntervalHigh.TabIndex = 16;
            this.numFakeSmallIntervalHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFakeSmallIntervalHigh.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numFakeSmallIntervalHigh.ValueChanged += new System.EventHandler(this.numFakeSmallIntervalHigh_ValueChanged);
            // 
            // cbIgnoreSmallFish
            // 
            this.cbIgnoreSmallFish.AutoSize = true;
            this.cbIgnoreSmallFish.Location = new System.Drawing.Point(7, 64);
            this.cbIgnoreSmallFish.Name = "cbIgnoreSmallFish";
            this.cbIgnoreSmallFish.Size = new System.Drawing.Size(106, 17);
            this.cbIgnoreSmallFish.TabIndex = 52;
            this.cbIgnoreSmallFish.Text = "Ignore Small Fish";
            this.cbIgnoreSmallFish.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreItem
            // 
            this.cbIgnoreItem.AutoSize = true;
            this.cbIgnoreItem.Checked = true;
            this.cbIgnoreItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreItem.Location = new System.Drawing.Point(142, 44);
            this.cbIgnoreItem.Name = "cbIgnoreItem";
            this.cbIgnoreItem.Size = new System.Drawing.Size(84, 17);
            this.cbIgnoreItem.TabIndex = 50;
            this.cbIgnoreItem.Text = "Ignore Items";
            this.cbIgnoreItem.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreMonster
            // 
            this.cbIgnoreMonster.AutoSize = true;
            this.cbIgnoreMonster.Checked = true;
            this.cbIgnoreMonster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreMonster.Location = new System.Drawing.Point(7, 44);
            this.cbIgnoreMonster.Name = "cbIgnoreMonster";
            this.cbIgnoreMonster.Size = new System.Drawing.Size(102, 17);
            this.cbIgnoreMonster.TabIndex = 51;
            this.cbIgnoreMonster.Text = "Ignore Monsters";
            this.cbIgnoreMonster.UseVisualStyleBackColor = true;
            // 
            // lblKillSeconds
            // 
            this.lblKillSeconds.AutoSize = true;
            this.lblKillSeconds.Location = new System.Drawing.Point(246, 25);
            this.lblKillSeconds.Name = "lblKillSeconds";
            this.lblKillSeconds.Size = new System.Drawing.Size(46, 13);
            this.lblKillSeconds.TabIndex = 48;
            this.lblKillSeconds.Text = "seconds";
            // 
            // numQuickKill
            // 
            this.numQuickKill.Location = new System.Drawing.Point(205, 23);
            this.numQuickKill.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numQuickKill.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numQuickKill.Name = "numQuickKill";
            this.numQuickKill.Size = new System.Drawing.Size(35, 18);
            this.numQuickKill.TabIndex = 45;
            this.numQuickKill.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // cbQuickKill
            // 
            this.cbQuickKill.AutoSize = true;
            this.cbQuickKill.Location = new System.Drawing.Point(142, 24);
            this.cbQuickKill.Name = "cbQuickKill";
            this.cbQuickKill.Size = new System.Drawing.Size(63, 17);
            this.cbQuickKill.TabIndex = 44;
            this.cbQuickKill.Text = "Kill after";
            this.cbQuickKill.UseVisualStyleBackColor = true;
            // 
            // cbAutoKill
            // 
            this.cbAutoKill.AutoSize = true;
            this.cbAutoKill.Checked = true;
            this.cbAutoKill.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoKill.Location = new System.Drawing.Point(142, 4);
            this.cbAutoKill.Name = "cbAutoKill";
            this.cbAutoKill.Size = new System.Drawing.Size(110, 17);
            this.cbAutoKill.TabIndex = 43;
            this.cbAutoKill.Text = "Kill fish at warning";
            this.cbAutoKill.UseVisualStyleBackColor = true;
            // 
            // cbExtend
            // 
            this.cbExtend.AutoSize = true;
            this.cbExtend.Location = new System.Drawing.Point(7, 24);
            this.cbExtend.Name = "cbExtend";
            this.cbExtend.Size = new System.Drawing.Size(96, 17);
            this.cbExtend.TabIndex = 42;
            this.cbExtend.Text = "Extend timeout";
            this.cbExtend.UseVisualStyleBackColor = true;
            // 
            // tabOptionsPageAdvanced
            // 
            this.tabOptionsPageAdvanced.BackColor = System.Drawing.SystemColors.Control;
            this.tabOptionsPageAdvanced.Controls.Add(this.cbRestartatMidnight);
            this.tabOptionsPageAdvanced.Controls.Add(this.gbLogging);
            this.tabOptionsPageAdvanced.Controls.Add(this.gbGMDetect);
            this.tabOptionsPageAdvanced.Controls.Add(this.groupBox1);
            this.tabOptionsPageAdvanced.Location = new System.Drawing.Point(4, 21);
            this.tabOptionsPageAdvanced.Name = "tabOptionsPageAdvanced";
            this.tabOptionsPageAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptionsPageAdvanced.Size = new System.Drawing.Size(318, 142);
            this.tabOptionsPageAdvanced.TabIndex = 4;
            this.tabOptionsPageAdvanced.Text = "Other";
            // 
            // gbLogging
            // 
            this.gbLogging.Controls.Add(this.cbLogToFile);
            this.gbLogging.Location = new System.Drawing.Point(127, 93);
            this.gbLogging.Name = "gbLogging";
            this.gbLogging.Size = new System.Drawing.Size(130, 42);
            this.gbLogging.TabIndex = 2;
            this.gbLogging.TabStop = false;
            this.gbLogging.Text = "Logging";
            // 
            // gbGMDetect
            // 
            this.gbGMDetect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbGMDetect.Controls.Add(this.cbGMExecuteCommand);
            this.gbGMDetect.Controls.Add(this.cbGMdetectAutostop);
            this.gbGMDetect.Location = new System.Drawing.Point(127, 30);
            this.gbGMDetect.Name = "gbGMDetect";
            this.gbGMDetect.Size = new System.Drawing.Size(130, 57);
            this.gbGMDetect.TabIndex = 1;
            this.gbGMDetect.TabStop = false;
            this.gbGMDetect.Text = "GM Detection";
            // 
            // cbGMdetectAutostop
            // 
            this.cbGMdetectAutostop.AutoSize = true;
            this.cbGMdetectAutostop.Checked = true;
            this.cbGMdetectAutostop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGMdetectAutostop.Location = new System.Drawing.Point(10, 17);
            this.cbGMdetectAutostop.Name = "cbGMdetectAutostop";
            this.cbGMdetectAutostop.Size = new System.Drawing.Size(84, 17);
            this.cbGMdetectAutostop.TabIndex = 10;
            this.cbGMdetectAutostop.Text = "Stop Fishing";
            this.cbGMdetectAutostop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tbFullactionOther);
            this.groupBox1.Controls.Add(this.rbFullactionOther);
            this.groupBox1.Controls.Add(this.rbFullactionWarp);
            this.groupBox1.Controls.Add(this.rbFullactionLogout);
            this.groupBox1.Controls.Add(this.rbFullactionNone);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "On Full Inventory";
            // 
            // tbFullactionOther
            // 
            this.tbFullactionOther.Location = new System.Drawing.Point(8, 98);
            this.tbFullactionOther.Name = "tbFullactionOther";
            this.tbFullactionOther.Size = new System.Drawing.Size(97, 18);
            this.tbFullactionOther.TabIndex = 4;
            this.toolTip.SetToolTip(this.tbFullactionOther, "Command to execute when inventory is full. This command is also executed when \"Ex" +
        "ecute Command\" is enabled in the GM detection section. Do not use itemtools/item" +
        "izer commands here!");
            // 
            // rbFullactionOther
            // 
            this.rbFullactionOther.AutoSize = true;
            this.rbFullactionOther.Location = new System.Drawing.Point(11, 73);
            this.rbFullactionOther.Name = "rbFullactionOther";
            this.rbFullactionOther.Size = new System.Drawing.Size(51, 17);
            this.rbFullactionOther.TabIndex = 3;
            this.rbFullactionOther.Text = "Other";
            this.rbFullactionOther.UseVisualStyleBackColor = true;
            this.rbFullactionOther.CheckedChanged += new System.EventHandler(this.rbFullactionOther_CheckedChanged);
            // 
            // rbFullactionWarp
            // 
            this.rbFullactionWarp.AutoSize = true;
            this.rbFullactionWarp.Location = new System.Drawing.Point(11, 55);
            this.rbFullactionWarp.Name = "rbFullactionWarp";
            this.rbFullactionWarp.Size = new System.Drawing.Size(49, 17);
            this.rbFullactionWarp.TabIndex = 2;
            this.rbFullactionWarp.Text = "Warp";
            this.rbFullactionWarp.UseVisualStyleBackColor = true;
            // 
            // rbFullactionLogout
            // 
            this.rbFullactionLogout.AutoSize = true;
            this.rbFullactionLogout.Location = new System.Drawing.Point(11, 37);
            this.rbFullactionLogout.Name = "rbFullactionLogout";
            this.rbFullactionLogout.Size = new System.Drawing.Size(58, 17);
            this.rbFullactionLogout.TabIndex = 1;
            this.rbFullactionLogout.Text = "Logout";
            this.rbFullactionLogout.UseVisualStyleBackColor = true;
            // 
            // rbFullactionNone
            // 
            this.rbFullactionNone.AutoSize = true;
            this.rbFullactionNone.Checked = true;
            this.rbFullactionNone.Location = new System.Drawing.Point(11, 19);
            this.rbFullactionNone.Name = "rbFullactionNone";
            this.rbFullactionNone.Size = new System.Drawing.Size(61, 17);
            this.rbFullactionNone.TabIndex = 0;
            this.rbFullactionNone.TabStop = true;
            this.rbFullactionNone.Text = "Nothing";
            this.rbFullactionNone.UseVisualStyleBackColor = true;
            // 
            // tabNavigation
            // 
            this.tabNavigation.BackColor = System.Drawing.SystemColors.Control;
            this.tabNavigation.Controls.Add(this.tabControl1);
            this.tabNavigation.Location = new System.Drawing.Point(4, 21);
            this.tabNavigation.Name = "tabNavigation";
            this.tabNavigation.Size = new System.Drawing.Size(318, 142);
            this.tabNavigation.TabIndex = 5;
            this.tabNavigation.Text = "Nav";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNavSetup);
            this.tabControl1.Controls.Add(this.tabNavEvents);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 139);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNavSetup
            // 
            this.tabNavSetup.BackColor = System.Drawing.SystemColors.Control;
            this.tabNavSetup.Controls.Add(this.btnCurrentCord);
            this.tabNavSetup.Controls.Add(this.cbNavReversePath);
            this.tabNavSetup.Controls.Add(this.btnNavRecordingSave);
            this.tabNavSetup.Controls.Add(this.btnNavRecordingStop);
            this.tabNavSetup.Controls.Add(this.btnRecordNav);
            this.tabNavSetup.Controls.Add(this.btnNavLoadFile);
            this.tabNavSetup.Controls.Add(this.btnStartNav);
            this.tabNavSetup.Location = new System.Drawing.Point(4, 21);
            this.tabNavSetup.Name = "tabNavSetup";
            this.tabNavSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabNavSetup.Size = new System.Drawing.Size(301, 114);
            this.tabNavSetup.TabIndex = 0;
            this.tabNavSetup.Text = "Setup";
            // 
            // btnCurrentCord
            // 
            this.btnCurrentCord.Location = new System.Drawing.Point(6, 85);
            this.btnCurrentCord.Name = "btnCurrentCord";
            this.btnCurrentCord.Size = new System.Drawing.Size(90, 23);
            this.btnCurrentCord.TabIndex = 13;
            this.btnCurrentCord.Text = "Current Cord";
            this.btnCurrentCord.UseVisualStyleBackColor = true;
            this.btnCurrentCord.Click += new System.EventHandler(this.btnCurrentCord_Click);
            // 
            // btnNavRecordingSave
            // 
            this.btnNavRecordingSave.Location = new System.Drawing.Point(102, 45);
            this.btnNavRecordingSave.Name = "btnNavRecordingSave";
            this.btnNavRecordingSave.Size = new System.Drawing.Size(90, 23);
            this.btnNavRecordingSave.TabIndex = 11;
            this.btnNavRecordingSave.Text = "Save Path";
            this.btnNavRecordingSave.UseVisualStyleBackColor = true;
            this.btnNavRecordingSave.Click += new System.EventHandler(this.btnNavRecordingSave_Click);
            // 
            // btnNavRecordingStop
            // 
            this.btnNavRecordingStop.Location = new System.Drawing.Point(102, 7);
            this.btnNavRecordingStop.Name = "btnNavRecordingStop";
            this.btnNavRecordingStop.Size = new System.Drawing.Size(90, 23);
            this.btnNavRecordingStop.TabIndex = 10;
            this.btnNavRecordingStop.Text = "Stop Path";
            this.btnNavRecordingStop.UseVisualStyleBackColor = true;
            this.btnNavRecordingStop.Click += new System.EventHandler(this.btnNavRecordingStop_Click);
            // 
            // btnRecordNav
            // 
            this.btnRecordNav.Location = new System.Drawing.Point(198, 45);
            this.btnRecordNav.Name = "btnRecordNav";
            this.btnRecordNav.Size = new System.Drawing.Size(90, 23);
            this.btnRecordNav.TabIndex = 9;
            this.btnRecordNav.Text = "Record Path";
            this.btnRecordNav.UseVisualStyleBackColor = true;
            this.btnRecordNav.Click += new System.EventHandler(this.btnRecordNav_Click);
            // 
            // btnNavLoadFile
            // 
            this.btnNavLoadFile.Location = new System.Drawing.Point(6, 45);
            this.btnNavLoadFile.Name = "btnNavLoadFile";
            this.btnNavLoadFile.Size = new System.Drawing.Size(90, 23);
            this.btnNavLoadFile.TabIndex = 8;
            this.btnNavLoadFile.Text = "Load Path File";
            this.btnNavLoadFile.UseVisualStyleBackColor = true;
            this.btnNavLoadFile.Click += new System.EventHandler(this.btnNavLoadFile_Click);
            // 
            // btnStartNav
            // 
            this.btnStartNav.Location = new System.Drawing.Point(6, 6);
            this.btnStartNav.Name = "btnStartNav";
            this.btnStartNav.Size = new System.Drawing.Size(90, 24);
            this.btnStartNav.TabIndex = 7;
            this.btnStartNav.Text = "Play Path";
            this.btnStartNav.UseVisualStyleBackColor = true;
            this.btnStartNav.Click += new System.EventHandler(this.btnStartNav_Click);
            // 
            // tabNavEvents
            // 
            this.tabNavEvents.BackColor = System.Drawing.SystemColors.Control;
            this.tabNavEvents.Controls.Add(this.cbFatigueFullInventory);
            this.tabNavEvents.Controls.Add(this.numNavMaxRecastDelay);
            this.tabNavEvents.Controls.Add(this.label2);
            this.tabNavEvents.Controls.Add(this.label1);
            this.tabNavEvents.Controls.Add(this.numNavMaxNoCatch);
            this.tabNavEvents.Controls.Add(this.btnFatiguePath);
            this.tabNavEvents.Controls.Add(this.cbNavEnableFatiguePath);
            this.tabNavEvents.Location = new System.Drawing.Point(4, 21);
            this.tabNavEvents.Name = "tabNavEvents";
            this.tabNavEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabNavEvents.Size = new System.Drawing.Size(301, 114);
            this.tabNavEvents.TabIndex = 1;
            this.tabNavEvents.Text = "Events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Recast Delay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max \"No Catch\"";
            // 
            // cbNavEnableFatiguePath
            // 
            this.cbNavEnableFatiguePath.AutoSize = true;
            this.cbNavEnableFatiguePath.Location = new System.Drawing.Point(158, 6);
            this.cbNavEnableFatiguePath.Name = "cbNavEnableFatiguePath";
            this.cbNavEnableFatiguePath.Size = new System.Drawing.Size(134, 17);
            this.cbNavEnableFatiguePath.TabIndex = 0;
            this.cbNavEnableFatiguePath.Text = "Enable Fatigue System";
            this.cbNavEnableFatiguePath.UseVisualStyleBackColor = true;
            this.cbNavEnableFatiguePath.CheckedChanged += new System.EventHandler(this.cboxNavEnableFatiguePath_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVanaDay,
            this.lblVanaClock,
            this.lblStatusTitle,
            this.lblStatus,
            this.lblHP,
            this.progressBarST});
            this.statusStripMain.Location = new System.Drawing.Point(0, 192);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(478, 25);
            this.statusStripMain.TabIndex = 35;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lblVanaDay
            // 
            this.lblVanaDay.AutoSize = false;
            this.lblVanaDay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblVanaDay.Font = new System.Drawing.Font("Segoe UI", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVanaDay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblVanaDay.Name = "lblVanaDay";
            this.lblVanaDay.Size = new System.Drawing.Size(18, 20);
            this.lblVanaDay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // lblVanaClock
            // 
            this.lblVanaClock.AutoSize = false;
            this.lblVanaClock.Name = "lblVanaClock";
            this.lblVanaClock.Size = new System.Drawing.Size(80, 20);
            this.lblVanaClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = false;
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(48, 20);
            this.lblStatusTitle.Text = "Status:";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatusTitle.Click += new System.EventHandler(this.lblStatusTitle_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(215, 20);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Idle.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHP
            // 
            this.lblHP.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(0, 20);
            // 
            // progressBarST
            // 
            this.progressBarST.Name = "progressBarST";
            this.progressBarST.Size = new System.Drawing.Size(100, 19);
            this.progressBarST.Click += new System.EventHandler(this.progressBarST_Click);
            // 
            // timer_JapaneseTimeCheck
            // 
            this.timer_JapaneseTimeCheck.Interval = 60000;
            // 
            // FishingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(478, 217);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.pnlLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(395, 255);
            this.Name = "FishingForm";
            this.Opacity = 0.99D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FishingForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FishingForm_Load);
            this.contextMenuStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNavMaxNoCatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNavMaxRecastDelay)).EndInit();
            this.contextMenuListBox.ResumeLayout(false);
            this.pnlLog.ResumeLayout(false);
            this.pnlWanted.ResumeLayout(false);
            this.pnlWanted.PerformLayout();
            this.pnlUnwanted.ResumeLayout(false);
            this.pnlUnwanted.PerformLayout();
            this.Extras.ResumeLayout(false);
            this.tabDisplayPageChat.ResumeLayout(false);
            this.tabDisplayPageChat.PerformLayout();
            this.tabChat.ResumeLayout(false);
            this.tabChatPageLog.ResumeLayout(false);
            this.tabChatPageFishing.ResumeLayout(false);
            this.tabChatPageTell.ResumeLayout(false);
            this.tabChatPageParty.ResumeLayout(false);
            this.tabChatPageLS.ResumeLayout(false);
            this.tabChatPageSay.ResumeLayout(false);
            this.tabDisplayPageStats.ResumeLayout(false);
            this.tabDisplayPageInfo.ResumeLayout(false);
            this.tabDisplayPageInfo.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.tabDisplayPageOptions.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.tabOptionsPageForm.ResumeLayout(false);
            this.tabOptionsPageForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCatch)).EndInit();
            this.gbGeneralFishing.ResumeLayout(false);
            this.gbGeneralFishing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxNoCatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCastIntervalLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCastIntervalHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpacity)).EndInit();
            this.tabOptionsPageFight.ResumeLayout(false);
            this.tabOptionsPageFight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReactionHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReactionLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFakeLargeIntervalLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFakeLargeIntervalHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFakeSmallIntervalLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFakeSmallIntervalHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuickKill)).EndInit();
            this.tabOptionsPageAdvanced.ResumeLayout(false);
            this.tabOptionsPageAdvanced.PerformLayout();
            this.gbLogging.ResumeLayout(false);
            this.gbLogging.PerformLayout();
            this.gbGMDetect.ResumeLayout(false);
            this.gbGMDetect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigation.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabNavSetup.ResumeLayout(false);
            this.tabNavSetup.PerformLayout();
            this.tabNavEvents.ResumeLayout(false);
            this.tabNavEvents.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStats;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuListBox;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.TextBox tbChangeName;
        private System.Windows.Forms.Label lblBait;
        private System.Windows.Forms.Label lblRod;
        private System.Windows.Forms.Label lblBaitHeader;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Label lblRodHeader;
        private System.Windows.Forms.Label lblZoneHeader;
        private System.Windows.Forms.RichTextBox rtbStats;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.TabControl Extras;
        private System.Windows.Forms.TabPage tabDisplayPageStats;
        private System.Windows.Forms.TabPage tabDisplayPageInfo;
        private System.Windows.Forms.TabPage tabDisplayPageOptions;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tabOptionsPageFight;
        private System.Windows.Forms.TabPage tabOptionsPageForm;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Button btnSettingsReset;
        private System.Windows.Forms.CheckBox cbAlwaysOnTop;
        private System.Windows.Forms.TabPage tabDisplayPageChat;
        private System.Windows.Forms.TabControl tabChat;
        private System.Windows.Forms.TabPage tabChatPageLog;
        private System.Windows.Forms.TabPage tabChatPageFishing;
        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.Button btnChatSend;
        private System.Windows.Forms.TabPage tabChatPageTell;
        private System.Windows.Forms.TabPage tabChatPageParty;
        private System.Windows.Forms.TabPage tabChatPageLS;
        private System.Windows.Forms.Label lblVanaTime;
        private System.Windows.Forms.TrackBar trackOpacity;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.RichTextBox rtbFish;
        private System.Windows.Forms.RichTextBox rtbTell;
        private System.Windows.Forms.RichTextBox rtbParty;
        private System.Windows.Forms.RichTextBox rtbShell;
        private System.Windows.Forms.TabPage tabOptionsPageAdvanced;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFullactionWarp;
        private System.Windows.Forms.RadioButton rbFullactionLogout;
        private System.Windows.Forms.RadioButton rbFullactionNone;
        private System.Windows.Forms.GroupBox gbGMDetect;
        private System.Windows.Forms.TextBox tbFullactionOther;
        private System.Windows.Forms.RadioButton rbFullactionOther;
        private System.Windows.Forms.CheckBox cbGMdetectAutostop;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTitle;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBarST;
        private System.Windows.Forms.ToolStripStatusLabel lblHP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbExtend;
        private System.Windows.Forms.CheckBox cbAutoKill;
        private System.Windows.Forms.CheckBox cbQuickKill;
        private System.Windows.Forms.NumericUpDown numQuickKill;
        private System.Windows.Forms.Button btnRefreshLists;
        private System.Windows.Forms.Panel pnlWanted;
        private System.Windows.Forms.CheckBox cbCatchUnknown;
        private System.Windows.Forms.Label lblWantedHeader;
        private System.Windows.Forms.ListBox lbWanted;
        private System.Windows.Forms.Panel pnlUnwanted;
        private System.Windows.Forms.ListBox lbUnwanted;
        private System.Windows.Forms.Label lblUnwantedHeader;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblSkillHeader;
        private System.Windows.Forms.ToolStripStatusLabel lblVanaDay;
        private System.Windows.Forms.Label lblKillSeconds;
        private System.Windows.Forms.Label lblMaxNoCatch;
        private System.Windows.Forms.Label lblCastWait;
        private System.Windows.Forms.NumericUpDown numCastIntervalHigh;
        private System.Windows.Forms.NumericUpDown numCastIntervalLow;
        private System.Windows.Forms.NumericUpDown numMaxNoCatch;
        private System.Windows.Forms.Button btnCastReset;
        private System.Windows.Forms.CheckBox cbIgnoreItem;
        private System.Windows.Forms.CheckBox cbIgnoreMonster;
        private System.Windows.Forms.CheckBox cbIgnoreSmallFish;
        private System.Windows.Forms.CheckBox cbIgnoreLargeFish;
        private System.Windows.Forms.CheckBox cbStopSound;
        private System.Windows.Forms.CheckBox cbReleaseSmall;
        private System.Windows.Forms.CheckBox cbReaction;
        private System.Windows.Forms.NumericUpDown numFakeSmallIntervalLow;
        private System.Windows.Forms.NumericUpDown numReactionLow;
        private System.Windows.Forms.NumericUpDown numFakeSmallIntervalHigh;
        private System.Windows.Forms.NumericUpDown numReactionHigh;
        private System.Windows.Forms.NumericUpDown numFakeLargeIntervalLow;
        private System.Windows.Forms.NumericUpDown numFakeLargeIntervalHigh;
        private System.Windows.Forms.CheckBox cbReleaseLarge;
        private System.Windows.Forms.Label lblSatchelHeader;
        private System.Windows.Forms.Label lblInventoryHeader;
        private System.Windows.Forms.Label lblSackHeader;
        private System.Windows.Forms.Label lblSackSpace;
        private System.Windows.Forms.Label lblSatchelSpace;
        private System.Windows.Forms.Label lblInventorySpace;
        private System.Windows.Forms.ToolStripStatusLabel lblVanaClock;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.TabPage tabChatPageSay;
        private System.Windows.Forms.RichTextBox rtbSay;
        private System.Windows.Forms.GroupBox gbGeneralFishing;
        private System.Windows.Forms.Label lblVanaTimeHeader;
        private System.Windows.Forms.Label lblEarthTime;
        private System.Windows.Forms.Label lblEarthTimeHeader;
        private System.Windows.Forms.CheckBox cbTellDetect;
        private System.Windows.Forms.Button btnStartM;
        private System.Windows.Forms.CheckBox cbFishHP;
        private System.Windows.Forms.CheckBox cbEnableItemizerItemTools;
        private System.Windows.Forms.NumericUpDown numMaxCatch;
        private System.Windows.Forms.CheckBox cbMaxCatch;
        private System.Windows.Forms.CheckBox cbSneakFishing;
        private System.Windows.Forms.TabPage tabNavigation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNavSetup;
        private System.Windows.Forms.Button btnCurrentCord;
        private System.Windows.Forms.CheckBox cbNavReversePath;
        private System.Windows.Forms.Button btnNavRecordingSave;
        private System.Windows.Forms.Button btnNavRecordingStop;
        private System.Windows.Forms.Button btnRecordNav;
        private System.Windows.Forms.Button btnNavLoadFile;
        private System.Windows.Forms.Button btnStartNav;
        private System.Windows.Forms.TabPage tabNavEvents;
        private System.Windows.Forms.Button btnFatiguePath;
        private System.Windows.Forms.GroupBox gbLogging;
        private System.Windows.Forms.CheckBox cbLogToFile;
        private System.Windows.Forms.CheckBox cbFatigueFullInventory;
        private System.Windows.Forms.NumericUpDown numNavMaxRecastDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNavMaxNoCatch;
        private System.Windows.Forms.CheckBox cbNavEnableFatiguePath;
        private System.Windows.Forms.Label lblFishingSkillup;
        private System.Windows.Forms.Timer timer_JapaneseTimeCheck;
        private System.Windows.Forms.Label lblCaseSpace;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.Label lblNoCatchAt;
        private System.Windows.Forms.Label lblNoCatchAtHeader;
        private System.Windows.Forms.CheckBox cbGMExecuteCommand;
        private System.Windows.Forms.CheckBox cbRestartatMidnight;
    }
}

