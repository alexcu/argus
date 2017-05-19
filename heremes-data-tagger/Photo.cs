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

        #region TaggedItems
        public BindingList<TaggedPerson> TaggedPeople = new BindingList<TaggedPerson>();
        public TaggedPerson LastPersonTagged => TaggedPeople.FirstOrDefault();
        public bool HasTaggedPeople => TaggedBibNumbers.Length > 0;
        private string[] TaggedBibNumbers => TaggedPeople.Select(p => p.BibNumber).ToArray();
        public TaggedPerson SelectedPerson { get; set; }
        #endregion

        #region Steps
        // Steps in tagging the photo
        public StepType TaggingStep { get; set; }
        public bool IsFirstTaggingStep => TaggingStep.IsFirstStep();
        public bool IsLastTaggingStep => TaggingStep.IsLastStep();
        public string TaggingStepName => TaggingStep.ToStepNameString();
        public string TaggingStepInstructions => TaggingStep.ToInstructionString();
        public void GoToNextStep()
        {
            // Can only progress if photo is not crowded
            if (IsPhotoCrowded)
            {
                return;
            }
            // Can only progress to following steps if at least one person tagged
            if (TaggingStep == StepType.SelectBibRegion && !HasTaggedPeople)
            {
                return;
            }
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
        private bool _photoCrowded = false;
        public bool IsPhotoNotCrowded { get { return !_photoCrowded; } }
        public bool IsPhotoCrowded    { get { return _photoCrowded; }  set { _photoCrowded = value; } }
        #endregion

        public Photo(string filename)
        {
            Filename = filename;
            Identifier = System.IO.Path.GetFileNameWithoutExtension(filename);
            TaggingStep = StepType.ImageCrowded;
        }

        public void DeleteTaggedPerson(TaggedPerson person)
        {
            TaggedPeople.Remove(person);
            if (person == SelectedPerson)
            {
                SelectedPerson = null;
            }
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
                    // Notify that this person has now been tagged (mouse up)
                    TaggedPeople.ResetItem(TaggedPeople.IndexOf(SelectedPerson));
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region CrowdedPhoto
        public void AskIfPhotoCrowded()
        {
            DialogResult result = MessageBox.Show("Is this photo crowded?", "Crowded Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            IsPhotoCrowded = result == DialogResult.Yes;
        }
        #endregion

        #region AddBibRegion
        public void AskToTagBibRegion(PictureBox pbx, Point pt)
        {
            TaggedPerson person = LastPersonTagged;

            // First person tagged or new person (last person has 4 clicks)?
            if (person == null || person.Bib.ClickPoints.Count == 4)
            {
                person = new TaggedPerson(this);
                TaggedPeople.Insert(0, person);
                Debug.WriteLine($"Adding person #{TaggedPeople.Count} to ({Identifier})");
            }
            person.Bib.ClickPoints.Add(pt);
            person.Bib.PixelPoints.Add(pt.ToPixelPoint(pbx));
            Debug.WriteLine($"Person #{TaggedPeople.Count} has Bib[{person.Bib.ClickPoints.Count}] = {pt} ({Identifier})");
            // We just finished tagging?
            if (person.IsBibRegionTagged)
            {
                // Invalidate (update graphics) of picture box to reflect new bib number
                pbx.Invalidate();
                AskToTagBibNumber(pbx, person);
            }
        }

        public void AskToTagBibNumber(PictureBox pbx, TaggedPerson person)
        {
            // Can only tag if all clicked!
            if (person.IsBibRegionTagged)
            {
                BibNumberDialog bibDiag = new BibNumberDialog(pbx.Image, person.Bib);
                // Prevent duplicate bib numbers being entered
                do
                {
                    bibDiag.ShowDialog();
                    string diagBibNumber = bibDiag.BibNumber;
                    if (TaggedBibNumbers.Contains(diagBibNumber))
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
                TaggedPeople.ResetItem(0);
                Debug.WriteLine($"Person #{TaggedPeople.Count} RBN identified as {person.Bib.BibNumber} ({Identifier})");
            }
        }
        #endregion

        #region FaceRegion
        public void RecordStartOfFaceRegion(PictureBox pbx, Point pt)
        {
            Debug.WriteLine($"Person #{SelectedPerson.BibNumber} face reigon start at {pt} ({Identifier})");
            SetFaceReigonAtIndex(pbx, pt, 0);
        }

        public void UpdateEndOfFaceRegion(PictureBox pbx, Point pt)
        {
            Debug.WriteLine($"Person #{SelectedPerson.BibNumber} face reigon end at {pt} ({Identifier})");
            SetFaceReigonAtIndex(pbx, pt, 1);
        }

        private void SetFaceReigonAtIndex(PictureBox pbx, Point pt, int idx)
        {
            TaggedPerson.PersonFace face = SelectedPerson.Face;
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
    }
}
