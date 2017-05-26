using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PropertyChanged;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Ponos
{
    [ImplementPropertyChanged]
    public class TaggedPerson
    {
        #region Timers
        [JsonIgnore]
        public Stopwatch TimerBibRegionClicks { get; } = new Stopwatch();
        [JsonIgnore]
        public Stopwatch TimerEnteringBibNumber { get; } = new Stopwatch();
        [JsonIgnore]
        public Stopwatch TimerBaseClassificationDialog { get; } = new Stopwatch();
        [JsonIgnore]
        public Stopwatch TimerColorClassificationDialog { get; } = new Stopwatch();
        [JsonIgnore]
        public Stopwatch TimerFaceDragDrop { get; } = new Stopwatch();
        // Time we care about
        public float TimeToClickBibReigons => TimerBibRegionClicks.ElapsedMilliseconds;
        public float TimeToEnterBibNumber => TimerEnteringBibNumber.ElapsedMilliseconds;
        public float TimeToDoBaseClassifications => TimerBaseClassificationDialog.ElapsedMilliseconds;
        public float TimeToDoColorClassifications => TimerColorClassificationDialog.ElapsedMilliseconds;
        public float TotalTimeTaken => TimeToClickBibReigons + TimeToEnterBibNumber + TimeToDoBaseClassifications + TimeToDoColorClassifications;
        #endregion

        #region Related Data Types
        [ImplementPropertyChanged]
        public class PersonFace
        {
            // Region
            [JsonIgnore]
            public Point Centre => new Point((int)ClickPoints.Average(pt => pt.X), (int)ClickPoints.Average(pt => pt.Y));
            [JsonIgnore]
            public Point TopLeft => ClickPoints.Find(pt => pt.X < Centre.X && pt.Y < Centre.Y); // MinX, MinY
            [JsonIgnore]
            public Point BtmRight => ClickPoints.Find(pt => pt.X > Centre.X && pt.Y > Centre.Y);  // MaxX, MaxY

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
            [JsonIgnore]
            public Point Centre => new Point((int)ClickPoints.Average(pt => pt.X), (int)ClickPoints.Average(pt => pt.Y));
            [JsonIgnore]
            public Point TopLeft => ClickPoints.Find(pt => pt.X < Centre.X && pt.Y < Centre.Y); // MinX, MinY
            [JsonIgnore]
            public Point TopRight => ClickPoints.Find(pt => pt.X > Centre.X && pt.Y < Centre.Y); // MaxX, MinY
            [JsonIgnore]
            public Point BtmRight => ClickPoints.Find(pt => pt.X > Centre.X && pt.Y > Centre.Y);  // MaxX, MaxY
            [JsonIgnore]
            public Point BtmLeft => ClickPoints.Find(pt => pt.X < Centre.X && pt.Y > Centre.Y); // MinX, MaxY

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
                    MainWindow.Singleton.RequestUpdateSelectedRunner();
                }
            }
            public bool IsNullBibNumber => BibNumber == null;
        }
        public enum LikelihoodOfPurchaseType { No = -1, Maybe = 0, Yes = 1 }
        public enum GenderType { Male, Female, Unknown }
        #endregion

        // Source photo
        private Photo SourcePhoto { get; }

        // Classifications
        public bool IsRunnerBlurred { get; set; }
        // Gender
        public GenderType Gender { get; set; }
        [JsonIgnore]
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
        public bool IsWearingHat { get { return Face.IsWearingHat; } set { Face.IsWearingHat = value; } }
        [JsonIgnore]
        public bool IsWearingGlasses { get { return Face.IsWearingGlasses; } set { Face.IsWearingGlasses = value; } }

        // Reigons
        public BibSheet Bib { get; } = new BibSheet();
        public bool IsBibRegionTagged => Bib.ClickPoints.AtCapacity();
        public PersonFace Face { get; } = new PersonFace();
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
        public Color HatColor { get; set; }
        public string ShirtColorName => ShirtColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShirtColor).Name;
        public string ShortsColorName => ShortsColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShortsColor).Name;
        public string ShoeColorName => ShoeColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(ShoeColor).Name;
        public string HatColorName => HatColor.IsEmpty ? "N/A" : Utils.GetNearestWebColor(HatColor).Name;

        public TaggedPerson(Photo srcPhoto)
        {
            SourcePhoto = srcPhoto;
        }
    }
}
