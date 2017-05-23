﻿﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;

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
            BindDataControls();
            BindEvents();
            CreateTaggingToolbox();
            BringToFront();
        }

        void CreateTaggingToolbox()
        {
            StepsToolbox tiForm = new StepsToolbox();
            tiForm.Show();
        }

        private void BindDataControls()
        {
            // Buttons display
            btnPrevImage.DataBindings.Add("Enabled", Model, "CanGetPrevPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
            btnNextImage.DataBindings.Add("Enabled", Model, "CanGetNextPhoto", false, DataSourceUpdateMode.OnPropertyChanged);

            // Image
            imgPhoto.DataBindings.Add("ImageLocation", Model, "CurrentPhoto.Filename", false, DataSourceUpdateMode.OnPropertyChanged);

            // Window Title
            this.DataBindings.Add("Text", Model, "CurrentPhoto.Filename", false, DataSourceUpdateMode.OnPropertyChanged);

            // Labels
            lblStepName.DataBindings.Add("Text", Model, "CurrentPhoto.TaggingStepName", false, DataSourceUpdateMode.OnPropertyChanged);
            lblInstructions.DataBindings.Add("Text", Model, "CurrentPhoto.TaggingStepInstructions", false, DataSourceUpdateMode.OnPropertyChanged);

            // Bind menus
            BindDataToMenuControls();
        }

        private void BindEvents()
        {
            // Click events
            btnPrevImage.Click += (sender, e) => Model.GetPrevPhoto();
            btnNextImage.Click += (sender, e) => Model.GetNextPhoto();

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

            // Do something when the list changes
            Model.CurrentPhoto.TaggedRunners.ListChanged += ModelListChanged;
            Model.CurrentPhoto.SelectedRunnerUpdated += (sender, e) => RequestRedrawGraphics();

            // Bind all menu shortcuts
            BindAllMenuShortcuts();

            // KBD Shortcuts
            KeyboardShortcutManager.SharedManager.BindKeyboardShortcuts(this);
        }

        private void BindAllMenuShortcuts()
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

        private void BindDataToMenuControls()
        {
            // View menu
            mnuViewPreviousPhoto.DataBindings.Add("Enabled", Model, "CanGetPrevPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
            mnuViewNextPhoto.DataBindings.Add("Enabled", Model, "CanGetNextPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
            // Edit menu
            //mnuEditUndo.DataBindings.Add("Enabled", Model, "CanUndoLastAction", false, DataSourceUpdateMode.OnPropertyChanged);
            //mnuEditRedo.DataBindings.Add("Enabled", Model, "CanRedoLastAction", false, DataSourceUpdateMode.OnPropertyChanged);
            // Photo menu
            mnuPhotoMarkCrowded.DataBindings.Add("Checked", Model.CurrentPhoto, "IsPhotoCrowded", false, DataSourceUpdateMode.OnPropertyChanged);
            mnuPhotoMarkBibs.DataBindings.Add("Enabled", Model.CurrentPhoto, "CanMarkBibs", false, DataSourceUpdateMode.OnPropertyChanged);
            mnuPhotoMarkFaces.DataBindings.Add("Enabled", Model.CurrentPhoto, "CanMarkFaces", false, DataSourceUpdateMode.OnPropertyChanged);
            //mnuPhotoSelectNextRunner.DataBindings.Add("Enabled", Model.CurrentPhoto, "HasTaggedARunner", false, DataSourceUpdateMode.OnPropertyChanged);
            //mnuPhotoSelectPrevRunner.DataBindings.Add("Enabled", Model.CurrentPhoto, "HasTaggedARunner", false, DataSourceUpdateMode.OnPropertyChanged);
            // Selected runner menu
            mnuSelectedRunner.DataBindings.Add("Enabled", Model.CurrentPhoto, "IsRunnerSelected", false, DataSourceUpdateMode.OnPropertyChanged);
            mnuSelectedRunner.CheckedChanged += (sender, e) =>
            {
                if (Model.CurrentPhoto.IsRunnerSelected)
                {
                    mnuRunnerStaticNumberValue.DataBindings.Add("Text", Model.CurrentPhoto, "SelectedRunnerNumber", false, DataSourceUpdateMode.OnPropertyChanged);
                    mnuRunnerMarkBlurry.DataBindings.Add("Checked", Model.CurrentPhoto.SelectedRunner, "IsRunnerBlurry", false, DataSourceUpdateMode.OnPropertyChanged);
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

        private void MouseDragStop(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Model.CurrentPhoto.HandleDragStop(imgPhoto, e);
                RequestRedrawGraphics();
            }
        }

        private void MouseDragMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Model.CurrentPhoto.HandleDragMove(imgPhoto, e);
                RequestRedrawGraphics();
            }
        }

        private void MouseDragStart(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Model.CurrentPhoto.HandleDragStart(imgPhoto, e);
                RequestRedrawGraphics();
            }
        }

        private void ClickPhoto(object sender, MouseEventArgs e)
        {
            Model.CurrentPhoto.HandleClick(imgPhoto, e);
        }

        private void UpdateCoordinatesLabel(object sender, MouseEventArgs e)
        {
            if (imgPhoto.Image != null)
            {
                var pt = e.Location.ToPixelPoint(imgPhoto);
                lblMousePos.Text = $"{pt.X}x{pt.Y}";
            }
        }

        private void ModelListChanged(object sender, ListChangedEventArgs e)
        {
            // Redraw graphics whenever we delete or select a new item
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemDeleted:
                    RequestRedrawGraphics();
                    break;
            }
        }

        public void RequestRedrawGraphics()
        {
            imgPhoto.Invalidate();
        }

        private void RenderGraphics(object sender, PaintEventArgs e)
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
                Pen bibPen = person == Model.CurrentPhoto.SelectedRunner ? Utils.SelectedBibPen : Utils.BibPen;
                Pen facePen = person == Model.CurrentPhoto.SelectedRunner ? Utils.SelectedFacePen : Utils.FacePen;

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
                    graphics.DrawString(person.BibNumber, Utils.StdFont, Utils.BibBrush, person.Bib.TopLeft);
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
                    graphics.DrawString(person.BibNumber, Utils.StdFont, Utils.FaceBrush, person.Face.TopLeft);
                    // Draw line between face and bib number
                    graphics.DrawLine(Utils.RedPen, startX, startY + height, person.Bib.TopLeft.X, person.Bib.TopLeft.Y);
                    graphics.DrawLine(Utils.RedPen, person.Face.BtmRight, person.Bib.TopRight);
                }
            }
        }
    }
}
