using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HermesDataTagger
{
    public enum StepType
    {
        ImageCrowded,
        SelectBibRegion,
        SelectFaceRegion
    }

    public static class StepTypeExtensions
    {
        public static string ToActionLabel(this StepType me)
        {
            switch (me)
            {
                case StepType.ImageCrowded:
                    return "Image Crowded";
                case StepType.SelectBibRegion:
                    return "Select Bib Number Region";
                case StepType.SelectFaceRegion:
                    return "Select Face Region";
                default:
                    return "";
            }
        }

        public static string ToHelpLabel(this StepType me)
        {
            switch (me)
            {
                case StepType.ImageCrowded:
                    return "Determine if this image is crowded with people";
                case StepType.SelectBibRegion:
                    return "Click FOUR times on the image to mark up a new bib region";
                case StepType.SelectFaceRegion:
                    return "Drag-and-drop around the face for the runner with Bib #{X}";
                default:
                    return "";
            }
        }
    }
}
