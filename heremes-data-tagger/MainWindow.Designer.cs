namespace HermesDataTagger
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMousePos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTooltip = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuFileLoadImages = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuEdit = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuEditUndo = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuEditRedo = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuView = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuViewPreviousPhoto = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuViewNextPhoto = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhoto = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhotoMarkCrowded = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhotoMarkBibs = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhotoMarkFaces = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPhotoSelectPrevRunner = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhotoSelectNextRunner = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuSelectedRunner = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerStaticNumberValue = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerMarkBib = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerOpenClassificationsWizard = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerOpenColorClassificationsWizard = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerMarkBlurry = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerMarkFaceVisible = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerLikelihoodPurchase = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerLikelihoodPurchaseNo = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerLikelihoodPurchaseMaybe = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerLikelihoodPurchaseYes = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerMarkHat = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerMarkGlasses = new HermesDataTagger.BindableToolStripMenuItem();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.tblMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpPhotoClass = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chbxIsCrowded = new System.Windows.Forms.CheckBox();
            this.grpSteps = new System.Windows.Forms.GroupBox();
            this.tblLayoutSteps = new System.Windows.Forms.TableLayoutPanel();
            this.lstSteps = new System.Windows.Forms.ListBox();
            this.btnPrevStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.tblTags = new System.Windows.Forms.DataGridView();
            this.tblcolBibNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolBlurry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolFaceVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolLikelihoodPurchase = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblcolWearingHat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolWearingGlasses = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolShirtColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolShortsColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolShoeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolBibDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.lblStepName = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tblMainGrid.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpPhotoClass.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSteps.SuspendLayout();
            this.tblLayoutSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTags)).BeginInit();
            this.pnlInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 1174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 13;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMousePos,
            this.lblTooltip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1931);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2900, 37);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMousePos
            // 
            this.lblMousePos.Name = "lblMousePos";
            this.lblMousePos.Size = new System.Drawing.Size(68, 32);
            this.lblMousePos.Text = "(X, Y)";
            // 
            // lblTooltip
            // 
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(238, 32);
            this.lblTooltip.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuPhoto,
            this.mnuSelectedRunner});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2900, 40);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileLoadImages,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(64, 36);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileLoadImages
            // 
            this.mnuFileLoadImages.Name = "mnuFileLoadImages";
            this.mnuFileLoadImages.Size = new System.Drawing.Size(249, 38);
            this.mnuFileLoadImages.Text = "&Load Images";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(249, 38);
            this.mnuFileExit.Text = "&Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditUndo,
            this.mnuEditRedo});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(67, 36);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditUndo
            // 
            this.mnuEditUndo.Name = "mnuEditUndo";
            this.mnuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuEditUndo.Size = new System.Drawing.Size(255, 38);
            this.mnuEditUndo.Text = "Undo";
            // 
            // mnuEditRedo
            // 
            this.mnuEditRedo.Name = "mnuEditRedo";
            this.mnuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mnuEditRedo.Size = new System.Drawing.Size(255, 38);
            this.mnuEditRedo.Text = "Redo";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewPreviousPhoto,
            this.mnuViewNextPhoto});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(78, 36);
            this.mnuView.Text = "&View";
            // 
            // mnuViewPreviousPhoto
            // 
            this.mnuViewPreviousPhoto.Name = "mnuViewPreviousPhoto";
            this.mnuViewPreviousPhoto.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnuViewPreviousPhoto.Size = new System.Drawing.Size(360, 38);
            this.mnuViewPreviousPhoto.Text = "Go &Back Photo";
            // 
            // mnuViewNextPhoto
            // 
            this.mnuViewNextPhoto.Name = "mnuViewNextPhoto";
            this.mnuViewNextPhoto.ShortcutKeyDisplayString = "";
            this.mnuViewNextPhoto.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mnuViewNextPhoto.Size = new System.Drawing.Size(360, 38);
            this.mnuViewNextPhoto.Text = "Go &Forward Photo";
            // 
            // mnuPhoto
            // 
            this.mnuPhoto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhotoMarkCrowded,
            this.mnuPhotoMarkBibs,
            this.mnuPhotoMarkFaces,
            this.toolStripSeparator7,
            this.mnuPhotoSelectPrevRunner,
            this.mnuPhotoSelectNextRunner});
            this.mnuPhoto.Name = "mnuPhoto";
            this.mnuPhoto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuPhoto.Size = new System.Drawing.Size(90, 36);
            this.mnuPhoto.Text = "&Photo";
            // 
            // mnuPhotoMarkCrowded
            // 
            this.mnuPhotoMarkCrowded.Name = "mnuPhotoMarkCrowded";
            this.mnuPhotoMarkCrowded.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuPhotoMarkCrowded.Size = new System.Drawing.Size(410, 38);
            this.mnuPhotoMarkCrowded.Text = "Mark Photo as &Crowded";
            // 
            // mnuPhotoMarkBibs
            // 
            this.mnuPhotoMarkBibs.Name = "mnuPhotoMarkBibs";
            this.mnuPhotoMarkBibs.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuPhotoMarkBibs.Size = new System.Drawing.Size(410, 38);
            this.mnuPhotoMarkBibs.Text = "Mark &Bib Regions";
            // 
            // mnuPhotoMarkFaces
            // 
            this.mnuPhotoMarkFaces.Name = "mnuPhotoMarkFaces";
            this.mnuPhotoMarkFaces.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuPhotoMarkFaces.Size = new System.Drawing.Size(410, 38);
            this.mnuPhotoMarkFaces.Text = "Mark &Face Regions";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(407, 6);
            // 
            // mnuPhotoSelectPrevRunner
            // 
            this.mnuPhotoSelectPrevRunner.Name = "mnuPhotoSelectPrevRunner";
            this.mnuPhotoSelectPrevRunner.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mnuPhotoSelectPrevRunner.Size = new System.Drawing.Size(410, 38);
            this.mnuPhotoSelectPrevRunner.Text = "Select &Previous Runner";
            // 
            // mnuPhotoSelectNextRunner
            // 
            this.mnuPhotoSelectNextRunner.Name = "mnuPhotoSelectNextRunner";
            this.mnuPhotoSelectNextRunner.ShortcutKeyDisplayString = "";
            this.mnuPhotoSelectNextRunner.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.mnuPhotoSelectNextRunner.Size = new System.Drawing.Size(410, 38);
            this.mnuPhotoSelectNextRunner.Text = "Select &Next Runner";
            // 
            // mnuSelectedRunner
            // 
            this.mnuSelectedRunner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRunnerStaticNumberValue,
            this.toolStripSeparator8,
            this.mnuRunnerMarkBib,
            this.mnuRunnerOpenClassificationsWizard,
            this.mnuRunnerOpenColorClassificationsWizard,
            this.toolStripSeparator3,
            this.mnuRunnerMarkBlurry,
            this.mnuRunnerMarkFaceVisible,
            this.toolStripSeparator4,
            this.mnuRunnerLikelihoodPurchase,
            this.toolStripSeparator5,
            this.mnuRunnerMarkHat,
            this.mnuRunnerMarkGlasses});
            this.mnuSelectedRunner.Name = "mnuSelectedRunner";
            this.mnuSelectedRunner.Size = new System.Drawing.Size(202, 36);
            this.mnuSelectedRunner.Text = "Selected &Runner";
            // 
            // mnuRunnerStaticNumberValue
            // 
            this.mnuRunnerStaticNumberValue.Enabled = false;
            this.mnuRunnerStaticNumberValue.Name = "mnuRunnerStaticNumberValue";
            this.mnuRunnerStaticNumberValue.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerStaticNumberValue.Text = "Runner #X";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(513, 6);
            // 
            // mnuRunnerMarkBib
            // 
            this.mnuRunnerMarkBib.Name = "mnuRunnerMarkBib";
            this.mnuRunnerMarkBib.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuRunnerMarkBib.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerMarkBib.Text = "Set Bib &Number";
            // 
            // mnuRunnerOpenClassificationsWizard
            // 
            this.mnuRunnerOpenClassificationsWizard.Name = "mnuRunnerOpenClassificationsWizard";
            this.mnuRunnerOpenClassificationsWizard.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuRunnerOpenClassificationsWizard.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerOpenClassificationsWizard.Text = "Open &Classifications Wizard";
            // 
            // mnuRunnerOpenColorClassificationsWizard
            // 
            this.mnuRunnerOpenColorClassificationsWizard.Name = "mnuRunnerOpenColorClassificationsWizard";
            this.mnuRunnerOpenColorClassificationsWizard.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mnuRunnerOpenColorClassificationsWizard.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerOpenColorClassificationsWizard.Text = "Open C&olor Selection Wizard";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(513, 6);
            // 
            // mnuRunnerMarkBlurry
            // 
            this.mnuRunnerMarkBlurry.Name = "mnuRunnerMarkBlurry";
            this.mnuRunnerMarkBlurry.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuRunnerMarkBlurry.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerMarkBlurry.Text = "Mark Runner &Blurry";
            // 
            // mnuRunnerMarkFaceVisible
            // 
            this.mnuRunnerMarkFaceVisible.Name = "mnuRunnerMarkFaceVisible";
            this.mnuRunnerMarkFaceVisible.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuRunnerMarkFaceVisible.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerMarkFaceVisible.Text = "Mark &Face Visible";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(513, 6);
            // 
            // mnuRunnerLikelihoodPurchase
            // 
            this.mnuRunnerLikelihoodPurchase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRunnerLikelihoodPurchaseNo,
            this.mnuRunnerLikelihoodPurchaseMaybe,
            this.mnuRunnerLikelihoodPurchaseYes});
            this.mnuRunnerLikelihoodPurchase.Name = "mnuRunnerLikelihoodPurchase";
            this.mnuRunnerLikelihoodPurchase.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerLikelihoodPurchase.Text = "Likelihood Of &Purchase";
            // 
            // mnuRunnerLikelihoodPurchaseNo
            // 
            this.mnuRunnerLikelihoodPurchaseNo.Name = "mnuRunnerLikelihoodPurchaseNo";
            this.mnuRunnerLikelihoodPurchaseNo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mnuRunnerLikelihoodPurchaseNo.Size = new System.Drawing.Size(612, 38);
            this.mnuRunnerLikelihoodPurchaseNo.Text = "I would &Not buy this photo";
            // 
            // mnuRunnerLikelihoodPurchaseMaybe
            // 
            this.mnuRunnerLikelihoodPurchaseMaybe.Name = "mnuRunnerLikelihoodPurchaseMaybe";
            this.mnuRunnerLikelihoodPurchaseMaybe.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.mnuRunnerLikelihoodPurchaseMaybe.Size = new System.Drawing.Size(612, 38);
            this.mnuRunnerLikelihoodPurchaseMaybe.Text = "I would &Maybe buy this photo";
            // 
            // mnuRunnerLikelihoodPurchaseYes
            // 
            this.mnuRunnerLikelihoodPurchaseYes.Name = "mnuRunnerLikelihoodPurchaseYes";
            this.mnuRunnerLikelihoodPurchaseYes.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Y)));
            this.mnuRunnerLikelihoodPurchaseYes.Size = new System.Drawing.Size(612, 38);
            this.mnuRunnerLikelihoodPurchaseYes.Text = "I would &Definitely buy this photo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(513, 6);
            // 
            // mnuRunnerMarkHat
            // 
            this.mnuRunnerMarkHat.Name = "mnuRunnerMarkHat";
            this.mnuRunnerMarkHat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuRunnerMarkHat.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerMarkHat.Text = "Mark Runner Wearing &Hat";
            // 
            // mnuRunnerMarkGlasses
            // 
            this.mnuRunnerMarkGlasses.Name = "mnuRunnerMarkGlasses";
            this.mnuRunnerMarkGlasses.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuRunnerMarkGlasses.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerMarkGlasses.Text = "Mark Runner Wearing &Glasses";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.Location = new System.Drawing.Point(2758, 3);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(139, 183);
            this.btnNextImage.TabIndex = 9;
            this.btnNextImage.Text = "Next Photo [F12] ▶";
            this.btnNextImage.UseVisualStyleBackColor = true;
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevImage.Location = new System.Drawing.Point(3, 3);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(139, 183);
            this.btnPrevImage.TabIndex = 10;
            this.btnPrevImage.Text = "Prev Photo ◀ [F11] ";
            this.btnPrevImage.UseVisualStyleBackColor = true;
            // 
            // tblMainGrid
            // 
            this.tblMainGrid.BackColor = System.Drawing.SystemColors.Control;
            this.tblMainGrid.ColumnCount = 5;
            this.tblMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblMainGrid.Controls.Add(this.pnlRight, 3, 1);
            this.tblMainGrid.Controls.Add(this.tblTags, 0, 2);
            this.tblMainGrid.Controls.Add(this.pnlInstructions, 1, 0);
            this.tblMainGrid.Controls.Add(this.btnNextImage, 4, 0);
            this.tblMainGrid.Controls.Add(this.imgPhoto, 2, 1);
            this.tblMainGrid.Controls.Add(this.btnPrevImage, 0, 0);
            this.tblMainGrid.Controls.Add(this.pnlLeft, 0, 1);
            this.tblMainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainGrid.Location = new System.Drawing.Point(0, 40);
            this.tblMainGrid.Name = "tblMainGrid";
            this.tblMainGrid.RowCount = 3;
            this.tblMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMainGrid.Size = new System.Drawing.Size(2900, 1891);
            this.tblMainGrid.TabIndex = 18;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.Control;
            this.tblMainGrid.SetColumnSpan(this.pnlRight, 2);
            this.pnlRight.Controls.Add(this.grpPhotoClass);
            this.pnlRight.Controls.Add(this.grpSteps);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(2323, 192);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(574, 1317);
            this.pnlRight.TabIndex = 33;
            // 
            // grpPhotoClass
            // 
            this.grpPhotoClass.Controls.Add(this.tableLayoutPanel1);
            this.grpPhotoClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpPhotoClass.Location = new System.Drawing.Point(0, 949);
            this.grpPhotoClass.Name = "grpPhotoClass";
            this.grpPhotoClass.Padding = new System.Windows.Forms.Padding(10);
            this.grpPhotoClass.Size = new System.Drawing.Size(574, 368);
            this.grpPhotoClass.TabIndex = 28;
            this.grpPhotoClass.TabStop = false;
            this.grpPhotoClass.Text = "General Photo Classification";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chbxIsCrowded, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 324);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(3, 165);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(548, 156);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Mark photo as Complete [F4]";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chbxIsCrowded
            // 
            this.chbxIsCrowded.AutoSize = true;
            this.chbxIsCrowded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxIsCrowded.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxIsCrowded.Location = new System.Drawing.Point(3, 3);
            this.chbxIsCrowded.Name = "chbxIsCrowded";
            this.chbxIsCrowded.Size = new System.Drawing.Size(548, 156);
            this.chbxIsCrowded.TabIndex = 23;
            this.chbxIsCrowded.Text = "Mark photo as Crowded [F1]";
            this.chbxIsCrowded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbxIsCrowded.UseVisualStyleBackColor = true;
            // 
            // grpSteps
            // 
            this.grpSteps.Controls.Add(this.tblLayoutSteps);
            this.grpSteps.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSteps.Location = new System.Drawing.Point(0, 0);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Padding = new System.Windows.Forms.Padding(10);
            this.grpSteps.Size = new System.Drawing.Size(574, 480);
            this.grpSteps.TabIndex = 25;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Steps";
            // 
            // tblLayoutSteps
            // 
            this.tblLayoutSteps.ColumnCount = 3;
            this.tblLayoutSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblLayoutSteps.Controls.Add(this.lstSteps, 0, 0);
            this.tblLayoutSteps.Controls.Add(this.btnPrevStep, 0, 1);
            this.tblLayoutSteps.Controls.Add(this.btnNextStep, 2, 1);
            this.tblLayoutSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutSteps.Location = new System.Drawing.Point(10, 34);
            this.tblLayoutSteps.Name = "tblLayoutSteps";
            this.tblLayoutSteps.RowCount = 2;
            this.tblLayoutSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblLayoutSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutSteps.Size = new System.Drawing.Size(554, 436);
            this.tblLayoutSteps.TabIndex = 26;
            // 
            // lstSteps
            // 
            this.tblLayoutSteps.SetColumnSpan(this.lstSteps, 3);
            this.lstSteps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSteps.FormattingEnabled = true;
            this.lstSteps.ItemHeight = 37;
            this.lstSteps.Items.AddRange(new object[] {
            ""});
            this.lstSteps.Location = new System.Drawing.Point(3, 3);
            this.lstSteps.Name = "lstSteps";
            this.lstSteps.Size = new System.Drawing.Size(548, 321);
            this.lstSteps.TabIndex = 28;
            // 
            // btnPrevStep
            // 
            this.btnPrevStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevStep.Location = new System.Drawing.Point(3, 330);
            this.btnPrevStep.Name = "btnPrevStep";
            this.btnPrevStep.Size = new System.Drawing.Size(178, 103);
            this.btnPrevStep.TabIndex = 27;
            this.btnPrevStep.Text = "Prev Step ◀";
            this.btnPrevStep.UseVisualStyleBackColor = true;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStep.Location = new System.Drawing.Point(371, 330);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(180, 103);
            this.btnNextStep.TabIndex = 26;
            this.btnNextStep.Text = "Next Step ▶";
            this.btnNextStep.UseVisualStyleBackColor = true;
            // 
            // tblTags
            // 
            this.tblTags.AllowUserToAddRows = false;
            this.tblTags.AllowUserToDeleteRows = false;
            this.tblTags.AllowUserToResizeColumns = false;
            this.tblTags.AllowUserToResizeRows = false;
            this.tblTags.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblTags.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTags.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblTags.ColumnHeadersHeight = 40;
            this.tblTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblcolBibNumber,
            this.tblcolBlurry,
            this.tblcolFaceVisible,
            this.tblcolLikelihoodPurchase,
            this.tblcolWearingHat,
            this.tblcolWearingGlasses,
            this.tblcolShirtColor,
            this.tblcolShortsColor,
            this.tblcolShoeColor,
            this.tblcolBibDelete});
            this.tblMainGrid.SetColumnSpan(this.tblTags, 5);
            this.tblTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTags.Location = new System.Drawing.Point(3, 1515);
            this.tblTags.MultiSelect = false;
            this.tblTags.Name = "tblTags";
            this.tblTags.RowHeadersVisible = false;
            this.tblTags.RowTemplate.Height = 25;
            this.tblTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTags.Size = new System.Drawing.Size(2894, 373);
            this.tblTags.StandardTab = true;
            this.tblTags.TabIndex = 32;
            // 
            // tblcolBibNumber
            // 
            this.tblcolBibNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblcolBibNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblcolBibNumber.Frozen = true;
            this.tblcolBibNumber.HeaderText = "Bib Number";
            this.tblcolBibNumber.Name = "tblcolBibNumber";
            this.tblcolBibNumber.ToolTipText = "The bib number identified of this runner";
            this.tblcolBibNumber.Width = 211;
            // 
            // tblcolBlurry
            // 
            this.tblcolBlurry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolBlurry.HeaderText = "Runner Blurry?";
            this.tblcolBlurry.Name = "tblcolBlurry";
            this.tblcolBlurry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblcolBlurry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tblcolBlurry.ToolTipText = "Is this runner blurry?";
            // 
            // tblcolFaceVisible
            // 
            this.tblcolFaceVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolFaceVisible.HeaderText = "Face Visible?";
            this.tblcolFaceVisible.Name = "tblcolFaceVisible";
            this.tblcolFaceVisible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblcolFaceVisible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tblcolFaceVisible.ToolTipText = "Is this runner\'s face visible?";
            // 
            // tblcolLikelihoodPurchase
            // 
            this.tblcolLikelihoodPurchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolLikelihoodPurchase.HeaderText = "Would Purchase?";
            this.tblcolLikelihoodPurchase.Items.AddRange(new object[] {
            "Yes",
            "Maybe",
            "No"});
            this.tblcolLikelihoodPurchase.MaxDropDownItems = 3;
            this.tblcolLikelihoodPurchase.Name = "tblcolLikelihoodPurchase";
            this.tblcolLikelihoodPurchase.ToolTipText = "Would you purchase this photo given the option to?";
            // 
            // tblcolWearingHat
            // 
            this.tblcolWearingHat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolWearingHat.HeaderText = "Wearing Hat?";
            this.tblcolWearingHat.Name = "tblcolWearingHat";
            this.tblcolWearingHat.ToolTipText = "Is this runner wearing a hat?";
            // 
            // tblcolWearingGlasses
            // 
            this.tblcolWearingGlasses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolWearingGlasses.HeaderText = "Wearing Glasses?";
            this.tblcolWearingGlasses.Name = "tblcolWearingGlasses";
            this.tblcolWearingGlasses.ToolTipText = "Is this runner wearing glasses?";
            // 
            // tblcolShirtColor
            // 
            this.tblcolShirtColor.HeaderText = "Shirt Color";
            this.tblcolShirtColor.Name = "tblcolShirtColor";
            this.tblcolShirtColor.ReadOnly = true;
            this.tblcolShirtColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblcolShirtColor.ToolTipText = "What is the color of the runner\'s shirt?";
            // 
            // tblcolShortsColor
            // 
            this.tblcolShortsColor.HeaderText = "Shorts Color";
            this.tblcolShortsColor.Name = "tblcolShortsColor";
            this.tblcolShortsColor.ReadOnly = true;
            this.tblcolShortsColor.ToolTipText = "What is the color of the runner\'s shorts?";
            // 
            // tblcolShoeColor
            // 
            this.tblcolShoeColor.HeaderText = "Shoe Color";
            this.tblcolShoeColor.Name = "tblcolShoeColor";
            this.tblcolShoeColor.ReadOnly = true;
            this.tblcolShoeColor.ToolTipText = "What is the color of the runner\'s shoe?";
            // 
            // tblcolBibDelete
            // 
            this.tblcolBibDelete.HeaderText = "Delete";
            this.tblcolBibDelete.Name = "tblcolBibDelete";
            this.tblcolBibDelete.Text = "Delete";
            this.tblcolBibDelete.ToolTipText = "Delete this bib region";
            this.tblcolBibDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.BackColor = System.Drawing.Color.White;
            this.tblMainGrid.SetColumnSpan(this.pnlInstructions, 3);
            this.pnlInstructions.Controls.Add(this.lblStepName);
            this.pnlInstructions.Controls.Add(this.lblInstructions);
            this.pnlInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInstructions.Location = new System.Drawing.Point(148, 3);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(2604, 183);
            this.pnlInstructions.TabIndex = 28;
            // 
            // lblStepName
            // 
            this.lblStepName.BackColor = System.Drawing.Color.White;
            this.lblStepName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepName.ForeColor = System.Drawing.Color.Red;
            this.lblStepName.Location = new System.Drawing.Point(0, 0);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(2604, 102);
            this.lblStepName.TabIndex = 39;
            this.lblStepName.Text = "[Step Label]";
            this.lblStepName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.White;
            this.lblInstructions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblInstructions.Location = new System.Drawing.Point(0, 102);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(2604, 81);
            this.lblInstructions.TabIndex = 38;
            this.lblInstructions.Text = "[Step Instructions Label]";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPhoto.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPhoto.Location = new System.Drawing.Point(438, 192);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(1879, 1317);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 25;
            this.imgPhoto.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.Control;
            this.tblMainGrid.SetColumnSpan(this.pnlLeft, 2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 192);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(429, 1317);
            this.pnlLeft.TabIndex = 29;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2900, 1968);
            this.Controls.Add(this.tblMainGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1842, 1450);
            this.Name = "MainWindow";
            this.Text = "Racing Bib Number Tagger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tblMainGrid.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.grpPhotoClass.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpSteps.ResumeLayout(false);
            this.tblLayoutSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblTags)).EndInit();
            this.pnlInstructions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private BindableToolStripMenuItem mnuFile;
        private BindableToolStripMenuItem mnuFileLoadImages;
        private System.Windows.Forms.ToolStripStatusLabel lblMousePos;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.TableLayoutPanel tblMainGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private BindableToolStripMenuItem mnuFileExit;
        private BindableToolStripMenuItem mnuEdit;
        private BindableToolStripMenuItem mnuEditUndo;
        private BindableToolStripMenuItem mnuEditRedo;
        private BindableToolStripMenuItem mnuView;
        private BindableToolStripMenuItem mnuViewNextPhoto;
        private BindableToolStripMenuItem mnuViewPreviousPhoto;
        private BindableToolStripMenuItem mnuSelectedRunner;
        private BindableToolStripMenuItem mnuRunnerMarkBib;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private BindableToolStripMenuItem mnuRunnerMarkBlurry;
        private BindableToolStripMenuItem mnuRunnerMarkFaceVisible;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private BindableToolStripMenuItem mnuRunnerLikelihoodPurchase;
        private BindableToolStripMenuItem mnuRunnerLikelihoodPurchaseNo;
        private BindableToolStripMenuItem mnuRunnerLikelihoodPurchaseMaybe;
        private BindableToolStripMenuItem mnuRunnerLikelihoodPurchaseYes;
        private BindableToolStripMenuItem mnuPhoto;
        private BindableToolStripMenuItem mnuPhotoMarkCrowded;
        private BindableToolStripMenuItem mnuPhotoMarkBibs;
        private BindableToolStripMenuItem mnuPhotoMarkFaces;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private BindableToolStripMenuItem mnuRunnerMarkHat;
        private BindableToolStripMenuItem mnuRunnerMarkGlasses;
        private BindableToolStripMenuItem mnuRunnerOpenClassificationsWizard;
        private BindableToolStripMenuItem mnuRunnerOpenColorClassificationsWizard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private BindableToolStripMenuItem mnuPhotoSelectNextRunner;
        private BindableToolStripMenuItem mnuRunnerStaticNumberValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private BindableToolStripMenuItem mnuPhotoSelectPrevRunner;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Label lblStepName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.DataGridView tblTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolBibNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolBlurry;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolFaceVisible;
        private System.Windows.Forms.DataGridViewComboBoxColumn tblcolLikelihoodPurchase;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolWearingHat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolWearingGlasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolShirtColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolShortsColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolShoeColor;
        private System.Windows.Forms.DataGridViewButtonColumn tblcolBibDelete;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpSteps;
        private System.Windows.Forms.TableLayoutPanel tblLayoutSteps;
        private System.Windows.Forms.Button btnPrevStep;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.ListBox lstSteps;
        private System.Windows.Forms.GroupBox grpPhotoClass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chbxIsCrowded;
        private System.Windows.Forms.ToolStripStatusLabel lblTooltip;
    }
}

