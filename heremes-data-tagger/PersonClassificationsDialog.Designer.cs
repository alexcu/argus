namespace HermesDataTagger
{
    partial class PersonClassificationsDialog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpClothing = new System.Windows.Forms.GroupBox();
            this.chbxHat = new System.Windows.Forms.CheckBox();
            this.chbxGlasses = new System.Windows.Forms.CheckBox();
            this.grpLikelihood = new System.Windows.Forms.GroupBox();
            this.rdoMaybeBuy = new System.Windows.Forms.RadioButton();
            this.rdoNotBuy = new System.Windows.Forms.RadioButton();
            this.rdoWouldBuy = new System.Windows.Forms.RadioButton();
            this.grpVisibility = new System.Windows.Forms.GroupBox();
            this.chbxBlurry = new System.Windows.Forms.CheckBox();
            this.chbxFaceVisible = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpClothing.SuspendLayout();
            this.grpLikelihood.SuspendLayout();
            this.grpVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 1008);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpClothing
            // 
            this.grpClothing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClothing.Controls.Add(this.chbxHat);
            this.grpClothing.Controls.Add(this.chbxGlasses);
            this.grpClothing.Location = new System.Drawing.Point(12, 1517);
            this.grpClothing.Name = "grpClothing";
            this.grpClothing.Size = new System.Drawing.Size(750, 180);
            this.grpClothing.TabIndex = 15;
            this.grpClothing.TabStop = false;
            this.grpClothing.Text = "Clothing Assessories";
            // 
            // chbxHat
            // 
            this.chbxHat.AutoSize = true;
            this.chbxHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxHat.Location = new System.Drawing.Point(22, 111);
            this.chbxHat.Name = "chbxHat";
            this.chbxHat.Size = new System.Drawing.Size(456, 46);
            this.chbxHat.TabIndex = 7;
            this.chbxHat.Text = "Runner is wearing [&H]AT";
            this.chbxHat.UseVisualStyleBackColor = true;
            // 
            // chbxGlasses
            // 
            this.chbxGlasses.AutoSize = true;
            this.chbxGlasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxGlasses.Location = new System.Drawing.Point(22, 46);
            this.chbxGlasses.Name = "chbxGlasses";
            this.chbxGlasses.Size = new System.Drawing.Size(651, 46);
            this.chbxGlasses.TabIndex = 6;
            this.chbxGlasses.Text = "Runner is wearing (sun) [&G]LASSES";
            this.chbxGlasses.UseVisualStyleBackColor = true;
            // 
            // grpLikelihood
            // 
            this.grpLikelihood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLikelihood.Controls.Add(this.rdoMaybeBuy);
            this.grpLikelihood.Controls.Add(this.rdoNotBuy);
            this.grpLikelihood.Controls.Add(this.rdoWouldBuy);
            this.grpLikelihood.Location = new System.Drawing.Point(12, 1242);
            this.grpLikelihood.Name = "grpLikelihood";
            this.grpLikelihood.Size = new System.Drawing.Size(750, 253);
            this.grpLikelihood.TabIndex = 14;
            this.grpLikelihood.TabStop = false;
            this.grpLikelihood.Text = "Likelihood Of Purchase";
            // 
            // rdoMaybeBuy
            // 
            this.rdoMaybeBuy.AutoSize = true;
            this.rdoMaybeBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaybeBuy.Location = new System.Drawing.Point(34, 113);
            this.rdoMaybeBuy.Name = "rdoMaybeBuy";
            this.rdoMaybeBuy.Size = new System.Drawing.Size(601, 46);
            this.rdoMaybeBuy.TabIndex = 7;
            this.rdoMaybeBuy.TabStop = true;
            this.rdoMaybeBuy.Text = "[&2] I would MAYBE buy this photo";
            this.rdoMaybeBuy.UseVisualStyleBackColor = true;
            // 
            // rdoNotBuy
            // 
            this.rdoNotBuy.AutoSize = true;
            this.rdoNotBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNotBuy.Location = new System.Drawing.Point(34, 50);
            this.rdoNotBuy.Name = "rdoNotBuy";
            this.rdoNotBuy.Size = new System.Drawing.Size(549, 46);
            this.rdoNotBuy.TabIndex = 6;
            this.rdoNotBuy.TabStop = true;
            this.rdoNotBuy.Text = "[&1] I would NOT buy this photo";
            this.rdoNotBuy.UseVisualStyleBackColor = true;
            // 
            // rdoWouldBuy
            // 
            this.rdoWouldBuy.AutoSize = true;
            this.rdoWouldBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWouldBuy.Location = new System.Drawing.Point(34, 178);
            this.rdoWouldBuy.Name = "rdoWouldBuy";
            this.rdoWouldBuy.Size = new System.Drawing.Size(684, 46);
            this.rdoWouldBuy.TabIndex = 8;
            this.rdoWouldBuy.TabStop = true;
            this.rdoWouldBuy.Text = "[&3] I would DEFINITELY buy this photo";
            this.rdoWouldBuy.UseVisualStyleBackColor = true;
            // 
            // grpVisibility
            // 
            this.grpVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVisibility.Controls.Add(this.chbxBlurry);
            this.grpVisibility.Controls.Add(this.chbxFaceVisible);
            this.grpVisibility.Location = new System.Drawing.Point(12, 1058);
            this.grpVisibility.Name = "grpVisibility";
            this.grpVisibility.Size = new System.Drawing.Size(750, 180);
            this.grpVisibility.TabIndex = 13;
            this.grpVisibility.TabStop = false;
            this.grpVisibility.Text = "Visibility Classifications";
            // 
            // chbxBlurry
            // 
            this.chbxBlurry.AutoSize = true;
            this.chbxBlurry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxBlurry.Location = new System.Drawing.Point(26, 49);
            this.chbxBlurry.Name = "chbxBlurry";
            this.chbxBlurry.Size = new System.Drawing.Size(483, 46);
            this.chbxBlurry.TabIndex = 4;
            this.chbxBlurry.Text = "Mark runner as [&B]LURRY";
            this.chbxBlurry.UseVisualStyleBackColor = true;
            // 
            // chbxFaceVisible
            // 
            this.chbxFaceVisible.AutoSize = true;
            this.chbxFaceVisible.Checked = true;
            this.chbxFaceVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxFaceVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxFaceVisible.Location = new System.Drawing.Point(26, 113);
            this.chbxFaceVisible.Name = "chbxFaceVisible";
            this.chbxFaceVisible.Size = new System.Drawing.Size(599, 46);
            this.chbxFaceVisible.TabIndex = 5;
            this.chbxFaceVisible.Text = "Mark runners [&F]ACE as VISIBLE";
            this.chbxFaceVisible.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 1730);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(750, 69);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "[&S]ave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // PersonClassificationsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSave;
            this.ClientSize = new System.Drawing.Size(774, 1811);
            this.Controls.Add(this.grpClothing);
            this.Controls.Add(this.grpLikelihood);
            this.Controls.Add(this.grpVisibility);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PersonClassificationsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Classifications";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpClothing.ResumeLayout(false);
            this.grpClothing.PerformLayout();
            this.grpLikelihood.ResumeLayout(false);
            this.grpLikelihood.PerformLayout();
            this.grpVisibility.ResumeLayout(false);
            this.grpVisibility.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpClothing;
        private System.Windows.Forms.CheckBox chbxHat;
        private System.Windows.Forms.CheckBox chbxGlasses;
        private System.Windows.Forms.GroupBox grpLikelihood;
        private System.Windows.Forms.RadioButton rdoMaybeBuy;
        private System.Windows.Forms.RadioButton rdoNotBuy;
        private System.Windows.Forms.RadioButton rdoWouldBuy;
        private System.Windows.Forms.GroupBox grpVisibility;
        private System.Windows.Forms.CheckBox chbxBlurry;
        private System.Windows.Forms.CheckBox chbxFaceVisible;
        private System.Windows.Forms.Button btnSave;
    }
}