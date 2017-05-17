using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HermesDataTagger
{
    public class TaggedPerson
    {
        #region Related Data Types
        public class PersonFace
        {
            // Reigon
            public Point TopLeft => ClickPoints[0];
            public Point BtmRight => ClickPoints[1];

            // 2 indexes for top left and bottom right and the second mapped as pixels
            public List<Point> ClickPoints = new List<Point>(2);
            public List<Point> PixelPoints = new List<Point>(2);

            // Face modifications
            public bool IsWearingCap { get; set; }
            public bool IsWearingSunglasses { get; set; }

            // Classifications
            public bool IsFaceVisible { get; set; }
        }
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
        }
        public enum LikelihoodOfPurchaseType { No = -1, Maybe = 0, Yes = 1 }
        #endregion

        // Source photo
        public Photo SourcePhoto { get; }

        // Classifications
        public bool IsRunnerBlurred { get; set; }
        public LikelihoodOfPurchaseType LikelihoodOfPurchase { get; set; }

        // Reigons
        public BibSheet Bib = new BibSheet();
        public PersonFace Face = new PersonFace();

        // Bounds of person within photo
        private Point[] AllPoints => Face.ClickPoints.Concat(Bib.ClickPoints).ToArray();
        public int LeftmostX => AllPoints.Min(pt => pt.X);
        public int RightmostX => AllPoints.Max(pt => pt.X);
    
        // Colors
        private Color _shirtColor = Color.Black;
        private Color _shortsColor = Color.Black;
        private Color _shoesColor = Color.Black;
        public Color ShirtColor
        {
            get { return _shirtColor; }
            set { _shirtColor = Utils.GetNearestWebColor(value); }
        }
        public Color ShortsColor
        {
            get { return _shortsColor; }
            set { _shortsColor = Utils.GetNearestWebColor(value); }
        }
        public Color ShoesColor
        {
            get { return _shoesColor; }
            set { _shoesColor = Utils.GetNearestWebColor(value); }
        }

        public TaggedPerson(Photo srcPhoto)
        {
            SourcePhoto = srcPhoto;
        }
    }
}
