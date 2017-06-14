namespace Argus
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
            this.mnuFile = new Argus.BindableToolStripMenuItem();
            this.mnuFileAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new Argus.BindableToolStripMenuItem();
            this.mnuEdit = new Argus.BindableToolStripMenuItem();
            this.mnuEditUndo = new Argus.BindableToolStripMenuItem();
            this.mnuView = new Argus.BindableToolStripMenuItem();
            this.mnuViewPreviousPhoto = new Argus.BindableToolStripMenuItem();
            this.mnuViewNextPhoto = new Argus.BindableToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuViewRotateImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhoto = new Argus.BindableToolStripMenuItem();
            this.mnuPhotoMarkCrowded = new Argus.BindableToolStripMenuItem();
            this.mnuPhotoMarkBibs = new Argus.BindableToolStripMenuItem();
            this.mnuPhotoMarkFaces = new Argus.BindableToolStripMenuItem();
            this.mnuPhotoMarkComplete = new Argus.BindableToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPhotoSelectPrevRunner = new Argus.BindableToolStripMenuItem();
            this.mnuPhotoSelectNextRunner = new Argus.BindableToolStripMenuItem();
            this.mnuSelectedRunner = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerStaticNumberValue = new Argus.BindableToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerOpenMarkBibToolbox = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerOpenMarkBaseClassToolbox = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerOpenColorClassificationsToolbox = new Argus.BindableToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerGender = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerGenderMale = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerGenderFemale = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerGenderUnknown = new Argus.BindableToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerMarkBlurry = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerMarkFaceVisible = new Argus.BindableToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerLikelihoodPurchase = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerLikelihoodPurchaseNo = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerLikelihoodPurchaseMaybe = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerLikelihoodPurchaseYes = new Argus.BindableToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerMarkHat = new Argus.BindableToolStripMenuItem();
            this.mnuRunnerMarkGlasses = new Argus.BindableToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRunnerDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.tblMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpPhotoClass = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chbxIsComplete = new System.Windows.Forms.CheckBox();
            this.chbxIsCrowded = new System.Windows.Forms.CheckBox();
            this.grpSteps = new System.Windows.Forms.GroupBox();
            this.lstSteps = new System.Windows.Forms.ListBox();
            this.tblTags = new System.Windows.Forms.DataGridView();
            this.tblcolBibNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblcolBlurry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolFaceVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolLikelihoodPurchase = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblcolWearingHat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolWearingGlasses = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolShirtColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolShortsColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolShoeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolHatColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolBibDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStepName = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tblMainGrid.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpPhotoClass.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTags)).BeginInit();
            this.pnlInstructions.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.grpFiles.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 1946);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2642, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMousePos
            // 
            this.lblMousePos.Name = "lblMousePos";
            this.lblMousePos.Size = new System.Drawing.Size(68, 32);
            this.lblMousePos.Text = "(X, Y)";
            this.lblMousePos.Visible = false;
            // 
            // lblTooltip
            // 
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(209, 32);
            this.lblTooltip.Text = "[Guidance Tooltip]";
            this.lblTooltip.Visible = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(2642, 42);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileAbout,
            this.toolStripSeparator10,
            this.mnuFileSave,
            this.toolStripSeparator2,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(64, 38);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileAbout
            // 
            this.mnuFileAbout.Name = "mnuFileAbout";
            this.mnuFileAbout.Size = new System.Drawing.Size(393, 38);
            this.mnuFileAbout.Text = "&About Argus";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(393, 38);
            this.mnuFileSave.Text = "Save Tagging Data";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(390, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(393, 38);
            this.mnuFileExit.Text = "&Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditUndo});
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
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewPreviousPhoto,
            this.mnuViewNextPhoto,
            this.toolStripSeparator6,
            this.mnuViewRotateImage});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(78, 38);
            this.mnuView.Text = "&View";
            // 
            // mnuViewPreviousPhoto
            // 
            this.mnuViewPreviousPhoto.Name = "mnuViewPreviousPhoto";
            this.mnuViewPreviousPhoto.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnuViewPreviousPhoto.Size = new System.Drawing.Size(380, 38);
            this.mnuViewPreviousPhoto.Text = "Go &Back Photo";
            // 
            // mnuViewNextPhoto
            // 
            this.mnuViewNextPhoto.Name = "mnuViewNextPhoto";
            this.mnuViewNextPhoto.ShortcutKeyDisplayString = "";
            this.mnuViewNextPhoto.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mnuViewNextPhoto.Size = new System.Drawing.Size(380, 38);
            this.mnuViewNextPhoto.Text = "Go &Forward Photo";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(377, 6);
            // 
            // mnuViewRotateImage
            // 
            this.mnuViewRotateImage.Name = "mnuViewRotateImage";
            this.mnuViewRotateImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuViewRotateImage.Size = new System.Drawing.Size(380, 38);
            this.mnuViewRotateImage.Text = "Rotate Image 90°";
            // 
            // mnuPhoto
            // 
            this.mnuPhoto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhotoMarkCrowded,
            this.mnuPhotoMarkBibs,
            this.mnuPhotoMarkFaces,
            this.mnuPhotoMarkComplete,
            this.toolStripSeparator7,
            this.mnuPhotoSelectPrevRunner,
            this.mnuPhotoSelectNextRunner});
            this.mnuPhoto.Name = "mnuPhoto";
            this.mnuPhoto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuPhoto.Size = new System.Drawing.Size(90, 38);
            this.mnuPhoto.Text = "&Photo";
            // 
            // mnuPhotoMarkCrowded
            // 
            this.mnuPhotoMarkCrowded.Name = "mnuPhotoMarkCrowded";
            this.mnuPhotoMarkCrowded.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuPhotoMarkCrowded.Size = new System.Drawing.Size(422, 38);
            this.mnuPhotoMarkCrowded.Text = "Mark Photo as &Crowded";
            // 
            // mnuPhotoMarkBibs
            // 
            this.mnuPhotoMarkBibs.Name = "mnuPhotoMarkBibs";
            this.mnuPhotoMarkBibs.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuPhotoMarkBibs.Size = new System.Drawing.Size(422, 38);
            this.mnuPhotoMarkBibs.Text = "Mark &Bib Regions";
            // 
            // mnuPhotoMarkFaces
            // 
            this.mnuPhotoMarkFaces.Name = "mnuPhotoMarkFaces";
            this.mnuPhotoMarkFaces.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuPhotoMarkFaces.Size = new System.Drawing.Size(422, 38);
            this.mnuPhotoMarkFaces.Text = "Mark &Face Regions";
            // 
            // mnuPhotoMarkComplete
            // 
            this.mnuPhotoMarkComplete.Name = "mnuPhotoMarkComplete";
            this.mnuPhotoMarkComplete.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuPhotoMarkComplete.Size = new System.Drawing.Size(422, 38);
            this.mnuPhotoMarkComplete.Text = "Mark Photo As Com&plete";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(419, 6);
            // 
            // mnuPhotoSelectPrevRunner
            // 
            this.mnuPhotoSelectPrevRunner.Name = "mnuPhotoSelectPrevRunner";
            this.mnuPhotoSelectPrevRunner.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mnuPhotoSelectPrevRunner.Size = new System.Drawing.Size(422, 38);
            this.mnuPhotoSelectPrevRunner.Text = "Select &Previous Runner";
            // 
            // mnuPhotoSelectNextRunner
            // 
            this.mnuPhotoSelectNextRunner.Name = "mnuPhotoSelectNextRunner";
            this.mnuPhotoSelectNextRunner.ShortcutKeyDisplayString = "";
            this.mnuPhotoSelectNextRunner.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.mnuPhotoSelectNextRunner.Size = new System.Drawing.Size(422, 38);
            this.mnuPhotoSelectNextRunner.Text = "Select &Next Runner";
            // 
            // mnuSelectedRunner
            // 
            this.mnuSelectedRunner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRunnerStaticNumberValue,
            this.toolStripSeparator8,
            this.mnuRunnerOpenMarkBibToolbox,
            this.mnuRunnerOpenMarkBaseClassToolbox,
            this.mnuRunnerOpenColorClassificationsToolbox,
            this.toolStripSeparator1,
            this.mnuRunnerGender,
            this.toolStripSeparator3,
            this.mnuRunnerMarkBlurry,
            this.mnuRunnerMarkFaceVisible,
            this.toolStripSeparator4,
            this.mnuRunnerLikelihoodPurchase,
            this.toolStripSeparator5,
            this.mnuRunnerMarkHat,
            this.mnuRunnerMarkGlasses,
            this.toolStripSeparator9,
            this.mnuRunnerDelete});
            this.mnuSelectedRunner.Name = "mnuSelectedRunner";
            this.mnuSelectedRunner.Size = new System.Drawing.Size(202, 38);
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
            // mnuRunnerOpenMarkBibToolbox
            // 
            this.mnuRunnerOpenMarkBibToolbox.Name = "mnuRunnerOpenMarkBibToolbox";
            this.mnuRunnerOpenMarkBibToolbox.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuRunnerOpenMarkBibToolbox.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerOpenMarkBibToolbox.Text = "Set Bib &Number";
            // 
            // mnuRunnerOpenMarkBaseClassToolbox
            // 
            this.mnuRunnerOpenMarkBaseClassToolbox.Name = "mnuRunnerOpenMarkBaseClassToolbox";
            this.mnuRunnerOpenMarkBaseClassToolbox.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuRunnerOpenMarkBaseClassToolbox.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerOpenMarkBaseClassToolbox.Text = "Set Runner &Classifications";
            // 
            // mnuRunnerOpenColorClassificationsToolbox
            // 
            this.mnuRunnerOpenColorClassificationsToolbox.Name = "mnuRunnerOpenColorClassificationsToolbox";
            this.mnuRunnerOpenColorClassificationsToolbox.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.mnuRunnerOpenColorClassificationsToolbox.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerOpenColorClassificationsToolbox.Text = "Set Runner C&olors";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(513, 6);
            // 
            // mnuRunnerGender
            // 
            this.mnuRunnerGender.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRunnerGenderMale,
            this.mnuRunnerGenderFemale,
            this.mnuRunnerGenderUnknown});
            this.mnuRunnerGender.Name = "mnuRunnerGender";
            this.mnuRunnerGender.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerGender.Text = "Runner\'s Gen&der";
            // 
            // mnuRunnerGenderMale
            // 
            this.mnuRunnerGenderMale.Name = "mnuRunnerGenderMale";
            this.mnuRunnerGenderMale.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuRunnerGenderMale.Size = new System.Drawing.Size(300, 38);
            this.mnuRunnerGenderMale.Text = "&Male";
            // 
            // mnuRunnerGenderFemale
            // 
            this.mnuRunnerGenderFemale.Name = "mnuRunnerGenderFemale";
            this.mnuRunnerGenderFemale.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuRunnerGenderFemale.Size = new System.Drawing.Size(300, 38);
            this.mnuRunnerGenderFemale.Text = "&Female";
            // 
            // mnuRunnerGenderUnknown
            // 
            this.mnuRunnerGenderUnknown.Name = "mnuRunnerGenderUnknown";
            this.mnuRunnerGenderUnknown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuRunnerGenderUnknown.Size = new System.Drawing.Size(300, 38);
            this.mnuRunnerGenderUnknown.Text = "&Unknown";
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
            this.mnuRunnerMarkFaceVisible.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuRunnerMarkFaceVisible.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerMarkFaceVisible.Text = "Mark Face &Visible";
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
            this.mnuRunnerLikelihoodPurchaseNo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuRunnerLikelihoodPurchaseNo.Size = new System.Drawing.Size(547, 38);
            this.mnuRunnerLikelihoodPurchaseNo.Text = "I would &Not buy this photo";
            // 
            // mnuRunnerLikelihoodPurchaseMaybe
            // 
            this.mnuRunnerLikelihoodPurchaseMaybe.Name = "mnuRunnerLikelihoodPurchaseMaybe";
            this.mnuRunnerLikelihoodPurchaseMaybe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuRunnerLikelihoodPurchaseMaybe.Size = new System.Drawing.Size(547, 38);
            this.mnuRunnerLikelihoodPurchaseMaybe.Text = "I would &Maybe buy this photo";
            // 
            // mnuRunnerLikelihoodPurchaseYes
            // 
            this.mnuRunnerLikelihoodPurchaseYes.Name = "mnuRunnerLikelihoodPurchaseYes";
            this.mnuRunnerLikelihoodPurchaseYes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.mnuRunnerLikelihoodPurchaseYes.Size = new System.Drawing.Size(547, 38);
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
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(513, 6);
            // 
            // mnuRunnerDelete
            // 
            this.mnuRunnerDelete.Name = "mnuRunnerDelete";
            this.mnuRunnerDelete.ShortcutKeyDisplayString = "Delete";
            this.mnuRunnerDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuRunnerDelete.Size = new System.Drawing.Size(516, 38);
            this.mnuRunnerDelete.Text = "&Delete Runner";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.Location = new System.Drawing.Point(2512, 3);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(127, 184);
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
            this.btnPrevImage.Size = new System.Drawing.Size(126, 184);
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
            this.tblMainGrid.Location = new System.Drawing.Point(0, 42);
            this.tblMainGrid.Name = "tblMainGrid";
            this.tblMainGrid.RowCount = 3;
            this.tblMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblMainGrid.Size = new System.Drawing.Size(2642, 1904);
            this.tblMainGrid.TabIndex = 18;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.Control;
            this.tblMainGrid.SetColumnSpan(this.pnlRight, 2);
            this.pnlRight.Controls.Add(this.grpPhotoClass);
            this.pnlRight.Controls.Add(this.grpSteps);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(2116, 193);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(523, 1326);
            this.pnlRight.TabIndex = 33;
            // 
            // grpPhotoClass
            // 
            this.grpPhotoClass.Controls.Add(this.tableLayoutPanel1);
            this.grpPhotoClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpPhotoClass.Location = new System.Drawing.Point(0, 958);
            this.grpPhotoClass.Name = "grpPhotoClass";
            this.grpPhotoClass.Padding = new System.Windows.Forms.Padding(10);
            this.grpPhotoClass.Size = new System.Drawing.Size(523, 368);
            this.grpPhotoClass.TabIndex = 28;
            this.grpPhotoClass.TabStop = false;
            this.grpPhotoClass.Text = "General Photo Classification";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chbxIsComplete, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chbxIsCrowded, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 324);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // chbxIsComplete
            // 
            this.chbxIsComplete.AutoSize = true;
            this.chbxIsComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxIsComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxIsComplete.Location = new System.Drawing.Point(3, 165);
            this.chbxIsComplete.Name = "chbxIsComplete";
            this.chbxIsComplete.Padding = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.chbxIsComplete.Size = new System.Drawing.Size(497, 156);
            this.chbxIsComplete.TabIndex = 24;
            this.chbxIsComplete.Text = "Mark photo as Complete [F4]";
            this.chbxIsComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbxIsComplete.UseVisualStyleBackColor = true;
            // 
            // chbxIsCrowded
            // 
            this.chbxIsCrowded.AutoSize = true;
            this.chbxIsCrowded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbxIsCrowded.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxIsCrowded.Location = new System.Drawing.Point(3, 3);
            this.chbxIsCrowded.Name = "chbxIsCrowded";
            this.chbxIsCrowded.Padding = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.chbxIsCrowded.Size = new System.Drawing.Size(497, 156);
            this.chbxIsCrowded.TabIndex = 23;
            this.chbxIsCrowded.Text = "Mark photo as Crowded [F1]";
            this.chbxIsCrowded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbxIsCrowded.UseVisualStyleBackColor = true;
            // 
            // grpSteps
            // 
            this.grpSteps.Controls.Add(this.lstSteps);
            this.grpSteps.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSteps.Location = new System.Drawing.Point(0, 0);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Padding = new System.Windows.Forms.Padding(10);
            this.grpSteps.Size = new System.Drawing.Size(523, 480);
            this.grpSteps.TabIndex = 25;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Steps";
            // 
            // lstSteps
            // 
            this.lstSteps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSteps.FormattingEnabled = true;
            this.lstSteps.ItemHeight = 37;
            this.lstSteps.Items.AddRange(new object[] {
            ""});
            this.lstSteps.Location = new System.Drawing.Point(10, 34);
            this.lstSteps.Name = "lstSteps";
            this.lstSteps.Size = new System.Drawing.Size(503, 436);
            this.lstSteps.TabIndex = 29;
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
            this.tblcolGender,
            this.tblcolBlurry,
            this.tblcolFaceVisible,
            this.tblcolLikelihoodPurchase,
            this.tblcolWearingHat,
            this.tblcolWearingGlasses,
            this.tblcolShirtColor,
            this.tblcolShortsColor,
            this.tblcolShoeColor,
            this.tblcolHatColor,
            this.tblcolBibDelete});
            this.tblMainGrid.SetColumnSpan(this.tblTags, 5);
            this.tblTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTags.Location = new System.Drawing.Point(3, 1525);
            this.tblTags.MultiSelect = false;
            this.tblTags.Name = "tblTags";
            this.tblTags.ReadOnly = true;
            this.tblTags.RowHeadersVisible = false;
            this.tblTags.RowTemplate.Height = 25;
            this.tblTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTags.Size = new System.Drawing.Size(2636, 376);
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
            this.tblcolBibNumber.ReadOnly = true;
            this.tblcolBibNumber.ToolTipText = "The bib number identified of this runner";
            this.tblcolBibNumber.Width = 211;
            // 
            // tblcolGender
            // 
            this.tblcolGender.HeaderText = "Gender";
            this.tblcolGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown"});
            this.tblcolGender.Name = "tblcolGender";
            this.tblcolGender.ReadOnly = true;
            this.tblcolGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblcolGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tblcolBlurry
            // 
            this.tblcolBlurry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolBlurry.HeaderText = "Runner Blurry?";
            this.tblcolBlurry.Name = "tblcolBlurry";
            this.tblcolBlurry.ReadOnly = true;
            this.tblcolBlurry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tblcolBlurry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tblcolBlurry.ToolTipText = "Is this runner blurry?";
            // 
            // tblcolFaceVisible
            // 
            this.tblcolFaceVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolFaceVisible.HeaderText = "Face Visible?";
            this.tblcolFaceVisible.Name = "tblcolFaceVisible";
            this.tblcolFaceVisible.ReadOnly = true;
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
            this.tblcolLikelihoodPurchase.ReadOnly = true;
            this.tblcolLikelihoodPurchase.ToolTipText = "Would you purchase this photo given the option to?";
            // 
            // tblcolWearingHat
            // 
            this.tblcolWearingHat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolWearingHat.HeaderText = "Wearing Hat?";
            this.tblcolWearingHat.Name = "tblcolWearingHat";
            this.tblcolWearingHat.ReadOnly = true;
            this.tblcolWearingHat.ToolTipText = "Is this runner wearing a hat?";
            // 
            // tblcolWearingGlasses
            // 
            this.tblcolWearingGlasses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tblcolWearingGlasses.HeaderText = "Wearing Glasses?";
            this.tblcolWearingGlasses.Name = "tblcolWearingGlasses";
            this.tblcolWearingGlasses.ReadOnly = true;
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
            // tblcolHatColor
            // 
            this.tblcolHatColor.HeaderText = "Hat Color";
            this.tblcolHatColor.Name = "tblcolHatColor";
            this.tblcolHatColor.ReadOnly = true;
            // 
            // tblcolBibDelete
            // 
            this.tblcolBibDelete.HeaderText = "Delete";
            this.tblcolBibDelete.Name = "tblcolBibDelete";
            this.tblcolBibDelete.ReadOnly = true;
            this.tblcolBibDelete.Text = "Delete";
            this.tblcolBibDelete.ToolTipText = "Delete this bib region";
            this.tblcolBibDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.BackColor = System.Drawing.Color.White;
            this.tblMainGrid.SetColumnSpan(this.pnlInstructions, 3);
            this.pnlInstructions.Controls.Add(this.tableLayoutPanel2);
            this.pnlInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInstructions.Location = new System.Drawing.Point(135, 3);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(2371, 184);
            this.pnlInstructions.TabIndex = 28;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblStepName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblInstructions, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2371, 184);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblStepName
            // 
            this.lblStepName.BackColor = System.Drawing.Color.White;
            this.lblStepName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepName.ForeColor = System.Drawing.Color.Red;
            this.lblStepName.Location = new System.Drawing.Point(3, 0);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(2365, 93);
            this.lblStepName.TabIndex = 44;
            this.lblStepName.Text = "[Step Label]";
            this.lblStepName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.White;
            this.lblInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblInstructions.Location = new System.Drawing.Point(3, 93);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(2365, 91);
            this.lblInstructions.TabIndex = 42;
            this.lblInstructions.Text = "[Step Instructions Label]";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPhoto.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPhoto.Location = new System.Drawing.Point(399, 193);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(1711, 1326);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 25;
            this.imgPhoto.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.Control;
            this.tblMainGrid.SetColumnSpan(this.pnlLeft, 2);
            this.pnlLeft.Controls.Add(this.grpFiles);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 193);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(390, 1326);
            this.pnlLeft.TabIndex = 29;
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.lstFiles);
            this.grpFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFiles.Location = new System.Drawing.Point(0, 0);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Padding = new System.Windows.Forms.Padding(10);
            this.grpFiles.Size = new System.Drawing.Size(390, 1326);
            this.grpFiles.TabIndex = 26;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Photo Files";
            // 
            // lstFiles
            // 
            this.lstFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 37;
            this.lstFiles.Items.AddRange(new object[] {
            ""});
            this.lstFiles.Location = new System.Drawing.Point(10, 34);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(370, 1282);
            this.lstFiles.TabIndex = 29;
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(390, 6);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2642, 1968);
            this.Controls.Add(this.tblMainGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Argus";
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
            ((System.ComponentModel.ISupportInitialize)(this.tblTags)).EndInit();
            this.pnlInstructions.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.grpFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private BindableToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripStatusLabel lblMousePos;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.TableLayoutPanel tblMainGrid;
        private BindableToolStripMenuItem mnuFileExit;
        private BindableToolStripMenuItem mnuEdit;
        private BindableToolStripMenuItem mnuEditUndo;
        private BindableToolStripMenuItem mnuView;
        private BindableToolStripMenuItem mnuViewNextPhoto;
        private BindableToolStripMenuItem mnuViewPreviousPhoto;
        private BindableToolStripMenuItem mnuSelectedRunner;
        private BindableToolStripMenuItem mnuRunnerOpenMarkBibToolbox;
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
        private BindableToolStripMenuItem mnuRunnerOpenColorClassificationsToolbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private BindableToolStripMenuItem mnuPhotoSelectNextRunner;
        private BindableToolStripMenuItem mnuRunnerStaticNumberValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private BindableToolStripMenuItem mnuPhotoSelectPrevRunner;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.DataGridView tblTags;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpSteps;
        private System.Windows.Forms.GroupBox grpPhotoClass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chbxIsComplete;
        private System.Windows.Forms.CheckBox chbxIsCrowded;
        private System.Windows.Forms.ToolStripStatusLabel lblTooltip;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.ListBox lstFiles;
        private BindableToolStripMenuItem mnuPhotoMarkComplete;
        private System.Windows.Forms.ListBox lstSteps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private BindableToolStripMenuItem mnuRunnerGender;
        private BindableToolStripMenuItem mnuRunnerGenderMale;
        private BindableToolStripMenuItem mnuRunnerGenderFemale;
        private BindableToolStripMenuItem mnuRunnerGenderUnknown;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolBibNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn tblcolGender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolBlurry;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolFaceVisible;
        private System.Windows.Forms.DataGridViewComboBoxColumn tblcolLikelihoodPurchase;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolWearingHat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolWearingGlasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolShirtColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolShortsColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolShoeColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolHatColor;
        private System.Windows.Forms.DataGridViewButtonColumn tblcolBibDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuViewRotateImage;
        private BindableToolStripMenuItem mnuRunnerOpenMarkBaseClassToolbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mnuRunnerDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblStepName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ToolStripMenuItem mnuFileAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    }
}

