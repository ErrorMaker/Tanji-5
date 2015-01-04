namespace Tanji
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TanjiStrip = new System.Windows.Forms.StatusStrip();
            this.ProtocolTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.SchedulesTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExtensionsInstalledTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiTabs = new Tanji.Controls.TanjiTabControl();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.IPacketTxt = new System.Windows.Forms.TextBox();
            this.PSendToClientBtn = new Tanji.Controls.TanjiButton();
            this.PSendToServerBtn = new Tanji.Controls.TanjiButton();
            this.IInjectionTabs = new Tanji.Controls.TanjiTabControl();
            this.IConstructerTab = new System.Windows.Forms.TabPage();
            this.ICCountTxt = new System.Windows.Forms.NumericUpDown();
            this.ICCountLbl = new System.Windows.Forms.Label();
            this.ICEditBtn = new Tanji.Controls.TanjiButton();
            this.ICRemoveBtn = new Tanji.Controls.TanjiButton();
            this.ICTransferBtn = new Tanji.Controls.TanjiButton();
            this.ICMoveDownBtn = new Tanji.Controls.TanjiButton();
            this.ICMoveUpBtn = new Tanji.Controls.TanjiButton();
            this.ICClearBtn = new Tanji.Controls.TanjiButton();
            this.ICAppendBooleanBtn = new Tanji.Controls.TanjiButton();
            this.ICAppendStringBtn = new Tanji.Controls.TanjiButton();
            this.ICAppendIntegerBtn = new Tanji.Controls.TanjiButton();
            this.ICHeaderLbl = new System.Windows.Forms.Label();
            this.ICHeaderTxt = new System.Windows.Forms.TextBox();
            this.ICValueLbl = new System.Windows.Forms.Label();
            this.ICValueTxt = new System.Windows.Forms.TextBox();
            this.ICTanjiConstructer = new Sulakore.Protocol.Controls.Constructer();
            this.ICConstructMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ICSendToClientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICSendToServerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.IConstructSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ICCopyPacketBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICTransferToBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICSchedulerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ISchedulerTab = new System.Windows.Forms.TabPage();
            this.ISAutoStartChckbx = new System.Windows.Forms.CheckBox();
            this.ISTanjiScheduler = new Sulakore.Protocol.Controls.Scheduler();
            this.ISBurstLbl = new System.Windows.Forms.Label();
            this.ISBurstTxt = new System.Windows.Forms.NumericUpDown();
            this.ISIntervalLbl = new System.Windows.Forms.Label();
            this.ISIntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.ISDirectionLbl = new System.Windows.Forms.Label();
            this.ISDirectionTxt = new System.Windows.Forms.ComboBox();
            this.ISPacketLbl = new System.Windows.Forms.Label();
            this.ISPacketTxt = new System.Windows.Forms.TextBox();
            this.ISDescriptionLbl = new System.Windows.Forms.Label();
            this.ISDescriptionTxt = new System.Windows.Forms.TextBox();
            this.ISToggleBtn = new Tanji.Controls.TanjiButton();
            this.ISStopAllBtn = new Tanji.Controls.TanjiButton();
            this.ISEditBtn = new Tanji.Controls.TanjiButton();
            this.ISRemoveBtn = new Tanji.Controls.TanjiButton();
            this.ISCreateBtn = new Tanji.Controls.TanjiButton();
            this.IPrimitiveTab = new System.Windows.Forms.TabPage();
            this.IPIsCorruptedLbl = new System.Windows.Forms.Label();
            this.IPPacketInfoLbl = new System.Windows.Forms.Label();
            this.IPPacketTxt = new System.Windows.Forms.TextBox();
            this.ITriggersTab = new System.Windows.Forms.TabPage();
            this.IFiltersTab = new System.Windows.Forms.TabPage();
            this.EncoderDecoderTab = new System.Windows.Forms.TabPage();
            this.ModernEncodingGrpbx = new System.Windows.Forms.GroupBox();
            this.ModernShortOutputTxt = new System.Windows.Forms.TextBox();
            this.ModernIntegerOutputTxt = new System.Windows.Forms.TextBox();
            this.ModernShortInputTxt = new System.Windows.Forms.TextBox();
            this.ModernCypherShortBtn = new Tanji.Controls.TanjiButton();
            this.ModernCypherIntegerBtn = new Tanji.Controls.TanjiButton();
            this.ModernDecypherShortBtn = new Tanji.Controls.TanjiButton();
            this.ModernDecypherIntegerBtn = new Tanji.Controls.TanjiButton();
            this.ModernIntegerInputTxt = new System.Windows.Forms.TextBox();
            this.EDAdvVL64DecoderGrpbx = new System.Windows.Forms.GroupBox();
            this.ChunksFoundLbl = new System.Windows.Forms.Label();
            this.ExtractValuesBtn = new Tanji.Controls.TanjiButton();
            this.VL64ValueTxt = new System.Windows.Forms.TextBox();
            this.VL64ValueLbl = new System.Windows.Forms.Label();
            this.VL64ChunkTxt = new System.Windows.Forms.TextBox();
            this.VL64ChunkLbl = new System.Windows.Forms.Label();
            this.VL64StringTxt = new System.Windows.Forms.TextBox();
            this.VL64StringLbl = new System.Windows.Forms.Label();
            this.VL64Chunks = new System.Windows.Forms.ListView();
            this.ChunkCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AncientEncodingGrpbx = new System.Windows.Forms.GroupBox();
            this.AncientShortOutputTxt = new System.Windows.Forms.TextBox();
            this.AncientIntegerOutputTxt = new System.Windows.Forms.TextBox();
            this.AncientShortInputTxt = new System.Windows.Forms.TextBox();
            this.AncientCypherShortBtn = new Tanji.Controls.TanjiButton();
            this.AncientCypherIntegerBtn = new Tanji.Controls.TanjiButton();
            this.AncientDecypherShortBtn = new Tanji.Controls.TanjiButton();
            this.AncientDecypherIntegerBtn = new Tanji.Controls.TanjiButton();
            this.AncientIntegerInputTxt = new System.Windows.Forms.TextBox();
            this.ToolboxTab = new System.Windows.Forms.TabPage();
            this.ExtensionsTab = new System.Windows.Forms.TabPage();
            this.ETanjiExtensionViewer = new Sulakore.Extensions.Controls.ExtensionView();
            this.EExtensionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EOpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EUninstallBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EExtensionsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.EInstallExtensionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.ChooseExtensionDlg = new System.Windows.Forms.OpenFileDialog();
            this.TanjiStrip.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.InjectionTab.SuspendLayout();
            this.IInjectionTabs.SuspendLayout();
            this.IConstructerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICCountTxt)).BeginInit();
            this.ICConstructMenu.SuspendLayout();
            this.ISchedulerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).BeginInit();
            this.IPrimitiveTab.SuspendLayout();
            this.EncoderDecoderTab.SuspendLayout();
            this.ModernEncodingGrpbx.SuspendLayout();
            this.EDAdvVL64DecoderGrpbx.SuspendLayout();
            this.AncientEncodingGrpbx.SuspendLayout();
            this.ExtensionsTab.SuspendLayout();
            this.EExtensionsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProtocolTxt,
            this.SchedulesTxt,
            this.ExtensionsInstalledTxt});
            this.TanjiStrip.Location = new System.Drawing.Point(0, 345);
            this.TanjiStrip.Name = "TanjiStrip";
            this.TanjiStrip.Size = new System.Drawing.Size(479, 24);
            this.TanjiStrip.SizingGrip = false;
            this.TanjiStrip.TabIndex = 4;
            this.TanjiStrip.Text = "statusStrip1";
            // 
            // ProtocolTxt
            // 
            this.ProtocolTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ProtocolTxt.Name = "ProtocolTxt";
            this.ProtocolTxt.Size = new System.Drawing.Size(113, 19);
            this.ProtocolTxt.Text = "Protocol: Unknown";
            // 
            // SchedulesTxt
            // 
            this.SchedulesTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SchedulesTxt.Name = "SchedulesTxt";
            this.SchedulesTxt.Size = new System.Drawing.Size(123, 19);
            this.SchedulesTxt.Text = "Schedules Active: 0/0";
            // 
            // ExtensionsInstalledTxt
            // 
            this.ExtensionsInstalledTxt.Name = "ExtensionsInstalledTxt";
            this.ExtensionsInstalledTxt.Size = new System.Drawing.Size(121, 19);
            this.ExtensionsInstalledTxt.Text = "Extensions Installed: 0";
            // 
            // TanjiTabs
            // 
            this.TanjiTabs.Controls.Add(this.InjectionTab);
            this.TanjiTabs.Controls.Add(this.EncoderDecoderTab);
            this.TanjiTabs.Controls.Add(this.ToolboxTab);
            this.TanjiTabs.Controls.Add(this.ExtensionsTab);
            this.TanjiTabs.Controls.Add(this.OptionsTab);
            this.TanjiTabs.DisplayBoundary = true;
            this.TanjiTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanjiTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TanjiTabs.ItemSize = new System.Drawing.Size(95, 24);
            this.TanjiTabs.Location = new System.Drawing.Point(0, 0);
            this.TanjiTabs.Name = "TanjiTabs";
            this.TanjiTabs.SelectedIndex = 0;
            this.TanjiTabs.Size = new System.Drawing.Size(479, 345);
            this.TanjiTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TanjiTabs.TabIndex = 0;
            // 
            // InjectionTab
            // 
            this.InjectionTab.BackColor = System.Drawing.Color.White;
            this.InjectionTab.Controls.Add(this.IPacketTxt);
            this.InjectionTab.Controls.Add(this.PSendToClientBtn);
            this.InjectionTab.Controls.Add(this.PSendToServerBtn);
            this.InjectionTab.Controls.Add(this.IInjectionTabs);
            this.InjectionTab.Location = new System.Drawing.Point(4, 28);
            this.InjectionTab.Name = "InjectionTab";
            this.InjectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.InjectionTab.Size = new System.Drawing.Size(471, 313);
            this.InjectionTab.TabIndex = 0;
            this.InjectionTab.Text = "Injection";
            // 
            // IPacketTxt
            // 
            this.IPacketTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPacketTxt.Location = new System.Drawing.Point(6, 286);
            this.IPacketTxt.MaxLength = 2147483647;
            this.IPacketTxt.Name = "IPacketTxt";
            this.IPacketTxt.Size = new System.Drawing.Size(247, 20);
            this.IPacketTxt.TabIndex = 5;
            // 
            // PSendToClientBtn
            // 
            this.PSendToClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PSendToClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.PSendToClientBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PSendToClientBtn.Location = new System.Drawing.Point(259, 285);
            this.PSendToClientBtn.Name = "PSendToClientBtn";
            this.PSendToClientBtn.Size = new System.Drawing.Size(100, 22);
            this.PSendToClientBtn.TabIndex = 4;
            this.PSendToClientBtn.Text = "Send To Client";
            this.PSendToClientBtn.Click += new System.EventHandler(this.SendToClientBtn_Click);
            // 
            // PSendToServerBtn
            // 
            this.PSendToServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PSendToServerBtn.BackColor = System.Drawing.Color.Transparent;
            this.PSendToServerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PSendToServerBtn.Location = new System.Drawing.Point(365, 285);
            this.PSendToServerBtn.Name = "PSendToServerBtn";
            this.PSendToServerBtn.Size = new System.Drawing.Size(100, 22);
            this.PSendToServerBtn.TabIndex = 3;
            this.PSendToServerBtn.Text = "Send To Server";
            this.PSendToServerBtn.Click += new System.EventHandler(this.SendToServerBtn_Click);
            // 
            // IInjectionTabs
            // 
            this.IInjectionTabs.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.IInjectionTabs.Controls.Add(this.IConstructerTab);
            this.IInjectionTabs.Controls.Add(this.ISchedulerTab);
            this.IInjectionTabs.Controls.Add(this.IPrimitiveTab);
            this.IInjectionTabs.Controls.Add(this.ITriggersTab);
            this.IInjectionTabs.Controls.Add(this.IFiltersTab);
            this.IInjectionTabs.DisplayBoundary = true;
            this.IInjectionTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.IInjectionTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.IInjectionTabs.ItemSize = new System.Drawing.Size(66, 25);
            this.IInjectionTabs.Location = new System.Drawing.Point(3, 3);
            this.IInjectionTabs.Multiline = true;
            this.IInjectionTabs.Name = "IInjectionTabs";
            this.IInjectionTabs.SelectedIndex = 0;
            this.IInjectionTabs.Size = new System.Drawing.Size(465, 276);
            this.IInjectionTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.IInjectionTabs.TabIndex = 0;
            this.IInjectionTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.IInjectionTabs_Selected);
            // 
            // IConstructerTab
            // 
            this.IConstructerTab.BackColor = System.Drawing.Color.White;
            this.IConstructerTab.Controls.Add(this.ICCountTxt);
            this.IConstructerTab.Controls.Add(this.ICCountLbl);
            this.IConstructerTab.Controls.Add(this.ICEditBtn);
            this.IConstructerTab.Controls.Add(this.ICRemoveBtn);
            this.IConstructerTab.Controls.Add(this.ICTransferBtn);
            this.IConstructerTab.Controls.Add(this.ICMoveDownBtn);
            this.IConstructerTab.Controls.Add(this.ICMoveUpBtn);
            this.IConstructerTab.Controls.Add(this.ICClearBtn);
            this.IConstructerTab.Controls.Add(this.ICAppendBooleanBtn);
            this.IConstructerTab.Controls.Add(this.ICAppendStringBtn);
            this.IConstructerTab.Controls.Add(this.ICAppendIntegerBtn);
            this.IConstructerTab.Controls.Add(this.ICHeaderLbl);
            this.IConstructerTab.Controls.Add(this.ICHeaderTxt);
            this.IConstructerTab.Controls.Add(this.ICValueLbl);
            this.IConstructerTab.Controls.Add(this.ICValueTxt);
            this.IConstructerTab.Controls.Add(this.ICTanjiConstructer);
            this.IConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.IConstructerTab.Name = "IConstructerTab";
            this.IConstructerTab.Padding = new System.Windows.Forms.Padding(3);
            this.IConstructerTab.Size = new System.Drawing.Size(391, 268);
            this.IConstructerTab.TabIndex = 1;
            this.IConstructerTab.Text = "Constructer";
            // 
            // ICCountTxt
            // 
            this.ICCountTxt.Location = new System.Drawing.Point(326, 19);
            this.ICCountTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ICCountTxt.Name = "ICCountTxt";
            this.ICCountTxt.Size = new System.Drawing.Size(59, 20);
            this.ICCountTxt.TabIndex = 24;
            this.ICCountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICCountTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ICCountLbl
            // 
            this.ICCountLbl.AutoSize = true;
            this.ICCountLbl.Location = new System.Drawing.Point(324, 3);
            this.ICCountLbl.Name = "ICCountLbl";
            this.ICCountLbl.Size = new System.Drawing.Size(35, 13);
            this.ICCountLbl.TabIndex = 23;
            this.ICCountLbl.Text = "Count";
            // 
            // ICEditBtn
            // 
            this.ICEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICEditBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICEditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICEditBtn.Enabled = false;
            this.ICEditBtn.Location = new System.Drawing.Point(113, 240);
            this.ICEditBtn.Name = "ICEditBtn";
            this.ICEditBtn.Size = new System.Drawing.Size(57, 22);
            this.ICEditBtn.TabIndex = 22;
            this.ICEditBtn.Text = "Edit";
            this.ICEditBtn.Click += new System.EventHandler(this.ICEditBtn_Click);
            // 
            // ICRemoveBtn
            // 
            this.ICRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICRemoveBtn.Enabled = false;
            this.ICRemoveBtn.Location = new System.Drawing.Point(176, 240);
            this.ICRemoveBtn.Name = "ICRemoveBtn";
            this.ICRemoveBtn.Size = new System.Drawing.Size(57, 22);
            this.ICRemoveBtn.TabIndex = 21;
            this.ICRemoveBtn.Text = "Remove";
            this.ICRemoveBtn.Click += new System.EventHandler(this.ICRemoveBtn_Click);
            // 
            // ICTransferBtn
            // 
            this.ICTransferBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICTransferBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICTransferBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICTransferBtn.Location = new System.Drawing.Point(6, 240);
            this.ICTransferBtn.Name = "ICTransferBtn";
            this.ICTransferBtn.Size = new System.Drawing.Size(101, 22);
            this.ICTransferBtn.TabIndex = 20;
            this.ICTransferBtn.Text = "Transfer (Below)";
            this.ICTransferBtn.Click += new System.EventHandler(this.ICTransferBtn_Click);
            // 
            // ICMoveDownBtn
            // 
            this.ICMoveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICMoveDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICMoveDownBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICMoveDownBtn.Enabled = false;
            this.ICMoveDownBtn.Location = new System.Drawing.Point(239, 240);
            this.ICMoveDownBtn.Name = "ICMoveDownBtn";
            this.ICMoveDownBtn.Size = new System.Drawing.Size(70, 22);
            this.ICMoveDownBtn.TabIndex = 19;
            this.ICMoveDownBtn.Text = "Move Down";
            this.ICMoveDownBtn.Click += new System.EventHandler(this.ICMoveDownBtn_Click);
            // 
            // ICMoveUpBtn
            // 
            this.ICMoveUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICMoveUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICMoveUpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICMoveUpBtn.Enabled = false;
            this.ICMoveUpBtn.Location = new System.Drawing.Point(315, 240);
            this.ICMoveUpBtn.Name = "ICMoveUpBtn";
            this.ICMoveUpBtn.Size = new System.Drawing.Size(70, 22);
            this.ICMoveUpBtn.TabIndex = 18;
            this.ICMoveUpBtn.Text = "Move Up";
            this.ICMoveUpBtn.Click += new System.EventHandler(this.ICMoveUpBtn_Click);
            // 
            // ICClearBtn
            // 
            this.ICClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICClearBtn.Location = new System.Drawing.Point(6, 45);
            this.ICClearBtn.Name = "ICClearBtn";
            this.ICClearBtn.Size = new System.Drawing.Size(67, 22);
            this.ICClearBtn.TabIndex = 17;
            this.ICClearBtn.Text = "Clear";
            this.ICClearBtn.Click += new System.EventHandler(this.ICClearBtn_Click);
            // 
            // ICAppendBooleanBtn
            // 
            this.ICAppendBooleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendBooleanBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendBooleanBtn.Location = new System.Drawing.Point(287, 45);
            this.ICAppendBooleanBtn.Name = "ICAppendBooleanBtn";
            this.ICAppendBooleanBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendBooleanBtn.TabIndex = 16;
            this.ICAppendBooleanBtn.Text = "Append Boolean";
            this.ICAppendBooleanBtn.Click += new System.EventHandler(this.ICAppendBooleanBtn_Click);
            // 
            // ICAppendStringBtn
            // 
            this.ICAppendStringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendStringBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendStringBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendStringBtn.Location = new System.Drawing.Point(183, 45);
            this.ICAppendStringBtn.Name = "ICAppendStringBtn";
            this.ICAppendStringBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendStringBtn.TabIndex = 15;
            this.ICAppendStringBtn.Text = "Append String";
            this.ICAppendStringBtn.Click += new System.EventHandler(this.ICAppendStringBtn_Click);
            // 
            // ICAppendIntegerBtn
            // 
            this.ICAppendIntegerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendIntegerBtn.Location = new System.Drawing.Point(79, 45);
            this.ICAppendIntegerBtn.Name = "ICAppendIntegerBtn";
            this.ICAppendIntegerBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendIntegerBtn.TabIndex = 14;
            this.ICAppendIntegerBtn.Text = "Append Integer";
            this.ICAppendIntegerBtn.Click += new System.EventHandler(this.ICAppendIntegerBtn_Click);
            // 
            // ICHeaderLbl
            // 
            this.ICHeaderLbl.AutoSize = true;
            this.ICHeaderLbl.Location = new System.Drawing.Point(3, 3);
            this.ICHeaderLbl.Name = "ICHeaderLbl";
            this.ICHeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.ICHeaderLbl.TabIndex = 13;
            this.ICHeaderLbl.Text = "Header";
            // 
            // ICHeaderTxt
            // 
            this.ICHeaderTxt.Location = new System.Drawing.Point(6, 19);
            this.ICHeaderTxt.MaxLength = 4;
            this.ICHeaderTxt.Name = "ICHeaderTxt";
            this.ICHeaderTxt.Size = new System.Drawing.Size(67, 20);
            this.ICHeaderTxt.TabIndex = 12;
            this.ICHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ICValueLbl
            // 
            this.ICValueLbl.AutoSize = true;
            this.ICValueLbl.Location = new System.Drawing.Point(76, 3);
            this.ICValueLbl.Name = "ICValueLbl";
            this.ICValueLbl.Size = new System.Drawing.Size(34, 13);
            this.ICValueLbl.TabIndex = 11;
            this.ICValueLbl.Text = "Value";
            // 
            // ICValueTxt
            // 
            this.ICValueTxt.Location = new System.Drawing.Point(79, 19);
            this.ICValueTxt.Name = "ICValueTxt";
            this.ICValueTxt.Size = new System.Drawing.Size(241, 20);
            this.ICValueTxt.TabIndex = 10;
            this.ICValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ICTanjiConstructer
            // 
            this.ICTanjiConstructer.ContextMenuStrip = this.ICConstructMenu;
            this.ICTanjiConstructer.Destination = Sulakore.Protocol.HDestination.Server;
            this.ICTanjiConstructer.FullRowSelect = true;
            this.ICTanjiConstructer.GridLines = true;
            this.ICTanjiConstructer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ICTanjiConstructer.Location = new System.Drawing.Point(6, 73);
            this.ICTanjiConstructer.LockColumns = false;
            this.ICTanjiConstructer.MultiSelect = false;
            this.ICTanjiConstructer.Name = "ICTanjiConstructer";
            this.ICTanjiConstructer.Protocol = Sulakore.Protocol.HProtocol.Modern;
            this.ICTanjiConstructer.ShowItemToolTips = true;
            this.ICTanjiConstructer.Size = new System.Drawing.Size(379, 161);
            this.ICTanjiConstructer.TabIndex = 0;
            this.ICTanjiConstructer.UseCompatibleStateImageBehavior = false;
            this.ICTanjiConstructer.View = System.Windows.Forms.View.Details;
            this.ICTanjiConstructer.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ICTanjiConstructer_ItemSelectionChanged);
            this.ICTanjiConstructer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ICTanjiConstructer_MouseDoubleClick);
            // 
            // ICConstructMenu
            // 
            this.ICConstructMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ICSendToClientBtn,
            this.ICSendToServerBtn,
            this.IConstructSeperator,
            this.ICCopyPacketBtn,
            this.ICTransferToBtn});
            this.ICConstructMenu.Name = "ConstructMenu";
            this.ICConstructMenu.Size = new System.Drawing.Size(153, 98);
            // 
            // ICSendToClientBtn
            // 
            this.ICSendToClientBtn.Name = "ICSendToClientBtn";
            this.ICSendToClientBtn.Size = new System.Drawing.Size(152, 22);
            this.ICSendToClientBtn.Text = "Send To Client";
            this.ICSendToClientBtn.Click += new System.EventHandler(this.ICSendToClientBtn_Click);
            // 
            // ICSendToServerBtn
            // 
            this.ICSendToServerBtn.Name = "ICSendToServerBtn";
            this.ICSendToServerBtn.Size = new System.Drawing.Size(152, 22);
            this.ICSendToServerBtn.Text = "Send To Server";
            this.ICSendToServerBtn.Click += new System.EventHandler(this.ICSendToServerBtn_Click);
            // 
            // IConstructSeperator
            // 
            this.IConstructSeperator.Name = "IConstructSeperator";
            this.IConstructSeperator.Size = new System.Drawing.Size(149, 6);
            // 
            // ICCopyPacketBtn
            // 
            this.ICCopyPacketBtn.Name = "ICCopyPacketBtn";
            this.ICCopyPacketBtn.Size = new System.Drawing.Size(152, 22);
            this.ICCopyPacketBtn.Text = "Copy Packet";
            this.ICCopyPacketBtn.Click += new System.EventHandler(this.ICCopyPacketBtn_Click);
            // 
            // ICTransferToBtn
            // 
            this.ICTransferToBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ICSchedulerBtn});
            this.ICTransferToBtn.Name = "ICTransferToBtn";
            this.ICTransferToBtn.Size = new System.Drawing.Size(152, 22);
            this.ICTransferToBtn.Text = "Transfer To";
            // 
            // ICSchedulerBtn
            // 
            this.ICSchedulerBtn.Name = "ICSchedulerBtn";
            this.ICSchedulerBtn.Size = new System.Drawing.Size(126, 22);
            this.ICSchedulerBtn.Text = "Scheduler";
            this.ICSchedulerBtn.Click += new System.EventHandler(this.ICSchedulerBtn_Click);
            // 
            // ISchedulerTab
            // 
            this.ISchedulerTab.BackColor = System.Drawing.Color.White;
            this.ISchedulerTab.Controls.Add(this.ISAutoStartChckbx);
            this.ISchedulerTab.Controls.Add(this.ISTanjiScheduler);
            this.ISchedulerTab.Controls.Add(this.ISBurstLbl);
            this.ISchedulerTab.Controls.Add(this.ISBurstTxt);
            this.ISchedulerTab.Controls.Add(this.ISIntervalLbl);
            this.ISchedulerTab.Controls.Add(this.ISIntervalTxt);
            this.ISchedulerTab.Controls.Add(this.ISDirectionLbl);
            this.ISchedulerTab.Controls.Add(this.ISDirectionTxt);
            this.ISchedulerTab.Controls.Add(this.ISPacketLbl);
            this.ISchedulerTab.Controls.Add(this.ISPacketTxt);
            this.ISchedulerTab.Controls.Add(this.ISDescriptionLbl);
            this.ISchedulerTab.Controls.Add(this.ISDescriptionTxt);
            this.ISchedulerTab.Controls.Add(this.ISToggleBtn);
            this.ISchedulerTab.Controls.Add(this.ISStopAllBtn);
            this.ISchedulerTab.Controls.Add(this.ISEditBtn);
            this.ISchedulerTab.Controls.Add(this.ISRemoveBtn);
            this.ISchedulerTab.Controls.Add(this.ISCreateBtn);
            this.ISchedulerTab.Location = new System.Drawing.Point(4, 4);
            this.ISchedulerTab.Name = "ISchedulerTab";
            this.ISchedulerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ISchedulerTab.Size = new System.Drawing.Size(391, 268);
            this.ISchedulerTab.TabIndex = 2;
            this.ISchedulerTab.Text = "Scheduler";
            // 
            // ISAutoStartChckbx
            // 
            this.ISAutoStartChckbx.AutoSize = true;
            this.ISAutoStartChckbx.Location = new System.Drawing.Point(151, 158);
            this.ISAutoStartChckbx.Name = "ISAutoStartChckbx";
            this.ISAutoStartChckbx.Size = new System.Drawing.Size(73, 17);
            this.ISAutoStartChckbx.TabIndex = 42;
            this.ISAutoStartChckbx.Text = "Auto Start";
            this.ISAutoStartChckbx.UseVisualStyleBackColor = true;
            // 
            // ISTanjiScheduler
            // 
            this.ISTanjiScheduler.FullRowSelect = true;
            this.ISTanjiScheduler.GridLines = true;
            this.ISTanjiScheduler.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ISTanjiScheduler.Location = new System.Drawing.Point(6, 6);
            this.ISTanjiScheduler.LockColumns = true;
            this.ISTanjiScheduler.MultiSelect = false;
            this.ISTanjiScheduler.Name = "ISTanjiScheduler";
            this.ISTanjiScheduler.ShowItemToolTips = true;
            this.ISTanjiScheduler.Size = new System.Drawing.Size(379, 141);
            this.ISTanjiScheduler.TabIndex = 41;
            this.ISTanjiScheduler.UseCompatibleStateImageBehavior = false;
            this.ISTanjiScheduler.View = System.Windows.Forms.View.Details;
            this.ISTanjiScheduler.ScheduleTriggered += new System.EventHandler<Sulakore.Protocol.Controls.ScheduleTriggeredEventArgs>(this.ISTanjiScheduler_ScheduleTriggered);
            this.ISTanjiScheduler.ItemActivate += new System.EventHandler(this.ISTanjiScheduler_ItemActivate);
            this.ISTanjiScheduler.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ISTanjiScheduler_ItemSelectionChanged);
            // 
            // ISBurstLbl
            // 
            this.ISBurstLbl.AutoSize = true;
            this.ISBurstLbl.Location = new System.Drawing.Point(312, 198);
            this.ISBurstLbl.Name = "ISBurstLbl";
            this.ISBurstLbl.Size = new System.Drawing.Size(31, 13);
            this.ISBurstLbl.TabIndex = 40;
            this.ISBurstLbl.Text = "Burst";
            // 
            // ISBurstTxt
            // 
            this.ISBurstTxt.Location = new System.Drawing.Point(315, 214);
            this.ISBurstTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ISBurstTxt.Name = "ISBurstTxt";
            this.ISBurstTxt.Size = new System.Drawing.Size(70, 20);
            this.ISBurstTxt.TabIndex = 39;
            this.ISBurstTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ISBurstTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ISIntervalLbl
            // 
            this.ISIntervalLbl.AutoSize = true;
            this.ISIntervalLbl.Location = new System.Drawing.Point(312, 159);
            this.ISIntervalLbl.Name = "ISIntervalLbl";
            this.ISIntervalLbl.Size = new System.Drawing.Size(64, 13);
            this.ISIntervalLbl.TabIndex = 38;
            this.ISIntervalLbl.Text = "Interval (ms)";
            // 
            // ISIntervalTxt
            // 
            this.ISIntervalTxt.Location = new System.Drawing.Point(315, 175);
            this.ISIntervalTxt.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ISIntervalTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ISIntervalTxt.Name = "ISIntervalTxt";
            this.ISIntervalTxt.Size = new System.Drawing.Size(70, 20);
            this.ISIntervalTxt.TabIndex = 37;
            this.ISIntervalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ISIntervalTxt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ISDirectionLbl
            // 
            this.ISDirectionLbl.AutoSize = true;
            this.ISDirectionLbl.Location = new System.Drawing.Point(230, 159);
            this.ISDirectionLbl.Name = "ISDirectionLbl";
            this.ISDirectionLbl.Size = new System.Drawing.Size(49, 13);
            this.ISDirectionLbl.TabIndex = 36;
            this.ISDirectionLbl.Text = "Direction";
            // 
            // ISDirectionTxt
            // 
            this.ISDirectionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISDirectionTxt.FormattingEnabled = true;
            this.ISDirectionTxt.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.ISDirectionTxt.Location = new System.Drawing.Point(233, 174);
            this.ISDirectionTxt.Name = "ISDirectionTxt";
            this.ISDirectionTxt.Size = new System.Drawing.Size(76, 21);
            this.ISDirectionTxt.TabIndex = 35;
            // 
            // ISPacketLbl
            // 
            this.ISPacketLbl.AutoSize = true;
            this.ISPacketLbl.Location = new System.Drawing.Point(3, 159);
            this.ISPacketLbl.Name = "ISPacketLbl";
            this.ISPacketLbl.Size = new System.Drawing.Size(41, 13);
            this.ISPacketLbl.TabIndex = 34;
            this.ISPacketLbl.Text = "Packet";
            // 
            // ISPacketTxt
            // 
            this.ISPacketTxt.Location = new System.Drawing.Point(6, 175);
            this.ISPacketTxt.MaxLength = 2147483647;
            this.ISPacketTxt.Name = "ISPacketTxt";
            this.ISPacketTxt.Size = new System.Drawing.Size(221, 20);
            this.ISPacketTxt.TabIndex = 33;
            // 
            // ISDescriptionLbl
            // 
            this.ISDescriptionLbl.AutoSize = true;
            this.ISDescriptionLbl.Location = new System.Drawing.Point(3, 198);
            this.ISDescriptionLbl.Name = "ISDescriptionLbl";
            this.ISDescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.ISDescriptionLbl.TabIndex = 32;
            this.ISDescriptionLbl.Text = "Description";
            // 
            // ISDescriptionTxt
            // 
            this.ISDescriptionTxt.Location = new System.Drawing.Point(6, 214);
            this.ISDescriptionTxt.Name = "ISDescriptionTxt";
            this.ISDescriptionTxt.Size = new System.Drawing.Size(303, 20);
            this.ISDescriptionTxt.TabIndex = 31;
            // 
            // ISToggleBtn
            // 
            this.ISToggleBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISToggleBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISToggleBtn.Enabled = false;
            this.ISToggleBtn.Location = new System.Drawing.Point(87, 240);
            this.ISToggleBtn.Name = "ISToggleBtn";
            this.ISToggleBtn.Size = new System.Drawing.Size(70, 22);
            this.ISToggleBtn.TabIndex = 29;
            this.ISToggleBtn.Text = "Start / Stop";
            this.ISToggleBtn.Click += new System.EventHandler(this.ISToggleBtn_Click);
            // 
            // ISStopAllBtn
            // 
            this.ISStopAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISStopAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISStopAllBtn.Enabled = false;
            this.ISStopAllBtn.Location = new System.Drawing.Point(6, 240);
            this.ISStopAllBtn.Name = "ISStopAllBtn";
            this.ISStopAllBtn.Size = new System.Drawing.Size(75, 22);
            this.ISStopAllBtn.TabIndex = 28;
            this.ISStopAllBtn.Text = "Stop All";
            this.ISStopAllBtn.Click += new System.EventHandler(this.ISStopAllBtn_Click);
            // 
            // ISEditBtn
            // 
            this.ISEditBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISEditBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISEditBtn.Enabled = false;
            this.ISEditBtn.Location = new System.Drawing.Point(239, 240);
            this.ISEditBtn.Name = "ISEditBtn";
            this.ISEditBtn.Size = new System.Drawing.Size(70, 22);
            this.ISEditBtn.TabIndex = 27;
            this.ISEditBtn.Text = "Edit";
            this.ISEditBtn.Click += new System.EventHandler(this.ISEditBtn_Click);
            // 
            // ISRemoveBtn
            // 
            this.ISRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISRemoveBtn.Enabled = false;
            this.ISRemoveBtn.Location = new System.Drawing.Point(163, 240);
            this.ISRemoveBtn.Name = "ISRemoveBtn";
            this.ISRemoveBtn.Size = new System.Drawing.Size(70, 22);
            this.ISRemoveBtn.TabIndex = 26;
            this.ISRemoveBtn.Text = "Remove";
            this.ISRemoveBtn.Click += new System.EventHandler(this.ISRemoveBtn_Click);
            // 
            // ISCreateBtn
            // 
            this.ISCreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISCreateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISCreateBtn.Location = new System.Drawing.Point(315, 240);
            this.ISCreateBtn.Name = "ISCreateBtn";
            this.ISCreateBtn.Size = new System.Drawing.Size(70, 22);
            this.ISCreateBtn.TabIndex = 25;
            this.ISCreateBtn.Text = "Create";
            this.ISCreateBtn.Click += new System.EventHandler(this.ISCreateBtn_Click);
            // 
            // IPrimitiveTab
            // 
            this.IPrimitiveTab.BackColor = System.Drawing.Color.White;
            this.IPrimitiveTab.Controls.Add(this.IPIsCorruptedLbl);
            this.IPrimitiveTab.Controls.Add(this.IPPacketInfoLbl);
            this.IPrimitiveTab.Controls.Add(this.IPPacketTxt);
            this.IPrimitiveTab.Location = new System.Drawing.Point(4, 4);
            this.IPrimitiveTab.Name = "IPrimitiveTab";
            this.IPrimitiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.IPrimitiveTab.Size = new System.Drawing.Size(391, 268);
            this.IPrimitiveTab.TabIndex = 0;
            this.IPrimitiveTab.Text = "Primitive";
            // 
            // IPIsCorruptedLbl
            // 
            this.IPIsCorruptedLbl.AutoSize = true;
            this.IPIsCorruptedLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.IPIsCorruptedLbl.Location = new System.Drawing.Point(165, 3);
            this.IPIsCorruptedLbl.Name = "IPIsCorruptedLbl";
            this.IPIsCorruptedLbl.Size = new System.Drawing.Size(29, 13);
            this.IPIsCorruptedLbl.TabIndex = 2;
            this.IPIsCorruptedLbl.Text = "True";
            // 
            // IPPacketInfoLbl
            // 
            this.IPPacketInfoLbl.AutoSize = true;
            this.IPPacketInfoLbl.Location = new System.Drawing.Point(6, 3);
            this.IPPacketInfoLbl.Name = "IPPacketInfoLbl";
            this.IPPacketInfoLbl.Size = new System.Drawing.Size(164, 13);
            this.IPPacketInfoLbl.TabIndex = 1;
            this.IPPacketInfoLbl.Text = "Header: 0 | Length: 0 | Corrupted:";
            // 
            // IPPacketTxt
            // 
            this.IPPacketTxt.Location = new System.Drawing.Point(6, 19);
            this.IPPacketTxt.MaxLength = 2147483647;
            this.IPPacketTxt.Multiline = true;
            this.IPPacketTxt.Name = "IPPacketTxt";
            this.IPPacketTxt.Size = new System.Drawing.Size(379, 243);
            this.IPPacketTxt.TabIndex = 0;
            this.IPPacketTxt.TextChanged += new System.EventHandler(this.IPPacketTxt_TextChanged);
            // 
            // ITriggersTab
            // 
            this.ITriggersTab.BackColor = System.Drawing.Color.White;
            this.ITriggersTab.Location = new System.Drawing.Point(4, 4);
            this.ITriggersTab.Name = "ITriggersTab";
            this.ITriggersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ITriggersTab.Size = new System.Drawing.Size(391, 268);
            this.ITriggersTab.TabIndex = 3;
            this.ITriggersTab.Text = "Triggers";
            // 
            // IFiltersTab
            // 
            this.IFiltersTab.BackColor = System.Drawing.Color.White;
            this.IFiltersTab.Location = new System.Drawing.Point(4, 4);
            this.IFiltersTab.Name = "IFiltersTab";
            this.IFiltersTab.Padding = new System.Windows.Forms.Padding(3);
            this.IFiltersTab.Size = new System.Drawing.Size(391, 268);
            this.IFiltersTab.TabIndex = 4;
            this.IFiltersTab.Text = "Filters";
            // 
            // EncoderDecoderTab
            // 
            this.EncoderDecoderTab.BackColor = System.Drawing.Color.White;
            this.EncoderDecoderTab.Controls.Add(this.ModernEncodingGrpbx);
            this.EncoderDecoderTab.Controls.Add(this.EDAdvVL64DecoderGrpbx);
            this.EncoderDecoderTab.Controls.Add(this.AncientEncodingGrpbx);
            this.EncoderDecoderTab.Location = new System.Drawing.Point(4, 28);
            this.EncoderDecoderTab.Name = "EncoderDecoderTab";
            this.EncoderDecoderTab.Padding = new System.Windows.Forms.Padding(3);
            this.EncoderDecoderTab.Size = new System.Drawing.Size(471, 313);
            this.EncoderDecoderTab.TabIndex = 1;
            this.EncoderDecoderTab.Text = "Encoder/Decoder";
            // 
            // ModernEncodingGrpbx
            // 
            this.ModernEncodingGrpbx.Controls.Add(this.ModernShortOutputTxt);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernIntegerOutputTxt);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernShortInputTxt);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernCypherShortBtn);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernCypherIntegerBtn);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernDecypherShortBtn);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernDecypherIntegerBtn);
            this.ModernEncodingGrpbx.Controls.Add(this.ModernIntegerInputTxt);
            this.ModernEncodingGrpbx.Location = new System.Drawing.Point(6, 6);
            this.ModernEncodingGrpbx.Name = "ModernEncodingGrpbx";
            this.ModernEncodingGrpbx.Size = new System.Drawing.Size(459, 79);
            this.ModernEncodingGrpbx.TabIndex = 21;
            this.ModernEncodingGrpbx.TabStop = false;
            this.ModernEncodingGrpbx.Text = "Modern Encoding ( BigEndian )";
            // 
            // ModernShortOutputTxt
            // 
            this.ModernShortOutputTxt.Location = new System.Drawing.Point(233, 50);
            this.ModernShortOutputTxt.Name = "ModernShortOutputTxt";
            this.ModernShortOutputTxt.Size = new System.Drawing.Size(117, 20);
            this.ModernShortOutputTxt.TabIndex = 17;
            this.ModernShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModernIntegerOutputTxt
            // 
            this.ModernIntegerOutputTxt.Location = new System.Drawing.Point(233, 21);
            this.ModernIntegerOutputTxt.Name = "ModernIntegerOutputTxt";
            this.ModernIntegerOutputTxt.Size = new System.Drawing.Size(117, 20);
            this.ModernIntegerOutputTxt.TabIndex = 16;
            this.ModernIntegerOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModernShortInputTxt
            // 
            this.ModernShortInputTxt.Location = new System.Drawing.Point(110, 50);
            this.ModernShortInputTxt.Name = "ModernShortInputTxt";
            this.ModernShortInputTxt.Size = new System.Drawing.Size(117, 20);
            this.ModernShortInputTxt.TabIndex = 15;
            this.ModernShortInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModernCypherShortBtn
            // 
            this.ModernCypherShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModernCypherShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModernCypherShortBtn.Location = new System.Drawing.Point(6, 48);
            this.ModernCypherShortBtn.Name = "ModernCypherShortBtn";
            this.ModernCypherShortBtn.Size = new System.Drawing.Size(98, 23);
            this.ModernCypherShortBtn.TabIndex = 12;
            this.ModernCypherShortBtn.Text = "Cypher Short";
            this.ModernCypherShortBtn.Click += new System.EventHandler(this.ModernCypherShortBtn_Click);
            // 
            // ModernCypherIntegerBtn
            // 
            this.ModernCypherIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModernCypherIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModernCypherIntegerBtn.Location = new System.Drawing.Point(6, 19);
            this.ModernCypherIntegerBtn.Name = "ModernCypherIntegerBtn";
            this.ModernCypherIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.ModernCypherIntegerBtn.TabIndex = 11;
            this.ModernCypherIntegerBtn.Text = "Cypher Integer";
            this.ModernCypherIntegerBtn.Click += new System.EventHandler(this.ModernCypherIntegerBtn_Click);
            // 
            // ModernDecypherShortBtn
            // 
            this.ModernDecypherShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModernDecypherShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModernDecypherShortBtn.Location = new System.Drawing.Point(356, 48);
            this.ModernDecypherShortBtn.Name = "ModernDecypherShortBtn";
            this.ModernDecypherShortBtn.Size = new System.Drawing.Size(98, 23);
            this.ModernDecypherShortBtn.TabIndex = 14;
            this.ModernDecypherShortBtn.Text = "Decypher Short";
            this.ModernDecypherShortBtn.Click += new System.EventHandler(this.ModernDecypherShortBtn_Click);
            // 
            // ModernDecypherIntegerBtn
            // 
            this.ModernDecypherIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ModernDecypherIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ModernDecypherIntegerBtn.Location = new System.Drawing.Point(356, 19);
            this.ModernDecypherIntegerBtn.Name = "ModernDecypherIntegerBtn";
            this.ModernDecypherIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.ModernDecypherIntegerBtn.TabIndex = 13;
            this.ModernDecypherIntegerBtn.Text = "Decypher Integer";
            this.ModernDecypherIntegerBtn.Click += new System.EventHandler(this.ModernDecypherIntegerBtn_Click);
            // 
            // ModernIntegerInputTxt
            // 
            this.ModernIntegerInputTxt.Location = new System.Drawing.Point(110, 21);
            this.ModernIntegerInputTxt.Name = "ModernIntegerInputTxt";
            this.ModernIntegerInputTxt.Size = new System.Drawing.Size(117, 20);
            this.ModernIntegerInputTxt.TabIndex = 10;
            this.ModernIntegerInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDAdvVL64DecoderGrpbx
            // 
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.ChunksFoundLbl);
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.ExtractValuesBtn);
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.VL64ValueTxt);
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.VL64ValueLbl);
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.VL64ChunkTxt);
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.VL64ChunkLbl);
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.VL64StringTxt);
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.VL64StringLbl);
            this.EDAdvVL64DecoderGrpbx.Controls.Add(this.VL64Chunks);
            this.EDAdvVL64DecoderGrpbx.Location = new System.Drawing.Point(5, 174);
            this.EDAdvVL64DecoderGrpbx.Name = "EDAdvVL64DecoderGrpbx";
            this.EDAdvVL64DecoderGrpbx.Size = new System.Drawing.Size(460, 135);
            this.EDAdvVL64DecoderGrpbx.TabIndex = 20;
            this.EDAdvVL64DecoderGrpbx.TabStop = false;
            this.EDAdvVL64DecoderGrpbx.Text = "Advanced VL64 Decoder ( Multiple Value Extractor )";
            // 
            // ChunksFoundLbl
            // 
            this.ChunksFoundLbl.Location = new System.Drawing.Point(208, 103);
            this.ChunksFoundLbl.Name = "ChunksFoundLbl";
            this.ChunksFoundLbl.Size = new System.Drawing.Size(120, 23);
            this.ChunksFoundLbl.TabIndex = 8;
            this.ChunksFoundLbl.Text = "Chunks Found: 0";
            this.ChunksFoundLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExtractValuesBtn
            // 
            this.ExtractValuesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExtractValuesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExtractValuesBtn.Location = new System.Drawing.Point(334, 103);
            this.ExtractValuesBtn.Name = "ExtractValuesBtn";
            this.ExtractValuesBtn.Size = new System.Drawing.Size(120, 23);
            this.ExtractValuesBtn.TabIndex = 7;
            this.ExtractValuesBtn.Text = "Extract Values";
            this.ExtractValuesBtn.Click += new System.EventHandler(this.ExtractValuesBtn_Click);
            // 
            // VL64ValueTxt
            // 
            this.VL64ValueTxt.Location = new System.Drawing.Point(334, 74);
            this.VL64ValueTxt.Name = "VL64ValueTxt";
            this.VL64ValueTxt.ReadOnly = true;
            this.VL64ValueTxt.Size = new System.Drawing.Size(120, 20);
            this.VL64ValueTxt.TabIndex = 6;
            this.VL64ValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VL64ValueLbl
            // 
            this.VL64ValueLbl.AutoSize = true;
            this.VL64ValueLbl.Location = new System.Drawing.Point(331, 58);
            this.VL64ValueLbl.Name = "VL64ValueLbl";
            this.VL64ValueLbl.Size = new System.Drawing.Size(34, 13);
            this.VL64ValueLbl.TabIndex = 5;
            this.VL64ValueLbl.Text = "Value";
            // 
            // VL64ChunkTxt
            // 
            this.VL64ChunkTxt.Location = new System.Drawing.Point(208, 74);
            this.VL64ChunkTxt.Name = "VL64ChunkTxt";
            this.VL64ChunkTxt.ReadOnly = true;
            this.VL64ChunkTxt.Size = new System.Drawing.Size(120, 20);
            this.VL64ChunkTxt.TabIndex = 4;
            this.VL64ChunkTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VL64ChunkLbl
            // 
            this.VL64ChunkLbl.AutoSize = true;
            this.VL64ChunkLbl.Location = new System.Drawing.Point(208, 58);
            this.VL64ChunkLbl.Name = "VL64ChunkLbl";
            this.VL64ChunkLbl.Size = new System.Drawing.Size(38, 13);
            this.VL64ChunkLbl.TabIndex = 3;
            this.VL64ChunkLbl.Text = "Chunk";
            // 
            // VL64StringTxt
            // 
            this.VL64StringTxt.Location = new System.Drawing.Point(208, 35);
            this.VL64StringTxt.Name = "VL64StringTxt";
            this.VL64StringTxt.Size = new System.Drawing.Size(246, 20);
            this.VL64StringTxt.TabIndex = 2;
            this.VL64StringTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VL64StringLbl
            // 
            this.VL64StringLbl.AutoSize = true;
            this.VL64StringLbl.Location = new System.Drawing.Point(208, 19);
            this.VL64StringLbl.Name = "VL64StringLbl";
            this.VL64StringLbl.Size = new System.Drawing.Size(62, 13);
            this.VL64StringLbl.TabIndex = 1;
            this.VL64StringLbl.Text = "VL64 String";
            // 
            // VL64Chunks
            // 
            this.VL64Chunks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChunkCol,
            this.ValueCol});
            this.VL64Chunks.FullRowSelect = true;
            this.VL64Chunks.GridLines = true;
            this.VL64Chunks.Location = new System.Drawing.Point(6, 19);
            this.VL64Chunks.MultiSelect = false;
            this.VL64Chunks.Name = "VL64Chunks";
            this.VL64Chunks.Size = new System.Drawing.Size(196, 110);
            this.VL64Chunks.TabIndex = 0;
            this.VL64Chunks.UseCompatibleStateImageBehavior = false;
            this.VL64Chunks.View = System.Windows.Forms.View.Details;
            this.VL64Chunks.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.VL64Chunks_ColumnWidthChanging);
            this.VL64Chunks.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.VL64Chunks_ItemSelectionChanged);
            // 
            // ChunkCol
            // 
            this.ChunkCol.Text = "Chunk";
            this.ChunkCol.Width = 87;
            // 
            // ValueCol
            // 
            this.ValueCol.Text = "Value";
            this.ValueCol.Width = 87;
            // 
            // AncientEncodingGrpbx
            // 
            this.AncientEncodingGrpbx.Controls.Add(this.AncientShortOutputTxt);
            this.AncientEncodingGrpbx.Controls.Add(this.AncientIntegerOutputTxt);
            this.AncientEncodingGrpbx.Controls.Add(this.AncientShortInputTxt);
            this.AncientEncodingGrpbx.Controls.Add(this.AncientCypherShortBtn);
            this.AncientEncodingGrpbx.Controls.Add(this.AncientCypherIntegerBtn);
            this.AncientEncodingGrpbx.Controls.Add(this.AncientDecypherShortBtn);
            this.AncientEncodingGrpbx.Controls.Add(this.AncientDecypherIntegerBtn);
            this.AncientEncodingGrpbx.Controls.Add(this.AncientIntegerInputTxt);
            this.AncientEncodingGrpbx.Location = new System.Drawing.Point(6, 89);
            this.AncientEncodingGrpbx.Name = "AncientEncodingGrpbx";
            this.AncientEncodingGrpbx.Size = new System.Drawing.Size(459, 79);
            this.AncientEncodingGrpbx.TabIndex = 19;
            this.AncientEncodingGrpbx.TabStop = false;
            this.AncientEncodingGrpbx.Text = "Ancient Encoding ( Base64/VL64 )";
            // 
            // AncientShortOutputTxt
            // 
            this.AncientShortOutputTxt.Location = new System.Drawing.Point(233, 50);
            this.AncientShortOutputTxt.Name = "AncientShortOutputTxt";
            this.AncientShortOutputTxt.Size = new System.Drawing.Size(117, 20);
            this.AncientShortOutputTxt.TabIndex = 17;
            this.AncientShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AncientIntegerOutputTxt
            // 
            this.AncientIntegerOutputTxt.Location = new System.Drawing.Point(233, 21);
            this.AncientIntegerOutputTxt.Name = "AncientIntegerOutputTxt";
            this.AncientIntegerOutputTxt.Size = new System.Drawing.Size(117, 20);
            this.AncientIntegerOutputTxt.TabIndex = 16;
            this.AncientIntegerOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AncientShortInputTxt
            // 
            this.AncientShortInputTxt.Location = new System.Drawing.Point(110, 50);
            this.AncientShortInputTxt.Name = "AncientShortInputTxt";
            this.AncientShortInputTxt.Size = new System.Drawing.Size(117, 20);
            this.AncientShortInputTxt.TabIndex = 15;
            this.AncientShortInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AncientCypherShortBtn
            // 
            this.AncientCypherShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.AncientCypherShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AncientCypherShortBtn.Location = new System.Drawing.Point(6, 48);
            this.AncientCypherShortBtn.Name = "AncientCypherShortBtn";
            this.AncientCypherShortBtn.Size = new System.Drawing.Size(98, 23);
            this.AncientCypherShortBtn.TabIndex = 12;
            this.AncientCypherShortBtn.Text = "Cypher Short";
            this.AncientCypherShortBtn.Click += new System.EventHandler(this.AncientCypherShortBtn_Click);
            // 
            // AncientCypherIntegerBtn
            // 
            this.AncientCypherIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.AncientCypherIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AncientCypherIntegerBtn.Location = new System.Drawing.Point(6, 19);
            this.AncientCypherIntegerBtn.Name = "AncientCypherIntegerBtn";
            this.AncientCypherIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.AncientCypherIntegerBtn.TabIndex = 11;
            this.AncientCypherIntegerBtn.Text = "Cypher Integer";
            this.AncientCypherIntegerBtn.Click += new System.EventHandler(this.AncientCypherIntegerBtn_Click);
            // 
            // AncientDecypherShortBtn
            // 
            this.AncientDecypherShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.AncientDecypherShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AncientDecypherShortBtn.Location = new System.Drawing.Point(356, 48);
            this.AncientDecypherShortBtn.Name = "AncientDecypherShortBtn";
            this.AncientDecypherShortBtn.Size = new System.Drawing.Size(98, 23);
            this.AncientDecypherShortBtn.TabIndex = 14;
            this.AncientDecypherShortBtn.Text = "Decypher Short";
            this.AncientDecypherShortBtn.Click += new System.EventHandler(this.AncientDecypherShortBtn_Click);
            // 
            // AncientDecypherIntegerBtn
            // 
            this.AncientDecypherIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.AncientDecypherIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AncientDecypherIntegerBtn.Location = new System.Drawing.Point(356, 19);
            this.AncientDecypherIntegerBtn.Name = "AncientDecypherIntegerBtn";
            this.AncientDecypherIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.AncientDecypherIntegerBtn.TabIndex = 13;
            this.AncientDecypherIntegerBtn.Text = "Decypher Integer";
            this.AncientDecypherIntegerBtn.Click += new System.EventHandler(this.AncientDecypherIntegerBtn_Click);
            // 
            // AncientIntegerInputTxt
            // 
            this.AncientIntegerInputTxt.Location = new System.Drawing.Point(110, 21);
            this.AncientIntegerInputTxt.Name = "AncientIntegerInputTxt";
            this.AncientIntegerInputTxt.Size = new System.Drawing.Size(117, 20);
            this.AncientIntegerInputTxt.TabIndex = 10;
            this.AncientIntegerInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToolboxTab
            // 
            this.ToolboxTab.BackColor = System.Drawing.Color.White;
            this.ToolboxTab.Location = new System.Drawing.Point(4, 28);
            this.ToolboxTab.Name = "ToolboxTab";
            this.ToolboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.ToolboxTab.Size = new System.Drawing.Size(471, 313);
            this.ToolboxTab.TabIndex = 2;
            this.ToolboxTab.Text = "Toolbox";
            // 
            // ExtensionsTab
            // 
            this.ExtensionsTab.BackColor = System.Drawing.Color.White;
            this.ExtensionsTab.Controls.Add(this.ETanjiExtensionViewer);
            this.ExtensionsTab.Location = new System.Drawing.Point(4, 28);
            this.ExtensionsTab.Name = "ExtensionsTab";
            this.ExtensionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExtensionsTab.Size = new System.Drawing.Size(471, 313);
            this.ExtensionsTab.TabIndex = 5;
            this.ExtensionsTab.Text = "Extensions";
            // 
            // ETanjiExtensionViewer
            // 
            this.ETanjiExtensionViewer.AllowDrop = true;
            this.ETanjiExtensionViewer.ContextMenuStrip = this.EExtensionsMenu;
            this.ETanjiExtensionViewer.Contractor = null;
            this.ETanjiExtensionViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ETanjiExtensionViewer.FullRowSelect = true;
            this.ETanjiExtensionViewer.GridLines = true;
            this.ETanjiExtensionViewer.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ETanjiExtensionViewer.Location = new System.Drawing.Point(3, 3);
            this.ETanjiExtensionViewer.LockColumns = true;
            this.ETanjiExtensionViewer.MultiSelect = false;
            this.ETanjiExtensionViewer.Name = "ETanjiExtensionViewer";
            this.ETanjiExtensionViewer.ShowItemToolTips = true;
            this.ETanjiExtensionViewer.Size = new System.Drawing.Size(465, 307);
            this.ETanjiExtensionViewer.TabIndex = 0;
            this.ETanjiExtensionViewer.UseCompatibleStateImageBehavior = false;
            this.ETanjiExtensionViewer.View = System.Windows.Forms.View.Details;
            this.ETanjiExtensionViewer.ItemActivate += new System.EventHandler(this.ETanjiExtensionViewer_ItemActivate);
            this.ETanjiExtensionViewer.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ETanjiExtensionViewer_ItemSelectionChanged);
            this.ETanjiExtensionViewer.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExtensionViewer_DragDrop);
            this.ETanjiExtensionViewer.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExtensionViewer_DragEnter);
            // 
            // EExtensionsMenu
            // 
            this.EExtensionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EOpenBtn,
            this.EUninstallBtn,
            this.EExtensionsSeperator,
            this.EInstallExtensionBtn});
            this.EExtensionsMenu.Name = "ConstructMenu";
            this.EExtensionsMenu.Size = new System.Drawing.Size(159, 76);
            // 
            // EOpenBtn
            // 
            this.EOpenBtn.Enabled = false;
            this.EOpenBtn.Name = "EOpenBtn";
            this.EOpenBtn.Size = new System.Drawing.Size(158, 22);
            this.EOpenBtn.Text = "Open";
            this.EOpenBtn.Click += new System.EventHandler(this.EOpenBtn_Click);
            // 
            // EUninstallBtn
            // 
            this.EUninstallBtn.Enabled = false;
            this.EUninstallBtn.Name = "EUninstallBtn";
            this.EUninstallBtn.Size = new System.Drawing.Size(158, 22);
            this.EUninstallBtn.Text = "Uninstall";
            this.EUninstallBtn.Click += new System.EventHandler(this.EUninstallBtn_Click);
            // 
            // EExtensionsSeperator
            // 
            this.EExtensionsSeperator.Name = "EExtensionsSeperator";
            this.EExtensionsSeperator.Size = new System.Drawing.Size(155, 6);
            // 
            // EInstallExtensionBtn
            // 
            this.EInstallExtensionBtn.Name = "EInstallExtensionBtn";
            this.EInstallExtensionBtn.Size = new System.Drawing.Size(158, 22);
            this.EInstallExtensionBtn.Text = "Install Extension";
            this.EInstallExtensionBtn.Click += new System.EventHandler(this.EInstallExtensionBtn_Click);
            // 
            // OptionsTab
            // 
            this.OptionsTab.BackColor = System.Drawing.Color.White;
            this.OptionsTab.Location = new System.Drawing.Point(4, 28);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsTab.Size = new System.Drawing.Size(471, 313);
            this.OptionsTab.TabIndex = 4;
            this.OptionsTab.Text = "Options";
            // 
            // ChooseExtensionDlg
            // 
            this.ChooseExtensionDlg.DefaultExt = "dll";
            this.ChooseExtensionDlg.Filter = "Dynamic Link Library (*.dll)|*.dll";
            this.ChooseExtensionDlg.Title = "Tanji ~ Choose Extension";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 369);
            this.Controls.Add(this.TanjiTabs);
            this.Controls.Add(this.TanjiStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji  ~ Connected[Host:Port]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.TanjiTabs.ResumeLayout(false);
            this.InjectionTab.ResumeLayout(false);
            this.InjectionTab.PerformLayout();
            this.IInjectionTabs.ResumeLayout(false);
            this.IConstructerTab.ResumeLayout(false);
            this.IConstructerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICCountTxt)).EndInit();
            this.ICConstructMenu.ResumeLayout(false);
            this.ISchedulerTab.ResumeLayout(false);
            this.ISchedulerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).EndInit();
            this.IPrimitiveTab.ResumeLayout(false);
            this.IPrimitiveTab.PerformLayout();
            this.EncoderDecoderTab.ResumeLayout(false);
            this.ModernEncodingGrpbx.ResumeLayout(false);
            this.ModernEncodingGrpbx.PerformLayout();
            this.EDAdvVL64DecoderGrpbx.ResumeLayout(false);
            this.EDAdvVL64DecoderGrpbx.PerformLayout();
            this.AncientEncodingGrpbx.ResumeLayout(false);
            this.AncientEncodingGrpbx.PerformLayout();
            this.ExtensionsTab.ResumeLayout(false);
            this.EExtensionsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip TanjiStrip;
        private System.Windows.Forms.ToolStripStatusLabel SchedulesTxt;
        private System.Windows.Forms.TabPage EncoderDecoderTab;
        private System.Windows.Forms.TabPage InjectionTab;
        private Controls.TanjiTabControl TanjiTabs;
        private System.Windows.Forms.TabPage ToolboxTab;
        private System.Windows.Forms.TabPage OptionsTab;
        private Controls.TanjiTabControl IInjectionTabs;
        private System.Windows.Forms.TabPage IPrimitiveTab;
        private System.Windows.Forms.TabPage IConstructerTab;
        private System.Windows.Forms.TextBox IPacketTxt;
        private Controls.TanjiButton PSendToClientBtn;
        private Controls.TanjiButton PSendToServerBtn;
        private System.Windows.Forms.TabPage ISchedulerTab;
        private System.Windows.Forms.TabPage ITriggersTab;
        private System.Windows.Forms.TabPage IFiltersTab;
        private System.Windows.Forms.GroupBox EDAdvVL64DecoderGrpbx;
        private System.Windows.Forms.Label ChunksFoundLbl;
        private Controls.TanjiButton ExtractValuesBtn;
        private System.Windows.Forms.TextBox VL64ValueTxt;
        private System.Windows.Forms.Label VL64ValueLbl;
        private System.Windows.Forms.TextBox VL64ChunkTxt;
        private System.Windows.Forms.Label VL64ChunkLbl;
        private System.Windows.Forms.TextBox VL64StringTxt;
        private System.Windows.Forms.Label VL64StringLbl;
        private System.Windows.Forms.ListView VL64Chunks;
        private System.Windows.Forms.ColumnHeader ChunkCol;
        private System.Windows.Forms.ColumnHeader ValueCol;
        private System.Windows.Forms.GroupBox AncientEncodingGrpbx;
        private System.Windows.Forms.TextBox AncientShortOutputTxt;
        private System.Windows.Forms.TextBox AncientIntegerOutputTxt;
        private System.Windows.Forms.TextBox AncientShortInputTxt;
        private Controls.TanjiButton AncientCypherShortBtn;
        private Controls.TanjiButton AncientCypherIntegerBtn;
        private Controls.TanjiButton AncientDecypherShortBtn;
        private Controls.TanjiButton AncientDecypherIntegerBtn;
        private System.Windows.Forms.TextBox AncientIntegerInputTxt;
        private System.Windows.Forms.ToolStripStatusLabel ExtensionsInstalledTxt;
        private System.Windows.Forms.GroupBox ModernEncodingGrpbx;
        private System.Windows.Forms.TextBox ModernShortOutputTxt;
        private System.Windows.Forms.TextBox ModernIntegerOutputTxt;
        private System.Windows.Forms.TextBox ModernShortInputTxt;
        private Controls.TanjiButton ModernCypherShortBtn;
        private Controls.TanjiButton ModernCypherIntegerBtn;
        private Controls.TanjiButton ModernDecypherShortBtn;
        private Controls.TanjiButton ModernDecypherIntegerBtn;
        private System.Windows.Forms.TextBox ModernIntegerInputTxt;
        private System.Windows.Forms.TabPage ExtensionsTab;
        private Sulakore.Protocol.Controls.Constructer ICTanjiConstructer;
        private System.Windows.Forms.Label ICHeaderLbl;
        private System.Windows.Forms.TextBox ICHeaderTxt;
        private System.Windows.Forms.Label ICValueLbl;
        private System.Windows.Forms.TextBox ICValueTxt;
        private Controls.TanjiButton ICAppendBooleanBtn;
        private Controls.TanjiButton ICAppendStringBtn;
        private Controls.TanjiButton ICAppendIntegerBtn;
        private Controls.TanjiButton ICClearBtn;
        private Controls.TanjiButton ICEditBtn;
        private Controls.TanjiButton ICRemoveBtn;
        private Controls.TanjiButton ICTransferBtn;
        private Controls.TanjiButton ICMoveDownBtn;
        private Controls.TanjiButton ICMoveUpBtn;
        private System.Windows.Forms.ContextMenuStrip ICConstructMenu;
        private System.Windows.Forms.ToolStripMenuItem ICSendToClientBtn;
        private System.Windows.Forms.ToolStripMenuItem ICSendToServerBtn;
        private System.Windows.Forms.ToolStripSeparator IConstructSeperator;
        private System.Windows.Forms.ToolStripMenuItem ICCopyPacketBtn;
        private System.Windows.Forms.ToolStripStatusLabel ProtocolTxt;
        private System.Windows.Forms.ContextMenuStrip EExtensionsMenu;
        private System.Windows.Forms.ToolStripMenuItem EOpenBtn;
        private System.Windows.Forms.ToolStripMenuItem EUninstallBtn;
        private System.Windows.Forms.ToolStripSeparator EExtensionsSeperator;
        private System.Windows.Forms.ToolStripMenuItem EInstallExtensionBtn;
        private System.Windows.Forms.Label ISBurstLbl;
        private System.Windows.Forms.NumericUpDown ISBurstTxt;
        private System.Windows.Forms.Label ISIntervalLbl;
        private System.Windows.Forms.NumericUpDown ISIntervalTxt;
        private System.Windows.Forms.Label ISDirectionLbl;
        private System.Windows.Forms.ComboBox ISDirectionTxt;
        private System.Windows.Forms.Label ISPacketLbl;
        private System.Windows.Forms.TextBox ISPacketTxt;
        private System.Windows.Forms.Label ISDescriptionLbl;
        private System.Windows.Forms.TextBox ISDescriptionTxt;
        private Controls.TanjiButton ISToggleBtn;
        private Controls.TanjiButton ISStopAllBtn;
        private Controls.TanjiButton ISEditBtn;
        private Controls.TanjiButton ISRemoveBtn;
        private Controls.TanjiButton ISCreateBtn;
        private Sulakore.Protocol.Controls.Scheduler ISTanjiScheduler;
        private System.Windows.Forms.OpenFileDialog ChooseExtensionDlg;
        private System.Windows.Forms.Label ICCountLbl;
        private System.Windows.Forms.NumericUpDown ICCountTxt;
        private System.Windows.Forms.TextBox IPPacketTxt;
        private System.Windows.Forms.Label IPPacketInfoLbl;
        private System.Windows.Forms.Label IPIsCorruptedLbl;
        private System.Windows.Forms.ToolStripMenuItem ICTransferToBtn;
        private System.Windows.Forms.ToolStripMenuItem ICSchedulerBtn;
        private System.Windows.Forms.CheckBox ISAutoStartChckbx;
        private Sulakore.Extensions.Controls.ExtensionView ETanjiExtensionViewer;

    }
}

