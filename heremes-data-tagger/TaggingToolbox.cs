using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HermesDataTagger
{
    public partial class TaggingToolbox : Form
    {
        private PhotoManager Model = PhotoManager.SharedManager;

        public TaggingToolbox()
        {
            InitializeComponent();
            MoveToBottom();
            BindDataToControls();
            BindEvents();
        }

        void BindDataToControls()
        {
            // Enable bib panel if not in crowded step
            tblTags.DataBindings.Add("Enabled", Model, "CurrentPhoto.IsPhotoNotCrowded", false, DataSourceUpdateMode.OnPropertyChanged);
            // Set up table for bib # identified
            tblTags.AutoGenerateColumns = false;
            tblTags.DataSource = Model.CurrentPhoto.TaggedPeople;
            tblcolBibNumber.DataPropertyName = "BibNumber";
        }


        void BindEvents()
        {
            // Prevent form from closing
            FormClosing += (sender, e) => e.Cancel = true;
            // KBD Shortcuts
            KeyboardShortcutManager.SharedManager.BindKeyboardShortcuts(this);
            // Switch to most recently added in bind list
            tblTags.RowsAdded += NewTagAdded;
            tblTags.CellContentClick += HandleDeleteRow;
        }

        private void HandleDeleteRow(object sender, DataGridViewCellEventArgs e)
        {
            if (tblTags.Columns[e.ColumnIndex] == tblcolBibDelete)
            {
                Model.CurrentPhoto.TaggedPeople.RemoveAt(e.RowIndex);
            }
        }

        private void NewTagAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tblTags.Rows[0].Selected = true;
        }

        void MoveToBottom()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
        }

    }
}
