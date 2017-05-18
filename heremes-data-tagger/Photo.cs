using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string[] TaggedBibNumbers => TaggedPeople.Select(p => p.BibNumber).ToArray();
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

        #region Graphics
        public Point[][] PolygonsToDraw => TaggedPeople.Where(p => p.Bib.ClickPoints.AtCapacity()).Select(p => p.Bib.ClickPoints.ToArray()).ToArray();
        #endregion

        public Photo(string filename)
        {
            Filename = filename;
            Identifier = System.IO.Path.GetFileNameWithoutExtension(filename);
            TaggingStep = StepType.ImageCrowded;
        }

        public void HandleClick(PictureBox picBx, MouseEventArgs e)
        {
            switch (TaggingStep)
            {
                case StepType.ImageCrowded:
                    AskIfPhotoCrowded();
                    break;
                case StepType.SelectBibRegion:
                    TagBibRegion(picBx, e.Location);
                    break;
                default:
                    break;
            }
        }

        public void AskIfPhotoCrowded()
        {
            DialogResult result = MessageBox.Show("Is this photo crowded?", "Crowded Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            IsPhotoCrowded = result == DialogResult.Yes;
        }

        public void TagBibRegion(PictureBox pbx, Point pt)
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
            if (person.Bib.ClickPoints.AtCapacity())
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
    }
}
