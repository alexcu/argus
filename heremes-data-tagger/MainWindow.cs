﻿﻿using System;
using System.Windows.Forms;
using System.Drawing;

namespace HermesDataTagger
{
    public partial class MainWindow : Form
    {
        PhotoManager Model = PhotoManager.SharedManager;

        public MainWindow()
        {
            InitializeComponent();
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

            // Mouse move event
            imgPhoto.MouseMove += (sender, e) =>
            {
                var pt = Utils.MousePointToPixelPoint(imgPhoto, e.Location);
                lblMousePos.Text = $"{pt.X}x{pt.Y}";
            };
            imgPhoto.MouseEnter += (sender, e) => lblMousePos.Visible = true;
            imgPhoto.MouseLeave += (sender, e) => lblMousePos.Visible = false;

            // Key Down Events
            KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.B)
                {
                    Model.GetPrevPhoto();
                }
                if (e.KeyCode == Keys.N)
                {
                    Model.GetNextPhoto();
                }
            };

            // Mouse click event
            imgPhoto.MouseClick += (sender, e) => Model.CurrentPhoto.HandleClick(imgPhoto, e);

        }
    }
}
