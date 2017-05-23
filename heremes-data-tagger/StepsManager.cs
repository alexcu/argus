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
        ImageCrowded = 0,
        SelectBibRegion,
        SelectFaceRegion
    }

    public static class StepTypeExtensions
    {
        private static PhotoManager Model = PhotoManager.SharedManager;

        public static bool IsFirstStep(this StepType me)
        {
            return me == 0;
        }

        public static bool IsLastStep(this StepType me)
        {
            return (int)me == Enum.GetValues(typeof(StepType)).Length - 1;
        }

        public static string ToStepNameString(this StepType me)
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

        public static string ToInstructionString(this StepType me)
        {
            switch (me)
            {
                case StepType.ImageCrowded:
                    return "Does this image have more than 5 people? Use CTRL+C to toggle if the image is crowded.";
                case StepType.SelectBibRegion:
                    return "Click FOUR times on the image to mark up a new bib region in a CLOCKWISE DIRECTION (top left, top right, bottom right, bottom left)";
                case StepType.SelectFaceRegion:
                    TaggedPerson person = Model.CurrentPhoto.SelectedRunner;
                    if (person == null)
                    {
                        return "You MUST TAG BIB REGIONS (Step 2) before you can select face regions!";
                    }
                    else
                    {
                        return $"Drag-and-drop around the face for the runner with Bib #{person.BibNumber}";
                    }
                default:
                    return "";
            }
        }
    }
}
