namespace HermesDataTagger
{
    partial class BibNumberDialog
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
            this.imgBibCrop = new System.Windows.Forms.PictureBox();
            this.txtBibNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnterBibNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBibCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBibCrop
            // 
            this.imgBibCrop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imgBibCrop.Location = new System.Drawing.Point(12, 12);
            this.imgBibCrop.Name = "imgBibCrop";
            this.imgBibCrop.Size = new System.Drawing.Size(608, 131);
            this.imgBibCrop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBibCrop.TabIndex = 0;
            this.imgBibCrop.TabStop = false;
            // 
            // txtBibNumber
            // 
            this.txtBibNumber.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBibNumber.Location = new System.Drawing.Point(12, 203);
            this.txtBibNumber.Name = "txtBibNumber";
            this.txtBibNumber.Size = new System.Drawing.Size(442, 55);
            this.txtBibNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "What is this Bib Number?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnterBibNumber
            // 
            this.btnEnterBibNumber.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnterBibNumber.Enabled = false;
            this.btnEnterBibNumber.Location = new System.Drawing.Point(460, 203);
            this.btnEnterBibNumber.Name = "btnEnterBibNumber";
            this.btnEnterBibNumber.Size = new System.Drawing.Size(160, 55);
            this.btnEnterBibNumber.TabIndex = 3;
            this.btnEnterBibNumber.Text = "Enter";
            this.btnEnterBibNumber.UseVisualStyleBackColor = true;
            // 
            // BibNumberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 313);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnterBibNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBibNumber);
            this.Controls.Add(this.imgBibCrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BibNumberDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bib Number Identification";
            ((System.ComponentModel.ISupportInitialize)(this.imgBibCrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBibCrop;
        private System.Windows.Forms.TextBox txtBibNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterBibNumber;
    }
}