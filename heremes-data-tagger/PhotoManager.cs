using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;
using PropertyChanged;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HermesDataTagger
{
    [ImplementPropertyChanged]
    public class PhotoManager
    {
        public static PhotoManager SharedManager = new PhotoManager();

        public List<string> PhotosNamesForFiles => Photos.Select(p => (p.IsPhotoCompletelyTagged ? "[✔] " : "") + p.Identifier).ToList(); 
        public List<Photo> Photos { get; private set; }

        private int _photoIdx;
        public int PhotoIdx
        {
            get => _photoIdx;
            set
            {
                // Stop old timner
                CurrentPhoto.TimerOnPhoto.Stop();
                try { _photoIdx = value; } catch { };
                MainWindow.Singleton.RequestDataBindingsUpdate();
                // Start new timer
                CurrentPhoto.TimerOnPhoto.Start();
            }
        }
        public Photo CurrentPhoto => Photos[PhotoIdx];


        #region Photo Storage
        public string SrcDirectory { get; private set; }
        public bool PhotosLoaded => Photos.Count > 0;
        public bool CanGetNextPhoto => CurrentPhoto != Photos.Last();
        public bool CanGetPrevPhoto => CurrentPhoto != Photos.First();
        #endregion

        #region Progressing Files
        public void GetNextPhoto()
        {
            if (CanGetNextPhoto)
            {
                // Ask if finished if not marked as complete
                ChangePhotoIndexBy(+1);
            }
            Debug.WriteLine($"File index is {PhotoIdx} and current file is {CurrentPhoto}");
        }
        public void GetPrevPhoto()
        {
            if (CanGetPrevPhoto)
            {
                ChangePhotoIndexBy(-1);
            }
            Debug.WriteLine($"File index is {PhotoIdx} and current file is {CurrentPhoto}");
        }
        void ChangePhotoIndexBy(int value)
        {
            if (CurrentPhoto.IsPhotoNotCompletelyTagged)
            {
                DialogResult result = MessageBox.Show("Are you finished tagging this image?", "Moving to Next Photo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    CurrentPhoto.ToggleComplete();
                    if (CurrentPhoto.IsPhotoCompletelyTagged)
                    {
                        PhotoIdx += value;
                    }
                }
            }
            else
            {
                PhotoIdx += value;
            }
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
                    .ToList();
                PhotoIdx = 0;
            }
            if (Photos == null || Photos.Count == 0)
            {
                MessageBox.Show($"No Image Files Loaded! Check that JPEG or PNGs exist in the directory {SrcDirectory}. Aborting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            Debug.WriteLine($"{Photos.Count} files were loaded in");
        }
        public void AttemptLoadFiles()
        {
            if (MessageBox.Show($"Quit assessing photos from {SrcDirectory}?", "Load Photos", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                LoadFiles();
            }
        }
        #endregion

        public void DumpToJson()
        {
            string filename = $"{SrcDirectory}\\DataTagging_{DateTime.Now.ToString("yyyy_dd_M_HH_mm_ss")}.json";
            File.WriteAllText(filename, JsonConvert.SerializeObject(Photos, Formatting.Indented));
        }

    }
}
