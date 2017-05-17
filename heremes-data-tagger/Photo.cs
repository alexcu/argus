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

        // Bib tagging management
        private List<Point> _bibTagCache = new List<Point>(4);

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
                    bool tagResult = TagBibRegion(picBx, e.Location);
                    if (tagResult)
                    {
                        //break;
                    }
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

        private void DrawBibLine(PictureBox picBx)
        {
            int lastIdx = _bibTagCache.Count() - 1;
            using (Graphics graphics = picBx.CreateGraphics())
            {
                Point fromPt = _bibTagCache[lastIdx];
                Point lastPt =_bibTagCache[lastIdx - 1];
                graphics.DrawLine(Utils.BibPen, fromPt, lastPt);
                // Autocomplete polygon
                if (lastIdx == _bibTagCache.Capacity - 1)
                {
                    graphics.DrawLine(Utils.BibPen, fromPt, _bibTagCache[0]);
                }
            }
        }

        public bool TagBibRegion(PictureBox picBx, Point pt)
        {
            int idx = _bibTagCache.Count;
            // Points 0, 1, 2
            _bibTagCache.Add(pt);
            if (idx > 0 && idx < _bibTagCache.Capacity)
            {
                DrawBibLine(picBx);
            }
            if (idx == _bibTagCache.Capacity - 1)
            {
                // Map each "clicked" coords into "pixel of photo" coords
                Point[] pixelPts = _bibTagCache.Select(p => Utils.MousePointToPixelPoint(picBx, p)).ToArray();
                Point[] clickPts = _bibTagCache.ToArray();
                TaggedPerson person = new TaggedPerson(this, pixelPts, clickPts);
                _bibTagCache.Clear();
                return true;
            }
            return false;
        }
    }
}
