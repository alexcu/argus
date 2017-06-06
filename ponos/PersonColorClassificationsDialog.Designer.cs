namespace Ponos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearShoesColor = new System.Windows.Forms.Button();
            this.btnClearShortsColor = new System.Windows.Forms.Button();
            this.btnClearShirtColor = new System.Windows.Forms.Button();
            this.rdoSettingShoesColor = new System.Windows.Forms.RadioButton();
            this.rdoSettingShortsColor = new System.Windows.Forms.RadioButton();
            this.rdoSettingShirtColor = new System.Windows.Forms.RadioButton();
            this.pnlShoesColor = new System.Windows.Forms.Panel();
            this.pnlShortsColor = new System.Windows.Forms.Panel();
            this.pnlShirtColor = new System.Windows.Forms.Panel();
            this.btnClearHatColor = new System.Windows.Forms.Button();
            this.rdoSettingHatColor = new System.Windows.Forms.RadioButton();
            this.pnlHatColor = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.imgPersonCrop = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(0, 850);
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblInstructions, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imgPersonCrop, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 850);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.68421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 1729);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(13, 1630);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 86);
            this.panel2.TabIndex = 52;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(410, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(338, 86);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "[&C]ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(338, 86);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "[&S]ave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearShoesColor);
            this.panel1.Controls.Add(this.btnClearShortsColor);
            this.panel1.Controls.Add(this.btnClearShirtColor);
            this.panel1.Controls.Add(this.rdoSettingShoesColor);
            this.panel1.Controls.Add(this.rdoSettingShortsColor);
            this.panel1.Controls.Add(this.rdoSettingShirtColor);
            this.panel1.Controls.Add(this.pnlShoesColor);
            this.panel1.Controls.Add(this.pnlShortsColor);
            this.panel1.Controls.Add(this.pnlShirtColor);
            this.panel1.Controls.Add(this.btnClearHatColor);
            this.panel1.Controls.Add(this.rdoSettingHatColor);
            this.panel1.Controls.Add(this.pnlHatColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 1226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 398);
            this.panel1.TabIndex = 51;
            // 
            // btnClearShoesColor
            // 
            this.btnClearShoesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearShoesColor.Location = new System.Drawing.Point(561, 276);
            this.btnClearShoesColor.Name = "btnClearShoesColor";
            this.btnClearShoesColor.Size = new System.Drawing.Size(164, 64);
            this.btnClearShoesColor.TabIndex = 60;
            this.btnClearShoesColor.Text = "Clear";
            this.btnClearShoesColor.UseVisualStyleBackColor = true;
            // 
            // btnClearShortsColor
            // 
            this.btnClearShortsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearShortsColor.Location = new System.Drawing.Point(561, 198);
            this.btnClearShortsColor.Name = "btnClearShortsColor";
            this.btnClearShortsColor.Size = new System.Drawing.Size(164, 64);
            this.btnClearShortsColor.TabIndex = 59;
            this.btnClearShortsColor.Text = "Clear";
            this.btnClearShortsColor.UseVisualStyleBackColor = true;
            // 
            // btnClearShirtColor
            // 
            this.btnClearShirtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearShirtColor.Location = new System.Drawing.Point(561, 113);
            this.btnClearShirtColor.Name = "btnClearShirtColor";
            this.btnClearShirtColor.Size = new System.Drawing.Size(164, 64);
            this.btnClearShirtColor.TabIndex = 58;
            this.btnClearShirtColor.Text = "Clear";
            this.btnClearShirtColor.UseVisualStyleBackColor = true;
            // 
            // rdoSettingShoesColor
            // 
            this.rdoSettingShoesColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSettingShoesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSettingShoesColor.Location = new System.Drawing.Point(91, 276);
            this.rdoSettingShoesColor.Name = "rdoSettingShoesColor";
            this.rdoSettingShoesColor.Size = new System.Drawing.Size(455, 64);
            this.rdoSettingShoesColor.TabIndex = 57;
            this.rdoSettingShoesColor.Text = "[&4] Set Shoes Color";
            this.rdoSettingShoesColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSettingShoesColor.UseVisualStyleBackColor = true;
            // 
            // rdoSettingShortsColor
            // 
            this.rdoSettingShortsColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSettingShortsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSettingShortsColor.Location = new System.Drawing.Point(91, 195);
            this.rdoSettingShortsColor.Name = "rdoSettingShortsColor";
            this.rdoSettingShortsColor.Size = new System.Drawing.Size(455, 64);
            this.rdoSettingShortsColor.TabIndex = 56;
            this.rdoSettingShortsColor.Text = "[&3] Set Shorts Color";
            this.rdoSettingShortsColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSettingShortsColor.UseVisualStyleBackColor = true;
            // 
            // rdoSettingShirtColor
            // 
            this.rdoSettingShirtColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSettingShirtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSettingShirtColor.Location = new System.Drawing.Point(91, 113);
            this.rdoSettingShirtColor.Name = "rdoSettingShirtColor";
            this.rdoSettingShirtColor.Size = new System.Drawing.Size(455, 64);
            this.rdoSettingShirtColor.TabIndex = 55;
            this.rdoSettingShirtColor.Text = "[&2] Set Top Color";
            this.rdoSettingShirtColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSettingShirtColor.UseVisualStyleBackColor = true;
            // 
            // pnlShoesColor
            // 
            this.pnlShoesColor.BackColor = System.Drawing.Color.Red;
            this.pnlShoesColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShoesColor.Location = new System.Drawing.Point(21, 276);
            this.pnlShoesColor.Name = "pnlShoesColor";
            this.pnlShoesColor.Size = new System.Drawing.Size(64, 64);
            this.pnlShoesColor.TabIndex = 54;
            // 
            // pnlShortsColor
            // 
            this.pnlShortsColor.BackColor = System.Drawing.Color.Red;
            this.pnlShortsColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShortsColor.Location = new System.Drawing.Point(21, 195);
            this.pnlShortsColor.Name = "pnlShortsColor";
            this.pnlShortsColor.Size = new System.Drawing.Size(64, 64);
            this.pnlShortsColor.TabIndex = 53;
            // 
            // pnlShirtColor
            // 
            this.pnlShirtColor.BackColor = System.Drawing.Color.Red;
            this.pnlShirtColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShirtColor.Location = new System.Drawing.Point(21, 113);
            this.pnlShirtColor.Name = "pnlShirtColor";
            this.pnlShirtColor.Size = new System.Drawing.Size(64, 64);
            this.pnlShirtColor.TabIndex = 52;
            // 
            // btnClearHatColor
            // 
            this.btnClearHatColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHatColor.Location = new System.Drawing.Point(561, 34);
            this.btnClearHatColor.Name = "btnClearHatColor";
            this.btnClearHatColor.Size = new System.Drawing.Size(164, 64);
            this.btnClearHatColor.TabIndex = 51;
            this.btnClearHatColor.Text = "Clear";
            this.btnClearHatColor.UseVisualStyleBackColor = true;
            // 
            // rdoSettingHatColor
            // 
            this.rdoSettingHatColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoSettingHatColor.Checked = true;
            this.rdoSettingHatColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSettingHatColor.Location = new System.Drawing.Point(91, 34);
            this.rdoSettingHatColor.Name = "rdoSettingHatColor";
            this.rdoSettingHatColor.Size = new System.Drawing.Size(455, 64);
            this.rdoSettingHatColor.TabIndex = 50;
            this.rdoSettingHatColor.TabStop = true;
            this.rdoSettingHatColor.Text = "[&1] Set Hat Color";
            this.rdoSettingHatColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoSettingHatColor.UseVisualStyleBackColor = true;
            // 
            // pnlHatColor
            // 
            this.pnlHatColor.BackColor = System.Drawing.Color.Red;
            this.pnlHatColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHatColor.Location = new System.Drawing.Point(21, 34);
            this.pnlHatColor.Name = "pnlHatColor";
            this.pnlHatColor.Size = new System.Drawing.Size(64, 64);
            this.pnlHatColor.TabIndex = 49;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.White;
            this.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblInstructions.Location = new System.Drawing.Point(13, 999);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(748, 224);
            this.lblInstructions.TabIndex = 32;
            this.lblInstructions.Text = "[Click Image Instructions]";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgPersonCrop
            // 
            this.imgPersonCrop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.imgPersonCrop.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imgPersonCrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPersonCrop.Location = new System.Drawing.Point(13, 13);
            this.imgPersonCrop.Name = "imgPersonCrop";
            this.imgPersonCrop.Size = new System.Drawing.Size(748, 983);
            this.imgPersonCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPersonCrop.TabIndex = 22;
            this.imgPersonCrop.TabStop = false;
            // 
            // PersonColorClassificationsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(774, 1729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonColorClassificationsDialog";
            this.ShowIcon = false;
            this.Text = "Runner Color Identification";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonCrop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox imgPersonCrop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearShoesColor;
        private System.Windows.Forms.Button btnClearShortsColor;
        private System.Windows.Forms.Button btnClearShirtColor;
        private System.Windows.Forms.RadioButton rdoSettingShoesColor;
        private System.Windows.Forms.RadioButton rdoSettingShortsColor;
        private System.Windows.Forms.RadioButton rdoSettingShirtColor;
        private System.Windows.Forms.Panel pnlShoesColor;
        private System.Windows.Forms.Panel pnlShortsColor;
        private System.Windows.Forms.Panel pnlShirtColor;
        private System.Windows.Forms.Button btnClearHatColor;
        private System.Windows.Forms.RadioButton rdoSettingHatColor;
        private System.Windows.Forms.Panel pnlHatColor;
    }
}