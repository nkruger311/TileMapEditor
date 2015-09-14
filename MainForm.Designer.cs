namespace TileMapEditor
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.grpTiles = new System.Windows.Forms.GroupBox();
      this.scContainer1 = new System.Windows.Forms.SplitContainer();
      this.flpRegularTiles = new System.Windows.Forms.FlowLayoutPanel();
      this.lblRegularTiles = new System.Windows.Forms.Label();
      this.scContainer2 = new System.Windows.Forms.SplitContainer();
      this.flpSolidTiles = new System.Windows.Forms.FlowLayoutPanel();
      this.lblSolidTiles = new System.Windows.Forms.Label();
      this.flpOverlayTiles = new System.Windows.Forms.FlowLayoutPanel();
      this.lblOverlayTiles = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiImport = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiImportTileSheet = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiImportMap = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsmiImportSongisms = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiExportTileSheet = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiExportMap = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlTileMap = new System.Windows.Forms.Panel();
      this.grpTools = new System.Windows.Forms.GroupBox();
      this.btnClearSelection = new System.Windows.Forms.Button();
      this.btnRefreshGrid = new System.Windows.Forms.Button();
      this.cmsTileSheetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsmiMove = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiMoveToRegular = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiMoveToSolid = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiMoveToOverlay = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiCopyToRegular = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiCopyToSolid = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiCopyToOverlay = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiRemoveTile = new System.Windows.Forms.ToolStripMenuItem();
      this.scMainContainer = new System.Windows.Forms.SplitContainer();
      this.tabEditingTools = new System.Windows.Forms.TabControl();
      this.tpgTiles = new System.Windows.Forms.TabPage();
      this.grpTileSheetSettings = new System.Windows.Forms.GroupBox();
      this.grpTileSheetTileDimensions = new System.Windows.Forms.GroupBox();
      this.nudTileSheetTileWidth = new System.Windows.Forms.NumericUpDown();
      this.nudTileSheetTileHeight = new System.Windows.Forms.NumericUpDown();
      this.lblTileSheetTileWidth = new System.Windows.Forms.Label();
      this.lblTileSheetTileHeight = new System.Windows.Forms.Label();
      this.grpTileSheetDimensions = new System.Windows.Forms.GroupBox();
      this.nudTileSheetColumnCount = new System.Windows.Forms.NumericUpDown();
      this.nudTileSheetRowCount = new System.Windows.Forms.NumericUpDown();
      this.lblTileSheetColumnCount = new System.Windows.Forms.Label();
      this.lblTileSheetRowCount = new System.Windows.Forms.Label();
      this.tpgSongisms = new System.Windows.Forms.TabPage();
      this.grpSongisms = new System.Windows.Forms.GroupBox();
      this.flpSongisms = new System.Windows.Forms.FlowLayoutPanel();
      this.scMapContainer = new System.Windows.Forms.SplitContainer();
      this.grpTileMap = new System.Windows.Forms.GroupBox();
      this.grpMapSettings = new System.Windows.Forms.GroupBox();
      this.grpMapTileHighlighting = new System.Windows.Forms.GroupBox();
      this.chkHighlightEntranceTiles = new System.Windows.Forms.CheckBox();
      this.chkHighlightOverlayTiles = new System.Windows.Forms.CheckBox();
      this.chkHighlightSolidTiles = new System.Windows.Forms.CheckBox();
      this.chkHighlightRegularTiles = new System.Windows.Forms.CheckBox();
      this.grpMapTileDimensions = new System.Windows.Forms.GroupBox();
      this.nudMapTileWidth = new System.Windows.Forms.NumericUpDown();
      this.nudMapTileHeight = new System.Windows.Forms.NumericUpDown();
      this.lblMapTileWidth = new System.Windows.Forms.Label();
      this.lblMapTileHeight = new System.Windows.Forms.Label();
      this.grpMapDimensions = new System.Windows.Forms.GroupBox();
      this.nudMapColumnCount = new System.Windows.Forms.NumericUpDown();
      this.nudMapRowCount = new System.Windows.Forms.NumericUpDown();
      this.lblMapColumnCount = new System.Windows.Forms.Label();
      this.lblMapRowCount = new System.Windows.Forms.Label();
      this.txtMapName = new System.Windows.Forms.TextBox();
      this.lblMapName = new System.Windows.Forms.Label();
      this.cmsMapMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsmiMoveMapTile = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiMoveMapTileToRegular = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiMoveMapTileToSolid = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiMoveMapTileToOverlay = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiCopyMapTile = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiCopyMapTileToRegular = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiCopyMapTileToSolid = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiCopyMapTileToOverlay = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiClearMapTileSelection = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.grpSongismAttributes = new System.Windows.Forms.GroupBox();
      this.pnlSongismAttributesControls = new System.Windows.Forms.Panel();
      this.pbSelectedTile = new TileMapEditor.TileSheetPictureBox();
      this.lblName = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblMapPosition = new System.Windows.Forms.Label();
      this.lblMapPositionX = new System.Windows.Forms.Label();
      this.nudMapPositionX = new System.Windows.Forms.NumericUpDown();
      this.lblMapPositionY = new System.Windows.Forms.Label();
      this.nudMapPositionY = new System.Windows.Forms.NumericUpDown();
      this.lblBoundingBox = new System.Windows.Forms.Label();
      this.lblBoundingBoxWidth = new System.Windows.Forms.Label();
      this.nudBoundingBoxWidth = new System.Windows.Forms.NumericUpDown();
      this.lblBoundingBoxHeight = new System.Windows.Forms.Label();
      this.nudBoundingBoxHeight = new System.Windows.Forms.NumericUpDown();
      this.lblBoundingBoxPositionX = new System.Windows.Forms.Label();
      this.nudBoundingBoxPositionX = new System.Windows.Forms.NumericUpDown();
      this.lblBoundingBoxPositionY = new System.Windows.Forms.Label();
      this.nudBoundingBoxPositionY = new System.Windows.Forms.NumericUpDown();
      this.lblState = new System.Windows.Forms.Label();
      this.cboState = new System.Windows.Forms.ComboBox();
      this.lblAlbumName = new System.Windows.Forms.Label();
      this.txtAlbumName = new System.Windows.Forms.TextBox();
      this.lblSongInfo = new System.Windows.Forms.Label();
      this.txtSongInfo = new System.Windows.Forms.TextBox();
      this.chkHasPrerequisiteSongism = new System.Windows.Forms.CheckBox();
      this.lblPrerequisiteSongism = new System.Windows.Forms.Label();
      this.txtPrerequisiteSongism = new System.Windows.Forms.TextBox();
      this.chkHasPrerequisiteInventoryItem = new System.Windows.Forms.CheckBox();
      this.lblPrerequisiteInventoryItem = new System.Windows.Forms.Label();
      this.txtPrerequisiteInventoryItem = new System.Windows.Forms.TextBox();
      this.grpTiles.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scContainer1)).BeginInit();
      this.scContainer1.Panel1.SuspendLayout();
      this.scContainer1.Panel2.SuspendLayout();
      this.scContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scContainer2)).BeginInit();
      this.scContainer2.Panel1.SuspendLayout();
      this.scContainer2.Panel2.SuspendLayout();
      this.scContainer2.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.grpTools.SuspendLayout();
      this.cmsTileSheetMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scMainContainer)).BeginInit();
      this.scMainContainer.Panel1.SuspendLayout();
      this.scMainContainer.Panel2.SuspendLayout();
      this.scMainContainer.SuspendLayout();
      this.tabEditingTools.SuspendLayout();
      this.tpgTiles.SuspendLayout();
      this.grpTileSheetSettings.SuspendLayout();
      this.grpTileSheetTileDimensions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudTileSheetTileWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudTileSheetTileHeight)).BeginInit();
      this.grpTileSheetDimensions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudTileSheetColumnCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudTileSheetRowCount)).BeginInit();
      this.tpgSongisms.SuspendLayout();
      this.grpSongisms.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scMapContainer)).BeginInit();
      this.scMapContainer.Panel1.SuspendLayout();
      this.scMapContainer.Panel2.SuspendLayout();
      this.scMapContainer.SuspendLayout();
      this.grpTileMap.SuspendLayout();
      this.grpMapSettings.SuspendLayout();
      this.grpMapTileHighlighting.SuspendLayout();
      this.grpMapTileDimensions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapTileWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapTileHeight)).BeginInit();
      this.grpMapDimensions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapColumnCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapRowCount)).BeginInit();
      this.cmsMapMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.grpSongismAttributes.SuspendLayout();
      this.pnlSongismAttributesControls.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbSelectedTile)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapPositionX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapPositionY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudBoundingBoxWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudBoundingBoxHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudBoundingBoxPositionX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudBoundingBoxPositionY)).BeginInit();
      this.SuspendLayout();
      // 
      // grpTiles
      // 
      this.grpTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpTiles.Controls.Add(this.scContainer1);
      this.grpTiles.Location = new System.Drawing.Point(6, 6);
      this.grpTiles.Name = "grpTiles";
      this.grpTiles.Size = new System.Drawing.Size(288, 263);
      this.grpTiles.TabIndex = 0;
      this.grpTiles.TabStop = false;
      this.grpTiles.Text = "Tiles";
      // 
      // scContainer1
      // 
      this.scContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.scContainer1.Location = new System.Drawing.Point(3, 16);
      this.scContainer1.Name = "scContainer1";
      this.scContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // scContainer1.Panel1
      // 
      this.scContainer1.Panel1.Controls.Add(this.flpRegularTiles);
      this.scContainer1.Panel1.Controls.Add(this.lblRegularTiles);
      // 
      // scContainer1.Panel2
      // 
      this.scContainer1.Panel2.Controls.Add(this.scContainer2);
      this.scContainer1.Size = new System.Drawing.Size(282, 244);
      this.scContainer1.SplitterDistance = 101;
      this.scContainer1.TabIndex = 0;
      // 
      // flpRegularTiles
      // 
      this.flpRegularTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flpRegularTiles.AutoScroll = true;
      this.flpRegularTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpRegularTiles.Location = new System.Drawing.Point(3, 25);
      this.flpRegularTiles.Name = "flpRegularTiles";
      this.flpRegularTiles.Size = new System.Drawing.Size(276, 73);
      this.flpRegularTiles.TabIndex = 0;
      // 
      // lblRegularTiles
      // 
      this.lblRegularTiles.AutoSize = true;
      this.lblRegularTiles.Location = new System.Drawing.Point(3, 0);
      this.lblRegularTiles.Name = "lblRegularTiles";
      this.lblRegularTiles.Size = new System.Drawing.Size(69, 13);
      this.lblRegularTiles.TabIndex = 1;
      this.lblRegularTiles.Text = "Regular Tiles";
      // 
      // scContainer2
      // 
      this.scContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.scContainer2.Location = new System.Drawing.Point(0, 0);
      this.scContainer2.Name = "scContainer2";
      this.scContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // scContainer2.Panel1
      // 
      this.scContainer2.Panel1.Controls.Add(this.flpSolidTiles);
      this.scContainer2.Panel1.Controls.Add(this.lblSolidTiles);
      // 
      // scContainer2.Panel2
      // 
      this.scContainer2.Panel2.Controls.Add(this.flpOverlayTiles);
      this.scContainer2.Panel2.Controls.Add(this.lblOverlayTiles);
      this.scContainer2.Size = new System.Drawing.Size(282, 139);
      this.scContainer2.SplitterDistance = 66;
      this.scContainer2.TabIndex = 0;
      // 
      // flpSolidTiles
      // 
      this.flpSolidTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flpSolidTiles.AutoScroll = true;
      this.flpSolidTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpSolidTiles.Location = new System.Drawing.Point(3, 16);
      this.flpSolidTiles.Name = "flpSolidTiles";
      this.flpSolidTiles.Size = new System.Drawing.Size(276, 47);
      this.flpSolidTiles.TabIndex = 1;
      // 
      // lblSolidTiles
      // 
      this.lblSolidTiles.AutoSize = true;
      this.lblSolidTiles.Location = new System.Drawing.Point(3, 0);
      this.lblSolidTiles.Name = "lblSolidTiles";
      this.lblSolidTiles.Size = new System.Drawing.Size(55, 13);
      this.lblSolidTiles.TabIndex = 0;
      this.lblSolidTiles.Text = "Solid Tiles";
      // 
      // flpOverlayTiles
      // 
      this.flpOverlayTiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flpOverlayTiles.AutoScroll = true;
      this.flpOverlayTiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.flpOverlayTiles.Location = new System.Drawing.Point(3, 16);
      this.flpOverlayTiles.Name = "flpOverlayTiles";
      this.flpOverlayTiles.Size = new System.Drawing.Size(276, 50);
      this.flpOverlayTiles.TabIndex = 1;
      // 
      // lblOverlayTiles
      // 
      this.lblOverlayTiles.AutoSize = true;
      this.lblOverlayTiles.Location = new System.Drawing.Point(3, 0);
      this.lblOverlayTiles.Name = "lblOverlayTiles";
      this.lblOverlayTiles.Size = new System.Drawing.Size(68, 13);
      this.lblOverlayTiles.TabIndex = 0;
      this.lblOverlayTiles.Text = "Overlay Tiles";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // tsmiFile
      // 
      this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImport,
            this.tsmiExport,
            this.toolStripSeparator1,
            this.tsmiExit});
      this.tsmiFile.Name = "tsmiFile";
      this.tsmiFile.Size = new System.Drawing.Size(37, 20);
      this.tsmiFile.Text = "&File";
      // 
      // tsmiImport
      // 
      this.tsmiImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImportTileSheet,
            this.tsmiImportMap,
            this.toolStripSeparator2,
            this.tsmiImportSongisms});
      this.tsmiImport.Name = "tsmiImport";
      this.tsmiImport.Size = new System.Drawing.Size(110, 22);
      this.tsmiImport.Text = "&Import";
      // 
      // tsmiImportTileSheet
      // 
      this.tsmiImportTileSheet.Name = "tsmiImportTileSheet";
      this.tsmiImportTileSheet.Size = new System.Drawing.Size(125, 22);
      this.tsmiImportTileSheet.Text = "&Tile Sheet";
      this.tsmiImportTileSheet.Click += new System.EventHandler(this.tsmiImportTileSheet_Click);
      // 
      // tsmiImportMap
      // 
      this.tsmiImportMap.Name = "tsmiImportMap";
      this.tsmiImportMap.Size = new System.Drawing.Size(125, 22);
      this.tsmiImportMap.Text = "&Map";
      this.tsmiImportMap.Click += new System.EventHandler(this.tsmiImportMap_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(122, 6);
      // 
      // tsmiImportSongisms
      // 
      this.tsmiImportSongisms.Name = "tsmiImportSongisms";
      this.tsmiImportSongisms.Size = new System.Drawing.Size(125, 22);
      this.tsmiImportSongisms.Text = "&Songisms";
      this.tsmiImportSongisms.Click += new System.EventHandler(this.tsmiImportSongisms_Click);
      // 
      // tsmiExport
      // 
      this.tsmiExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportTileSheet,
            this.tsmiExportMap});
      this.tsmiExport.Name = "tsmiExport";
      this.tsmiExport.Size = new System.Drawing.Size(110, 22);
      this.tsmiExport.Text = "&Export";
      // 
      // tsmiExportTileSheet
      // 
      this.tsmiExportTileSheet.Name = "tsmiExportTileSheet";
      this.tsmiExportTileSheet.Size = new System.Drawing.Size(125, 22);
      this.tsmiExportTileSheet.Text = "&Tile Sheet";
      this.tsmiExportTileSheet.Click += new System.EventHandler(this.tsmiExportTileSheet_Click);
      // 
      // tsmiExportMap
      // 
      this.tsmiExportMap.Name = "tsmiExportMap";
      this.tsmiExportMap.Size = new System.Drawing.Size(125, 22);
      this.tsmiExportMap.Text = "&Map";
      this.tsmiExportMap.Click += new System.EventHandler(this.tsmiExportMap_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(107, 6);
      // 
      // tsmiExit
      // 
      this.tsmiExit.Name = "tsmiExit";
      this.tsmiExit.Size = new System.Drawing.Size(110, 22);
      this.tsmiExit.Text = "E&xit";
      this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
      // 
      // pnlTileMap
      // 
      this.pnlTileMap.AllowDrop = true;
      this.pnlTileMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlTileMap.AutoScroll = true;
      this.pnlTileMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlTileMap.Location = new System.Drawing.Point(6, 19);
      this.pnlTileMap.Name = "pnlTileMap";
      this.pnlTileMap.Size = new System.Drawing.Size(536, 538);
      this.pnlTileMap.TabIndex = 2;
      this.pnlTileMap.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlTileMap_DragDrop);
      this.pnlTileMap.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlTileMap_DragEnter);
      this.pnlTileMap.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlTileMap_DragOver);
      this.pnlTileMap.DragLeave += new System.EventHandler(this.pnlTileMap_DragLeave);
      // 
      // grpTools
      // 
      this.grpTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpTools.Controls.Add(this.btnClearSelection);
      this.grpTools.Controls.Add(this.pbSelectedTile);
      this.grpTools.Location = new System.Drawing.Point(6, 275);
      this.grpTools.Name = "grpTools";
      this.grpTools.Size = new System.Drawing.Size(288, 89);
      this.grpTools.TabIndex = 3;
      this.grpTools.TabStop = false;
      this.grpTools.Text = "Selected Tile";
      // 
      // btnClearSelection
      // 
      this.btnClearSelection.Location = new System.Drawing.Point(76, 60);
      this.btnClearSelection.Name = "btnClearSelection";
      this.btnClearSelection.Size = new System.Drawing.Size(75, 23);
      this.btnClearSelection.TabIndex = 1;
      this.btnClearSelection.Text = "Clear";
      this.btnClearSelection.UseVisualStyleBackColor = true;
      this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
      // 
      // btnRefreshGrid
      // 
      this.btnRefreshGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRefreshGrid.Location = new System.Drawing.Point(119, 534);
      this.btnRefreshGrid.Name = "btnRefreshGrid";
      this.btnRefreshGrid.Size = new System.Drawing.Size(75, 23);
      this.btnRefreshGrid.TabIndex = 4;
      this.btnRefreshGrid.Text = "Refresh Grid";
      this.btnRefreshGrid.UseVisualStyleBackColor = true;
      this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
      // 
      // cmsTileSheetMenu
      // 
      this.cmsTileSheetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMove,
            this.tsmiCopy,
            this.tsmiRemoveTile});
      this.cmsTileSheetMenu.Name = "cmsTileSheetMenu";
      this.cmsTileSheetMenu.Size = new System.Drawing.Size(118, 70);
      this.cmsTileSheetMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTileSheetMenu_Opening);
      // 
      // tsmiMove
      // 
      this.tsmiMove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoveToRegular,
            this.tsmiMoveToSolid,
            this.tsmiMoveToOverlay});
      this.tsmiMove.Name = "tsmiMove";
      this.tsmiMove.Size = new System.Drawing.Size(117, 22);
      this.tsmiMove.Text = "Move";
      // 
      // tsmiMoveToRegular
      // 
      this.tsmiMoveToRegular.Name = "tsmiMoveToRegular";
      this.tsmiMoveToRegular.Size = new System.Drawing.Size(158, 22);
      this.tsmiMoveToRegular.Text = "To Regular Tiles";
      this.tsmiMoveToRegular.Click += new System.EventHandler(this.tsmiMoveToRegular_Click);
      // 
      // tsmiMoveToSolid
      // 
      this.tsmiMoveToSolid.Name = "tsmiMoveToSolid";
      this.tsmiMoveToSolid.Size = new System.Drawing.Size(158, 22);
      this.tsmiMoveToSolid.Text = "To Solid Tiles";
      this.tsmiMoveToSolid.Click += new System.EventHandler(this.tsmiMoveToSolid_Click);
      // 
      // tsmiMoveToOverlay
      // 
      this.tsmiMoveToOverlay.Name = "tsmiMoveToOverlay";
      this.tsmiMoveToOverlay.Size = new System.Drawing.Size(158, 22);
      this.tsmiMoveToOverlay.Text = "To Overlay Tiles";
      this.tsmiMoveToOverlay.Click += new System.EventHandler(this.tsmiMoveToOverlay_Click);
      // 
      // tsmiCopy
      // 
      this.tsmiCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyToRegular,
            this.tsmiCopyToSolid,
            this.tsmiCopyToOverlay});
      this.tsmiCopy.Name = "tsmiCopy";
      this.tsmiCopy.Size = new System.Drawing.Size(117, 22);
      this.tsmiCopy.Text = "Copy";
      // 
      // tsmiCopyToRegular
      // 
      this.tsmiCopyToRegular.Name = "tsmiCopyToRegular";
      this.tsmiCopyToRegular.Size = new System.Drawing.Size(158, 22);
      this.tsmiCopyToRegular.Text = "To Regular Tiles";
      this.tsmiCopyToRegular.Click += new System.EventHandler(this.tsmiCopyToRegular_Click);
      // 
      // tsmiCopyToSolid
      // 
      this.tsmiCopyToSolid.Name = "tsmiCopyToSolid";
      this.tsmiCopyToSolid.Size = new System.Drawing.Size(158, 22);
      this.tsmiCopyToSolid.Text = "To Solid Tiles";
      this.tsmiCopyToSolid.Click += new System.EventHandler(this.tsmiCopyToSolid_Click);
      // 
      // tsmiCopyToOverlay
      // 
      this.tsmiCopyToOverlay.Name = "tsmiCopyToOverlay";
      this.tsmiCopyToOverlay.Size = new System.Drawing.Size(158, 22);
      this.tsmiCopyToOverlay.Text = "To Overlay Tiles";
      this.tsmiCopyToOverlay.Click += new System.EventHandler(this.tsmiCopyToOverlay_Click);
      // 
      // tsmiRemoveTile
      // 
      this.tsmiRemoveTile.Name = "tsmiRemoveTile";
      this.tsmiRemoveTile.Size = new System.Drawing.Size(117, 22);
      this.tsmiRemoveTile.Text = "Remove";
      this.tsmiRemoveTile.Click += new System.EventHandler(this.tsmiRemoveTile_Click);
      // 
      // scMainContainer
      // 
      this.scMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scMainContainer.Location = new System.Drawing.Point(12, 27);
      this.scMainContainer.Name = "scMainContainer";
      // 
      // scMainContainer.Panel1
      // 
      this.scMainContainer.Panel1.Controls.Add(this.tabEditingTools);
      // 
      // scMainContainer.Panel2
      // 
      this.scMainContainer.Panel2.Controls.Add(this.scMapContainer);
      this.scMainContainer.Size = new System.Drawing.Size(1082, 575);
      this.scMainContainer.SplitterDistance = 308;
      this.scMainContainer.TabIndex = 5;
      // 
      // tabEditingTools
      // 
      this.tabEditingTools.Controls.Add(this.tpgTiles);
      this.tabEditingTools.Controls.Add(this.tpgSongisms);
      this.tabEditingTools.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabEditingTools.Location = new System.Drawing.Point(0, 0);
      this.tabEditingTools.Name = "tabEditingTools";
      this.tabEditingTools.SelectedIndex = 0;
      this.tabEditingTools.Size = new System.Drawing.Size(308, 575);
      this.tabEditingTools.TabIndex = 0;
      // 
      // tpgTiles
      // 
      this.tpgTiles.Controls.Add(this.grpTools);
      this.tpgTiles.Controls.Add(this.grpTileSheetSettings);
      this.tpgTiles.Controls.Add(this.grpTiles);
      this.tpgTiles.Location = new System.Drawing.Point(4, 22);
      this.tpgTiles.Name = "tpgTiles";
      this.tpgTiles.Padding = new System.Windows.Forms.Padding(3);
      this.tpgTiles.Size = new System.Drawing.Size(300, 549);
      this.tpgTiles.TabIndex = 0;
      this.tpgTiles.Text = "Tiles";
      this.tpgTiles.UseVisualStyleBackColor = true;
      // 
      // grpTileSheetSettings
      // 
      this.grpTileSheetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpTileSheetSettings.Controls.Add(this.grpTileSheetTileDimensions);
      this.grpTileSheetSettings.Controls.Add(this.grpTileSheetDimensions);
      this.grpTileSheetSettings.Location = new System.Drawing.Point(6, 370);
      this.grpTileSheetSettings.Name = "grpTileSheetSettings";
      this.grpTileSheetSettings.Size = new System.Drawing.Size(288, 173);
      this.grpTileSheetSettings.TabIndex = 4;
      this.grpTileSheetSettings.TabStop = false;
      this.grpTileSheetSettings.Text = "Tile Sheet Settings";
      // 
      // grpTileSheetTileDimensions
      // 
      this.grpTileSheetTileDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpTileSheetTileDimensions.Controls.Add(this.nudTileSheetTileWidth);
      this.grpTileSheetTileDimensions.Controls.Add(this.nudTileSheetTileHeight);
      this.grpTileSheetTileDimensions.Controls.Add(this.lblTileSheetTileWidth);
      this.grpTileSheetTileDimensions.Controls.Add(this.lblTileSheetTileHeight);
      this.grpTileSheetTileDimensions.Location = new System.Drawing.Point(6, 96);
      this.grpTileSheetTileDimensions.Name = "grpTileSheetTileDimensions";
      this.grpTileSheetTileDimensions.Size = new System.Drawing.Size(276, 71);
      this.grpTileSheetTileDimensions.TabIndex = 5;
      this.grpTileSheetTileDimensions.TabStop = false;
      this.grpTileSheetTileDimensions.Text = "Tile Dimensions";
      // 
      // nudTileSheetTileWidth
      // 
      this.nudTileSheetTileWidth.Location = new System.Drawing.Point(98, 45);
      this.nudTileSheetTileWidth.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
      this.nudTileSheetTileWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nudTileSheetTileWidth.Name = "nudTileSheetTileWidth";
      this.nudTileSheetTileWidth.Size = new System.Drawing.Size(42, 20);
      this.nudTileSheetTileWidth.TabIndex = 5;
      this.nudTileSheetTileWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nudTileSheetTileWidth.ValueChanged += new System.EventHandler(this.nudTileSheetTileWidth_ValueChanged);
      // 
      // nudTileSheetTileHeight
      // 
      this.nudTileSheetTileHeight.Location = new System.Drawing.Point(98, 19);
      this.nudTileSheetTileHeight.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
      this.nudTileSheetTileHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nudTileSheetTileHeight.Name = "nudTileSheetTileHeight";
      this.nudTileSheetTileHeight.Size = new System.Drawing.Size(42, 20);
      this.nudTileSheetTileHeight.TabIndex = 4;
      this.nudTileSheetTileHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nudTileSheetTileHeight.ValueChanged += new System.EventHandler(this.nudTileSheetTileHeight_ValueChanged);
      // 
      // lblTileSheetTileWidth
      // 
      this.lblTileSheetTileWidth.AutoSize = true;
      this.lblTileSheetTileWidth.Location = new System.Drawing.Point(6, 47);
      this.lblTileSheetTileWidth.Name = "lblTileSheetTileWidth";
      this.lblTileSheetTileWidth.Size = new System.Drawing.Size(35, 13);
      this.lblTileSheetTileWidth.TabIndex = 2;
      this.lblTileSheetTileWidth.Text = "Width";
      // 
      // lblTileSheetTileHeight
      // 
      this.lblTileSheetTileHeight.AutoSize = true;
      this.lblTileSheetTileHeight.Location = new System.Drawing.Point(6, 21);
      this.lblTileSheetTileHeight.Name = "lblTileSheetTileHeight";
      this.lblTileSheetTileHeight.Size = new System.Drawing.Size(38, 13);
      this.lblTileSheetTileHeight.TabIndex = 0;
      this.lblTileSheetTileHeight.Text = "Height";
      // 
      // grpTileSheetDimensions
      // 
      this.grpTileSheetDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpTileSheetDimensions.Controls.Add(this.nudTileSheetColumnCount);
      this.grpTileSheetDimensions.Controls.Add(this.nudTileSheetRowCount);
      this.grpTileSheetDimensions.Controls.Add(this.lblTileSheetColumnCount);
      this.grpTileSheetDimensions.Controls.Add(this.lblTileSheetRowCount);
      this.grpTileSheetDimensions.Location = new System.Drawing.Point(6, 19);
      this.grpTileSheetDimensions.Name = "grpTileSheetDimensions";
      this.grpTileSheetDimensions.Size = new System.Drawing.Size(276, 71);
      this.grpTileSheetDimensions.TabIndex = 3;
      this.grpTileSheetDimensions.TabStop = false;
      this.grpTileSheetDimensions.Text = "Tile Sheet Dimensions";
      // 
      // nudTileSheetColumnCount
      // 
      this.nudTileSheetColumnCount.Location = new System.Drawing.Point(98, 45);
      this.nudTileSheetColumnCount.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nudTileSheetColumnCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudTileSheetColumnCount.Name = "nudTileSheetColumnCount";
      this.nudTileSheetColumnCount.Size = new System.Drawing.Size(42, 20);
      this.nudTileSheetColumnCount.TabIndex = 5;
      this.nudTileSheetColumnCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
      // 
      // nudTileSheetRowCount
      // 
      this.nudTileSheetRowCount.Location = new System.Drawing.Point(98, 19);
      this.nudTileSheetRowCount.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nudTileSheetRowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudTileSheetRowCount.Name = "nudTileSheetRowCount";
      this.nudTileSheetRowCount.Size = new System.Drawing.Size(42, 20);
      this.nudTileSheetRowCount.TabIndex = 4;
      this.nudTileSheetRowCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
      // 
      // lblTileSheetColumnCount
      // 
      this.lblTileSheetColumnCount.AutoSize = true;
      this.lblTileSheetColumnCount.Location = new System.Drawing.Point(6, 47);
      this.lblTileSheetColumnCount.Name = "lblTileSheetColumnCount";
      this.lblTileSheetColumnCount.Size = new System.Drawing.Size(73, 13);
      this.lblTileSheetColumnCount.TabIndex = 2;
      this.lblTileSheetColumnCount.Text = "Column Count";
      // 
      // lblTileSheetRowCount
      // 
      this.lblTileSheetRowCount.AutoSize = true;
      this.lblTileSheetRowCount.Location = new System.Drawing.Point(6, 21);
      this.lblTileSheetRowCount.Name = "lblTileSheetRowCount";
      this.lblTileSheetRowCount.Size = new System.Drawing.Size(60, 13);
      this.lblTileSheetRowCount.TabIndex = 0;
      this.lblTileSheetRowCount.Text = "Row Count";
      // 
      // tpgSongisms
      // 
      this.tpgSongisms.Controls.Add(this.splitContainer1);
      this.tpgSongisms.Location = new System.Drawing.Point(4, 22);
      this.tpgSongisms.Name = "tpgSongisms";
      this.tpgSongisms.Padding = new System.Windows.Forms.Padding(3);
      this.tpgSongisms.Size = new System.Drawing.Size(300, 549);
      this.tpgSongisms.TabIndex = 1;
      this.tpgSongisms.Text = "Songisms";
      this.tpgSongisms.UseVisualStyleBackColor = true;
      // 
      // grpSongisms
      // 
      this.grpSongisms.Controls.Add(this.flpSongisms);
      this.grpSongisms.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpSongisms.Location = new System.Drawing.Point(0, 0);
      this.grpSongisms.Name = "grpSongisms";
      this.grpSongisms.Size = new System.Drawing.Size(294, 229);
      this.grpSongisms.TabIndex = 0;
      this.grpSongisms.TabStop = false;
      this.grpSongisms.Text = "Songisms";
      // 
      // flpSongisms
      // 
      this.flpSongisms.AutoScroll = true;
      this.flpSongisms.BackColor = System.Drawing.Color.Transparent;
      this.flpSongisms.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flpSongisms.Location = new System.Drawing.Point(3, 16);
      this.flpSongisms.Name = "flpSongisms";
      this.flpSongisms.Size = new System.Drawing.Size(288, 210);
      this.flpSongisms.TabIndex = 0;
      // 
      // scMapContainer
      // 
      this.scMapContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scMapContainer.Location = new System.Drawing.Point(3, 3);
      this.scMapContainer.Name = "scMapContainer";
      // 
      // scMapContainer.Panel1
      // 
      this.scMapContainer.Panel1.Controls.Add(this.grpTileMap);
      // 
      // scMapContainer.Panel2
      // 
      this.scMapContainer.Panel2.Controls.Add(this.grpMapSettings);
      this.scMapContainer.Size = new System.Drawing.Size(764, 569);
      this.scMapContainer.SplitterDistance = 554;
      this.scMapContainer.TabIndex = 4;
      // 
      // grpTileMap
      // 
      this.grpTileMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpTileMap.Controls.Add(this.pnlTileMap);
      this.grpTileMap.Location = new System.Drawing.Point(3, 3);
      this.grpTileMap.Name = "grpTileMap";
      this.grpTileMap.Size = new System.Drawing.Size(548, 563);
      this.grpTileMap.TabIndex = 3;
      this.grpTileMap.TabStop = false;
      this.grpTileMap.Text = "Tile Map";
      // 
      // grpMapSettings
      // 
      this.grpMapSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpMapSettings.Controls.Add(this.grpMapTileHighlighting);
      this.grpMapSettings.Controls.Add(this.grpMapTileDimensions);
      this.grpMapSettings.Controls.Add(this.grpMapDimensions);
      this.grpMapSettings.Controls.Add(this.btnRefreshGrid);
      this.grpMapSettings.Controls.Add(this.txtMapName);
      this.grpMapSettings.Controls.Add(this.lblMapName);
      this.grpMapSettings.Location = new System.Drawing.Point(3, 3);
      this.grpMapSettings.Name = "grpMapSettings";
      this.grpMapSettings.Size = new System.Drawing.Size(200, 563);
      this.grpMapSettings.TabIndex = 0;
      this.grpMapSettings.TabStop = false;
      this.grpMapSettings.Text = "Map Settings";
      // 
      // grpMapTileHighlighting
      // 
      this.grpMapTileHighlighting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpMapTileHighlighting.Controls.Add(this.chkHighlightEntranceTiles);
      this.grpMapTileHighlighting.Controls.Add(this.chkHighlightOverlayTiles);
      this.grpMapTileHighlighting.Controls.Add(this.chkHighlightSolidTiles);
      this.grpMapTileHighlighting.Controls.Add(this.chkHighlightRegularTiles);
      this.grpMapTileHighlighting.Location = new System.Drawing.Point(6, 212);
      this.grpMapTileHighlighting.Name = "grpMapTileHighlighting";
      this.grpMapTileHighlighting.Size = new System.Drawing.Size(188, 111);
      this.grpMapTileHighlighting.TabIndex = 5;
      this.grpMapTileHighlighting.TabStop = false;
      this.grpMapTileHighlighting.Text = "Map Tile Highlighting";
      // 
      // chkHighlightEntranceTiles
      // 
      this.chkHighlightEntranceTiles.AutoSize = true;
      this.chkHighlightEntranceTiles.Location = new System.Drawing.Point(6, 88);
      this.chkHighlightEntranceTiles.Name = "chkHighlightEntranceTiles";
      this.chkHighlightEntranceTiles.Size = new System.Drawing.Size(94, 17);
      this.chkHighlightEntranceTiles.TabIndex = 3;
      this.chkHighlightEntranceTiles.Text = "Entrance Tiles";
      this.chkHighlightEntranceTiles.UseVisualStyleBackColor = true;
      // 
      // chkHighlightOverlayTiles
      // 
      this.chkHighlightOverlayTiles.AutoSize = true;
      this.chkHighlightOverlayTiles.Location = new System.Drawing.Point(6, 65);
      this.chkHighlightOverlayTiles.Name = "chkHighlightOverlayTiles";
      this.chkHighlightOverlayTiles.Size = new System.Drawing.Size(87, 17);
      this.chkHighlightOverlayTiles.TabIndex = 2;
      this.chkHighlightOverlayTiles.Text = "Overlay Tiles";
      this.chkHighlightOverlayTiles.UseVisualStyleBackColor = true;
      this.chkHighlightOverlayTiles.CheckedChanged += new System.EventHandler(this.chkHighlightOverlayTiles_CheckedChanged);
      // 
      // chkHighlightSolidTiles
      // 
      this.chkHighlightSolidTiles.AutoSize = true;
      this.chkHighlightSolidTiles.Location = new System.Drawing.Point(6, 42);
      this.chkHighlightSolidTiles.Name = "chkHighlightSolidTiles";
      this.chkHighlightSolidTiles.Size = new System.Drawing.Size(74, 17);
      this.chkHighlightSolidTiles.TabIndex = 1;
      this.chkHighlightSolidTiles.Text = "Solid Tiles";
      this.chkHighlightSolidTiles.UseVisualStyleBackColor = true;
      this.chkHighlightSolidTiles.CheckedChanged += new System.EventHandler(this.chkHighlightSolidTiles_CheckedChanged);
      // 
      // chkHighlightRegularTiles
      // 
      this.chkHighlightRegularTiles.AutoSize = true;
      this.chkHighlightRegularTiles.Location = new System.Drawing.Point(6, 19);
      this.chkHighlightRegularTiles.Name = "chkHighlightRegularTiles";
      this.chkHighlightRegularTiles.Size = new System.Drawing.Size(88, 17);
      this.chkHighlightRegularTiles.TabIndex = 0;
      this.chkHighlightRegularTiles.Text = "Regular Tiles";
      this.chkHighlightRegularTiles.UseVisualStyleBackColor = true;
      this.chkHighlightRegularTiles.CheckedChanged += new System.EventHandler(this.chkHighlightRegularTiles_CheckedChanged);
      // 
      // grpMapTileDimensions
      // 
      this.grpMapTileDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpMapTileDimensions.Controls.Add(this.nudMapTileWidth);
      this.grpMapTileDimensions.Controls.Add(this.nudMapTileHeight);
      this.grpMapTileDimensions.Controls.Add(this.lblMapTileWidth);
      this.grpMapTileDimensions.Controls.Add(this.lblMapTileHeight);
      this.grpMapTileDimensions.Location = new System.Drawing.Point(6, 135);
      this.grpMapTileDimensions.Name = "grpMapTileDimensions";
      this.grpMapTileDimensions.Size = new System.Drawing.Size(188, 71);
      this.grpMapTileDimensions.TabIndex = 4;
      this.grpMapTileDimensions.TabStop = false;
      this.grpMapTileDimensions.Text = "Tile Dimensions";
      // 
      // nudMapTileWidth
      // 
      this.nudMapTileWidth.Location = new System.Drawing.Point(98, 45);
      this.nudMapTileWidth.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
      this.nudMapTileWidth.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nudMapTileWidth.Name = "nudMapTileWidth";
      this.nudMapTileWidth.Size = new System.Drawing.Size(42, 20);
      this.nudMapTileWidth.TabIndex = 5;
      this.nudMapTileWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nudMapTileWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nudMapTileWidth.ValueChanged += new System.EventHandler(this.nudTileWidth_ValueChanged);
      // 
      // nudMapTileHeight
      // 
      this.nudMapTileHeight.Location = new System.Drawing.Point(98, 19);
      this.nudMapTileHeight.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
      this.nudMapTileHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nudMapTileHeight.Name = "nudMapTileHeight";
      this.nudMapTileHeight.Size = new System.Drawing.Size(42, 20);
      this.nudMapTileHeight.TabIndex = 4;
      this.nudMapTileHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nudMapTileHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nudMapTileHeight.ValueChanged += new System.EventHandler(this.nudTileHeight_ValueChanged);
      // 
      // lblMapTileWidth
      // 
      this.lblMapTileWidth.AutoSize = true;
      this.lblMapTileWidth.Location = new System.Drawing.Point(6, 47);
      this.lblMapTileWidth.Name = "lblMapTileWidth";
      this.lblMapTileWidth.Size = new System.Drawing.Size(35, 13);
      this.lblMapTileWidth.TabIndex = 2;
      this.lblMapTileWidth.Text = "Width";
      // 
      // lblMapTileHeight
      // 
      this.lblMapTileHeight.AutoSize = true;
      this.lblMapTileHeight.Location = new System.Drawing.Point(6, 21);
      this.lblMapTileHeight.Name = "lblMapTileHeight";
      this.lblMapTileHeight.Size = new System.Drawing.Size(38, 13);
      this.lblMapTileHeight.TabIndex = 0;
      this.lblMapTileHeight.Text = "Height";
      // 
      // grpMapDimensions
      // 
      this.grpMapDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpMapDimensions.Controls.Add(this.nudMapColumnCount);
      this.grpMapDimensions.Controls.Add(this.nudMapRowCount);
      this.grpMapDimensions.Controls.Add(this.lblMapColumnCount);
      this.grpMapDimensions.Controls.Add(this.lblMapRowCount);
      this.grpMapDimensions.Location = new System.Drawing.Point(6, 58);
      this.grpMapDimensions.Name = "grpMapDimensions";
      this.grpMapDimensions.Size = new System.Drawing.Size(188, 71);
      this.grpMapDimensions.TabIndex = 2;
      this.grpMapDimensions.TabStop = false;
      this.grpMapDimensions.Text = "Map Dimensions";
      // 
      // nudMapColumnCount
      // 
      this.nudMapColumnCount.Location = new System.Drawing.Point(98, 45);
      this.nudMapColumnCount.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nudMapColumnCount.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nudMapColumnCount.Name = "nudMapColumnCount";
      this.nudMapColumnCount.Size = new System.Drawing.Size(42, 20);
      this.nudMapColumnCount.TabIndex = 5;
      this.nudMapColumnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nudMapColumnCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nudMapColumnCount.ValueChanged += new System.EventHandler(this.nudMapColumnCount_ValueChanged);
      // 
      // nudMapRowCount
      // 
      this.nudMapRowCount.Location = new System.Drawing.Point(98, 19);
      this.nudMapRowCount.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.nudMapRowCount.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nudMapRowCount.Name = "nudMapRowCount";
      this.nudMapRowCount.Size = new System.Drawing.Size(42, 20);
      this.nudMapRowCount.TabIndex = 4;
      this.nudMapRowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.nudMapRowCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.nudMapRowCount.ValueChanged += new System.EventHandler(this.nudMapRowCount_ValueChanged);
      // 
      // lblMapColumnCount
      // 
      this.lblMapColumnCount.AutoSize = true;
      this.lblMapColumnCount.Location = new System.Drawing.Point(6, 47);
      this.lblMapColumnCount.Name = "lblMapColumnCount";
      this.lblMapColumnCount.Size = new System.Drawing.Size(73, 13);
      this.lblMapColumnCount.TabIndex = 2;
      this.lblMapColumnCount.Text = "Column Count";
      // 
      // lblMapRowCount
      // 
      this.lblMapRowCount.AutoSize = true;
      this.lblMapRowCount.Location = new System.Drawing.Point(6, 21);
      this.lblMapRowCount.Name = "lblMapRowCount";
      this.lblMapRowCount.Size = new System.Drawing.Size(60, 13);
      this.lblMapRowCount.TabIndex = 0;
      this.lblMapRowCount.Text = "Row Count";
      // 
      // txtMapName
      // 
      this.txtMapName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMapName.Location = new System.Drawing.Point(6, 32);
      this.txtMapName.Name = "txtMapName";
      this.txtMapName.Size = new System.Drawing.Size(188, 20);
      this.txtMapName.TabIndex = 1;
      // 
      // lblMapName
      // 
      this.lblMapName.AutoSize = true;
      this.lblMapName.Location = new System.Drawing.Point(6, 16);
      this.lblMapName.Name = "lblMapName";
      this.lblMapName.Size = new System.Drawing.Size(59, 13);
      this.lblMapName.TabIndex = 0;
      this.lblMapName.Text = "Map Name";
      // 
      // cmsMapMenu
      // 
      this.cmsMapMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoveMapTile,
            this.tsmiCopyMapTile,
            this.tsmiClearMapTileSelection});
      this.cmsMapMenu.Name = "cmsTileSheetMenu";
      this.cmsMapMenu.Size = new System.Drawing.Size(153, 70);
      this.cmsMapMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsMapMenu_Opening);
      // 
      // tsmiMoveMapTile
      // 
      this.tsmiMoveMapTile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMoveMapTileToRegular,
            this.tsmiMoveMapTileToSolid,
            this.tsmiMoveMapTileToOverlay});
      this.tsmiMoveMapTile.Name = "tsmiMoveMapTile";
      this.tsmiMoveMapTile.Size = new System.Drawing.Size(152, 22);
      this.tsmiMoveMapTile.Text = "Move";
      // 
      // tsmiMoveMapTileToRegular
      // 
      this.tsmiMoveMapTileToRegular.Name = "tsmiMoveMapTileToRegular";
      this.tsmiMoveMapTileToRegular.Size = new System.Drawing.Size(158, 22);
      this.tsmiMoveMapTileToRegular.Text = "To Regular Tiles";
      this.tsmiMoveMapTileToRegular.Click += new System.EventHandler(this.tsmiMoveMapTileToRegular_Click);
      // 
      // tsmiMoveMapTileToSolid
      // 
      this.tsmiMoveMapTileToSolid.Name = "tsmiMoveMapTileToSolid";
      this.tsmiMoveMapTileToSolid.Size = new System.Drawing.Size(158, 22);
      this.tsmiMoveMapTileToSolid.Text = "To Solid Tiles";
      this.tsmiMoveMapTileToSolid.Click += new System.EventHandler(this.tsmiMoveMapTileToSolid_Click);
      // 
      // tsmiMoveMapTileToOverlay
      // 
      this.tsmiMoveMapTileToOverlay.Name = "tsmiMoveMapTileToOverlay";
      this.tsmiMoveMapTileToOverlay.Size = new System.Drawing.Size(158, 22);
      this.tsmiMoveMapTileToOverlay.Text = "To Overlay Tiles";
      this.tsmiMoveMapTileToOverlay.Click += new System.EventHandler(this.tsmiMoveMapTileToOverlay_Click);
      // 
      // tsmiCopyMapTile
      // 
      this.tsmiCopyMapTile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyMapTileToRegular,
            this.tsmiCopyMapTileToSolid,
            this.tsmiCopyMapTileToOverlay});
      this.tsmiCopyMapTile.Name = "tsmiCopyMapTile";
      this.tsmiCopyMapTile.Size = new System.Drawing.Size(152, 22);
      this.tsmiCopyMapTile.Text = "Copy";
      // 
      // tsmiCopyMapTileToRegular
      // 
      this.tsmiCopyMapTileToRegular.Name = "tsmiCopyMapTileToRegular";
      this.tsmiCopyMapTileToRegular.Size = new System.Drawing.Size(158, 22);
      this.tsmiCopyMapTileToRegular.Text = "To Regular Tiles";
      this.tsmiCopyMapTileToRegular.Click += new System.EventHandler(this.tsmiCopyMapTileToRegular_Click);
      // 
      // tsmiCopyMapTileToSolid
      // 
      this.tsmiCopyMapTileToSolid.Name = "tsmiCopyMapTileToSolid";
      this.tsmiCopyMapTileToSolid.Size = new System.Drawing.Size(158, 22);
      this.tsmiCopyMapTileToSolid.Text = "To Solid Tiles";
      this.tsmiCopyMapTileToSolid.Click += new System.EventHandler(this.tsmiCopyMapTileToSolid_Click);
      // 
      // tsmiCopyMapTileToOverlay
      // 
      this.tsmiCopyMapTileToOverlay.Name = "tsmiCopyMapTileToOverlay";
      this.tsmiCopyMapTileToOverlay.Size = new System.Drawing.Size(158, 22);
      this.tsmiCopyMapTileToOverlay.Text = "To Overlay Tiles";
      this.tsmiCopyMapTileToOverlay.Click += new System.EventHandler(this.tsmiCopyMapTileToOverlay_Click);
      // 
      // tsmiClearMapTileSelection
      // 
      this.tsmiClearMapTileSelection.Name = "tsmiClearMapTileSelection";
      this.tsmiClearMapTileSelection.Size = new System.Drawing.Size(152, 22);
      this.tsmiClearMapTileSelection.Text = "Clear Selection";
      this.tsmiClearMapTileSelection.Click += new System.EventHandler(this.tsmiClearMapTileSelection_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.grpSongisms);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.grpSongismAttributes);
      this.splitContainer1.Size = new System.Drawing.Size(294, 543);
      this.splitContainer1.SplitterDistance = 229;
      this.splitContainer1.TabIndex = 0;
      // 
      // grpSongismAttributes
      // 
      this.grpSongismAttributes.Controls.Add(this.pnlSongismAttributesControls);
      this.grpSongismAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpSongismAttributes.Location = new System.Drawing.Point(0, 0);
      this.grpSongismAttributes.Name = "grpSongismAttributes";
      this.grpSongismAttributes.Size = new System.Drawing.Size(294, 310);
      this.grpSongismAttributes.TabIndex = 0;
      this.grpSongismAttributes.TabStop = false;
      this.grpSongismAttributes.Text = "Songism Attributes";
      // 
      // pnlSongismAttributesControls
      // 
      this.pnlSongismAttributesControls.AutoScroll = true;
      this.pnlSongismAttributesControls.Controls.Add(this.txtPrerequisiteInventoryItem);
      this.pnlSongismAttributesControls.Controls.Add(this.lblPrerequisiteInventoryItem);
      this.pnlSongismAttributesControls.Controls.Add(this.chkHasPrerequisiteInventoryItem);
      this.pnlSongismAttributesControls.Controls.Add(this.txtPrerequisiteSongism);
      this.pnlSongismAttributesControls.Controls.Add(this.lblPrerequisiteSongism);
      this.pnlSongismAttributesControls.Controls.Add(this.chkHasPrerequisiteSongism);
      this.pnlSongismAttributesControls.Controls.Add(this.txtSongInfo);
      this.pnlSongismAttributesControls.Controls.Add(this.lblSongInfo);
      this.pnlSongismAttributesControls.Controls.Add(this.txtAlbumName);
      this.pnlSongismAttributesControls.Controls.Add(this.lblAlbumName);
      this.pnlSongismAttributesControls.Controls.Add(this.cboState);
      this.pnlSongismAttributesControls.Controls.Add(this.lblState);
      this.pnlSongismAttributesControls.Controls.Add(this.nudBoundingBoxPositionY);
      this.pnlSongismAttributesControls.Controls.Add(this.lblBoundingBoxPositionY);
      this.pnlSongismAttributesControls.Controls.Add(this.nudBoundingBoxPositionX);
      this.pnlSongismAttributesControls.Controls.Add(this.lblBoundingBoxPositionX);
      this.pnlSongismAttributesControls.Controls.Add(this.nudBoundingBoxHeight);
      this.pnlSongismAttributesControls.Controls.Add(this.lblBoundingBoxHeight);
      this.pnlSongismAttributesControls.Controls.Add(this.nudBoundingBoxWidth);
      this.pnlSongismAttributesControls.Controls.Add(this.lblBoundingBoxWidth);
      this.pnlSongismAttributesControls.Controls.Add(this.lblBoundingBox);
      this.pnlSongismAttributesControls.Controls.Add(this.nudMapPositionY);
      this.pnlSongismAttributesControls.Controls.Add(this.lblMapPositionY);
      this.pnlSongismAttributesControls.Controls.Add(this.nudMapPositionX);
      this.pnlSongismAttributesControls.Controls.Add(this.lblMapPositionX);
      this.pnlSongismAttributesControls.Controls.Add(this.lblMapPosition);
      this.pnlSongismAttributesControls.Controls.Add(this.txtName);
      this.pnlSongismAttributesControls.Controls.Add(this.lblName);
      this.pnlSongismAttributesControls.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlSongismAttributesControls.Location = new System.Drawing.Point(3, 16);
      this.pnlSongismAttributesControls.Name = "pnlSongismAttributesControls";
      this.pnlSongismAttributesControls.Size = new System.Drawing.Size(288, 291);
      this.pnlSongismAttributesControls.TabIndex = 0;
      // 
      // pbSelectedTile
      // 
      this.pbSelectedTile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbSelectedTile.Highlight = false;
      this.pbSelectedTile.Location = new System.Drawing.Point(6, 19);
      this.pbSelectedTile.MapColumnIndex = -1;
      this.pbSelectedTile.MapRowIndex = -1;
      this.pbSelectedTile.Name = "pbSelectedTile";
      this.pbSelectedTile.Size = new System.Drawing.Size(64, 64);
      this.pbSelectedTile.TabIndex = 0;
      this.pbSelectedTile.TabStop = false;
      this.pbSelectedTile.TileSheetColumnIndex = -1;
      this.pbSelectedTile.TileSheetRowIndex = -1;
      this.pbSelectedTile.TileType = TileMapEditor.Globals.TileType.Regular;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(3, 10);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(35, 13);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "Name";
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(3, 26);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(265, 20);
      this.txtName.TabIndex = 1;
      // 
      // lblMapPosition
      // 
      this.lblMapPosition.AutoSize = true;
      this.lblMapPosition.Location = new System.Drawing.Point(3, 49);
      this.lblMapPosition.Name = "lblMapPosition";
      this.lblMapPosition.Size = new System.Drawing.Size(68, 13);
      this.lblMapPosition.TabIndex = 2;
      this.lblMapPosition.Text = "Map Position";
      // 
      // lblMapPositionX
      // 
      this.lblMapPositionX.AutoSize = true;
      this.lblMapPositionX.Location = new System.Drawing.Point(21, 67);
      this.lblMapPositionX.Name = "lblMapPositionX";
      this.lblMapPositionX.Size = new System.Drawing.Size(14, 13);
      this.lblMapPositionX.TabIndex = 3;
      this.lblMapPositionX.Text = "X";
      // 
      // nudMapPositionX
      // 
      this.nudMapPositionX.Location = new System.Drawing.Point(62, 65);
      this.nudMapPositionX.Maximum = new decimal(new int[] {
            7999,
            0,
            0,
            0});
      this.nudMapPositionX.Name = "nudMapPositionX";
      this.nudMapPositionX.Size = new System.Drawing.Size(45, 20);
      this.nudMapPositionX.TabIndex = 4;
      this.nudMapPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblMapPositionY
      // 
      this.lblMapPositionY.AutoSize = true;
      this.lblMapPositionY.Location = new System.Drawing.Point(21, 93);
      this.lblMapPositionY.Name = "lblMapPositionY";
      this.lblMapPositionY.Size = new System.Drawing.Size(14, 13);
      this.lblMapPositionY.TabIndex = 5;
      this.lblMapPositionY.Text = "Y";
      // 
      // nudMapPositionY
      // 
      this.nudMapPositionY.Location = new System.Drawing.Point(62, 91);
      this.nudMapPositionY.Maximum = new decimal(new int[] {
            7999,
            0,
            0,
            0});
      this.nudMapPositionY.Name = "nudMapPositionY";
      this.nudMapPositionY.Size = new System.Drawing.Size(45, 20);
      this.nudMapPositionY.TabIndex = 6;
      this.nudMapPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblBoundingBox
      // 
      this.lblBoundingBox.AutoSize = true;
      this.lblBoundingBox.Location = new System.Drawing.Point(3, 114);
      this.lblBoundingBox.Name = "lblBoundingBox";
      this.lblBoundingBox.Size = new System.Drawing.Size(73, 13);
      this.lblBoundingBox.TabIndex = 7;
      this.lblBoundingBox.Text = "Bounding Box";
      // 
      // lblBoundingBoxWidth
      // 
      this.lblBoundingBoxWidth.AutoSize = true;
      this.lblBoundingBoxWidth.Location = new System.Drawing.Point(21, 132);
      this.lblBoundingBoxWidth.Name = "lblBoundingBoxWidth";
      this.lblBoundingBoxWidth.Size = new System.Drawing.Size(35, 13);
      this.lblBoundingBoxWidth.TabIndex = 8;
      this.lblBoundingBoxWidth.Text = "Width";
      // 
      // nudBoundingBoxWidth
      // 
      this.nudBoundingBoxWidth.Location = new System.Drawing.Point(62, 130);
      this.nudBoundingBoxWidth.Maximum = new decimal(new int[] {
            7999,
            0,
            0,
            0});
      this.nudBoundingBoxWidth.Name = "nudBoundingBoxWidth";
      this.nudBoundingBoxWidth.Size = new System.Drawing.Size(45, 20);
      this.nudBoundingBoxWidth.TabIndex = 9;
      this.nudBoundingBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblBoundingBoxHeight
      // 
      this.lblBoundingBoxHeight.AutoSize = true;
      this.lblBoundingBoxHeight.Location = new System.Drawing.Point(21, 158);
      this.lblBoundingBoxHeight.Name = "lblBoundingBoxHeight";
      this.lblBoundingBoxHeight.Size = new System.Drawing.Size(38, 13);
      this.lblBoundingBoxHeight.TabIndex = 10;
      this.lblBoundingBoxHeight.Text = "Height";
      // 
      // nudBoundingBoxHeight
      // 
      this.nudBoundingBoxHeight.Location = new System.Drawing.Point(62, 156);
      this.nudBoundingBoxHeight.Maximum = new decimal(new int[] {
            7999,
            0,
            0,
            0});
      this.nudBoundingBoxHeight.Name = "nudBoundingBoxHeight";
      this.nudBoundingBoxHeight.Size = new System.Drawing.Size(45, 20);
      this.nudBoundingBoxHeight.TabIndex = 11;
      this.nudBoundingBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblBoundingBoxPositionX
      // 
      this.lblBoundingBoxPositionX.AutoSize = true;
      this.lblBoundingBoxPositionX.Location = new System.Drawing.Point(21, 184);
      this.lblBoundingBoxPositionX.Name = "lblBoundingBoxPositionX";
      this.lblBoundingBoxPositionX.Size = new System.Drawing.Size(14, 13);
      this.lblBoundingBoxPositionX.TabIndex = 12;
      this.lblBoundingBoxPositionX.Text = "X";
      // 
      // nudBoundingBoxPositionX
      // 
      this.nudBoundingBoxPositionX.Location = new System.Drawing.Point(62, 182);
      this.nudBoundingBoxPositionX.Maximum = new decimal(new int[] {
            7999,
            0,
            0,
            0});
      this.nudBoundingBoxPositionX.Name = "nudBoundingBoxPositionX";
      this.nudBoundingBoxPositionX.Size = new System.Drawing.Size(45, 20);
      this.nudBoundingBoxPositionX.TabIndex = 13;
      this.nudBoundingBoxPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblBoundingBoxPositionY
      // 
      this.lblBoundingBoxPositionY.AutoSize = true;
      this.lblBoundingBoxPositionY.Location = new System.Drawing.Point(21, 210);
      this.lblBoundingBoxPositionY.Name = "lblBoundingBoxPositionY";
      this.lblBoundingBoxPositionY.Size = new System.Drawing.Size(14, 13);
      this.lblBoundingBoxPositionY.TabIndex = 14;
      this.lblBoundingBoxPositionY.Text = "Y";
      // 
      // nudBoundingBoxPositionY
      // 
      this.nudBoundingBoxPositionY.Location = new System.Drawing.Point(62, 208);
      this.nudBoundingBoxPositionY.Maximum = new decimal(new int[] {
            7999,
            0,
            0,
            0});
      this.nudBoundingBoxPositionY.Name = "nudBoundingBoxPositionY";
      this.nudBoundingBoxPositionY.Size = new System.Drawing.Size(45, 20);
      this.nudBoundingBoxPositionY.TabIndex = 15;
      this.nudBoundingBoxPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblState
      // 
      this.lblState.AutoSize = true;
      this.lblState.Location = new System.Drawing.Point(3, 231);
      this.lblState.Name = "lblState";
      this.lblState.Size = new System.Drawing.Size(32, 13);
      this.lblState.TabIndex = 16;
      this.lblState.Text = "State";
      // 
      // cboState
      // 
      this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboState.FormattingEnabled = true;
      this.cboState.Items.AddRange(new object[] {
            "Solid",
            "Passive"});
      this.cboState.Location = new System.Drawing.Point(3, 247);
      this.cboState.Name = "cboState";
      this.cboState.Size = new System.Drawing.Size(121, 21);
      this.cboState.TabIndex = 17;
      // 
      // lblAlbumName
      // 
      this.lblAlbumName.AutoSize = true;
      this.lblAlbumName.Location = new System.Drawing.Point(3, 271);
      this.lblAlbumName.Name = "lblAlbumName";
      this.lblAlbumName.Size = new System.Drawing.Size(67, 13);
      this.lblAlbumName.TabIndex = 18;
      this.lblAlbumName.Text = "Album Name";
      // 
      // txtAlbumName
      // 
      this.txtAlbumName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAlbumName.Location = new System.Drawing.Point(3, 287);
      this.txtAlbumName.Name = "txtAlbumName";
      this.txtAlbumName.Size = new System.Drawing.Size(265, 20);
      this.txtAlbumName.TabIndex = 19;
      // 
      // lblSongInfo
      // 
      this.lblSongInfo.AutoSize = true;
      this.lblSongInfo.Location = new System.Drawing.Point(3, 310);
      this.lblSongInfo.Name = "lblSongInfo";
      this.lblSongInfo.Size = new System.Drawing.Size(53, 13);
      this.lblSongInfo.TabIndex = 21;
      this.lblSongInfo.Text = "Song Info";
      // 
      // txtSongInfo
      // 
      this.txtSongInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSongInfo.Location = new System.Drawing.Point(3, 326);
      this.txtSongInfo.Multiline = true;
      this.txtSongInfo.Name = "txtSongInfo";
      this.txtSongInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtSongInfo.Size = new System.Drawing.Size(265, 112);
      this.txtSongInfo.TabIndex = 22;
      // 
      // chkHasPrerequisiteSongism
      // 
      this.chkHasPrerequisiteSongism.AutoSize = true;
      this.chkHasPrerequisiteSongism.Location = new System.Drawing.Point(3, 444);
      this.chkHasPrerequisiteSongism.Name = "chkHasPrerequisiteSongism";
      this.chkHasPrerequisiteSongism.Size = new System.Drawing.Size(146, 17);
      this.chkHasPrerequisiteSongism.TabIndex = 23;
      this.chkHasPrerequisiteSongism.Text = "Has Prerequisite Songism";
      this.chkHasPrerequisiteSongism.UseVisualStyleBackColor = true;
      // 
      // lblPrerequisiteSongism
      // 
      this.lblPrerequisiteSongism.AutoSize = true;
      this.lblPrerequisiteSongism.Location = new System.Drawing.Point(3, 464);
      this.lblPrerequisiteSongism.Name = "lblPrerequisiteSongism";
      this.lblPrerequisiteSongism.Size = new System.Drawing.Size(105, 13);
      this.lblPrerequisiteSongism.TabIndex = 24;
      this.lblPrerequisiteSongism.Text = "Prerequisite Songism";
      // 
      // txtPrerequisiteSongism
      // 
      this.txtPrerequisiteSongism.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPrerequisiteSongism.Location = new System.Drawing.Point(3, 480);
      this.txtPrerequisiteSongism.Name = "txtPrerequisiteSongism";
      this.txtPrerequisiteSongism.Size = new System.Drawing.Size(265, 20);
      this.txtPrerequisiteSongism.TabIndex = 25;
      // 
      // chkHasPrerequisiteInventoryItem
      // 
      this.chkHasPrerequisiteInventoryItem.AutoSize = true;
      this.chkHasPrerequisiteInventoryItem.Location = new System.Drawing.Point(3, 506);
      this.chkHasPrerequisiteInventoryItem.Name = "chkHasPrerequisiteInventoryItem";
      this.chkHasPrerequisiteInventoryItem.Size = new System.Drawing.Size(173, 17);
      this.chkHasPrerequisiteInventoryItem.TabIndex = 26;
      this.chkHasPrerequisiteInventoryItem.Text = "Has Prerequisite Inventory Item";
      this.chkHasPrerequisiteInventoryItem.UseVisualStyleBackColor = true;
      // 
      // lblPrerequisiteInventoryItem
      // 
      this.lblPrerequisiteInventoryItem.AutoSize = true;
      this.lblPrerequisiteInventoryItem.Location = new System.Drawing.Point(3, 526);
      this.lblPrerequisiteInventoryItem.Name = "lblPrerequisiteInventoryItem";
      this.lblPrerequisiteInventoryItem.Size = new System.Drawing.Size(132, 13);
      this.lblPrerequisiteInventoryItem.TabIndex = 27;
      this.lblPrerequisiteInventoryItem.Text = "Prerequisite Inventory Item";
      // 
      // txtPrerequisiteInventoryItem
      // 
      this.txtPrerequisiteInventoryItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPrerequisiteInventoryItem.Location = new System.Drawing.Point(3, 542);
      this.txtPrerequisiteInventoryItem.Name = "txtPrerequisiteInventoryItem";
      this.txtPrerequisiteInventoryItem.Size = new System.Drawing.Size(265, 20);
      this.txtPrerequisiteInventoryItem.TabIndex = 28;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1106, 614);
      this.Controls.Add(this.scMainContainer);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Tile Map Editor";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.grpTiles.ResumeLayout(false);
      this.scContainer1.Panel1.ResumeLayout(false);
      this.scContainer1.Panel1.PerformLayout();
      this.scContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.scContainer1)).EndInit();
      this.scContainer1.ResumeLayout(false);
      this.scContainer2.Panel1.ResumeLayout(false);
      this.scContainer2.Panel1.PerformLayout();
      this.scContainer2.Panel2.ResumeLayout(false);
      this.scContainer2.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scContainer2)).EndInit();
      this.scContainer2.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.grpTools.ResumeLayout(false);
      this.cmsTileSheetMenu.ResumeLayout(false);
      this.scMainContainer.Panel1.ResumeLayout(false);
      this.scMainContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.scMainContainer)).EndInit();
      this.scMainContainer.ResumeLayout(false);
      this.tabEditingTools.ResumeLayout(false);
      this.tpgTiles.ResumeLayout(false);
      this.grpTileSheetSettings.ResumeLayout(false);
      this.grpTileSheetTileDimensions.ResumeLayout(false);
      this.grpTileSheetTileDimensions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudTileSheetTileWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudTileSheetTileHeight)).EndInit();
      this.grpTileSheetDimensions.ResumeLayout(false);
      this.grpTileSheetDimensions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudTileSheetColumnCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudTileSheetRowCount)).EndInit();
      this.tpgSongisms.ResumeLayout(false);
      this.grpSongisms.ResumeLayout(false);
      this.scMapContainer.Panel1.ResumeLayout(false);
      this.scMapContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.scMapContainer)).EndInit();
      this.scMapContainer.ResumeLayout(false);
      this.grpTileMap.ResumeLayout(false);
      this.grpMapSettings.ResumeLayout(false);
      this.grpMapSettings.PerformLayout();
      this.grpMapTileHighlighting.ResumeLayout(false);
      this.grpMapTileHighlighting.PerformLayout();
      this.grpMapTileDimensions.ResumeLayout(false);
      this.grpMapTileDimensions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapTileWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapTileHeight)).EndInit();
      this.grpMapDimensions.ResumeLayout(false);
      this.grpMapDimensions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapColumnCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapRowCount)).EndInit();
      this.cmsMapMenu.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.grpSongismAttributes.ResumeLayout(false);
      this.pnlSongismAttributesControls.ResumeLayout(false);
      this.pnlSongismAttributesControls.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbSelectedTile)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapPositionX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudMapPositionY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudBoundingBoxWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudBoundingBoxHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudBoundingBoxPositionX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudBoundingBoxPositionY)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox grpTiles;
    private System.Windows.Forms.FlowLayoutPanel flpRegularTiles;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem tsmiFile;
    private System.Windows.Forms.ToolStripMenuItem tsmiImportTileSheet;
    private System.Windows.Forms.ToolStripMenuItem tsmiExport;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    private System.Windows.Forms.Panel pnlTileMap;
    private System.Windows.Forms.GroupBox grpTools;
    private System.Windows.Forms.Button btnRefreshGrid;
    private System.Windows.Forms.SplitContainer scContainer1;
    private System.Windows.Forms.Label lblRegularTiles;
    private System.Windows.Forms.SplitContainer scContainer2;
    private System.Windows.Forms.FlowLayoutPanel flpSolidTiles;
    private System.Windows.Forms.Label lblSolidTiles;
    private System.Windows.Forms.FlowLayoutPanel flpOverlayTiles;
    private System.Windows.Forms.Label lblOverlayTiles;
    private System.Windows.Forms.ContextMenuStrip cmsTileSheetMenu;
    private System.Windows.Forms.ToolStripMenuItem tsmiMove;
    private System.Windows.Forms.ToolStripMenuItem tsmiMoveToRegular;
    private System.Windows.Forms.ToolStripMenuItem tsmiMoveToSolid;
    private System.Windows.Forms.ToolStripMenuItem tsmiMoveToOverlay;
    private TileSheetPictureBox pbSelectedTile;
    private System.Windows.Forms.SplitContainer scMainContainer;
    private System.Windows.Forms.GroupBox grpTileMap;
    private System.Windows.Forms.SplitContainer scMapContainer;
    private System.Windows.Forms.GroupBox grpMapSettings;
    private System.Windows.Forms.GroupBox grpMapTileDimensions;
    private System.Windows.Forms.NumericUpDown nudMapTileWidth;
    private System.Windows.Forms.NumericUpDown nudMapTileHeight;
    private System.Windows.Forms.Label lblMapTileWidth;
    private System.Windows.Forms.Label lblMapTileHeight;
    private System.Windows.Forms.GroupBox grpMapDimensions;
    private System.Windows.Forms.NumericUpDown nudMapColumnCount;
    private System.Windows.Forms.NumericUpDown nudMapRowCount;
    private System.Windows.Forms.Label lblMapColumnCount;
    private System.Windows.Forms.Label lblMapRowCount;
    private System.Windows.Forms.TextBox txtMapName;
    private System.Windows.Forms.Label lblMapName;
    private System.Windows.Forms.ToolStripMenuItem tsmiImport;
    private System.Windows.Forms.ToolStripMenuItem tsmiImportMap;
    private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
    private System.Windows.Forms.ToolStripMenuItem tsmiCopyToRegular;
    private System.Windows.Forms.ToolStripMenuItem tsmiCopyToSolid;
    private System.Windows.Forms.ToolStripMenuItem tsmiCopyToOverlay;
    private System.Windows.Forms.ToolStripMenuItem tsmiExportTileSheet;
    private System.Windows.Forms.ToolStripMenuItem tsmiExportMap;
    private System.Windows.Forms.GroupBox grpTileSheetSettings;
    private System.Windows.Forms.GroupBox grpTileSheetTileDimensions;
    private System.Windows.Forms.NumericUpDown nudTileSheetTileWidth;
    private System.Windows.Forms.NumericUpDown nudTileSheetTileHeight;
    private System.Windows.Forms.Label lblTileSheetTileWidth;
    private System.Windows.Forms.Label lblTileSheetTileHeight;
    private System.Windows.Forms.GroupBox grpTileSheetDimensions;
    private System.Windows.Forms.NumericUpDown nudTileSheetColumnCount;
    private System.Windows.Forms.NumericUpDown nudTileSheetRowCount;
    private System.Windows.Forms.Label lblTileSheetColumnCount;
    private System.Windows.Forms.Label lblTileSheetRowCount;
    private System.Windows.Forms.ToolStripMenuItem tsmiRemoveTile;
    private System.Windows.Forms.ContextMenuStrip cmsMapMenu;
    private System.Windows.Forms.ToolStripMenuItem tsmiMoveMapTile;
    private System.Windows.Forms.ToolStripMenuItem tsmiMoveMapTileToRegular;
    private System.Windows.Forms.ToolStripMenuItem tsmiMoveMapTileToSolid;
    private System.Windows.Forms.ToolStripMenuItem tsmiMoveMapTileToOverlay;
    private System.Windows.Forms.ToolStripMenuItem tsmiCopyMapTile;
    private System.Windows.Forms.ToolStripMenuItem tsmiCopyMapTileToRegular;
    private System.Windows.Forms.ToolStripMenuItem tsmiCopyMapTileToSolid;
    private System.Windows.Forms.ToolStripMenuItem tsmiCopyMapTileToOverlay;
    private System.Windows.Forms.Button btnClearSelection;
    private System.Windows.Forms.ToolStripMenuItem tsmiClearMapTileSelection;
    private System.Windows.Forms.GroupBox grpMapTileHighlighting;
    private System.Windows.Forms.CheckBox chkHighlightOverlayTiles;
    private System.Windows.Forms.CheckBox chkHighlightSolidTiles;
    private System.Windows.Forms.CheckBox chkHighlightRegularTiles;
    private System.Windows.Forms.CheckBox chkHighlightEntranceTiles;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem tsmiImportSongisms;
    private System.Windows.Forms.TabControl tabEditingTools;
    private System.Windows.Forms.TabPage tpgTiles;
    private System.Windows.Forms.TabPage tpgSongisms;
    private System.Windows.Forms.GroupBox grpSongisms;
    private System.Windows.Forms.FlowLayoutPanel flpSongisms;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.GroupBox grpSongismAttributes;
    private System.Windows.Forms.Panel pnlSongismAttributesControls;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtAlbumName;
    private System.Windows.Forms.Label lblAlbumName;
    private System.Windows.Forms.ComboBox cboState;
    private System.Windows.Forms.Label lblState;
    private System.Windows.Forms.NumericUpDown nudBoundingBoxPositionY;
    private System.Windows.Forms.Label lblBoundingBoxPositionY;
    private System.Windows.Forms.NumericUpDown nudBoundingBoxPositionX;
    private System.Windows.Forms.Label lblBoundingBoxPositionX;
    private System.Windows.Forms.NumericUpDown nudBoundingBoxHeight;
    private System.Windows.Forms.Label lblBoundingBoxHeight;
    private System.Windows.Forms.NumericUpDown nudBoundingBoxWidth;
    private System.Windows.Forms.Label lblBoundingBoxWidth;
    private System.Windows.Forms.Label lblBoundingBox;
    private System.Windows.Forms.NumericUpDown nudMapPositionY;
    private System.Windows.Forms.Label lblMapPositionY;
    private System.Windows.Forms.NumericUpDown nudMapPositionX;
    private System.Windows.Forms.Label lblMapPositionX;
    private System.Windows.Forms.Label lblMapPosition;
    private System.Windows.Forms.TextBox txtPrerequisiteInventoryItem;
    private System.Windows.Forms.Label lblPrerequisiteInventoryItem;
    private System.Windows.Forms.CheckBox chkHasPrerequisiteInventoryItem;
    private System.Windows.Forms.TextBox txtPrerequisiteSongism;
    private System.Windows.Forms.Label lblPrerequisiteSongism;
    private System.Windows.Forms.CheckBox chkHasPrerequisiteSongism;
    private System.Windows.Forms.TextBox txtSongInfo;
    private System.Windows.Forms.Label lblSongInfo;
  }
}

