using Newtonsoft.Json;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Argus
{
    [ImplementPropertyChanged]
    public class TaggedPerson
    {
        // Aspect ratio of Width and Height of Face relative to Bib sheet
        private const int FACE_ASPECT_W = 3;
        private const int FACE_ASPECT_H = 5;

        #region Statistics
        public Stopwatch TimeToClickBibRegions { get; set; }
        public Stopwatch TimeToEnterBibNumber { get; set; }
        public Stopwatch TimeToDoBaseClassifications { get; set; }
        public Stopwatch TimeToDoColorClassifications { get; set; }
        public Stopwatch TimeToDragAndDropFaceRegion { get; set; }
        public long TotalTimeTaken => 
            TimeToClickBibRegions.ElapsedMilliseconds +
            TimeToEnterBibNumber.ElapsedMilliseconds +
            TimeToDoBaseClassifications.ElapsedMilliseconds +
            TimeToDoColorClassifications.ElapsedMilliseconds +
            TimeToDragAndDropFaceRegion.ElapsedMilliseconds;

        public List<DateTime> TimeToClickBibRegionsTimestampsStarted => TimeToClickBibRegions.TimestampsStarted;
        public List<DateTime> TimeToClickBibRegionsTimestampsStopped => TimeToClickBibRegions.TimestampsStopped;
        public List<DateTime> TimeToEnterBibNumberTimestampsStarted => TimeToEnterBibNumber.TimestampsStarted;
        public List<DateTime> TimeToEnterBibNumberTimestampsStopped => TimeToEnterBibNumber.TimestampsStopped;
        public List<DateTime> TimeToDoBaseClassificationsTimestampsStarted => TimeToDoBaseClassifications.TimestampsStarted;
        public List<DateTime> TimeToDoBaseClassificationsTimestampsStopped => TimeToDoBaseClassifications.TimestampsStopped;
        public List<DateTime> TimeToDoColorClassificationsTimestampsStarted => TimeToDoColorClassifications.TimestampsStarted;
        public List<DateTime> TimeToDoColorClassificationsTimestampsStopped => TimeToDoColorClassifications.TimestampsStopped;
        public List<DateTime> TimeToDragAndDropFaceRegionTimestampsStarted => TimeToDragAndDropFaceRegion.TimestampsStarted;
        public List<DateTime> TimeToDragAndDropFaceRegionTimestampsStopped => TimeToDragAndDropFaceRegion.TimestampsStopped;

        public int TimesBibClickMade { get; set; }
        public int TimesFaceDragAndDropMade { get; set; }
        public int TimesColorClassificationsShown { get; set; }
        public int TimesBaseClassificationsShown { get; set; }
        public int TimesDragAndDropMadeForBibSheet { get; set; }
        public int TimesDragAndDropFaceInInversedDirection { get; set; }
        public int TimesClickedForFaceRegion { get; set; }
        public int TimesSelectedFaceRegionOutsideArea { get; set; }
        public int TimesSelectedFaceRegionBelowBibSheet { get; set; }
        public int TimesAttemptedToShowBaseClassificationsWhenInvalid { get; set; }
        public int TimesAttemptedToShowColorClassificationsWhenInvalid { get; set; }
        #endregion

        #region Related Data Types
        [ImplementPropertyChanged]
        public class PersonFace
        {
            // Region
            public Point PixelCentre => new Point((int)PixelPoints.Average(pt => pt.X), (int)PixelPoints.Average(pt => pt.Y));
            public Point ClickCentre => new Point((int)ClickPoints.Average(pt => pt.X), (int)ClickPoints.Average(pt => pt.Y));

            [JsonIgnore]
            public Point ClickTopLeft => ClickPoints.Find(pt => pt.X < ClickCentre.X && pt.Y < ClickCentre.Y); // MinX, MinY
            [JsonIgnore]
            public Point ClickBottomRight => ClickPoints.Find(pt => pt.X > ClickCentre.X && pt.Y > ClickCentre.Y);  // MaxX, MaxY

            private Point ClickTop => ClickPoints.OrderBy(p => p.Y).First();
            private Point ClickRight => ClickPoints.OrderBy(p => p.X).Last();
            private Point ClickBottom => ClickPoints.OrderBy(p => p.Y).Last();
            private Point ClickLeft => ClickPoints.OrderBy(p => p.X).First();
            private int ClickWidth => ClickRight.X - ClickLeft.X;
            private int ClickHeight => ClickBottom.Y - ClickTop.Y;
            
            private Point PixelTop => PixelPoints.OrderBy(p => p.Y).First();
            private Point PixelRight => PixelPoints.OrderBy(p => p.X).Last();
            private Point PixelBottom => PixelPoints.OrderBy(p => p.Y).Last();
            private Point PixelLeft => PixelPoints.OrderBy(p => p.X).First();
            private int PixelWidth => PixelRight.X - PixelLeft.X;
            private int PixelHeight => PixelBottom.Y - PixelTop.Y;

            // Face region itself
            public Rectangle ClickBounds => new Rectangle(ClickLeft.X, ClickTop.Y, ClickWidth, ClickHeight);
            public Rectangle PixelBounds => new Rectangle(PixelLeft.X, PixelTop.Y, PixelWidth, PixelHeight);

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
            public Point PixelCentre => new Point((int)PixelPoints.Average(pt => pt.X), (int)PixelPoints.Average(pt => pt.Y));
            public Point ClickCentre => new Point((int)ClickPoints.Average(pt => pt.X), (int)ClickPoints.Average(pt => pt.Y));

            [JsonIgnore]
            public Point ClickTopLeft => ClickPoints.Find(pt => pt.X < ClickCentre.X && pt.Y < ClickCentre.Y); // MinX, MinY
            [JsonIgnore]
            public Point ClickTopRight => ClickPoints.Find(pt => pt.X > ClickCentre.X && pt.Y < ClickCentre.Y); // MaxX, MinY
            [JsonIgnore]
            public Point ClickBottomRight => ClickPoints.Find(pt => pt.X > ClickCentre.X && pt.Y > ClickCentre.Y);  // MaxX, MaxY
            [JsonIgnore]
            public Point ClickBottomLeft => ClickPoints.Find(pt => pt.X < ClickCentre.X && pt.Y > ClickCentre.Y); // MinX, MaxY

            private Point ClickTop => ClickPoints.OrderBy(p => p.Y).First();
            private Point ClickRight => ClickPoints.OrderBy(p => p.X).Last();
            private Point ClickBottom => ClickPoints.OrderBy(p => p.Y).Last();
            private Point ClickLeft => ClickPoints.OrderBy(p => p.X).First();
            private int ClickWidth => ClickRight.X - ClickLeft.X;
            private int ClickHeight => ClickBottom.Y - ClickTop.Y;

            private Point PixelTop => PixelPoints.OrderBy(p => p.Y).First();
            private Point PixelRight => PixelPoints.OrderBy(p => p.X).Last();
            private Point PixelBottom => PixelPoints.OrderBy(p => p.Y).Last();
            private Point PixelLeft => PixelPoints.OrderBy(p => p.X).First();
            private int PixelWidth => PixelRight.X - PixelLeft.X;
            private int PixelHeight => PixelBottom.Y - PixelTop.Y;

            // Bib region itself
            public Rectangle ClickBounds => new Rectangle(ClickLeft.X, ClickTop.Y, ClickWidth, ClickHeight);
            public Rectangle PixelBounds => new Rectangle(PixelLeft.X, PixelTop.Y, PixelWidth, PixelHeight);

            // 4 indexes for 4 corners of mouse clicks and the representation as pixels
            public List<Point> ClickPoints = new List<Point>(4);
            public List<Point> PixelPoints = new List<Point>(4);

            private string _bibNumber;
            public string BibNumber
            {
                get => _bibNumber;
                set
                {
                    _bibNumber = value;
                    if (!Photo.LoadingJson)
                    {
                        MainWindow.Singleton.RequestUpdateSelectedRunner();
                    }
                }
            }
            public bool IsNullBibNumber => BibNumber == null;
        }
        public enum LikelihoodOfPurchaseType { No = -1, Maybe = 0, Yes = 1 }
        public enum GenderType { Male, Female, Unknown }
        private Point[] _originalClickPointsBib;
        private Point[] _originalClickPointsFace;
        public void AdaptClickPoints(Size clientSz)
        {
            Size originalSz = clientSz;
            Size newSz = MainWindow.Singleton.MainPictureBox.ClientSize;

            if (originalSz == newSz)
            {
                return;
            }
            else if (_originalClickPointsBib == null)
            {
                _originalClickPointsBib = Bib.ClickPoints.ToArray();
                _originalClickPointsFace = Face.ClickPoints.ToArray();
            }
            
            int w1 = originalSz.Width;
            int w2 = newSz.Width;
            int h1 = originalSz.Height;
            int h2 = newSz.Height;

            for (int i = 0; i < Bib.ClickPoints.Count; i++)
            {
                Bib.ClickPoints[i] = Utils.PixelPointToClickPoint(MainWindow.Singleton.MainPictureBox, Bib.PixelPoints[i]);
            }
            for (int i = 0; i < Face.ClickPoints.Count; i++)
            {
                Face.ClickPoints[i] = Utils.PixelPointToClickPoint(MainWindow.Singleton.MainPictureBox, Face.PixelPoints[i]);
            }
        }
        #endregion

        public TaggedPerson()
        {
            // Construct timers
            TimeToClickBibRegions = new Stopwatch();
            TimeToEnterBibNumber = new Stopwatch();
            TimeToDoBaseClassifications = new Stopwatch();
            TimeToDoColorClassifications = new Stopwatch();
            TimeToDragAndDropFaceRegion = new Stopwatch();
        }

        // Classifications
        public bool IsRunnerBlurred { get; set; }
        // Gender
        public GenderType Gender { get; set; }
        public string GenderName
        {
            get { return Gender.ToString(); }
            set
            {
                Enum.TryParse(value, out GenderType type);
                System.Diagnostics.Debug.WriteLine($"Person set to {type}");
                Gender = type;
                MainWindow.Singleton.RequestRedrawGraphics();
            }
        }
        [JsonIgnore]
        public bool IsGenderMale => Gender == GenderType.Male;
        [JsonIgnore]
        public bool IsGenderFemale => Gender == GenderType.Female;
        [JsonIgnore]
        public bool IsGenderUnknown => Gender == GenderType.Unknown;
        // LoP
        public LikelihoodOfPurchaseType LikelihoodOfPurchase { get; set; }
        public string LikelihoodOfPurchaseName
        {
            get { return LikelihoodOfPurchase.ToString(); }
            set {
                Enum.TryParse(value, out LikelihoodOfPurchaseType type);
                System.Diagnostics.Debug.WriteLine($"Person set to {type}");
                LikelihoodOfPurchase = type;
                MainWindow.Singleton.RequestRedrawGraphics();
            }
        }
        [JsonIgnore]
        public bool IsLikelihoodOfPurchaseYes => LikelihoodOfPurchase == LikelihoodOfPurchaseType.Yes;
        [JsonIgnore]
        public bool IsLikelihoodOfPurchaseMaybe => LikelihoodOfPurchase == LikelihoodOfPurchaseType.Maybe;
        [JsonIgnore]
        public bool IsLikelihoodOfPurchaseNo => LikelihoodOfPurchase == LikelihoodOfPurchaseType.No;


        // Extension bindings
        [JsonIgnore]
        public string BibNumber => Bib.BibNumber ?? "N/A";
        [JsonIgnore]
        public bool IsFaceVisible { get { return Face.IsFaceVisible; } set { Face.IsFaceVisible = value; } }
        [JsonIgnore]
        public bool IsWearingHat { get { return Face.IsWearingHat; } set { Face.IsWearingHat = value; if (!Face.IsWearingHat) { HatColor = Color.Empty; } } }
        [JsonIgnore]
        public bool IsWearingGlasses { get { return Face.IsWearingGlasses; } set { Face.IsWearingGlasses = value; } }

        // Regions
        public BibSheet Bib { get; } = new BibSheet();
        public bool IsBibRegionTagged => Bib.ClickPoints.AtCapacity();
        public PersonFace Face { get; } = new PersonFace();
        public bool IsFaceRegionTagged => Face.ClickPoints.AtCapacity();

        // Face region geometric boundaries
        [JsonIgnore]
        public Size ClickMaxFaceSize => new Size (FACE_ASPECT_W * Bib.ClickBounds.Width, FACE_ASPECT_H * Bib.ClickBounds.Height);
        [JsonIgnore]
        public Rectangle ClickMaxSelectableRegion => new Rectangle((int)(Bib.ClickCentre.X - ClickMaxFaceSize.Width / 2.0), Bib.ClickBounds.Top - ClickMaxFaceSize.Height, ClickMaxFaceSize.Width, ClickMaxFaceSize.Height + Bib.ClickBounds.Height + 30);

        // Bounds of person within photo
        private Point[] AllPixelPoints => Face.PixelPoints.Concat(Bib.PixelPoints).ToArray();
        public int LeftmostPixelX => AllPixelPoints.Min(pt => pt.X);
        public int RightmostPixelX => AllPixelPoints.Max(pt => pt.X);
        private Point[] AllClickPoints => Face.ClickPoints.Concat(Bib.ClickPoints).ToArray();
        public int LeftmostClickX => AllClickPoints.Min(pt => pt.X);
        public int RightmostClickX => AllClickPoints.Max(pt => pt.X);

        // Colors
        private Color _shirtColor;
        private Color _shortsColor;
        private Color _shoeColor;
        private Color _hatColor;

        public Color ShirtColor
        {
            get => _shirtColor;
            set
            {
                if (value == Color.Empty)
                {
                    ShirtColorPoint = Point.Empty;
                }
                _shirtColor = value;
            }
        }
        public Color ShortsColor
        {
            get => _shortsColor;
            set
            {
                if (value == Color.Empty)
                {
                    ShortsColorPoint = Point.Empty;
                }
                _shortsColor = value;
            }
        }
        public Color ShoeColor
        {
            get => _shoeColor;
            set
            {
                if (value == Color.Empty)
                {
                    ShoeColorPoint = Point.Empty;
                }
                _shoeColor = value;
            }
        }
        public Color HatColor
        {
            get => _hatColor;
            set
            {
                if (value == Color.Empty)
                {
                    HatColorPoint = Point.Empty;
                }
                _hatColor = value;
            }
        }

        public Point ShirtColorPoint { get; set; }
        public Point ShortsColorPoint { get; set; }
        public Point ShoeColorPoint { get; set; }
        public Point HatColorPoint { get; set; }
        public string ShirtColorName => ShirtColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShirtColor).Name;
        public string ShortsColorName => ShortsColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShortsColor).Name;
        public string ShoeColorName => ShoeColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShoeColor).Name;
        public string HatColorName => HatColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(HatColor).Name;
    }
}
