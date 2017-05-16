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
            this.btnLoadImages = new System.Windows.Forms.Button();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.grpTaggingArea = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWriteCSV = new System.Windows.Forms.Button();
            this.grpTaggingArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImages
            // 
            this.btnLoadImages.Location = new System.Drawing.Point(14, 1309);
            this.btnLoadImages.Name = "btnLoadImages";
            this.btnLoadImages.Size = new System.Drawing.Size(204, 63);
            this.btnLoadImages.TabIndex = 8;
            this.btnLoadImages.Text = "Load Images";
            this.btnLoadImages.UseVisualStyleBackColor = true;
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevImage.Location = new System.Drawing.Point(14, 1086);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(204, 217);
            this.btnPrevImage.TabIndex = 10;
            this.btnPrevImage.Text = "< Previous Image";
            this.btnPrevImage.UseVisualStyleBackColor = true;

            // 
            // btnNextImage
            // 
            this.btnNextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.Location = new System.Drawing.Point(1602, 1086);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(202, 217);
            this.btnNextImage.TabIndex = 9;
            this.btnNextImage.Text = "Next Image >";
            this.btnNextImage.UseVisualStyleBackColor = true;

            // 
            // grpTaggingArea
            // 
            this.grpTaggingArea.Controls.Add(this.label5);
            this.grpTaggingArea.Controls.Add(this.button3);
            this.grpTaggingArea.Controls.Add(this.button2);
            this.grpTaggingArea.Controls.Add(this.checkBox2);
            this.grpTaggingArea.Controls.Add(this.label7);
            this.grpTaggingArea.Controls.Add(this.lblFilename);
            this.grpTaggingArea.Controls.Add(this.label3);
            this.grpTaggingArea.Controls.Add(this.label1);
            this.grpTaggingArea.Location = new System.Drawing.Point(224, 1074);
            this.grpTaggingArea.Name = "grpTaggingArea";
            this.grpTaggingArea.Size = new System.Drawing.Size(1372, 298);
            this.grpTaggingArea.TabIndex = 14;
            this.grpTaggingArea.TabStop = false;
            this.grpTaggingArea.Text = "Image Tagging";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Regions:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 52);
            this.button3.TabIndex = 14;
            this.button3.Text = "Select Face Reigon";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 52);
            this.button2.TabIndex = 13;
            this.button2.Text = "Select Bib Region";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(145, 96);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(262, 29);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "This Image Is Crowded";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Crowded:";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(140, 44);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(112, 25);
            this.lblFilename.TabIndex = 6;
            this.lblFilename.Text = "[Filename]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filename:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // imgPhoto
            // 
            this.imgPhoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgPhoto.Location = new System.Drawing.Point(14, -3);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(1790, 1068);
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
            // btnWriteCSV
            // 
            this.btnWriteCSV.Location = new System.Drawing.Point(1602, 1309);
            this.btnWriteCSV.Name = "btnWriteCSV";
            this.btnWriteCSV.Size = new System.Drawing.Size(202, 63);
            this.btnWriteCSV.TabIndex = 12;
            this.btnWriteCSV.Text = "Write CSV";
            this.btnWriteCSV.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 1379);
            this.Controls.Add(this.btnLoadImages);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.grpTaggingArea);
            this.Controls.Add(this.imgPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWriteCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Racing Bib Number Tagger";
            this.grpTaggingArea.ResumeLayout(false);
            this.grpTaggingArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImages;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.GroupBox grpTaggingArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWriteCSV;
    }
}

