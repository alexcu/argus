﻿﻿using System;
using System.Windows.Forms;

namespace HermesDataTagger
{
    public partial class MainWindow : Form
    {
        #region Main Window
        PhotoManager Model = new PhotoManager();
        public MainWindow()
        {
            InitializeComponent();
            Model.LoadFiles();
            BindControls();
            BindEvents();
            CreateTaggingStepPanels();
            BringToFront();
        }

        private void CreateTaggingStepPanels()
        {
            System.Array stepArray = Enum.GetValues(typeof(StepType));
            for (int i = 0; i < stepArray.Length; i++)
            {
                StepType step = (StepType)stepArray.GetValue(i);
                string labelText = step.ToActionLabel();
                TabPage newTabPage = new TabPage($"Step {i + 1}");
                tabSteps.TabPages.Add(newTabPage);
                // Dynamically add in the new tab each time
                newTabPage.Enter += (sender, e) =>
                {
                    // Update the step to this tab and ensure the label control shifts inside it
                    Model.CurrentPhoto.TaggingStep = step;
                    newTabPage.Controls.Add(lblStepName);
                };
            }
            // Remove le prototype
            tabSteps.TabPages.Remove(tabPagePrototype);
            tabSteps.TabPages[0].Select();
        }

        private void BindControls()
        {
            // Buttons display
            btnPrevImage.DataBindings.Add("Enabled", Model, "CanGetPrevPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
            btnNextImage.DataBindings.Add("Enabled", Model, "CanGetNextPhoto", false, DataSourceUpdateMode.OnPropertyChanged);
           
            // Image
            imgPhoto.DataBindings.Add("ImageLocation", Model, "CurrentPhotoFilename", false, DataSourceUpdateMode.OnPropertyChanged);

            // Window Title
            this.DataBindings.Add("Text", Model, "CurrentPhotoFilename", false, DataSourceUpdateMode.OnPropertyChanged);

            // Labels
            lblStepName.DataBindings.Add("Text", Model, "CurrentPhotoStepLabel", false, DataSourceUpdateMode.OnPropertyChanged);

            // Step Count
            tabSteps.DataBindings.Add("SelectedIndex", Model, "CurrentPhotoStepIdx", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BindEvents()
        {
            // Click events
            btnPrevImage.Click += (sender, e) => Model.GetPrevFile();
            btnNextImage.Click += (sender, e) => Model.GetNextFile();
            mnuLoadImages.Click += (sender, e) => Model.AttemptLoadFiles();

            // Mouse move event
            imgPhoto.MouseMove += (sender, e) =>
            {
                var pt = Model.CurrentPhoto.GetPointFromMousePos(imgPhoto, e.X, e.Y);
                lblMousePos.Text = $"{pt.X}x{pt.Y}";
            };
            imgPhoto.MouseEnter += (sender, e) => lblMousePos.Visible = true;
            imgPhoto.MouseLeave += (sender, e) => lblMousePos.Visible = false;

            // Key Down Events
            KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.B)
                {
                    Model.GetPrevFile();
                }
                if (e.KeyCode == Keys.N)
                {
                    Model.GetNextFile();
                }
            };

            // Mouse click event
            imgPhoto.MouseClick += (sender, e) => Model.CurrentPhoto.HandleClick(e);

        }
        #endregion
    }
}
