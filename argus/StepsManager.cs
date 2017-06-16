using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Argus
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
                    return "(STEP 1/3)  Is this Image Crowded?";
                case StepType.SelectBibRegion:
                    return "(STEP 2/3)  Select Bib Number Region";
                case StepType.SelectFaceRegion:
                    return "(STEP 3/3)  Select Face Region";
                default:
                    return "";
            }
        }

        public static string ToInstructionString(this StepType me)
        {
            switch (me)
            {
                case StepType.ImageCrowded:
                    return "Would you buy this image if you were in the foreground, or is it too crowded?";
                case StepType.SelectBibRegion:
                    return "LEFT-CLICK FOUR times on all BIB SHEETS in the image below";
                case StepType.SelectFaceRegion:
                    TaggedPerson person = Model.CurrentPhoto.SelectedRunner;
                    if (person == null)
                    {
                        return "You MUST TAG BIB REGIONS (Step 2) before you can select face regions!";
                    }
                    else
                    {
                        return "DRAG-AND-DROP from the TOP-LEFT to the BOTTOM-RIGHT of runner {#}'s FACE";
                    }
                default:
                    return "";
            }
        }
    }
}
