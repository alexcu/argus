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
            tblcolFaceVisible.DataPropertyName = "IsFaceVisible";
            tblcolBlurry.DataPropertyName = "IsRunnerBlurred";
            tblcolWearingGlasses.DataPropertyName = "IsWearingGlasses";
            tblcolWearingHat.DataPropertyName = "IsWearingHat";
            tblcolLikelihoodPurchase.DataPropertyName = "LikelihoodOfPurchaseName";
            tblTags.RowStateChanged += UpdateSelectedItem;
            // Bind colour and name
            tblcolShirtColor.DataPropertyName = "ShirtColorName";
            tblcolShortsColor.DataPropertyName = "ShortsColorName";
            tblcolShoeColor.DataPropertyName = "ShoeColorName";
            // Bind the background color
            tblTags.CellFormatting += BackgroundForSelectedColors;
        }

        private void BackgroundForSelectedColors(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TaggedPerson person = (TaggedPerson)tblTags.Rows[e.RowIndex].DataBoundItem;
            string col = tblTags.Columns[e.ColumnIndex].Name;
            switch (col)
            {
                case "tblcolShoeColor":
                    e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = person.ShoeColor;
                    e.CellStyle.ForeColor = e.CellStyle.SelectionForeColor = Utils.LabelForeColorForBackColor(person.ShoeColor);
                    break;
                case "tblcolShortsColor":
                    e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = person.ShortsColor;
                    e.CellStyle.ForeColor = e.CellStyle.SelectionForeColor = Utils.LabelForeColorForBackColor(person.ShortsColor);
                    break;
                case "tblcolShirtColor":
                    e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = person.ShirtColor;
                    e.CellStyle.ForeColor = e.CellStyle.SelectionForeColor = Utils.LabelForeColorForBackColor(person.ShirtColor);
                    break;
            }
        }

        private void SetCursorForCell(object sender, DataGridViewCellMouseEventArgs e)
        {
            string col = tblTags.Columns[e.ColumnIndex].Name;
            switch (col)
            {
                case "tblcolBibNumber":
                case "tblcolShoeColor":
                case "tblcolShirtColor":
                case "tblcolShortsColor":
                    Cursor.Current = Cursors.Hand;
                    break;
                default:
                    Cursor.Current = Cursors.Default;
                    break;
            }
        }

        private void UpdateSelectedItem(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                Model.CurrentPhoto.SelectedPerson = (TaggedPerson)e.Row.DataBoundItem;
                // Request update
                MainWindow.Singleton.RequestRedrawGraphics();
            }
        }

        void BindEvents()
        {
            // Prevent form from closing
            FormClosing += (sender, e) => e.Cancel = true;
            // KBD Shortcuts
            KeyboardShortcutManager.SharedManager.BindKeyboardShortcuts(this);
            // Switch to most recently added in bind list
            tblTags.RowsAdded += NewTagAdded;
            tblTags.CellContentClick += HandleClickRow;
            // Mouse in/out to show status
            tblTags.CellMouseEnter += (sender, e) => lblTooltip.Text = tblTags.Columns[e.ColumnIndex].ToolTipText;
            tblTags.MouseEnter += (sender, e) => statusStrip.Visible = true;
            tblTags.MouseLeave += (sender, e) => statusStrip.Visible = false;
            // Pointer cursor
            tblTags.CellMouseMove += SetCursorForCell;
        }

        private void HandleClickRow(object sender, DataGridViewCellEventArgs e)
        {
            var col = tblTags.Columns[e.ColumnIndex];

            bool deleteClicked = col == tblcolBibDelete;
            bool numberClicked = col == tblcolBibNumber;
            bool colorClicked = col == tblcolShirtColor || col == tblcolShoeColor || col == tblcolShortsColor;

            TaggedPerson personClicked = (TaggedPerson)tblTags.Rows[e.RowIndex].DataBoundItem;

            if (deleteClicked)
            {
                Model.CurrentPhoto.DeleteTaggedPerson(personClicked);
            }
            if (numberClicked)
            {
                Model.CurrentPhoto.AskToTagBibNumber(MainWindow.Singleton.MainPictureBox, personClicked);
                MainWindow.Singleton.RequestRedrawGraphics();
            }
            if (colorClicked)
            {
                Model.CurrentPhoto.AskForColorClassificationsOfPerson(personClicked);
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
