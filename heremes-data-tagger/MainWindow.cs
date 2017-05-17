﻿﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace HermesDataTagger
{
    public partial class MainWindow : Form
    {
        public static MainWindow MainWindowSingleton;

        PhotoManager Model = PhotoManager.SharedManager;

        public MainWindow()
        {
            InitializeComponent();
            MainWindowSingleton = this;
            Model.LoadFiles();
            BindDataControls();
            BindEvents();
            CreateTaggingToolbox();
            BringToFront();
        }

        void CreateTaggingToolbox()
        {
            TaggingToolbox tiForm = new TaggingToolbox();
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
            lblStepName.DataBindings.Add("Text", Model, "CurrentPhoto.TaggingStepLabel", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindEvents()
        {
            // Click events
            btnPrevImage.Click += (sender, e) => Model.GetPrevPhoto();
            btnNextImage.Click += (sender, e) => Model.GetNextPhoto();
            mnuLoadImages.Click += (sender, e) => Model.AttemptLoadFiles();
            mnuExit.Click += (sender, e) => Close();

            // Mouse move event
            imgPhoto.MouseMove += (sender, e) =>
            {
                if (imgPhoto.Image != null)
                {
                    var pt = e.Location.ToPixelPoint(imgPhoto);
                    lblMousePos.Text = $"{pt.X}x{pt.Y}";
                }
            };
            imgPhoto.MouseEnter += (sender, e) => lblMousePos.Visible = true;
            imgPhoto.MouseLeave += (sender, e) => lblMousePos.Visible = false;

            // Key Down Events
            KeyDown += HandleBackAndNextKeys;

            // Mouse click event
            imgPhoto.MouseClick += (sender, e) =>
            {
                Model.CurrentPhoto.HandleClick(imgPhoto, e);
                RenderLines(sender, null);
            };

            // Paint event
            imgPhoto.Paint += RenderLines;
        }

        private void RenderLines(object sender, PaintEventArgs e)
        {
            using (Graphics graphics = imgPhoto.CreateGraphics())
            {
                // For every runner tagged in the photo
                foreach (TaggedPerson person in Model.CurrentPhoto.TaggedPeople)
                {
                    // Markup each bib region
                    var bibClicks = person.Bib.ClickPoints;
                    for (int i = 1; i < bibClicks.Count; i++)
                    {
                        Point fromPt = bibClicks[i - 1];
                        Point toPt = bibClicks[i];
                        graphics.DrawLine(Utils.BibPen, fromPt, toPt);
                    }
                    // Autocomplete between first and last clicks if reached 4 (capacity) clicks
                    if (bibClicks.Capacity == bibClicks.Count)
                    {
                        graphics.DrawLine(Utils.BibPen, bibClicks.First(), bibClicks.Last());
                        graphics.DrawString(person.Bib.BibNumber, Utils.StdFont, Utils.BibBrush, person.Bib.TopLeft);
                    }
                    
                }
            }
        }

        private void HandleBackAndNextKeys(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                Model.GetPrevPhoto();
            }
            if (e.KeyCode == Keys.N)
            {
                Model.GetNextPhoto();
            }
        }
    }
}
