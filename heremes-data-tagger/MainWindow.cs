﻿using System;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using PropertyChanged;

namespace HermesDataTagger
{
    public partial class MainWindow : Form
    {
        [ImplementPropertyChanged]
        private class UIModel
        {

            public string[] Files { get; set; }
            public int FileIdx { get; set; }

            public bool FilesLoaded => Files.Length > 0;
            public bool CanGetNextFile => CurrentFile != Files.Last();
            public bool CanGetPrevFile => CurrentFile != Files.First();
            public string CurrentFile => Files[FileIdx];

            public void GetNextFile() {
                if (CanGetNextFile)
                {
                    FileIdx += 1;
                }
                Debug.WriteLine($"File index is {FileIdx} and current file is {CurrentFile}");
            }
            public void GetPrevFile()
            {
                if (CanGetPrevFile)
                {
                    FileIdx -= 1;
                }
                Debug.WriteLine($"File index is {FileIdx} and current file is {CurrentFile}");
            }
            public void LoadFiles()
            {
                FolderBrowserDialog diag = new FolderBrowserDialog();
                DialogResult diagResult = diag.ShowDialog();
                string srcDirectory = diag.SelectedPath;
                bool openedDialog = diagResult == DialogResult.OK && !String.IsNullOrWhiteSpace(srcDirectory);
                if (openedDialog)
                {
                    Files = Directory.GetFiles(srcDirectory).Where((file) =>
                    {
                        string ext = Path.GetExtension(file).ToLower();
                        return ext == ".jpg" || ext == ".jpeg" || ext == ".png";
                    }).ToArray();
                    FileIdx = 0;
                }
                if (Files.Length == 0)
                {
                    MessageBox.Show($"No Image Files Loaded! Check that JPEG or PNGs exist in the directory {srcDirectory}. Aborting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                Debug.WriteLine($"{Files.Length} files were loaded in");
            }
        }

        UIModel Model = new UIModel();

        public MainWindow()
        {
            InitializeComponent();
            Model.LoadFiles();
            BindControls();
            BindClickEvents();
		}

		private void BindControls()
		{
			// Buttons display
            btnPrevImage.DataBindings.Add("Enabled", Model, "CanGetPrevFile", false, DataSourceUpdateMode.OnPropertyChanged);
			btnNextImage.DataBindings.Add("Enabled", Model, "CanGetNextFile", false, DataSourceUpdateMode.OnPropertyChanged);
			grpTaggingArea.DataBindings.Add("Enabled", Model, "FilesLoaded", false, DataSourceUpdateMode.OnPropertyChanged);

			// Image
			imgPhoto.DataBindings.Add("ImageLocation", Model, "CurrentFile", false, DataSourceUpdateMode.OnPropertyChanged);
			lblFilename.DataBindings.Add("Text", Model, "CurrentFile", false, DataSourceUpdateMode.OnPropertyChanged);

            // Set cursor
            imgPhoto.Cursor = Cursors.Cross;
		}

        private void BindClickEvents()
        {
			btnPrevImage.Click += (sender, e) => Model.GetPrevFile();
			btnNextImage.Click += (sender, e) => Model.GetNextFile();
			btnLoadImages.Click += (sender, e) => Model.LoadFiles();
        }
    }
}
