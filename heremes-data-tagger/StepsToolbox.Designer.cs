namespace HermesDataTagger
{
    partial class StepsToolbox
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
            this.lblFilename = new System.Windows.Forms.Label();
            this.lstSteps = new System.Windows.Forms.ListBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chbxIsCrowded = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilename
            // 
            this.lblFilename.BackColor = System.Drawing.Color.Transparent;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(12, 9);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(668, 29);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.Text = "[Filename]";
            this.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSteps
            // 
            this.lstSteps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSteps.FormattingEnabled = true;
            this.lstSteps.ItemHeight = 37;
            this.lstSteps.Items.AddRange(new object[] {
            ""});
            this.lstSteps.Location = new System.Drawing.Point(12, 404);
            this.lstSteps.Name = "lstSteps";
            this.lstSteps.Size = new System.Drawing.Size(668, 152);
            this.lstSteps.TabIndex = 3;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Red;
            this.lblInstructions.Location = new System.Drawing.Point(11, 631);
            this.lblInstructions.MaximumSize = new System.Drawing.Size(668, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(171, 31);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "[Instructions]";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(668, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "INSTRUCTIONS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imgPhoto.Location = new System.Drawing.Point(12, 41);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(668, 315);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 0;
            this.imgPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "STEPS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevStep
            // 
            this.btnPrevStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevStep.Location = new System.Drawing.Point(12, 906);
            this.btnPrevStep.Name = "btnPrevStep";
            this.btnPrevStep.Size = new System.Drawing.Size(300, 63);
            this.btnPrevStep.TabIndex = 10;
            this.btnPrevStep.Text = "◀   Previous Step";
            this.btnPrevStep.UseVisualStyleBackColor = true;
            // 
            // btnNextStep
            // 
            this.btnNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStep.Location = new System.Drawing.Point(380, 906);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(300, 63);
            this.btnNextStep.TabIndex = 11;
            this.btnNextStep.Text = "Next Step   ▶";
            this.btnNextStep.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(12, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(668, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Use S and SHIFT+S to move to next and previous step";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbxIsCrowded
            // 
            this.chbxIsCrowded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxIsCrowded.AutoSize = true;
            this.chbxIsCrowded.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxIsCrowded.Location = new System.Drawing.Point(89, 824);
            this.chbxIsCrowded.Name = "chbxIsCrowded";
            this.chbxIsCrowded.Size = new System.Drawing.Size(533, 55);
            this.chbxIsCrowded.TabIndex = 12;
            this.chbxIsCrowded.Text = "Mark photo as [&C]rowded";
            this.chbxIsCrowded.UseVisualStyleBackColor = true;
            // 
            // StepsToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(692, 1013);
            this.ControlBox = false;
            this.Controls.Add(this.chbxIsCrowded);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnPrevStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lstSteps);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.imgPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StepsToolbox";
            this.Text = "Steps Toolbox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.ListBox lstSteps;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevStep;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbxIsCrowded;
    }
}