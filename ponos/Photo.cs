using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using PropertyChanged;
using System.IO;
using Newtonsoft.Json;

namespace Ponos
{
    [ImplementPropertyChanged]
    public class Photo
    {
        [JsonIgnore]
        public Stopwatch TimerOnPhoto { get; } = new Stopwatch();

        #region Statistics
        public float TimeTakenOnPhoto => TimerOnPhoto.ElapsedMilliseconds;
        public float AverageTimeTakenPerPerson => HasTaggedARunner ? TaggedRunners.Average(p => p.TotalTimeTaken) : 0;
        public float SumOfTimeTakenPerPerson => HasTaggedARunner ? TaggedRunners.Sum(p => p.TotalTimeTaken) : 0;
        #endregion


        #region File IO
        public DateTime DateSaved { get; set; }
        public void SaveToFile()
        {
            DateSaved = DateTime.Now;
            File.WriteAllText($"{Filename}.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
        public static bool LoadingJson { get; private set; }
        public static Photo LoadFromFile(string filename)
        {
            LoadingJson = true;
            string jsonStr = File.ReadAllText(filename);
            Photo photo = (Photo)JsonConvert.DeserializeObject(File.ReadAllText(filename), typeof(Photo));
            photo.Filename = filename.Replace(".json", "");
            LoadingJson = false;
            return photo;
        }
        #endregion

        // Rotation
        public int Rotation { get; set; } = 0;

        // Basic identifiers
        [JsonIgnore]
        public string Filename { get; private set; }
        public string Identifier { get; set;  }

        private bool _isComplete;
        public bool IsPhotoCompletelyTagged
        {
            get => _isComplete;
            set
            {
                if (LoadingJson)
                {
                    _isComplete = value;
                    return;
                }
                if (value && !HasAFaceMarkedForEveryBib && !IsPhotoCrowded)
                {
                    MessageBox.Show("Cannot be marked as complete as not all marked bibs have an associated face!", "Marking as Complete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _isComplete = value;
                MainWindow.Singleton.RequestPopulateFilesList();
            }
        }
        [JsonIgnore]
        public bool IsPhotoNotCompletelyTagged => !IsPhotoCompletelyTagged;
        public void ToggleComplete()
        {
            IsPhotoCompletelyTagged = !IsPhotoCompletelyTagged;
        }

        #region TaggedItems
        public BindingList<TaggedPerson> TaggedRunners = new BindingList<TaggedPerson>();
        [JsonIgnore]
        public List<TaggedPerson> OrderedTaggedRunners => TaggedRunners.OrderBy(p => p.LeftmostClickX).ToList();
        [JsonIgnore]
        public TaggedPerson LastRunnerTagged => TaggedRunners.FirstOrDefault();
        public int NumberOfPeopleTagged => TaggedRunners.Count;
        private string[] TaggedBibNumbers => TaggedRunners.Select(p => p.BibNumber).ToArray();
        [JsonIgnore]
        private bool HasAFaceMarkedForEveryBib => TaggedRunners.Count(p => p.IsFaceRegionTagged && p.IsBibRegionTagged) == TaggedRunners.Count;
        [JsonIgnore]
        public bool HasTaggedARunner => TaggedBibNumbers.Length > 0;
        private TaggedPerson _selectedRunner;
        [JsonIgnore]
        public bool IsRunnerSelected => SelectedRunner != null;
        [JsonIgnore]
        public bool CanOpenRunnerMenu => IsRunnerSelected && IsPhotoNotCrowded;
        [JsonIgnore]
        public bool CanSelectNextRunner => HasTaggedARunner && IsRunnerSelected && SelectedRunner != OrderedTaggedRunners.Last();
        [JsonIgnore]
        public bool CanSelectPrevRunner => HasTaggedARunner && IsRunnerSelected && SelectedRunner != OrderedTaggedRunners.First();
        [JsonIgnore]
        public TaggedPerson SelectedRunner
        {
            get => _selectedRunner;
            set
            {
                try
                {
                    _selectedRunner = value;
                }
                catch (FormatException)
                {
                    // Ignore
                }
                MainWindow.Singleton.RequestUpdateSelectedRunner();
            }
        }
        public void SelectNextRunner()
        {
            if (CanSelectNextRunner)
            {
                SelectedRunner = OrderedTaggedRunners[OrderedTaggedRunners.IndexOf(SelectedRunner) + 1];
            }
            else if (HasTaggedARunner)
            {
                SelectedRunner = OrderedTaggedRunners.First();
            }
        }
        public void SelectPrevRunner()
        {
            if (CanSelectPrevRunner)
            {
                SelectedRunner = OrderedTaggedRunners[OrderedTaggedRunners.IndexOf(SelectedRunner) - 1];
            }
            else if (HasTaggedARunner)
            {
                SelectedRunner = OrderedTaggedRunners.Last();
            }
        }

        public void DeleteTaggedPerson(TaggedPerson person)
        {
            TaggedRunners.Remove(person);
            if (person == SelectedRunner)
            {
                SelectedRunner = TaggedRunners.Count > 0 ? TaggedRunners.First() : null;
            }
            if (TaggedRunners.Count == 0)
            {
                TaggingStep = StepType.SelectBibRegion;
            }
        }
        #endregion

        #region Steps
        // Steps in tagging the photo
        private StepType _taggingStep;
        [JsonIgnore]
        public StepType TaggingStep
        {
            get => _taggingStep;
            set
            {
                if (LoadingJson)
                {
                    _taggingStep = value;
                    return;
                }
                switch (value)
                {
                    case StepType.ImageCrowded:
                        _taggingStep = value;
                        break;
                    case StepType.SelectBibRegion:
                        if (!CanMarkBibs)
                        {
                            _taggingStep = StepType.ImageCrowded;
                            MessageBox.Show("You cannot select bib regions as this image has been marked as crowded", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            _taggingStep = value;
                        }
                        break;
                    case StepType.SelectFaceRegion:
                        if (!CanMarkFaces)
                        {
                            _taggingStep = CanMarkBibs ? StepType.SelectBibRegion : StepType.ImageCrowded;
                            MessageBox.Show("You cannot tag image regions as there are no bib regions tagged", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            _taggingStep = value;
                            MainWindow.Singleton.RequestUpdateSelectedRunner();
                        }
                        break;
                }
                MainWindow.Singleton.RequestUpdateSelectedStep();
            }
        }
        [JsonIgnore]
        public bool IsFirstTaggingStep => TaggingStep.IsFirstStep();
        [JsonIgnore]
        public bool IsLastTaggingStep => TaggingStep.IsLastStep();
        [JsonIgnore]
        public string TaggingStepName => TaggingStep.ToStepNameString();
        [JsonIgnore]
        public string TaggingStepInstructions => TaggingStep.ToInstructionString();
        [JsonIgnore]
        public bool CanMarkFaces => CanMarkBibs && HasTaggedARunner;
        [JsonIgnore]
        public bool CanMarkBibs => IsPhotoNotCrowded;
        public void GoToNextStep()
        {
            if (TaggingStep != (StepType)(Enum.GetValues(typeof(StepType)).Length - 1))
            {
                TaggingStep++;
            }
        }
        public void GoToPrevStep()
        {
            if (TaggingStep != 0)
            {
                TaggingStep--;
            }
        }
        #endregion Steps

        #region GeneralClassifications
        // General classifications about the photo
        private bool _isPhotoCrowded = false;
        public bool AskedIfPhotoCrowded { get; set; } = false;
        [JsonIgnore]
        public bool IsPhotoNotCrowded => !IsPhotoCrowded;
        public bool IsPhotoCrowded
        {
            get => _isPhotoCrowded;
            set
            {
                if (LoadingJson)
                {
                    _isPhotoCrowded = value;
                    return;
                }
                _isPhotoCrowded = value;
                TaggingStep = StepType.ImageCrowded;
                if (_isPhotoCrowded)
                {
                    // TODO: Reset all people tagged?
                    SelectedRunner = null;
                    IsPhotoCompletelyTagged = true;
                    MainWindow.Singleton.RequestRedrawGraphics();
                    return;
                }
                else if (!_isPhotoCrowded && TaggedRunners.Count > 0)
                {
                    SelectedRunner = TaggedRunners.First();
                }
                TaggingStep = StepType.SelectBibRegion;
                IsPhotoCompletelyTagged = false;
            }
        }
        #endregion

        public Photo(string filename)
        {
            Filename = filename;
            Identifier = Path.GetFileNameWithoutExtension(filename);
            TaggingStep = StepType.ImageCrowded;
        }


        #region HandleEvents
        public void HandleClick(PictureBox pbx, MouseEventArgs e)
        {
            switch (TaggingStep)
            {
                case StepType.ImageCrowded:
                    AskIfPhotoCrowded();
                    break;
                case StepType.SelectBibRegion:
                    if (e.Clicks == 1 && e.Button == MouseButtons.Left)
                    {
                        AskToTagBibRegion(pbx, e.Location);
                    }
                    break;
                default:
                    break;
            }
        }
        public void HandleDragStart(PictureBox pbx, MouseEventArgs e)
        {
            switch (TaggingStep)
            {
                case StepType.SelectFaceRegion:
                    SelectedRunner.TimerFaceDragDrop.Start();
                    RecordStartOfFaceRegion(pbx, e.Location);
                    break;
                default:
                    break;
            }
        }

        internal void UndoLastAction()
        {
            switch (TaggingStep)
            {
                case StepType.ImageCrowded:
                    ToggleCrowdedPhoto();
                    break;
                case StepType.SelectBibRegion:
                    RemoveLastBibPoint();
                    break;
                case StepType.SelectFaceRegion:
                    RemoveLastFaceTaggingRegion();
                    break;
            }
        }

        public void HandleDragMove(PictureBox pbx, MouseEventArgs e)
        {
            switch (TaggingStep)
            {
                case StepType.SelectFaceRegion:
                    UpdateEndOfFaceRegion(pbx, e.Location);
                    break;
                default:
                    break;
            }
        }
        public void HandleDragStop(PictureBox pbx, MouseEventArgs e)
        {
            switch (TaggingStep)
            {
                case StepType.SelectFaceRegion:
                    UpdateEndOfFaceRegion(pbx, e.Location);
                    SelectedRunner.TimerFaceDragDrop.Stop();
                    bool didSetBothClassifications = AskForBothClassificationsOfPerson(SelectedRunner);
                    if (!didSetBothClassifications)
                    {
                        SelectedRunner.Face.ClearPoints();
                    }
                    else if (!HasAFaceMarkedForEveryBib)
                    {
                        // Move to next runner who isn't yet tagged if more bibs
                        SelectedRunner = OrderedTaggedRunners.Find(p => !p.IsFaceRegionTagged);
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region CrowdedPhoto
        public void ToggleCrowdedPhoto()
        {
            IsPhotoCrowded = !IsPhotoCrowded;
        }
        public void AskIfPhotoCrowded()
        {
            AskedIfPhotoCrowded = true;
            DialogResult result = MessageBox.Show("Is this photo crowded?", "Crowded Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            IsPhotoCrowded = result == DialogResult.Yes;
            if (IsPhotoNotCrowded)
            {
                GoToNextStep();
            }
        }
        public void WaitAndAskForPhotoCrowded()
        {
            if (!AskedIfPhotoCrowded)
            {

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1500;
                timer.Tick += (sender, e) =>
                {
                    timer.Stop();
                    if (TaggingStep == StepType.ImageCrowded && IsPhotoNotCrowded && !AskedIfPhotoCrowded)
                    {
                        AskIfPhotoCrowded();
                    }
                };
                timer.Start();
            }
        }
        #endregion

        #region AddBibRegion
        public void AskToTagBibRegion(PictureBox pbx, Point pt)
        {
            // Ignore this point if outside bounds of pbx
            if (!pbx.IsPointInImage(pt))
            {
                return;
            }

            TaggedPerson person = LastRunnerTagged;

            // First person tagged or new person (last person has 4 clicks)?
            if (person == null || person.Bib.ClickPoints.Count == 4)
            {
                person = new TaggedPerson();
                person.TimerBibRegionClicks.Start();
                TaggedRunners.Insert(0, person);
                Debug.WriteLine($"Adding person #{TaggedRunners.Count} to ({Identifier})");
            }
            person.Bib.ClickPoints.Add(pt);
            person.Bib.PixelPoints.Add(pt.ToPixelPoint(pbx));
            Debug.WriteLine($"Person #{TaggedRunners.Count} has Bib[{person.Bib.ClickPoints.Count}] = {pt} ({Identifier})");
            // We just finished tagging?
            if (person.IsBibRegionTagged)
            {
                // Reorder so that values are in clockwise order!
                List<Point> orderedPoints = new List<Point>
                {
                    person.Bib.TopLeft,
                    person.Bib.TopRight,
                    person.Bib.BtmRight,
                    person.Bib.BtmLeft
                };
                person.Bib.ClickPoints = orderedPoints;
                // Update to reflect pixel points
                person.Bib.PixelPoints = orderedPoints.Select(p => p.ToPixelPoint(pbx)).ToList();

                // Done!
                person.TimerBibRegionClicks.Stop();

                // Invalidate (update graphics) of picture box to reflect new bib number
                pbx.Invalidate();
                AskToTagBibNumber(pbx, person, true);
            }
        }

        public void AskToTagBibNumber(PictureBox pbx, TaggedPerson person, bool shouldDeleteIfCancel = false)
        {
            // Can only tag if all clicked!
            if (person == null)
            {
                MessageBox.Show("Unable to set tag of a person not selected", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!person.IsBibRegionTagged)
            {
                MessageBox.Show("Unable to set tag number - the tag region is not yet specified", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BibNumberDialog bibDiag = new BibNumberDialog(person);
            person.TimerEnteringBibNumber.Start();
            // Prevent duplicate bib numbers being entered
            do
            {
                DialogResult result = bibDiag.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    // Cancel -- remove this tag!
                    if (shouldDeleteIfCancel)
                    {
                        DeleteTaggedPerson(person);
                    }
                    return;
                }
                string diagBibNumber = bibDiag.EnteredBibNumber;
                if (TaggedBibNumbers.Contains(diagBibNumber) && person.BibNumber != diagBibNumber)
                {
                    MessageBox.Show($"The bib number {diagBibNumber} already exists in this photo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    person.Bib.BibNumber = diagBibNumber;
                    break;
                }
            } while (true);
            person.TimerEnteringBibNumber.Stop();
            // Notify that bindings should be updated to display tag
            TaggedRunners.ResetItem(TaggedRunners.IndexOf(person));
            Debug.WriteLine($"Person #{TaggedRunners.Count} RBN identified as {person.Bib.BibNumber} ({Identifier})");
        }

        void RemoveLastBibPoint()
        {
            TaggedPerson person = LastRunnerTagged;
            if (person == null)
            {
                MessageBox.Show("Cannot undo last bib tagged as there is no face tagged!", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (person.IsBibRegionTagged)
            {
                // Most likely want to undo the bib number
                AskToTagBibNumber(MainWindow.Singleton.MainPictureBox, person);
            }
            else if (person.Bib.ClickPoints.Count == 1)
            {
                DeleteTaggedPerson(person);
                MainWindow.Singleton.RequestRedrawGraphics();
            }
            else if (person.Bib.ClickPoints.Count > 0)
            {
                person.Bib.ClickPoints.Remove(person.Bib.ClickPoints.Last());
                person.Bib.PixelPoints.Remove(person.Bib.PixelPoints.Last());
                MainWindow.Singleton.RequestRedrawGraphics();
            }
        }
        #endregion

        #region FaceRegion
        public void RecordStartOfFaceRegion(PictureBox pbx, Point pt)
        {
            Debug.WriteLine($"Person #{SelectedRunner.BibNumber} face reigon start at {pt} ({Identifier})");
            SetFaceReigonAtIndex(pbx, pt, 0);
        }

        public void UpdateEndOfFaceRegion(PictureBox pbx, Point pt)
        {
            Debug.WriteLine($"Person #{SelectedRunner.BibNumber} face reigon end at {pt} ({Identifier})");
            SetFaceReigonAtIndex(pbx, pt, 1);
        }

        private void SetFaceReigonAtIndex(PictureBox pbx, Point pt, int idx)
        {
            TaggedPerson.PersonFace face = SelectedRunner.Face;
            Point pixelPt = pt.ToPixelPoint(pbx);

            if (face.ClickPoints.Count == idx)
            {
                face.ClickPoints.Add(pt);
                face.PixelPoints.Add(pixelPt);
            }
            else
            {
                face.ClickPoints[idx] = pt;
                face.PixelPoints[idx] = pixelPt;
            }
        }
        void RemoveLastFaceTaggingRegion()
        {
            TaggedPerson person = LastRunnerTagged;
            if (person == null || person.Face.ClickPoints.Count == 0)
            {
                MessageBox.Show("Cannot undo last face tagged as there is no face region tagged!", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            person.Face.ClickPoints.Clear();
            person.Face.PixelPoints.Clear();
            MainWindow.Singleton.RequestRedrawGraphics();
        }
        #endregion

        #region Classifications
        public bool AskForBothClassificationsOfPerson(TaggedPerson person)
        {
            bool didSetBase;
            bool didSetColor;
            do
            {
                didSetBase = AskForBaseClassificationsOfPerson(person);
                if (!didSetBase)
                {
                    return false;
                }
                didSetColor = AskForColorClassificationsOfPerson(person);
            } while (!didSetColor);
            return true;
        }
        public bool AskForBaseClassificationsOfPerson(TaggedPerson person)
        {
            if (!CanMarkFaces)
            {
                MessageBox.Show("Unable to set classifications for person as their face is not yet tagged", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            person.TimerBaseClassificationDialog.Start();
            Form dialog = new PersonBaseClassificationDialog(person);
            bool didSet = dialog.ShowDialog() != DialogResult.Cancel;
            if (didSet)
            {
                TaggedRunners.ResetItem(TaggedRunners.IndexOf(person));
            }
            person.TimerBaseClassificationDialog.Stop();
            return didSet;
        }
        public bool AskForColorClassificationsOfPerson(TaggedPerson person)
        {
            if (!CanMarkFaces)
            {
                MessageBox.Show("Unable to set classifications for person as their face is not yet tagged", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            person.TimerColorClassificationDialog.Start();
            Form dialog = new PersonColorClassificationsDialog(person);
            bool didSet = dialog.ShowDialog() != DialogResult.Cancel;
            if (didSet)
            {
                TaggedRunners.ResetItem(TaggedRunners.IndexOf(person));
            }
            person.TimerColorClassificationDialog.Stop();
            return didSet;
        }
        public bool AskIfPhotoTaggedAsComplete()
        {
            DialogResult result = MessageBox.Show("Are you finished tagging this image?", "Moving to Next Photo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                IsPhotoCompletelyTagged = false;
                return false;
            }
            else
            {
                IsPhotoCompletelyTagged = true;
                return true;
            }
        }
        #endregion Classifications
    }
}
