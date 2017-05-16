using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace HermesDataTagger
{
    public class Photo
    {
        public string Filename { get; }
        public string Identifier { get; }

        // Current step with photo
        public StepType TaggingStep { get; set; }

        // Classifications
        public bool IsImageCrowded { get; private set; }

        public Photo(string filename)
        {
            Filename = filename;
            Identifier = System.IO.Path.GetFileNameWithoutExtension(filename);
            TaggingStep = StepType.ImageCrowded;
        }

        public void HandleClick(MouseEventArgs e)
        {
            switch (TaggingStep)
            {
                case StepType.ImageCrowded:
                    AskIfPhotoCrowded();
                    break;
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

        public void AskToTagBibReigons()
        {

        }

#region UI Stuff
        public Point GetPointFromMousePos(PictureBox pic, int x, int y)
        {
            int picHeight = pic.ClientSize.Height;
            int picWidth = pic.ClientSize.Width;
            int imgHeight = pic.Image.Height;
            int imgWidth = pic.Image.Width;

            int retX = x;
            int retY = y;

            switch (pic.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                case PictureBoxSizeMode.Normal:
                    // These are okay. Leave them alone.
                    break;
                case PictureBoxSizeMode.CenterImage:
                    retX = x - (picWidth - imgWidth) / 2;
                    retY = y - (picHeight - imgHeight) / 2;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    retX = (int)(imgWidth * x / (float)picWidth);
                    retY = (int)(imgHeight * y / (float)picHeight);
                    break;
                case PictureBoxSizeMode.Zoom:
                    float pic_aspect = picWidth / (float)picHeight;
                    float img_aspect = imgWidth / (float)imgHeight;
                    if (pic_aspect > img_aspect)
                    {
                        // The PictureBox is wider/shorter than the image.
                        retY = (int)(imgHeight * y / (float)picHeight);

                        // The image fills the height of the PictureBox.
                        // Get its width.
                        float scaled_width = imgWidth * picHeight / imgHeight;
                        float dx = (picWidth - scaled_width) / 2;
                        retX = (int)((x - dx) * imgHeight / (float)picHeight);
                    }
                    else
                    {
                        // The PictureBox is taller/thinner than the image.
                        retX = (int)(imgWidth * x / (float)picWidth);

                        // The image fills the height of the PictureBox.
                        // Get its height.
                        float scaled_height = imgHeight * picWidth / imgWidth;
                        float dy = (picHeight - scaled_height) / 2;
                        retY = (int)((y - dy) * imgWidth / picWidth);
                    }
                    break;
            }
            return new Point(retX, retY);
        }
#endregion
    }
}
