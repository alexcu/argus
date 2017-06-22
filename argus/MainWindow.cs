﻿﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;

namespace Argus
{
    public partial class MainWindow : Form
    {
        public static MainWindow Singleton;
        public PictureBox MainPictureBox => imgPhoto;
        private PhotoManager Model = PhotoManager.SharedManager;
        private List<Binding> _dataBindings = new List<Binding>();

        public MainWindow()
        {
            Singleton = this;
            InitializeComponent();
            Model.LoadFiles();
            Load += WindowLoaded;
        }

        private void WindowLoaded(object sender, EventArgs e)
        {
            BindDataToControls();
            BindEvents();
            RequestDataBindingsUpdate();
            RequestRedrawGraphics();
            RequestUpdateSelectedRunner();
            RequestUpdateSelectedStep();
            Model.CurrentPhoto.TimeToMarkPhoto.Start();
            Model.CurrentPhoto.WaitAndAskForPhotoCrowded();
        }

        void BindDataToControls()
        {
            BindDataToMainImageControls();
            BindDataToTopPanelControls();
            BindDataToMenuControls();
            BindDataToStepPanelControls();
            BindDataToTaggedDataGrid();
            BindDataToFilesPanel();
        }

        void BindEvents()
        {
            BindFormEvents();
            BindTopPanelEvents();
            BindMainImageEvents();
            BindMainMenuEvents();
            BindTaggedDataGridEvents();
            BindFilesPanelEvents();
            BindStepPanelEvents();
        }

        void AddDataBinding(IBindableComponent component, string propertyName, object dataSource, string dataMember)
        {
            Binding dataBinding = new Binding(propertyName, dataSource, dataMember, false, DataSourceUpdateMode.OnPropertyChanged);
            component.DataBindings.Add(dataBinding);
            _dataBindings.Add(dataBinding);
        }

        #region Form
        #region Events
        void BindFormEvents()
        {
            MouseWheel += SelectedRunnerChangedByMouse;
            Model.CurrentPhoto.TaggedRunners.ListChanged += ModelListChanged;
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
        public void RequestUpdateSelectedRunner()
        {
            TaggedPerson person = Model.CurrentPhoto.SelectedRunner;
            if (person != null)
            {
                mnuRunnerStaticNumberValue.Text = $"Selected Runner: {person.BibNumber}";
                UpdateSelectedRunnerRow();
                RequestRedrawGraphics();
                if (Model.CurrentPhoto.TaggingStep == StepType.SelectFaceRegion)
                {
                    lblInstructions.Text = StepType.SelectFaceRegion.ToInstructionString().Replace("{#}", person.BibNumber);
                }
            }
        }
        public void RequestDataBindingsUpdate()
        {
            // Manual updates are SelectedIndex and tblTags data source
            tblTags.DataSource = Model.CurrentPhoto.TaggedRunners;
            RequestUpdateSelectedStep();
            lstFiles.SelectedIndex = Model.PhotoIdx;
            // Update bindings for all components 
            // (we cannot use foreach as we change the number)
            for (int i = 0; i < _dataBindings.Count; i++)
            {
                Binding binding = _dataBindings[i];
                try
                {
                    // Strip out the old bindings and rebind to new model!
                    IBindableComponent component = binding.BindableComponent;
                    component.DataBindings.Clear();
                    component.DataBindings.Add(binding);
                }
                catch
                {
                }
            }
        }
        public void RequestUpdateSelectedStep()
        {
            lstSteps.SelectedIndex = (int)Model.CurrentPhoto.TaggingStep;
        }
        public void RequestUpdateClickPoints()
        {
            foreach (Photo photo in PhotoManager.SharedManager.Photos)
            {
                photo.AdaptClickPoints();
            }
        }
        #endregion
        #endregion

        #region Top Panel
        #region Bind Data
        void BindDataToTopPanelControls()
        {
            AddDataBinding(lblStepName, "Text", Model, "CurrentPhoto.TaggingStepName");
            // Labels
            AddDataBinding(lblInstructions, "Text", Model, "CurrentPhoto.TaggingStepInstructions");
            // Buttons
            AddDataBinding(btnPrevImage, "Enabled", Model, "CanGetPrevPhoto");
        }
        #endregion
        #region Events
        void BindTopPanelEvents()
        {
            // Click events
            btnPrevImage.Click += (sender, e) => Model.GetPrevPhoto();
            btnNextImage.Click += (sender, e) => AttemptGetNextPhoto();
        }
        void AttemptGetNextPhoto()
        {
            {
                if (!Model.CanGetNextPhoto)
                {
                    AttemptExit(true);
                }
                else
                {
                    Model.GetNextPhoto();
                }
            };
        }
        #endregion
        #endregion

        #region Files Panel
        #region Bind Data
        void BindDataToFilesPanel()
        {
            lstFiles.DataSource = Model.PhotosNamesForFiles;
        }
        public void RequestPopulateFilesList()
        {
            int oldSelIdx = lstFiles.SelectedIndex;
            lstFiles.DataSource = Model.PhotosNamesForFiles;
            lstFiles.SelectedIndex = oldSelIdx;
        }
        #endregion
        #region Events
        void BindFilesPanelEvents()
        {
            lstFiles.SelectedIndexChanged += (sender, e) =>
            {
                int oldIdx = Model.PhotoIdx;
                Model.PhotoIdx = lstFiles.SelectedIndex;
                if (!Model.Photos[oldIdx].IsMarkUpValid)
                {
                    lstFiles.SelectedIndex = oldIdx;
                }
            };
        }
        #endregion
        #endregion

        #region Main Menu
        #region Bind Data
        void BindDataToMenuControls()
        {
            // View menu
            AddDataBinding(mnuViewPreviousPhoto, "Enabled", Model, "CanGetPrevPhoto");
            // Photo menu
            AddDataBinding(mnuPhotoMarkCrowded, "Checked", Model, "CurrentPhoto.IsPhotoCrowded");
            AddDataBinding(mnuPhotoMarkComplete, "Checked", Model, "CurrentPhoto.IsPhotoCompletelyTagged");
            // Selected runner menu
            AddDataBinding(mnuSelectedRunner, "Enabled", Model, "CurrentPhoto.CanOpenRunnerMenu");
        }
        #endregion
        #region Events
        void BindMainMenuEvents()
        {
            // File menu
            mnuFileAbout.Click += (sender, e) => AboutArgusClicked();
            mnuFileExit.Click += (sender, e) => AttemptExit();
            mnuFileSave.Click += (sender, e) =>
            {
                if (Model.CurrentPhoto.SaveToFile())
                {
                    Model.CurrentPhoto.TimesManualSaveMade++;
                    MessageBox.Show("Tagging data saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            // Edit menu
            mnuEditUndo.Click += (sender, e) => Model.CurrentPhoto.UndoLastAction();
            // View menu
            mnuViewNextPhoto.Click += (sender, e) => AttemptGetNextPhoto();
            mnuViewPreviousPhoto.Click += (sender, e) => Model.GetPrevPhoto();
            mnuViewRotateImage.Click += (sender, e) => RotateImage(true);
            // Photo menu
            mnuPhotoSelectNextRunner.Click += (sender, e) => Model.CurrentPhoto.SelectNextRunner();
            mnuPhotoSelectPrevRunner.Click += (sender, e) => Model.CurrentPhoto.SelectPrevRunner();
            mnuPhotoMarkFaces.Click += (sender, e) => { Model.CurrentPhoto.TaggingStep = StepType.SelectFaceRegion; RequestUpdateSelectedStep(); };
            mnuPhotoMarkBibs.Click += (sender, e) => { Model.CurrentPhoto.TaggingStep = StepType.SelectBibRegion; RequestUpdateSelectedStep(); };
            mnuPhotoMarkCrowded.Click += (sender, e) => Model.CurrentPhoto.AskIfPhotoCrowded();
            mnuPhotoMarkComplete.Click += (sender, e) => Model.CurrentPhoto.ToggleComplete();
            // Selected runner menu
            mnuRunnerOpenMarkBibToolbox.Click += (sender, e) => Model.CurrentPhoto.AskToTagBibNumber(imgPhoto, Model.CurrentPhoto.SelectedRunner);
            mnuRunnerMarkBlurry.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.IsRunnerBlurred = !Model.CurrentPhoto.SelectedRunner.IsRunnerBlurred; RequestRedrawGraphics(); };
            mnuRunnerMarkFaceVisible.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.IsFaceVisible = !Model.CurrentPhoto.SelectedRunner.IsFaceVisible; RequestRedrawGraphics(); };
            mnuRunnerMarkGlasses.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.IsWearingGlasses = !Model.CurrentPhoto.SelectedRunner.IsWearingGlasses; RequestRedrawGraphics(); };
            mnuRunnerMarkHat.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.IsWearingHat = !Model.CurrentPhoto.SelectedRunner.IsWearingHat; RequestRedrawGraphics(); };
            mnuRunnerLikelihoodPurchaseYes.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.Yes; RequestRedrawGraphics(); };
            mnuRunnerLikelihoodPurchaseMaybe.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.Maybe; RequestRedrawGraphics(); };
            mnuRunnerLikelihoodPurchaseNo.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.No; RequestRedrawGraphics(); };
            mnuRunnerGenderMale.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.Gender = TaggedPerson.GenderType.Male; RequestRedrawGraphics(); };
            mnuRunnerGenderFemale.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.Gender = TaggedPerson.GenderType.Female; RequestRedrawGraphics(); };
            mnuRunnerGenderUnknown.Click += (sender, e) => { Model.CurrentPhoto.SelectedRunner.Gender = TaggedPerson.GenderType.Unknown; RequestRedrawGraphics(); };
            mnuRunnerOpenColorClassificationsToolbox.Click += (sender, e) => Model.CurrentPhoto.AskForColorClassificationsOfPerson(Model.CurrentPhoto.SelectedRunner);
            mnuRunnerOpenMarkBaseClassToolbox.Click += (sender, e) => Model.CurrentPhoto.AskForBaseClassificationsOfPerson(Model.CurrentPhoto.SelectedRunner);
            mnuRunnerDelete.Click += (sender, e) => Model.CurrentPhoto.DeleteTaggedPerson(Model.CurrentPhoto.SelectedRunner);
        }


        private void AboutArgusClicked()
        {
            MessageBox.Show($"Argus v{Utils.ArgusVersion} - A data tagging tool.\n\nRefer to http://www.deakin.edu.au/~ca/argus/ for more.\n\n© Deakin Software and Technology Innovation Lab 2017.", "About Argus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AttemptExit(bool showLastPhotoDialog = false)
        {
            void RunClose()
            {
                if (showLastPhotoDialog)
                {
                    if (MessageBox.Show("You have finished tagging all photos. Would you like to exit?", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (Model.CurrentPhoto.SaveToFile())
                        {
                            Close();
                        }
                    }
                }
                else
                {
                    if (Model.CurrentPhoto.SaveToFile())
                    {
                        Close();
                    }
                }
            }

            if (Model.CurrentPhoto.IsPhotoNotCompletelyTagged)
            {
                if (!Model.CurrentPhoto.AskIfPhotoTaggedAsComplete())
                {
                    return;
                }
                else
                {
                    RunClose();
                }
            }
            else
            {
                RunClose();
            }
        }

        void RotateImage(bool incrementRotation = false)
        {
            if (imgPhoto.Image == null)
            {
                return;
            }
            imgPhoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if (incrementRotation)
            {
                if (++Model.CurrentPhoto.Rotation == 4)
                {
                    Model.CurrentPhoto.Rotation = 0;
                }
            }

            RequestRedrawGraphics();
        }
        #endregion
        #endregion

        #region Step Panel
        #region Bind Data
        void BindDataToStepPanelControls()
        {
            // Check boxes
            AddDataBinding(chbxIsCrowded, "Checked", Model, "CurrentPhoto.IsPhotoCrowded");
            AddDataBinding(chbxIsComplete, "Checked", Model, "CurrentPhoto.IsPhotoCompletelyTagged");
            // Disable next button & steps if crowded
            AddDataBinding(lstSteps, "Enabled", Model, "CurrentPhoto.IsPhotoNotCrowded");

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
            }

            // Bind the step list
            PopulateStepList();
        }
        #endregion
        #region Events
        void BindStepPanelEvents()
        {
            lstSteps.SelectedIndexChanged += (sender, e) => Model.CurrentPhoto.TaggingStep = (StepType)lstSteps.SelectedIndex;
            //chbxIsComplete.MouseClick += (sender, e) => Model.CurrentPhoto.ToggleComplete();
            //chbxIsCrowded.MouseClick += (sender, e) => Model.CurrentPhoto.ToggleCrowdedPhoto();
        }
        #endregion
        #endregion

        #region Tagged Data Grid
        #region Bind Data
        void BindDataToTaggedDataGrid()
        {
            // Toggle visibility bib panel if not in crowded step
            AddDataBinding(tblTags, "Visible", Model, "CurrentPhoto.IsPhotoNotCrowded");
            
            // Set up table for bib # identified
            tblTags.AutoGenerateColumns = false;
            // Update the new source!
            tblcolBibNumber.DataPropertyName = "BibNumber";
            tblcolFaceVisible.DataPropertyName = "IsFaceVisible";
            tblcolBlurry.DataPropertyName = "IsRunnerBlurred";
            tblcolWearingGlasses.DataPropertyName = "IsWearingGlasses";
            tblcolWearingHat.DataPropertyName = "IsWearingHat";
            tblcolLikelihoodPurchase.DataPropertyName = "LikelihoodOfPurchaseName";
            tblcolGender.DataPropertyName = "GenderName";

            // Bind colour and name
            tblcolShirtColor.DataPropertyName = "ShirtColorName";
            tblcolShortsColor.DataPropertyName = "ShortsColorName";
            tblcolShoeColor.DataPropertyName = "ShoeColorName";
            tblcolHatColor.DataPropertyName = "HatColorName";
        }
        #endregion
        #region Events
        void BindTaggedDataGridEvents()
        {
            // Update highlighted row on state change
            tblTags.RowStateChanged += UpdateSelectedItem;
            // Switch to most recently added in bind list
            tblTags.RowsAdded += NewTagAdded;
            // Mouse in/out to show status
            tblTags.CellMouseEnter += (sender, e) => lblTooltip.Text = tblTags.Columns[e.ColumnIndex].ToolTipText;
            tblTags.MouseEnter += (sender, e) => lblTooltip.Visible = true;
            tblTags.MouseLeave += (sender, e) => lblTooltip.Visible = false;
            // Pointer cursor
            tblTags.CellMouseMove += SetCursorForCell;

            // Bind the background color
            tblTags.CellFormatting += BackgroundForSelectedColors;

            // Cell click handling
            tblTags.CellValueChanged += HandleChangeDropdown;
            tblTags.CellContentClick += HandleClickRow;
        }

        void HandleChangeDropdown(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            string col = tblTags.Columns[e.ColumnIndex].Name;
            var rowValue = tblTags.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            switch (col)
            {
                case "tblcolGender":
                    Model.CurrentPhoto.SelectedRunner.GenderName = (string)rowValue;
                    break;
                case "tblcolLikelihoodPurchase":
                    Model.CurrentPhoto.SelectedRunner.LikelihoodOfPurchaseName = (string)rowValue;
                    break;
            }
            RequestRedrawGraphics();
        }

        void BackgroundForSelectedColors(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
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
                    case "tblcolHatColor":
                        e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = person.HatColor.IsEmpty ? Color.White : person.HatColor;
                        e.CellStyle.ForeColor = e.CellStyle.SelectionForeColor = person.HatColor.IsEmpty ? SystemColors.ControlText : Utils.LabelForeColorForBackColor(person.HatColor);
                        break;
                }
            }
            catch
            {
                // Data out of range error
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

        void UpdateSelectedRunnerRow()
        {
            TaggedPerson runner = Model.CurrentPhoto.SelectedRunner;
            int rowIdx = Model.CurrentPhoto.TaggedRunners.IndexOf(runner);
            tblTags.ClearSelection();
            if (rowIdx == -1)
            {
                return;
            }
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
            }
            if (colorClicked)
            {
                Model.CurrentPhoto.AskForColorClassificationsOfPerson(personClicked);
            }

            RequestRedrawGraphics();
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
            AddDataBinding(imgPhoto, "ImageLocation", Model, "CurrentPhoto.Filename");
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

            // Auto-rotate image
            imgPhoto.LoadCompleted += AutoRotateImage;
            imgPhoto.LoadCompleted += UpdateClickPoints;
            imgPhoto.ClientSizeChanged += UpdateClickPoints;
        }

        private void UpdateClickPoints(object sender, EventArgs e)
        {
            if (imgPhoto.Image != null)
            {
                RequestUpdateClickPoints();
            }
        }

        private void AutoRotateImage(object sender, EventArgs e)
        {
            for (int i = 0; i < Model.CurrentPhoto.Rotation; i++)
            {
                RotateImage();
            }
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
            Invalidate();
        }

        void RenderGraphics(object sender, PaintEventArgs e)
        {
            if (imgPhoto.Image == null || imgPhoto.Image == imgPhoto.InitialImage)
            {
                return;
            }
            
            Debug.WriteLine("Rendering Graphics...");
            Graphics graphics = e.Graphics;
            
            // Don't render if crowded image
            if (Model.CurrentPhoto.IsPhotoCrowded)
            {
                string foreCrowdedText = "== FOREGROUND MARKED AS CROWDED ==";
                Size szOfForegroundCrowded = graphics.MeasureString(foreCrowdedText, Utils.BigFont).ToSize();
                Point ptCentre = new Point { X = (imgPhoto.Width - szOfForegroundCrowded.Width) / 2, Y = (imgPhoto.Height - szOfForegroundCrowded.Height) / 2 };
                graphics.DrawString(foreCrowdedText, Utils.BigFont, Brushes.Lime, ptCentre);
                return;
            }

            // For every runner tagged in the photo
            foreach (TaggedPerson person in Model.CurrentPhoto.TaggedRunners)
            {
                bool isSelectedPerson = person == Model.CurrentPhoto.SelectedRunner;
                Pen bibPen = isSelectedPerson ? Utils.SelectedBibPen : Utils.BibPen;
                Pen facePen = isSelectedPerson ? Utils.SelectedFacePen : Utils.FacePen;

                // Draw bounding box of person
                if (isSelectedPerson)
                {
                    if (person.IsBibRegionTagged && Model.CurrentPhoto.TaggingStep == StepType.SelectFaceRegion)
                    {
                        // Mark up max selectable region if face
                        Rectangle selRegion = person.ClickMaxSelectableRegion;
                        Rectangle[] inactiveRegions = new Rectangle[]
                        {
                            new Rectangle(0, 0, selRegion.Left, imgPhoto.Height),
                            new Rectangle(selRegion.Left, 0, selRegion.Width, selRegion.Top),
                            new Rectangle(selRegion.Left, selRegion.Bottom, selRegion.Width, imgPhoto.Height - selRegion.Top),
                            new Rectangle(selRegion.Right, 0, imgPhoto.Width - selRegion.Right, imgPhoto.Height)
                        };
                        graphics.FillRectangles(Utils.InactiveRegionBrush, inactiveRegions);
                    }
                    Utils.GuidelinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    graphics.DrawLine(Utils.GuidelinePen, person.LeftmostClickX, 0, person.LeftmostClickX, imgPhoto.Height);
                    graphics.DrawLine(Utils.GuidelinePen, person.RightmostClickX, 0, person.RightmostClickX, imgPhoto.Height);
                    string extraInfo = "";
                    extraInfo += $"{person.BibNumber}\n";
                    if (person.IsFaceRegionTagged)
                    {
                        extraInfo += $"GENDER: {person.GenderName}\n";
                        extraInfo += $"PURCHASE: {person.LikelihoodOfPurchase}\n";
                    }
                    extraInfo += person.IsRunnerBlurred ? "RUNNER BLURRY ✔\n" : "";
                    extraInfo += !person.IsFaceVisible ? "FACE NOT VISIBLE ✔\n" : "";
                    extraInfo += person.IsWearingGlasses ? "WEARING GLASSES ✔\n" : "";
                    extraInfo += person.IsWearingHat ? "WEARING HAT ✔\n" : "";
                    // Draw extra info at top of screen
                    SizeF szOfInfoBox = graphics.MeasureString(extraInfo, Utils.StdFont);
                    Rectangle infoBox = new Rectangle(person.RightmostClickX, 0, (int)szOfInfoBox.Width + 5, (int)szOfInfoBox.Height + 5);
                    graphics.FillRectangle(Brushes.White, infoBox);
                    graphics.DrawString(extraInfo, Utils.StdFont, Brushes.Black, person.RightmostClickX + 2, 2);

                    // Draw a big arrow on top of their head
                    string downArrowText = "⬇";
                    Size szOfArrowText = graphics.MeasureString(downArrowText, Utils.BigFont).ToSize();
                    int widthOfGuideline = person.RightmostClickX - person.LeftmostClickX;
                    Point ptCentre = new Point { X = person.LeftmostClickX + ((widthOfGuideline - szOfArrowText.Width) / 2), Y = 10 };
                    graphics.DrawString(downArrowText, Utils.BigFont, Brushes.White, ptCentre);
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
                    graphics.DrawString(person.BibNumber, Utils.StdFont, Utils.BibBrush, person.Bib.ClickTopLeft.X, person.Bib.ClickTopLeft.Y - 25);
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
                    graphics.DrawString(person.BibNumber, Utils.StdFont, Utils.FaceBrush, person.Face.ClickTopLeft.X, person.Face.ClickTopLeft.Y - 25);
                    // Draw line between face and bib number
                    graphics.DrawLine(Utils.RedPen, startX, startY + height, person.Bib.ClickTopLeft.X, person.Bib.ClickTopLeft.Y);
                    graphics.DrawLine(Utils.RedPen, person.Face.ClickBottomRight, person.Bib.ClickTopRight);
                }
            }
        }
        #endregion

        #endregion
    }
}
