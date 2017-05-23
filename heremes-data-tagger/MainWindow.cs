﻿﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;

namespace HermesDataTagger
{
    public partial class MainWindow : Form
    {
        public static MainWindow Singleton;
        public PictureBox MainPictureBox => imgPhoto;
        private PhotoManager Model = PhotoManager.SharedManager;

        public MainWindow()
        {
            Singleton = this;
            InitializeComponent();
            Model.LoadFiles();
            BindDataToControls();
            BindEvents();
        }

        void BindDataToControls()
        {
            BindDataToMainImageControls();
            BindDataToTopPanelControls();
            BindDataToMenuControls();
            BindDataToStepPanelControls();
            BindDataToTaggedDataGrid();
        }

        void BindEvents()
        {
            BindFormEvents();
            BindTopPanelEvents();
            BindMainImageEvents();
            BindMainMenuEvents();
            BindTaggedDataGridEvents();
        }

        #region Form
        #region Events
        void BindFormEvents()
        {
            MouseWheel += SelectedRunnerChangedByMouse;
            Model.CurrentPhoto.TaggedRunners.ListChanged += ModelListChanged;
            Model.CurrentPhoto.SelectedRunnerUpdated += (sender, e) => RequestRedrawGraphics();
        }

        void SelectedRunnerChangedByMouse(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                Model.CurrentPhoto.SelectPrevRunner();
            }
            else
            {
                Model.CurrentPhoto.SelectNextRunner();
            }
        }
        #endregion
        #endregion

        #region Top Panel
        #region Bind Data
        void BindDataToTopPanelControls()
        {
            // Labels
            lblStepName.DataBindings.Add("Text", Model, "CurrentPhoto.TaggingStepName", false, DataSourceUpdateMode.OnPropertyChanged);
            lblInstructions.DataBindings.Add("Text", Model, "CurrentPhoto.TaggingStepInstructions", false, DataSourceUpdateMode.OnPropertyChanged);
            // Buttons
            btnPrevImage.DataBindings.Add("Enabled", Model, "CanGetPrevPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
            btnNextImage.DataBindings.Add("Enabled", Model, "CanGetNextPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
        #region Events
        void BindTopPanelEvents()
        {
            // Click events
            btnPrevImage.Click += (sender, e) => Model.GetPrevPhoto();
            btnNextImage.Click += (sender, e) => Model.GetNextPhoto();
        }
        #endregion
        #endregion

        #region Main Menu
        #region Bind Data
        void BindDataToMenuControls()
        {
            // View menu
            mnuViewPreviousPhoto.DataBindings.Add("Enabled", Model, "CanGetPrevPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
            mnuViewNextPhoto.DataBindings.Add("Enabled", Model, "CanGetNextPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
            // Edit menu
            //mnuEditUndo.DataBindings.Add("Enabled", Model, "CanUndoLastAction", false, DataSourceUpdateMode.OnPropertyChanged);
            //mnuEditRedo.DataBindings.Add("Enabled", Model, "CanRedoLastAction", false, DataSourceUpdateMode.OnPropertyChanged);
            // Photo menu
            mnuPhotoMarkCrowded.DataBindings.Add("Checked", Model.CurrentPhoto, "IsPhotoCrowded", false, DataSourceUpdateMode.OnPropertyChanged);
            //mnuPhotoMarkBibs.DataBindings.Add("Enabled", Model.CurrentPhoto, "CanMarkBibs", false, DataSourceUpdateMode.OnPropertyChanged);
            //mnuPhotoMarkFaces.DataBindings.Add("Enabled", Model.CurrentPhoto, "CanMarkFaces", false, DataSourceUpdateMode.OnPropertyChanged);
            //mnuPhotoSelectNextRunner.DataBindings.Add("Enabled", Model.CurrentPhoto, "HasTaggedARunner", false, DataSourceUpdateMode.OnPropertyChanged);
            //mnuPhotoSelectPrevRunner.DataBindings.Add("Enabled", Model.CurrentPhoto, "HasTaggedARunner", false, DataSourceUpdateMode.OnPropertyChanged);
            // Selected runner menu
            mnuSelectedRunner.DataBindings.Add("Enabled", Model.CurrentPhoto, "IsRunnerSelected", false, DataSourceUpdateMode.OnPropertyChanged);
            mnuSelectedRunner.EnabledChanged += (sender, e) =>
            {
                // Only bind if no bindings were set
                if (Model.CurrentPhoto.IsRunnerSelected && mnuRunnerStaticNumberValue.DataBindings.Count == 0)
                {
                    mnuRunnerStaticNumberValue.DataBindings.Add("Text", Model.CurrentPhoto, "SelectedRunnerNumber", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerMarkBlurry.DataBindings.Add("Checked", Model.CurrentPhoto.SelectedRunner, "IsRunnerBlurred", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerMarkFaceVisible.DataBindings.Add("Checked", Model.CurrentPhoto.SelectedRunner, "IsFaceVisible", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerMarkGlasses.DataBindings.Add("Checked", Model.CurrentPhoto.SelectedRunner, "IsWearingGlasses", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerMarkHat.DataBindings.Add("Checked", Model.CurrentPhoto.SelectedRunner, "IsWearingHat", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerLikelihoodPurchaseYes.DataBindings.Add("Checked", Model.CurrentPhoto.SelectedRunner, "IsLikelihoodOfPurchaseYes", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerLikelihoodPurchaseMaybe.DataBindings.Add("Checked", Model.CurrentPhoto.SelectedRunner, "IsLikelihoodOfPurchaseMaybe", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerLikelihoodPurchaseNo.DataBindings.Add("Checked", Model.CurrentPhoto.SelectedRunner, "IsLikelihoodOfPurchaseNo", false, DataSourceUpdateMode.OnPropertyChanged);
                    // Can only run wizards once face tagged
                    mnuRunnerOpenColorClassificationsWizard.DataBindings.Add("Enabled", Model.CurrentPhoto.SelectedRunner, "IsFaceRegionTagged", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerOpenClassificationsWizard.DataBindings.Add("Enabled", Model.CurrentPhoto.SelectedRunner, "IsFaceRegionTagged", false, DataSourceUpdateMode.OnPropertyChanged);
                }
            };
        }
        #endregion
        #region Events
        void BindMainMenuEvents()
        {
            // File menu
            mnuFileLoadImages.Click += (sender, e) => Model.AttemptLoadFiles();
            mnuFileExit.Click += (sender, e) => Close();
            // Edit menu
            mnuEditUndo.Click += (sender, e) => Model.CurrentPhoto.UndoLastAction();
            mnuEditRedo.Click += (sender, e) => Model.CurrentPhoto.RedoLastAction();
            // View menu
            mnuViewNextPhoto.Click += (sender, e) => Model.GetNextPhoto();
            mnuViewPreviousPhoto.Click += (sender, e) => Model.GetPrevPhoto();
            // Photo menu
            mnuPhotoSelectNextRunner.Click += (sender, e) => Model.CurrentPhoto.SelectNextRunner();
            mnuPhotoSelectPrevRunner.Click += (sender, e) => Model.CurrentPhoto.SelectPrevRunner();
            mnuPhotoMarkFaces.Click += (sender, e) => Model.CurrentPhoto.TaggingStep = StepType.SelectFaceRegion;
            mnuPhotoMarkBibs.Click += (sender, e) => Model.CurrentPhoto.TaggingStep = StepType.SelectBibRegion;
            mnuPhotoMarkCrowded.Click += (sender, e) => Model.CurrentPhoto.ToggleCrowdedPhoto();
            // Selected runner menu
            mnuRunnerMarkBib.Click += (sender, e) => Model.CurrentPhoto.AskToTagBibNumber(imgPhoto, Model.CurrentPhoto.SelectedRunner);
            mnuRunnerMarkBlurry.Click += (sender, e) => Model.CurrentPhoto.SelectedRunner.IsRunnerBlurred = !Model.CurrentPhoto.SelectedRunner.IsRunnerBlurred;
            mnuRunnerMarkFaceVisible.Click += (sender, e) => Model.CurrentPhoto.SelectedRunner.IsFaceVisible = !Model.CurrentPhoto.SelectedRunner.IsFaceVisible;
            mnuRunnerMarkGlasses.Click += (sender, e) => Model.CurrentPhoto.SelectedRunner.IsWearingGlasses = !Model.CurrentPhoto.SelectedRunner.IsWearingGlasses;
            mnuRunnerMarkHat.Click += (sender, e) => Model.CurrentPhoto.SelectedRunner.IsWearingHat = !Model.CurrentPhoto.SelectedRunner.IsWearingHat;
            mnuRunnerLikelihoodPurchaseYes.Click += (sender, e) => Model.CurrentPhoto.SelectedRunner.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.Yes;
            mnuRunnerLikelihoodPurchaseMaybe.Click += (sender, e) => Model.CurrentPhoto.SelectedRunner.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.Maybe;
            mnuRunnerLikelihoodPurchaseNo.Click += (sender, e) => Model.CurrentPhoto.SelectedRunner.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.No;
            mnuRunnerOpenClassificationsWizard.Click += (sender, e) => Model.CurrentPhoto.AskForBaseClassificationsOfPerson(Model.CurrentPhoto.SelectedRunner);
            mnuRunnerOpenColorClassificationsWizard.Click += (sender, e) => Model.CurrentPhoto.AskForColorClassificationsOfPerson(Model.CurrentPhoto.SelectedRunner);
        }
        #endregion
        #endregion

        #region Step Panel
        #region Bind Data
        void BindDataToStepPanelControls()
        {
            // Crowded
            chbxIsCrowded.DataBindings.Add("Checked", Model, "CurrentPhoto.IsPhotoCrowded", false, DataSourceUpdateMode.OnPropertyChanged);
            // Disable next button & steps if crowded
            btnNextStep.DataBindings.Add("Enabled", Model, "CurrentPhoto.IsPhotoNotCrowded", false, DataSourceUpdateMode.OnPropertyChanged);
            lstSteps.DataBindings.Add("Enabled", Model, "CurrentPhoto.IsPhotoNotCrowded", false, DataSourceUpdateMode.OnPropertyChanged);
            // Selected index of steps
            lstSteps.DataBindings.Add("SelectedIndex", Model, "CurrentPhoto.TaggingStep", false, DataSourceUpdateMode.OnPropertyChanged);

            void PopulateStepList()
            {
                List<string> resultingList = new List<string>();
                Array stepArray = Enum.GetValues(typeof(StepType));
                for (int i = 0; i < stepArray.Length; i++)
                {
                    StepType step = (StepType)stepArray.GetValue(i);
                    string stepLabel = $"[F{i + 1}] {step.ToStepNameString()}";
                    resultingList.Add(stepLabel);
                }
                lstSteps.DataSource = resultingList;
                lstSteps.SelectedIndexChanged += (sender, e) => Model.CurrentPhoto.TaggingStep = (StepType)lstSteps.SelectedIndex;
            }

            // Bind the step list
            PopulateStepList();
        }
        #endregion
        #endregion

        #region Tagged Data Grid
        #region Bind Data
        void BindDataToTaggedDataGrid()
        {
            // Enable bib panel if not in crowded step
            tblTags.DataBindings.Add("Enabled", Model, "CurrentPhoto.IsPhotoNotCrowded", false, DataSourceUpdateMode.OnPropertyChanged);
            // Set up table for bib # identified
            tblTags.AutoGenerateColumns = false;
            tblTags.DataSource = Model.CurrentPhoto.TaggedRunners;
            tblcolBibNumber.DataPropertyName = "BibNumber";
            tblcolFaceVisible.DataPropertyName = "IsFaceVisible";
            tblcolBlurry.DataPropertyName = "IsRunnerBlurred";
            tblcolWearingGlasses.DataPropertyName = "IsWearingGlasses";
            tblcolWearingHat.DataPropertyName = "IsWearingHat";
            tblcolLikelihoodPurchase.DataPropertyName = "LikelihoodOfPurchaseName";

            // Bind colour and name
            tblcolShirtColor.DataPropertyName = "ShirtColorName";
            tblcolShortsColor.DataPropertyName = "ShortsColorName";
            tblcolShoeColor.DataPropertyName = "ShoeColorName";

        }
        #endregion
        #region Events
        void BindTaggedDataGridEvents()
        {
            // Update highlighted row on state change
            tblTags.RowStateChanged += UpdateSelectedItem;
            // Switch to most recently added in bind list
            tblTags.RowsAdded += NewTagAdded;
            tblTags.CellContentClick += HandleClickRow;
            // Mouse in/out to show status
            tblTags.CellMouseEnter += (sender, e) => lblTooltip.Text = tblTags.Columns[e.ColumnIndex].ToolTipText;
            tblTags.MouseEnter += (sender, e) => lblTooltip.Visible = true;
            tblTags.MouseLeave += (sender, e) => lblTooltip.Visible = false;
            // Pointer cursor
            tblTags.CellMouseMove += SetCursorForCell;
            // Update selected runner
            Model.CurrentPhoto.SelectedRunnerUpdated += UpdateSelectedRunnerRow;

            // Bind the background color
            tblTags.CellFormatting += BackgroundForSelectedColors;
        }
        
        void BackgroundForSelectedColors(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TaggedPerson person = (TaggedPerson)tblTags.Rows[e.RowIndex].DataBoundItem;
            string col = tblTags.Columns[e.ColumnIndex].Name;
            switch (col)
            {
                case "tblcolShoeColor":
                    e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = person.ShoeColor.IsEmpty ? Color.White : person.ShoeColor;
                    e.CellStyle.ForeColor = e.CellStyle.SelectionForeColor = person.ShoeColor.IsEmpty ? SystemColors.ControlText : Utils.LabelForeColorForBackColor(person.ShoeColor);
                    break;
                case "tblcolShortsColor":
                    e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = person.ShortsColor.IsEmpty ? Color.White : person.ShortsColor;
                    e.CellStyle.ForeColor = e.CellStyle.SelectionForeColor = person.ShortsColor.IsEmpty ? SystemColors.ControlText : Utils.LabelForeColorForBackColor(person.ShortsColor);
                    break;
                case "tblcolShirtColor":
                    e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = person.ShirtColor.IsEmpty ? Color.White : person.ShirtColor;
                    e.CellStyle.ForeColor = e.CellStyle.SelectionForeColor = person.ShirtColor.IsEmpty ? SystemColors.ControlText : Utils.LabelForeColorForBackColor(person.ShirtColor);
                    break;
            }
        }

        void SetCursorForCell(object sender, DataGridViewCellMouseEventArgs e)
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

        void UpdateSelectedItem(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                Model.CurrentPhoto.SelectedRunner = (TaggedPerson)e.Row.DataBoundItem;
            }
        }

        void UpdateSelectedRunnerRow(object sender, EventArgs e)
        {
            TaggedPerson runner = Model.CurrentPhoto.SelectedRunner;
            int rowIdx = Model.CurrentPhoto.TaggedRunners.IndexOf(runner);
            tblTags.ClearSelection();
            tblTags.Rows[rowIdx].Selected = true;
        }

        void HandleClickRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

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

        void NewTagAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tblTags.Rows[0].Selected = true;
        }
        #endregion
        #endregion

        #region Main Picture Box
        #region Bind Data
        void BindDataToMainImageControls()
        {
            imgPhoto.DataBindings.Add("ImageLocation", Model, "CurrentPhoto.Filename", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
        #region Events
        void BindMainImageEvents()
        {
            // Mouse move event
            imgPhoto.MouseMove += UpdateCoordinatesLabel;
            imgPhoto.MouseEnter += (sender, e) => lblMousePos.Visible = true;
            imgPhoto.MouseLeave += (sender, e) => lblMousePos.Visible = false;

            // Mouse click event
            imgPhoto.MouseClick += ClickPhoto;

            // Drag and drop events
            imgPhoto.MouseDown += MouseDragStart;
            imgPhoto.MouseMove += MouseDragMove;
            imgPhoto.MouseUp += MouseDragStop;

            // Paint event
            imgPhoto.Paint += RenderGraphics;
        }

        void MouseDragStop(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Model.CurrentPhoto.HandleDragStop(imgPhoto, e);
                RequestRedrawGraphics();
            }
        }

        void MouseDragMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Model.CurrentPhoto.HandleDragMove(imgPhoto, e);
                RequestRedrawGraphics();
            }
        }

        void MouseDragStart(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Model.CurrentPhoto.HandleDragStart(imgPhoto, e);
                RequestRedrawGraphics();
            }
        }

        void ClickPhoto(object sender, MouseEventArgs e)
        {
            Model.CurrentPhoto.HandleClick(imgPhoto, e);
        }

        void UpdateCoordinatesLabel(object sender, MouseEventArgs e)
        {
            if (imgPhoto.Image != null)
            {
                var pt = e.Location.ToPixelPoint(imgPhoto);
                lblMousePos.Text = $"{pt.X}x{pt.Y}";
            }
        }

        void ModelListChanged(object sender, ListChangedEventArgs e)
        {
            // Redraw graphics whenever we delete or select a new item
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemDeleted:
                    RequestRedrawGraphics();
                    break;
            }
        }

        #endregion
        #region Graphics Rendering
        
        public void RequestRedrawGraphics()
        {
            imgPhoto.Invalidate();
        }

        void RenderGraphics(object sender, PaintEventArgs e)
        {
            // Don't render if crowded image
            if (Model.CurrentPhoto.IsPhotoCrowded)
            {
                return;
            }
            Debug.WriteLine("Rendering Graphics...");
            Graphics graphics = e.Graphics;
            // For every runner tagged in the photo
            foreach (TaggedPerson person in Model.CurrentPhoto.TaggedRunners)
            {
                bool isSelectedPerson = person == Model.CurrentPhoto.SelectedRunner;
                Pen bibPen = isSelectedPerson ? Utils.SelectedBibPen : Utils.BibPen;
                Pen facePen = isSelectedPerson ? Utils.SelectedFacePen : Utils.FacePen;

                // Draw bounding box of person
                if (isSelectedPerson)
                {
                    Utils.GuidelinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    graphics.DrawLine(Utils.GuidelinePen, person.LeftmostClickX, 0, person.LeftmostClickX, imgPhoto.Height);
                    graphics.DrawLine(Utils.GuidelinePen, person.RightmostClickX, 0, person.RightmostClickX, imgPhoto.Height);
                }

                // Markup each bib region (granted two lines)
                if (person.Bib.ClickPoints.Count > 1)
                {
                    graphics.DrawLines(bibPen, person.Bib.ClickPoints.ToArray());
                    // Autocomplete the line between the first and last click if fully tagged
                    if (person.IsBibRegionTagged)
                    {
                        graphics.DrawLine(bibPen, person.Bib.ClickPoints.First(), person.Bib.ClickPoints.Last());
                    }
                }
                // Number has been assigned? Draw that number
                if (person.Bib.BibNumber != null)
                {
                    graphics.DrawString(person.BibNumber, Utils.StdFont, Utils.BibBrush, person.Bib.TopLeft.X, person.Bib.TopLeft.Y - 50);
                }
                // Draw face
                if (person.Face.ClickPoints.Count == 2)
                {
                    Point startPt = person.Face.ClickPoints[0];
                    Point endPt = person.Face.ClickPoints[1];
                    int startX = startPt.X;
                    int startY = startPt.Y;
                    int width = Math.Abs(startX - endPt.X);
                    int height = Math.Abs(startY - endPt.Y);
                    graphics.DrawRectangle(facePen, startX, startY, width, height);
                    graphics.DrawString(person.BibNumber, Utils.StdFont, Utils.FaceBrush, person.Face.TopLeft.X, person.Face.TopLeft.Y - 50);
                    // Draw line between face and bib number
                    graphics.DrawLine(Utils.RedPen, startX, startY + height, person.Bib.TopLeft.X, person.Bib.TopLeft.Y);
                    graphics.DrawLine(Utils.RedPen, person.Face.BtmRight, person.Bib.TopRight);
                }
            }
        }
        #endregion
        #endregion
    }
}
