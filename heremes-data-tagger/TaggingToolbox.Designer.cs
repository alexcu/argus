namespace HermesDataTagger
{
    partial class TaggingToolbox
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
            this.tblTags = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblTooltip = new System.Windows.Forms.ToolStripStatusLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.tblTags)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.tblTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTags.Location = new System.Drawing.Point(0, 0);
            this.tblTags.MultiSelect = false;
            this.tblTags.Name = "tblTags";
            this.tblTags.RowHeadersVisible = false;
            this.tblTags.RowTemplate.Height = 25;
            this.tblTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTags.Size = new System.Drawing.Size(2526, 527);
            this.tblTags.StandardTab = true;
            this.tblTags.TabIndex = 17;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTooltip});
            this.statusStrip.Location = new System.Drawing.Point(0, 489);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(2526, 38);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.Visible = false;
            // 
            // lblTooltip
            // 
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(238, 33);
            this.lblTooltip.Text = "toolStripStatusLabel1";
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
            // TaggingToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2526, 527);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tblTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "TaggingToolbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tagging Toolbox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tblTags)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblTags;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblTooltip;
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
    }
}