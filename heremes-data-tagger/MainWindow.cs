using System;
using System.Windows.Forms;
using System.Linq;

namespace HermesDataTagger
{
    public partial class MainWindow : Form
    {

        private class DataModel
        {
            
            public string[] Files { get; set; }
            public int FileIdx { get; set; }
            public bool FilesLoaded { get; set; }

            public bool CanGetNextFile => CurrentFile != Files.Last();
            public bool CanGetPrevFile => CurrentFile != Files.First();

            public string CurrentFile => Files[FileIdx];

            public void GetNextFile() {
                if (CanGetNextFile)
                {
                    FileIdx += 1;
                }
            }
            public void GetPrevFile()
            {
                if (CanGetPrevFile)
                {
                    FileIdx -= 1;
                }
            }
            public void LoadFiles()
            {
                FolderBrowserDialog folderBrowseDialog = new FolderBrowserDialog();
                bool openedDialog = folderBrowseDialog.ShowDialog() == DialogResult.OK;
                if (openedDialog)
                {
                    string srcDirectory = folderBrowseDialog.SelectedPath;
                    // TODO: Path.GetExtension --> jpg
                    Files = System.IO.Directory.GetFiles(srcDirectory);
                    FileIdx = 0;
                }
                else
                {
                    MessageBox.Show("No Files Loaded. Aborting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }
        }

        DataModel Model = new DataModel();

        public MainWindow()
        {
            InitializeComponent();

            Model.LoadFiles();

            // Button display
            btnPrevImage.DataBindings.Add("Enabled", Model, "CanGetPrevFile", true, DataSourceUpdateMode.OnPropertyChanged);
            btnNextImage.DataBindings.Add("Enabled", Model, "CanGetNextFile", true, DataSourceUpdateMode.OnPropertyChanged);
            grpTaggingArea.DataBindings.Add("Enabled", Model, "FilesLoaded", true, DataSourceUpdateMode.OnPropertyChanged);

            // Image display
            imgPhoto.DataBindings.Add("ImageLocation", Model, "CurrentFile", true, DataSourceUpdateMode.OnPropertyChanged);
            lblFilename.DataBindings.Add("Text", Model, "CurrentFile", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            Model.GetNextFile();
        }

        private void btnPrevImage_Click(object sender, EventArgs e)
        {
            Model.GetPrevFile();
        }

        private void btnLoadImages_Click_1(object sender, EventArgs e)
        {
            Model.LoadFiles();
        }
    }
}
