namespace Ponos
{
    partial class PersonBaseClassificationDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoGenderFemale = new System.Windows.Forms.RadioButton();
            this.rdoGenderMale = new System.Windows.Forms.RadioButton();
            this.rdoGenderUnknown = new System.Windows.Forms.RadioButton();
            this.imgPersonCrop = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpClothing.SuspendLayout();
            this.grpLikelihood.SuspendLayout();
            this.grpVisibility.SuspendLayout();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(0, 850);
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.grpClothing, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.grpLikelihood, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.grpVisibility, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpGender, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imgPersonCrop, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 850);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 1729);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 1634);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 82);
            this.panel1.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(338, 82);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "[&S]ave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(410, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(338, 82);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "[&C]ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpClothing
            // 
            this.grpClothing.AutoSize = true;
            this.grpClothing.Controls.Add(this.chbxHat);
            this.grpClothing.Controls.Add(this.chbxGlasses);
            this.grpClothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpClothing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpClothing.Location = new System.Drawing.Point(13, 1464);
            this.grpClothing.Name = "grpClothing";
            this.grpClothing.Size = new System.Drawing.Size(748, 164);
            this.grpClothing.TabIndex = 19;
            this.grpClothing.TabStop = false;
            this.grpClothing.Text = "Clothing Assessories";
            // 
            // chbxHat
            // 
            this.chbxHat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbxHat.AutoSize = true;
            this.chbxHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxHat.Location = new System.Drawing.Point(22, 107);
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
            this.grpLikelihood.AutoSize = true;
            this.grpLikelihood.Controls.Add(this.rdoMaybeBuy);
            this.grpLikelihood.Controls.Add(this.rdoNotBuy);
            this.grpLikelihood.Controls.Add(this.rdoWouldBuy);
            this.grpLikelihood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLikelihood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpLikelihood.Location = new System.Drawing.Point(13, 1208);
            this.grpLikelihood.Name = "grpLikelihood";
            this.grpLikelihood.Size = new System.Drawing.Size(748, 250);
            this.grpLikelihood.TabIndex = 18;
            this.grpLikelihood.TabStop = false;
            this.grpLikelihood.Text = "Likelihood Of Purchase";
            // 
            // rdoMaybeBuy
            // 
            this.rdoMaybeBuy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoMaybeBuy.AutoSize = true;
            this.rdoMaybeBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaybeBuy.Location = new System.Drawing.Point(34, 111);
            this.rdoMaybeBuy.Name = "rdoMaybeBuy";
            this.rdoMaybeBuy.Size = new System.Drawing.Size(601, 46);
            this.rdoMaybeBuy.TabIndex = 7;
            this.rdoMaybeBuy.TabStop = true;
            this.rdoMaybeBuy.Tag = "0";
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
            this.rdoNotBuy.Tag = "-1";
            this.rdoNotBuy.Text = "[&1] I would NOT buy this photo";
            this.rdoNotBuy.UseVisualStyleBackColor = true;
            // 
            // rdoWouldBuy
            // 
            this.rdoWouldBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoWouldBuy.AutoSize = true;
            this.rdoWouldBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWouldBuy.Location = new System.Drawing.Point(34, 173);
            this.rdoWouldBuy.Name = "rdoWouldBuy";
            this.rdoWouldBuy.Size = new System.Drawing.Size(684, 46);
            this.rdoWouldBuy.TabIndex = 8;
            this.rdoWouldBuy.TabStop = true;
            this.rdoWouldBuy.Tag = "1";
            this.rdoWouldBuy.Text = "[&3] I would DEFINITELY buy this photo";
            this.rdoWouldBuy.UseVisualStyleBackColor = true;
            // 
            // grpVisibility
            // 
            this.grpVisibility.AutoSize = true;
            this.grpVisibility.Controls.Add(this.chbxBlurry);
            this.grpVisibility.Controls.Add(this.chbxFaceVisible);
            this.grpVisibility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpVisibility.Location = new System.Drawing.Point(13, 1038);
            this.grpVisibility.Name = "grpVisibility";
            this.grpVisibility.Size = new System.Drawing.Size(748, 164);
            this.grpVisibility.TabIndex = 17;
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
            this.chbxFaceVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbxFaceVisible.AutoSize = true;
            this.chbxFaceVisible.Checked = true;
            this.chbxFaceVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxFaceVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxFaceVisible.Location = new System.Drawing.Point(26, 109);
            this.chbxFaceVisible.Name = "chbxFaceVisible";
            this.chbxFaceVisible.Size = new System.Drawing.Size(599, 46);
            this.chbxFaceVisible.TabIndex = 5;
            this.chbxFaceVisible.Text = "Mark runners FACE as [&V]ISIBLE";
            this.chbxFaceVisible.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.AutoSize = true;
            this.grpGender.Controls.Add(this.rdoGenderFemale);
            this.grpGender.Controls.Add(this.rdoGenderMale);
            this.grpGender.Controls.Add(this.rdoGenderUnknown);
            this.grpGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpGender.Location = new System.Drawing.Point(13, 782);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(748, 250);
            this.grpGender.TabIndex = 16;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Runner\'s Gender";
            // 
            // rdoGenderFemale
            // 
            this.rdoGenderFemale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoGenderFemale.AutoSize = true;
            this.rdoGenderFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGenderFemale.Location = new System.Drawing.Point(34, 111);
            this.rdoGenderFemale.Name = "rdoGenderFemale";
            this.rdoGenderFemale.Size = new System.Drawing.Size(363, 46);
            this.rdoGenderFemale.TabIndex = 7;
            this.rdoGenderFemale.TabStop = true;
            this.rdoGenderFemale.Tag = "0";
            this.rdoGenderFemale.Text = "Runner is [&F]emale";
            this.rdoGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rdoGenderMale
            // 
            this.rdoGenderMale.AutoSize = true;
            this.rdoGenderMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGenderMale.Location = new System.Drawing.Point(34, 50);
            this.rdoGenderMale.Name = "rdoGenderMale";
            this.rdoGenderMale.Size = new System.Drawing.Size(320, 46);
            this.rdoGenderMale.TabIndex = 6;
            this.rdoGenderMale.TabStop = true;
            this.rdoGenderMale.Tag = "-1";
            this.rdoGenderMale.Text = "Runner is [&M]ale";
            this.rdoGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdoGenderUnknown
            // 
            this.rdoGenderUnknown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdoGenderUnknown.AutoSize = true;
            this.rdoGenderUnknown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGenderUnknown.Location = new System.Drawing.Point(34, 173);
            this.rdoGenderUnknown.Name = "rdoGenderUnknown";
            this.rdoGenderUnknown.Size = new System.Drawing.Size(270, 46);
            this.rdoGenderUnknown.TabIndex = 8;
            this.rdoGenderUnknown.TabStop = true;
            this.rdoGenderUnknown.Tag = "1";
            this.rdoGenderUnknown.Text = "I am [&U]nsure";
            this.rdoGenderUnknown.UseVisualStyleBackColor = true;
            // 
            // imgPersonCrop
            // 
            this.imgPersonCrop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPersonCrop.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgPersonCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPersonCrop.Location = new System.Drawing.Point(13, 13);
            this.imgPersonCrop.Name = "imgPersonCrop";
            this.imgPersonCrop.Size = new System.Drawing.Size(748, 763);
            this.imgPersonCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPersonCrop.TabIndex = 1;
            this.imgPersonCrop.TabStop = false;
            // 
            // PersonBaseClassificationDialog
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(774, 1729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonBaseClassificationDialog";
            this.ShowIcon = false;
            this.Text = "Runner Classifications";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpClothing.ResumeLayout(false);
            this.grpClothing.PerformLayout();
            this.grpLikelihood.ResumeLayout(false);
            this.grpLikelihood.PerformLayout();
            this.grpVisibility.ResumeLayout(false);
            this.grpVisibility.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonCrop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpVisibility;
        private System.Windows.Forms.CheckBox chbxBlurry;
        private System.Windows.Forms.CheckBox chbxFaceVisible;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoGenderFemale;
        private System.Windows.Forms.RadioButton rdoGenderMale;
        private System.Windows.Forms.RadioButton rdoGenderUnknown;
        private System.Windows.Forms.PictureBox imgPersonCrop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpClothing;
        private System.Windows.Forms.CheckBox chbxHat;
        private System.Windows.Forms.CheckBox chbxGlasses;
        private System.Windows.Forms.GroupBox grpLikelihood;
        private System.Windows.Forms.RadioButton rdoMaybeBuy;
        private System.Windows.Forms.RadioButton rdoNotBuy;
        private System.Windows.Forms.RadioButton rdoWouldBuy;
    }
}