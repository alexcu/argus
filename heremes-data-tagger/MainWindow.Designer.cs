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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadImages = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabSteps = new System.Windows.Forms.TabControl();
            this.lblStepName = new System.Windows.Forms.Label();
            this.tabPagePrototype = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.tabSteps.SuspendLayout();
            this.tabPagePrototype.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPhoto
            // 
            this.imgPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPhoto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPhoto.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgPhoto.Location = new System.Drawing.Point(3, 217);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(1816, 1129);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 1342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1816, 37);
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
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1816, 40);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadImages});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuLoadImages
            // 
            this.mnuLoadImages.Name = "mnuLoadImages";
            this.mnuLoadImages.Size = new System.Drawing.Size(249, 38);
            this.mnuLoadImages.Text = "Load Images";
            // 
            // btnNextImage
            // 
            this.btnNextImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.Location = new System.Drawing.Point(1546, 3);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(267, 168);
            this.btnNextImage.TabIndex = 9;
            this.btnNextImage.Text = "[&N]ext >";
            this.btnNextImage.UseVisualStyleBackColor = true;
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevImage.Location = new System.Drawing.Point(3, 3);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(266, 168);
            this.btnPrevImage.TabIndex = 10;
            this.btnPrevImage.Text = "< [&B]ack";
            this.btnPrevImage.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.ColumnCount = 3;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.topPanel.Controls.Add(this.btnPrevImage, 0, 0);
            this.topPanel.Controls.Add(this.btnNextImage, 2, 0);
            this.topPanel.Controls.Add(this.tabSteps, 1, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 40);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 1;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topPanel.Size = new System.Drawing.Size(1816, 174);
            this.topPanel.TabIndex = 18;
            // 
            // tabSteps
            // 
            this.tabSteps.Controls.Add(this.tabPagePrototype);
            this.tabSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSteps.Location = new System.Drawing.Point(275, 3);
            this.tabSteps.Name = "tabSteps";
            this.tabSteps.SelectedIndex = 0;
            this.tabSteps.Size = new System.Drawing.Size(1265, 168);
            this.tabSteps.TabIndex = 11;
            // 
            // lblStepName
            // 
            this.lblStepName.BackColor = System.Drawing.Color.White;
            this.lblStepName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStepName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepName.ForeColor = System.Drawing.Color.Red;
            this.lblStepName.Location = new System.Drawing.Point(3, 3);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Padding = new System.Windows.Forms.Padding(20);
            this.lblStepName.Size = new System.Drawing.Size(1243, 114);
            this.lblStepName.TabIndex = 20;
            this.lblStepName.Text = "[Step Label]";
            this.lblStepName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPagePrototype.Controls.Add(this.lblStepName);
            this.tabPagePrototype.Location = new System.Drawing.Point(8, 43);
            this.tabPagePrototype.Name = "tabPage1";
            this.tabPagePrototype.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrototype.Size = new System.Drawing.Size(1249, 117);
            this.tabPagePrototype.TabIndex = 0;
            this.tabPagePrototype.Text = "Step 1";
            this.tabPagePrototype.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 1379);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imgPhoto);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1842, 1450);
            this.Name = "MainWindow";
            this.Text = "Racing Bib Number Tagger";
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.tabSteps.ResumeLayout(false);
            this.tabPagePrototype.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadImages;
        private System.Windows.Forms.ToolStripStatusLabel lblMousePos;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.TabControl tabSteps;
        private System.Windows.Forms.TabPage tabPagePrototype;
        private System.Windows.Forms.Label lblStepName;
    }
}

