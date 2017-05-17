using System;
using System.Collections.Generic;
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
        public string Filename { get; }
        public string Identifier { get; }

        // Array of person
        public List<TaggedPerson> TaggedPeople = new List<TaggedPerson>();
        public TaggedPerson LastPersonTagged => TaggedPeople.LastOrDefault();

        // Current step with photo
        public StepType TaggingStep { get; set; }
        public string TaggingStepLabel => TaggingStep.ToActionLabel();
        public string TaggingStepHelpLabel => TaggingStep.ToHelpLabel();

        // Classifications
        public bool IsImageCrowded { get; private set; }

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
                    return;
                default:
                    return;
            }
            // Move to next step
            Debug.WriteLine($"The current step is: {TaggingStep.ToString()}");
            TaggingStep++;
        }

        public void AskIfPhotoCrowded()
        {
            DialogResult result = MessageBox.Show("Is this photo crowded?", "Crowded Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            IsImageCrowded = result == DialogResult.Yes;
        }

        public void TagBibRegion(PictureBox pbx, Point pt)
        {
            TaggedPerson person = LastPersonTagged;

            // First person tagged or new person (last person has 4 clicks)?
            if (person == null || person.Bib.ClickPoints.Count == 4)
            {
                person = new TaggedPerson(this);
                TaggedPeople.Add(person);
                Debug.WriteLine($"Adding person #{TaggedPeople.Count} to ({Identifier})");
            }
            person.Bib.ClickPoints.Add(pt);
            person.Bib.PixelPoints.Add(pt.ToPixelPoint(pbx));
            Debug.WriteLine($"Person #{TaggedPeople.Count} has Bib[{person.Bib.ClickPoints.Count}] = {pt} ({Identifier})");
            if (person.Bib.ClickPoints.AtCapacity())
            {
                BibNumberDialog bibDiag = new BibNumberDialog(pbx.Image, person.Bib);
                bibDiag.ShowDialog();
                person.Bib.BibNumber = bibDiag.BibNumber;
                Debug.WriteLine($"Person #{TaggedPeople.Count} RBN identified as {person.Bib.BibNumber} ({Identifier})");
            }
        }
    }
}
