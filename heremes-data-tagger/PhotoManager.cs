using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;
using PropertyChanged;
using System.Windows.Forms;

namespace HermesDataTagger
{
    [ImplementPropertyChanged]
    public class PhotoManager
    {
        private Photo[] Photos { get; set; }
        private int PhotoIdx { get; set; }

        #region Photo Storage
        public string SrcDirectory { get; private set; }
        public bool PhotosLoaded => Photos.Length > 0;
        public bool CanGetNextPhoto => CurrentPhoto != Photos.Last();
        public bool CanGetPrevPhoto => CurrentPhoto != Photos.First();
        #endregion

        #region Current Photo Properties
        public Photo CurrentPhoto => Photos[PhotoIdx];
        public string CurrentPhotoFilename => CurrentPhoto.Filename;
        public string CurrentPhotoStepLabel => CurrentPhoto.TaggingStep.ToActionLabel();
        public int CurrentPhotoStepIdx => (int)CurrentPhoto.TaggingStep;
        #endregion

        #region Progressing Files
        public void GetNextPhoto()
        {
            if (CanGetNextPhoto)
            {
                PhotoIdx += 1;
            }
            Debug.WriteLine($"File index is {PhotoIdx} and current file is {CurrentPhoto}");
        }
        public void GetPrevPhoto()
        {
            if (CanGetPrevPhoto)
            {
                PhotoIdx -= 1;
            }
            Debug.WriteLine($"File index is {PhotoIdx} and current file is {CurrentPhoto}");
        }
        #endregion

        #region File Loading
        public void LoadFiles()
                {
                    FolderBrowserDialog diag = new FolderBrowserDialog();
                    DialogResult diagResult = diag.ShowDialog();
                    SrcDirectory = diag.SelectedPath;
                    bool openedDialog = diagResult == DialogResult.OK && !String.IsNullOrWhiteSpace(SrcDirectory);
                    if (openedDialog)
                    {
                        Photos = 
                            Directory.GetFiles(SrcDirectory)
                            .Where((file) =>
                            {
                                string ext = Path.GetExtension(file).ToLower();
                                return ext == ".jpg" || ext == ".jpeg" || ext == ".png";
                            })
                            .Select(file => new Photo(file))
                            .ToArray();
                        PhotoIdx = 0;
                    }
                    if (Photos == null || Photos.Length == 0)
                    {
                        MessageBox.Show($"No Image Files Loaded! Check that JPEG or PNGs exist in the directory {SrcDirectory}. Aborting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(1);
                    }
                    Debug.WriteLine($"{Photos.Length} files were loaded in");
                }
        public void AttemptLoadFiles()
                {
                    if (MessageBox.Show($"Quit assessing photos from {SrcDirectory}?", "Load Photos", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        LoadFiles();
                    }
                }
        #endregion
    }
}
