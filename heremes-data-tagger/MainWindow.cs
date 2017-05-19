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
        }

        private void BindEvents()
        {
            // Click events
            btnPrevImage.Click += (sender, e) => Model.GetPrevPhoto();
            btnNextImage.Click += (sender, e) => Model.GetNextPhoto();
            mnuLoadImages.Click += (sender, e) => Model.AttemptLoadFiles();
            mnuExit.Click += (sender, e) => Close();

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
            Model.CurrentPhoto.TaggedPeople.ListChanged += ModelListChanged;

            // KBD Shortcuts
            KeyboardShortcutManager.SharedManager.BindKeyboardShortcuts(this);
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
            Debug.WriteLine("Rendering Graphics...");
            Graphics graphics = e.Graphics;
            // For every runner tagged in the photo
            foreach (TaggedPerson person in Model.CurrentPhoto.TaggedPeople)
            {
                Pen bibPen = person == Model.CurrentPhoto.SelectedPerson ? Utils.SelectedBibPen : Utils.BibPen;
                Pen facePen = person == Model.CurrentPhoto.SelectedPerson ? Utils.SelectedFacePen : Utils.FacePen;

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
