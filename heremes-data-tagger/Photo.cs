using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using PropertyChanged;

namespace HermesDataTagger
{
    [ImplementPropertyChanged]
    public class Photo
    {
        // Basic identifiers
        public string Filename { get; }
        public string Identifier { get; }

        private bool _isComplete;
        public event EventHandler PhotoCompleteStatusChanged;
        public bool IsPhotoCompletelyTagged {
            get => _isComplete;
            set
            {
                _isComplete = value;
                PhotoCompleteStatusChanged?.Invoke(this, EventArgs.Empty);
                MainWindow.Singleton.RequestPopulateFilesList();
            }
        }
        public bool IsPhotoNotCompletelyTagged => !IsPhotoCompletelyTagged;
        public void ToggleComplete()
        {
            IsPhotoCompletelyTagged = !IsPhotoCompletelyTagged;
        }

        #region TaggedItems
        public event EventHandler SelectedRunnerUpdated;
        public BindingList<TaggedPerson> TaggedRunners = new BindingList<TaggedPerson>();
        public List<TaggedPerson> OrderedTaggedRunners => TaggedRunners.OrderBy(p => p.LeftmostClickX).ToList();
        public TaggedPerson LastRunnerTagged => TaggedRunners.FirstOrDefault();
        public bool HasTaggedARunner => TaggedBibNumbers.Length > 0;
        private string[] TaggedBibNumbers => TaggedRunners.Select(p => p.BibNumber).ToArray();
        private TaggedPerson _selectedRunner;
        public bool IsRunnerSelected => SelectedRunner != null;
        public bool CanOpenRunnerMenu => IsRunnerSelected && SelectedRunner.IsBibRegionTagged;
        public bool CanSelectNextRunner => HasTaggedARunner && SelectedRunner != OrderedTaggedRunners.Last();
        public bool CanSelectPrevRunner => HasTaggedARunner && SelectedRunner != OrderedTaggedRunners.First();
        public TaggedPerson SelectedRunner
        {
            get => _selectedRunner;
            set {
                try
                {
                    _selectedRunner = value;
                }
                catch (FormatException)
                {
                    // Ignore
                }
                finally
                {
                    if (SelectedRunnerUpdated != null && value != null)
                    {
                        SelectedRunnerUpdated(this, EventArgs.Empty);
                    }
                }
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
                SelectedRunner = null;
            }
            if (TaggedRunners.Count == 0)
            {
                TaggingStep = StepType.SelectBibRegion;
            }
        }
        #endregion

        #region Steps
        // Steps in tagging the photo
        private StepType _taggingStep = StepType.ImageCrowded;
        public StepType TaggingStep {
            get => _taggingStep;
            set {
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
                        }
                        break;
                }
            }
        }
        public bool IsFirstTaggingStep => TaggingStep.IsFirstStep();
        public bool IsLastTaggingStep => TaggingStep.IsLastStep();
        public string TaggingStepName => TaggingStep.ToStepNameString();
        public string TaggingStepInstructions => TaggingStep.ToInstructionString();
        public bool CanMarkFaces => CanMarkBibs && HasTaggedARunner;
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
        public bool IsPhotoNotCrowded => !IsPhotoCrowded;
        public bool IsPhotoCrowded
        {
            get => _isPhotoCrowded;
            set
            {
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
                IsPhotoCompletelyTagged = false;
            }
        }
        #endregion

        public Photo(string filename)
        {
            Filename = filename;
            Identifier = System.IO.Path.GetFileNameWithoutExtension(filename);
            TaggingStep = StepType.ImageCrowded;
        }


        #region HandleEvents
        public void HandleClick(PictureBox pbx, MouseEventArgs e)
        {
            switch (TaggingStep)
            {
                case StepType.ImageCrowded:
                    AskIfPhotoCrowded();
                    if (IsPhotoNotCrowded)
                    {
                        TaggingStep++;
                    }
                    break;
                case StepType.SelectBibRegion:
                    AskToTagBibRegion(pbx, e.Location);
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
                    RecordStartOfFaceRegion(pbx, e.Location);
                    break;
                default:
                    break;
            }
        }

        internal void RedoLastAction()
        {
            throw new NotImplementedException();
        }

        internal void UndoLastAction()
        {
            throw new NotImplementedException();
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
                    bool didSetBothClassifications = AskForBaseClassificationsOfPerson(SelectedRunner) && AskForColorClassificationsOfPerson(SelectedRunner);
                    if (!didSetBothClassifications)
                    {
                        SelectedRunner.Face.ClearPoints();
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
            DialogResult result = MessageBox.Show("Is this photo crowded?", "Crowded Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            IsPhotoCrowded = result == DialogResult.Yes;
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
                person = new TaggedPerson(this);
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
            // Notify that bindings should be updated to display tag
            TaggedRunners.ResetItem(TaggedRunners.IndexOf(person));
            Debug.WriteLine($"Person #{TaggedRunners.Count} RBN identified as {person.Bib.BibNumber} ({Identifier})");
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
        #endregion

        #region Classifications
        public bool AskForBaseClassificationsOfPerson(TaggedPerson person)
        {
            if (!CanMarkFaces)
            {
                MessageBox.Show("Unable to set classifications for person as their face is not yet tagged", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            Form dialog = new PersonBaseClassificationDialog(person);
            bool didSet = dialog.ShowDialog() != DialogResult.Cancel;
            if (didSet)
            {
                TaggedRunners.ResetItem(TaggedRunners.IndexOf(person));
            }
            return didSet;
        }
        public bool AskForColorClassificationsOfPerson(TaggedPerson person)
        {
            if (!CanMarkFaces)
            {
                MessageBox.Show("Unable to set classifications for person as their face is not yet tagged", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            Form dialog = new PersonColorClassificationsDialog(person);
            bool didSet = dialog.ShowDialog() != DialogResult.Cancel;
            if (didSet)
            {
                TaggedRunners.ResetItem(TaggedRunners.IndexOf(person));
            }
            return didSet;            
        }
        #endregion Classifications
    }
}
