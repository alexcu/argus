using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PropertyChanged;

namespace HermesDataTagger
{
    [ImplementPropertyChanged]
    public class TaggedPerson
    {
        #region Related Data Types
        [ImplementPropertyChanged]
        public class PersonFace
        {
            // Reigon
            public Point TopLeft => ClickPoints[0];
            public Point BtmRight => ClickPoints[1];

            // 2 indexes for top left and bottom right and the second mapped as pixels
            public List<Point> ClickPoints = new List<Point>(2);
            public List<Point> PixelPoints = new List<Point>(2);

            // Clear functions
            public void ClearPoints()
            {
                ClickPoints.Clear();
                PixelPoints.Clear();
            }

            // Face modifications
            public bool IsWearingHat { get; set; }
            public bool IsWearingGlasses { get; set; }

            // Classifications
            public bool IsFaceVisible { get; set; } = true;
        }
        [ImplementPropertyChanged]
        public class BibSheet
        {
            // Bib region
            public Point TopLeft => ClickPoints[0];
            public Point TopRight => ClickPoints[1];
            public Point BtmRight => ClickPoints[2];
            public Point BtmLeft => ClickPoints[3];

            // 4 indexes for 4 corners of mouse clicks and the representation as pixels
            public List<Point> ClickPoints = new List<Point>(4);
            public List<Point> PixelPoints = new List<Point>(4);

            public string BibNumber { get; set; }
            public bool IsNullBibNumber => BibNumber == null;
        }
        public enum LikelihoodOfPurchaseType { No = -1, Maybe = 0, Yes = 1 }
        #endregion

        // Source photo
        private Photo SourcePhoto { get; }

        // Classifications
        public bool IsRunnerBlurred { get; set; }
        public LikelihoodOfPurchaseType LikelihoodOfPurchase { get; set; }
        public string LikelihoodOfPurchaseName
        {
            get { return LikelihoodOfPurchase.ToString(); }
            set {
                Enum.TryParse(value, out LikelihoodOfPurchaseType type);
                System.Diagnostics.Debug.WriteLine($"Person set to {type}");
                LikelihoodOfPurchase = type;
            }
        }
        public bool IsLikelihoodOfPurchaseYes => LikelihoodOfPurchase == LikelihoodOfPurchaseType.Yes;
        public bool IsLikelihoodOfPurchaseMaybe => LikelihoodOfPurchase == LikelihoodOfPurchaseType.Maybe;
        public bool IsLikelihoodOfPurchaseNo => LikelihoodOfPurchase == LikelihoodOfPurchaseType.No;

        // Extension bindings
        public string BibNumber => Bib.BibNumber ?? "N/A";
        public bool IsFaceVisible { get { return Face.IsFaceVisible; } set { Face.IsFaceVisible = value; } }
        public bool IsWearingHat { get { return Face.IsWearingHat; } set { Face.IsWearingHat = value; } }
        public bool IsWearingGlasses { get { return Face.IsWearingGlasses; } set { Face.IsWearingGlasses = value; } }

        // Reigons
        public BibSheet Bib = new BibSheet();
        public bool IsBibRegionTagged => Bib.ClickPoints.AtCapacity();
        public PersonFace Face = new PersonFace();
        public bool IsFaceRegionTagged => Face.ClickPoints.AtCapacity();

        // Bounds of person within photo
        private Point[] AllPixelPoints => Face.PixelPoints.Concat(Bib.PixelPoints).ToArray();
        public int LeftmostPixelX => AllPixelPoints.Min(pt => pt.X);
        public int RightmostPixelX => AllPixelPoints.Max(pt => pt.X);
        private Point[] AllClickPoints => Face.ClickPoints.Concat(Bib.ClickPoints).ToArray();
        public int LeftmostClickX => AllClickPoints.Min(pt => pt.X);
        public int RightmostClickX => AllClickPoints.Max(pt => pt.X);

        // Colors
        public Color ShirtColor { get; set; }
        public Color ShortsColor { get; set; }
        public Color ShoeColor { get; set; }
        public string ShirtColorName => ShirtColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShirtColor).Name;
        public string ShortsColorName => ShortsColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShortsColor).Name;
        public string ShoeColorName => ShoeColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShoeColor).Name;

        public TaggedPerson(Photo srcPhoto)
        {
            SourcePhoto = srcPhoto;
        }
    }
}
