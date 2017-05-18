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
            this.tblcolBibNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcolFaceTagged = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblcolBibDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblTags)).BeginInit();
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
            this.tblcolFaceTagged,
            this.tblcolBibDelete});
            this.tblTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTags.Location = new System.Drawing.Point(0, 0);
            this.tblTags.MultiSelect = false;
            this.tblTags.Name = "tblTags";
            this.tblTags.ReadOnly = true;
            this.tblTags.RowHeadersVisible = false;
            this.tblTags.RowTemplate.Height = 50;
            this.tblTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblTags.Size = new System.Drawing.Size(738, 483);
            this.tblTags.StandardTab = true;
            this.tblTags.TabIndex = 17;
            // 
            // tblcolBibNumber
            // 
            this.tblcolBibNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            this.tblcolBibNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblcolBibNumber.FillWeight = 90F;
            this.tblcolBibNumber.Frozen = true;
            this.tblcolBibNumber.HeaderText = "Bib Number";
            this.tblcolBibNumber.Name = "tblcolBibNumber";
            this.tblcolBibNumber.ReadOnly = true;
            this.tblcolBibNumber.Width = 211;
            // 
            // tblcolFaceTagged
            // 
            this.tblcolFaceTagged.FillWeight = 10F;
            this.tblcolFaceTagged.HeaderText = "Face Tagged";
            this.tblcolFaceTagged.Name = "tblcolFaceTagged";
            this.tblcolFaceTagged.ReadOnly = true;
            // 
            // tblcolBibDelete
            // 
            this.tblcolBibDelete.FillWeight = 10F;
            this.tblcolBibDelete.HeaderText = "Delete";
            this.tblcolBibDelete.Name = "tblcolBibDelete";
            this.tblcolBibDelete.ReadOnly = true;
            this.tblcolBibDelete.Text = "Delete";
            this.tblcolBibDelete.ToolTipText = "Delete this bib region";
            this.tblcolBibDelete.UseColumnTextForButtonValue = true;
            // 
            // TaggingToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 483);
            this.ControlBox = false;
            this.Controls.Add(this.tblTags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "TaggingToolbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tagging Toolbox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tblTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcolBibNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tblcolFaceTagged;
        private System.Windows.Forms.DataGridViewButtonColumn tblcolBibDelete;
    }
}