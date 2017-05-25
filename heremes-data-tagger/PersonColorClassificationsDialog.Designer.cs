namespace HermesDataTagger
{
    partial class PersonColorClassificationsDialog
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
            this.imgPersonCrop = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnClearHatColor = new System.Windows.Forms.Button();
            this.rdoSettingHatColor = new System.Windows.Forms.RadioButton();
            this.pnlHatColor = new System.Windows.Forms.Panel();
            this.btnClearShoesColor = new System.Windows.Forms.Button();
            this.btnClearShortsColor = new System.Windows.Forms.Button();
            this.btnClearShirtColor = new System.Windows.Forms.Button();
            this.rdoSettingShoesColor = new System.Windows.Forms.RadioButton();
            this.rdoSettingShortsColor = new System.Windows.Forms.RadioButton();
            this.rdoSettingShirtColor = new System.Windows.Forms.RadioButton();
            this.pnlShoesColor = new System.Windows.Forms.Panel();
            this.pnlShortsColor = new System.Windows.Forms.Panel();
            this.pnlShirtColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPersonCrop
            // 
            this.imgPersonCrop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPersonCrop.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgPersonCrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgPersonCrop.Location = new System.Drawing.Point(0, 0);
            this.imgPersonCrop.Name = "imgPersonCrop";
            this.imgPersonCrop.Size = new System.Drawing.Size(774, 976);
            this.imgPersonCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPersonCrop.TabIndex = 1;
            this.imgPersonCrop.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(424, 1478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(338, 69);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "[&C]ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 1478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(338, 69);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "[&S]ave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.White;
            this.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblInstructions.Location = new System.Drawing.Point(0, 979);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(774, 117);
            this.lblInstructions.TabIndex = 31;
            this.lblInstructions.Text = "[Click Image Instructions]";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearHatColor
            // 
            this.btnClearHatColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHatColor.Location = new System.Drawing.Point(575, 1132);
            this.btnClearHatColor.Name = "btnClearHatColor";
            this.btnClearHatColor.Size = new System.Drawing.Size(164, 64);
            this.btnClearHatColor.TabIndex = 34;
            this.btnClearHatColor.Text = "Clear";
            this.btnClearHatColor.UseVisualStyleBackColor = true;
            // 
            // rdoSettingHatColor
            // 
            this.rdoSettingHatColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSettingHatColor.Checked = true;
            this.rdoSettingHatColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSettingHatColor.Location = new System.Drawing.Point(105, 1132);
            this.rdoSettingHatColor.Name = "rdoSettingHatColor";
            this.rdoSettingHatColor.Size = new System.Drawing.Size(455, 64);
            this.rdoSettingHatColor.TabIndex = 33;
            this.rdoSettingHatColor.TabStop = true;
            this.rdoSettingHatColor.Text = "[&1] Set Hat Color";
            this.rdoSettingHatColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSettingHatColor.UseVisualStyleBackColor = true;
            // 
            // pnlHatColor
            // 
            this.pnlHatColor.BackColor = System.Drawing.Color.Red;
            this.pnlHatColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHatColor.Location = new System.Drawing.Point(35, 1132);
            this.pnlHatColor.Name = "pnlHatColor";
            this.pnlHatColor.Size = new System.Drawing.Size(64, 64);
            this.pnlHatColor.TabIndex = 32;
            // 
            // btnClearShoesColor
            // 
            this.btnClearShoesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearShoesColor.Location = new System.Drawing.Point(575, 1374);
            this.btnClearShoesColor.Name = "btnClearShoesColor";
            this.btnClearShoesColor.Size = new System.Drawing.Size(164, 64);
            this.btnClearShoesColor.TabIndex = 48;
            this.btnClearShoesColor.Text = "Clear";
            this.btnClearShoesColor.UseVisualStyleBackColor = true;
            // 
            // btnClearShortsColor
            // 
            this.btnClearShortsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearShortsColor.Location = new System.Drawing.Point(575, 1296);
            this.btnClearShortsColor.Name = "btnClearShortsColor";
            this.btnClearShortsColor.Size = new System.Drawing.Size(164, 64);
            this.btnClearShortsColor.TabIndex = 47;
            this.btnClearShortsColor.Text = "Clear";
            this.btnClearShortsColor.UseVisualStyleBackColor = true;
            // 
            // btnClearShirtColor
            // 
            this.btnClearShirtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearShirtColor.Location = new System.Drawing.Point(575, 1211);
            this.btnClearShirtColor.Name = "btnClearShirtColor";
            this.btnClearShirtColor.Size = new System.Drawing.Size(164, 64);
            this.btnClearShirtColor.TabIndex = 46;
            this.btnClearShirtColor.Text = "Clear";
            this.btnClearShirtColor.UseVisualStyleBackColor = true;
            // 
            // rdoSettingShoesColor
            // 
            this.rdoSettingShoesColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSettingShoesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSettingShoesColor.Location = new System.Drawing.Point(105, 1374);
            this.rdoSettingShoesColor.Name = "rdoSettingShoesColor";
            this.rdoSettingShoesColor.Size = new System.Drawing.Size(455, 64);
            this.rdoSettingShoesColor.TabIndex = 45;
            this.rdoSettingShoesColor.Text = "[&4] Set Shoes Color";
            this.rdoSettingShoesColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSettingShoesColor.UseVisualStyleBackColor = true;
            // 
            // rdoSettingShortsColor
            // 
            this.rdoSettingShortsColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSettingShortsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSettingShortsColor.Location = new System.Drawing.Point(105, 1293);
            this.rdoSettingShortsColor.Name = "rdoSettingShortsColor";
            this.rdoSettingShortsColor.Size = new System.Drawing.Size(455, 64);
            this.rdoSettingShortsColor.TabIndex = 44;
            this.rdoSettingShortsColor.Text = "[&3] Set Shorts Color";
            this.rdoSettingShortsColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSettingShortsColor.UseVisualStyleBackColor = true;
            // 
            // rdoSettingShirtColor
            // 
            this.rdoSettingShirtColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSettingShirtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSettingShirtColor.Location = new System.Drawing.Point(105, 1211);
            this.rdoSettingShirtColor.Name = "rdoSettingShirtColor";
            this.rdoSettingShirtColor.Size = new System.Drawing.Size(455, 64);
            this.rdoSettingShirtColor.TabIndex = 43;
            this.rdoSettingShirtColor.Text = "[&2] Set Top Color";
            this.rdoSettingShirtColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSettingShirtColor.UseVisualStyleBackColor = true;
            // 
            // pnlShoesColor
            // 
            this.pnlShoesColor.BackColor = System.Drawing.Color.Red;
            this.pnlShoesColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShoesColor.Location = new System.Drawing.Point(35, 1374);
            this.pnlShoesColor.Name = "pnlShoesColor";
            this.pnlShoesColor.Size = new System.Drawing.Size(64, 64);
            this.pnlShoesColor.TabIndex = 42;
            // 
            // pnlShortsColor
            // 
            this.pnlShortsColor.BackColor = System.Drawing.Color.Red;
            this.pnlShortsColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShortsColor.Location = new System.Drawing.Point(35, 1293);
            this.pnlShortsColor.Name = "pnlShortsColor";
            this.pnlShortsColor.Size = new System.Drawing.Size(64, 64);
            this.pnlShortsColor.TabIndex = 41;
            // 
            // pnlShirtColor
            // 
            this.pnlShirtColor.BackColor = System.Drawing.Color.Red;
            this.pnlShirtColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShirtColor.Location = new System.Drawing.Point(35, 1211);
            this.pnlShirtColor.Name = "pnlShirtColor";
            this.pnlShirtColor.Size = new System.Drawing.Size(64, 64);
            this.pnlShirtColor.TabIndex = 40;
            // 
            // PersonColorClassificationsDialog
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(774, 1571);
            this.Controls.Add(this.btnClearShoesColor);
            this.Controls.Add(this.btnClearShortsColor);
            this.Controls.Add(this.btnClearShirtColor);
            this.Controls.Add(this.rdoSettingShoesColor);
            this.Controls.Add(this.rdoSettingShortsColor);
            this.Controls.Add(this.rdoSettingShirtColor);
            this.Controls.Add(this.pnlShoesColor);
            this.Controls.Add(this.pnlShortsColor);
            this.Controls.Add(this.pnlShirtColor);
            this.Controls.Add(this.btnClearHatColor);
            this.Controls.Add(this.rdoSettingHatColor);
            this.Controls.Add(this.pnlHatColor);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.imgPersonCrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 1800);
            this.MinimizeBox = false;
            this.Name = "PersonColorClassificationsDialog";
            this.Text = "Person Color Identification";
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonCrop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPersonCrop;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnClearHatColor;
        private System.Windows.Forms.RadioButton rdoSettingHatColor;
        private System.Windows.Forms.Panel pnlHatColor;
        private System.Windows.Forms.Button btnClearShoesColor;
        private System.Windows.Forms.Button btnClearShortsColor;
        private System.Windows.Forms.Button btnClearShirtColor;
        private System.Windows.Forms.RadioButton rdoSettingShoesColor;
        private System.Windows.Forms.RadioButton rdoSettingShortsColor;
        private System.Windows.Forms.RadioButton rdoSettingShirtColor;
        private System.Windows.Forms.Panel pnlShoesColor;
        private System.Windows.Forms.Panel pnlShortsColor;
        private System.Windows.Forms.Panel pnlShirtColor;
    }
}