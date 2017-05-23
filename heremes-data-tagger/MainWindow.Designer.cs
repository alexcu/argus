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
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMousePos = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuFileLoadImages = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuEdit = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuEditUndo = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuEditRedo = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuView = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuViewNextPhoto = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuViewPreviousPhoto = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhoto = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhotoMarkCrowded = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhotoMarkBibs = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuPhotoMarkFaces = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPhotoSelectNextRunner = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuSelectedRunner = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerStaticNumberValue = new HermesDataTagger.BindableToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerMarkBib = new HermesDataTagger.BindableToolStripMenuItem();
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
            this.mnuRunnerOpenClassificationsWizard = new HermesDataTagger.BindableToolStripMenuItem();
            this.mnuRunnerOpenColorClassificationsWizard = new HermesDataTagger.BindableToolStripMenuItem();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblStepName = new System.Windows.Forms.Label();
            this.mnuPhotoSelectPrevRunner = new HermesDataTagger.BindableToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPhoto
            // 
            this.imgPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPhoto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPhoto.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgPhoto.Location = new System.Drawing.Point(3, 209);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(1842, 1208);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 11;
            this.imgPhoto.TabStop = false;
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
            this.lblMousePos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1842, 37);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMousePos
            // 
            this.lblMousePos.Name = "lblMousePos";
            this.lblMousePos.Size = new System.Drawing.Size(68, 32);
            this.lblMousePos.Text = "(X, Y)";
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
            this.menuStrip1.Size = new System.Drawing.Size(1842, 42);
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
            this.mnuFile.Size = new System.Drawing.Size(64, 38);
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
            this.mnuEdit.Size = new System.Drawing.Size(67, 38);
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
            this.mnuViewNextPhoto,
            this.mnuViewPreviousPhoto});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(78, 38);
            this.mnuView.Text = "&View";
            // 
            // mnuViewNextPhoto
            // 
            this.mnuViewNextPhoto.Name = "mnuViewNextPhoto";
            this.mnuViewNextPhoto.ShortcutKeyDisplayString = "";
            this.mnuViewNextPhoto.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mnuViewNextPhoto.Size = new System.Drawing.Size(360, 38);
            this.mnuViewNextPhoto.Text = "Go &Forward Photo";
            // 
            // mnuViewPreviousPhoto
            // 
            this.mnuViewPreviousPhoto.Name = "mnuViewPreviousPhoto";
            this.mnuViewPreviousPhoto.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnuViewPreviousPhoto.Size = new System.Drawing.Size(360, 38);
            this.mnuViewPreviousPhoto.Text = "Go &Back Photo";
            // 
            // mnuPhoto
            // 
            this.mnuPhoto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhotoMarkCrowded,
            this.mnuPhotoMarkBibs,
            this.mnuPhotoMarkFaces,
            this.toolStripSeparator7,
            this.mnuPhotoSelectNextRunner,
            this.mnuPhotoSelectPrevRunner});
            this.mnuPhoto.Name = "mnuPhoto";
            this.mnuPhoto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuPhoto.Size = new System.Drawing.Size(90, 38);
            this.mnuPhoto.Text = "&Photo";
            // 
            // mnuPhotoMarkCrowded
            // 
            this.mnuPhotoMarkCrowded.Name = "mnuPhotoMarkCrowded";
            this.mnuPhotoMarkCrowded.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuPhotoMarkCrowded.Size = new System.Drawing.Size(529, 38);
            this.mnuPhotoMarkCrowded.Text = "Mark Photo as &Crowded";
            // 
            // mnuPhotoMarkBibs
            // 
            this.mnuPhotoMarkBibs.Name = "mnuPhotoMarkBibs";
            this.mnuPhotoMarkBibs.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuPhotoMarkBibs.Size = new System.Drawing.Size(424, 38);
            this.mnuPhotoMarkBibs.Text = "Mark &Bib Regions";
            // 
            // mnuPhotoMarkFaces
            // 
            this.mnuPhotoMarkFaces.Name = "mnuPhotoMarkFaces";
            this.mnuPhotoMarkFaces.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuPhotoMarkFaces.Size = new System.Drawing.Size(424, 38);
            this.mnuPhotoMarkFaces.Text = "Mark &Face Regions";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(504, 6);
            // 
            // mnuPhotoSelectNextRunner
            // 
            this.mnuPhotoSelectNextRunner.Name = "mnuPhotoSelectNextRunner";
            this.mnuPhotoSelectNextRunner.ShortcutKeyDisplayString = "";
            this.mnuPhotoSelectNextRunner.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.mnuPhotoSelectNextRunner.Size = new System.Drawing.Size(424, 38);
            this.mnuPhotoSelectNextRunner.Text = "Select &Next Runner";
            // 
            // mnuSelectedRunner
            // 
            this.mnuSelectedRunner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRunnerStaticNumberValue,
            this.toolStripSeparator8,
            this.mnuRunnerMarkBib,
            this.mnuRunnerOpenColorClassificationsWizard,
            this.mnuRunnerOpenClassificationsWizard,
            this.toolStripSeparator3,
            this.mnuRunnerMarkBlurry,
            this.mnuRunnerMarkFaceVisible,
            this.toolStripSeparator4,
            this.mnuRunnerLikelihoodPurchase,
            this.toolStripSeparator5,
            this.mnuRunnerMarkHat,
            this.mnuRunnerMarkGlasses});
            this.mnuSelectedRunner.Name = "mnuSelectedRunner";
            this.mnuSelectedRunner.Size = new System.Drawing.Size(202, 38);
            this.mnuSelectedRunner.Text = "Selected &Runner";
            // 
            // mnuRunnerStaticNumberValue
            // 
            this.mnuRunnerStaticNumberValue.Enabled = false;
            this.mnuRunnerStaticNumberValue.Name = "mnuRunnerStaticNumberValue";
            this.mnuRunnerStaticNumberValue.Size = new System.Drawing.Size(578, 38);
            this.mnuRunnerStaticNumberValue.Text = "Runner #X";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(575, 6);
            // 
            // mnuRunnerMarkBib
            // 
            this.mnuRunnerMarkBib.Name = "mnuRunnerMarkBib";
            this.mnuRunnerMarkBib.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuRunnerMarkBib.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerMarkBib.Text = "Set Bib &Number";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(575, 6);
            // 
            // mnuRunnerMarkBlurry
            // 
            this.mnuRunnerMarkBlurry.Name = "mnuRunnerMarkBlurry";
            this.mnuRunnerMarkBlurry.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuRunnerMarkBlurry.Size = new System.Drawing.Size(578, 38);
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
            this.toolStripSeparator4.Size = new System.Drawing.Size(575, 6);
            // 
            // mnuRunnerLikelihoodPurchase
            // 
            this.mnuRunnerLikelihoodPurchase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRunnerLikelihoodPurchaseNo,
            this.mnuRunnerLikelihoodPurchaseMaybe,
            this.mnuRunnerLikelihoodPurchaseYes});
            this.mnuRunnerLikelihoodPurchase.Name = "mnuRunnerLikelihoodPurchase";
            this.mnuRunnerLikelihoodPurchase.Size = new System.Drawing.Size(578, 38);
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
            this.toolStripSeparator5.Size = new System.Drawing.Size(575, 6);
            // 
            // mnuRunnerMarkHat
            // 
            this.mnuRunnerMarkHat.Name = "mnuRunnerMarkHat";
            this.mnuRunnerMarkHat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuRunnerMarkHat.Size = new System.Drawing.Size(578, 38);
            this.mnuRunnerMarkHat.Text = "Mark Runner Wearing &Hat";
            // 
            // mnuRunnerMarkGlasses
            // 
            this.mnuRunnerMarkGlasses.Name = "mnuRunnerMarkGlasses";
            this.mnuRunnerMarkGlasses.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuRunnerMarkGlasses.Size = new System.Drawing.Size(578, 38);
            this.mnuRunnerMarkGlasses.Text = "Mark Runner Wearing &Glasses";
            // 
            // mnuRunnerOpenClassificationsWizard
            // 
            this.mnuRunnerOpenClassificationsWizard.Name = "mnuRunnerOpenClassificationsWizard";
            this.mnuRunnerOpenClassificationsWizard.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuRunnerOpenClassificationsWizard.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerOpenClassificationsWizard.Text = "Open &Classifications Wizard";
            // 
            // mnuRunnerOpenColorClassificationsWizard
            // 
            this.mnuRunnerOpenColorClassificationsWizard.Name = "mnuRunnerOpenColorClassificationsWizard";
            this.mnuRunnerOpenColorClassificationsWizard.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuRunnerOpenColorClassificationsWizard.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerOpenColorClassificationsWizard.Text = "Open C&olor Selection Wizard";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.Location = new System.Drawing.Point(1572, 3);
            this.btnNextImage.Name = "btnNextImage";
            this.topPanel.SetRowSpan(this.btnNextImage, 2);
            this.btnNextImage.Size = new System.Drawing.Size(267, 157);
            this.btnNextImage.TabIndex = 9;
            this.btnNextImage.Text = "Next   ▶";
            this.btnNextImage.UseVisualStyleBackColor = true;
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevImage.Location = new System.Drawing.Point(3, 3);
            this.btnPrevImage.Name = "btnPrevImage";
            this.topPanel.SetRowSpan(this.btnPrevImage, 2);
            this.btnPrevImage.Size = new System.Drawing.Size(266, 157);
            this.btnPrevImage.TabIndex = 10;
            this.btnPrevImage.Text = "◀   Back";
            this.btnPrevImage.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.ColumnCount = 3;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topPanel.Controls.Add(this.lblInstructions, 0, 1);
            this.topPanel.Controls.Add(this.lblStepName, 0, 0);
            this.topPanel.Controls.Add(this.btnPrevImage, 0, 0);
            this.topPanel.Controls.Add(this.btnNextImage, 2, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 42);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 2;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.topPanel.Size = new System.Drawing.Size(1842, 163);
            this.topPanel.TabIndex = 18;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.White;
            this.lblInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblInstructions.Location = new System.Drawing.Point(279, 97);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(1283, 66);
            this.lblInstructions.TabIndex = 22;
            this.lblInstructions.Text = "[Step Instructions Label]";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStepName
            // 
            this.lblStepName.BackColor = System.Drawing.Color.White;
            this.lblStepName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepName.ForeColor = System.Drawing.Color.Red;
            this.lblStepName.Location = new System.Drawing.Point(279, 0);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(1283, 97);
            this.lblStepName.TabIndex = 21;
            this.lblStepName.Text = "[Step Label]";
            this.lblStepName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuPhotoSelectPrevRunner
            // 
            this.mnuPhotoSelectPrevRunner.Name = "mnuPhotoSelectPrevRunner";
            this.mnuPhotoSelectPrevRunner.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Tab)));
            this.mnuPhotoSelectPrevRunner.Size = new System.Drawing.Size(529, 38);
            this.mnuPhotoSelectPrevRunner.Text = "Select &Previous Runner";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 1450);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imgPhoto);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private BindableToolStripMenuItem mnuFile;
        private BindableToolStripMenuItem mnuFileLoadImages;
        private System.Windows.Forms.ToolStripStatusLabel lblMousePos;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.Label lblStepName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private BindableToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Label lblInstructions;
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
    }
}

