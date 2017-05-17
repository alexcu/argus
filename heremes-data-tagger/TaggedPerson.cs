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
        public struct PersonFace
        {
            // Reigon
            public Point TopLeft { get; set; }
            public Point BtmRight { get; set; }
            public Point[] Points => new Point[] { TopLeft, BtmRight };

            public Point[] PixelPoints;
            public Point[] DisplayPoints;

            // Face modifications
            public bool IsWearingCap { get; set; }
            public bool IsWearingSunglasses { get; set; }

            // Classifications
            public bool IsFaceVisible { get; set; }
        }
        public struct BibSheet
        {
            public Point TopLeft { get; set; }
            public Point TopRight { get; set; }
            public Point BtmLeft { get; set; }
            public Point BtmRight { get; set; }
            public Point[] Points => new Point[] { TopLeft, TopRight, BtmLeft, BtmRight };

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
        private Point[] AllPoints => Face.Points.Concat(Bib.Points).ToArray();
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

        public TaggedPerson(Photo srcPhoto, Point[] clickPts, Point[] pixelPts)
        {
            Bib = new BibSheet
            {
                TopLeft = pixelPts[0],
                TopRight = pixelPts[1],
                BtmRight = pixelPts[2],
                BtmLeft = pixelPts[3]
            };
            SourcePhoto = srcPhoto;
        }
    }
}
