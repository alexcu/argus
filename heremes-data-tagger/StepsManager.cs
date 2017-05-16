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
        SelectFaceRegion,
        Complete
    }

    public static class StepTypeExtensions
    {
        public static string ToActionLabel(this StepType me)
        {
            switch (me)
            {
                case StepType.ImageCrowded:
                    return "Is this image crowded? (Click image to answer)";
                case StepType.SelectBibRegion:
                    return "Select the bib number pad (4 clicks)";
                case StepType.SelectFaceRegion:
                    return "Select the face for this bib (2 clicks)";
                case StepType.Complete:
                    return "Fully tagged";
                default:
                    return "";
            }
        }
    }
}
