using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HermesDataTagger
{
    public partial class PersonColorClassificationsDialog : Form
    {
        public TaggedPerson Person { get; private set; }
        private bool _isSettingShirtColor = true;
        private bool _isSettingShortsColor = false;
        private bool _isSettingShoeColor = false;
        private bool _isSettingHatColor = false;
        private bool _dragingModeEnabled = false;

        public PersonColorClassificationsDialog(TaggedPerson person)
        {
            InitializeComponent();
            Person = person;
            CropPersonPhoto();
            BindDataToControls();
            BindEvents();
            UpdateInstructionsLabel();
            // TODO: Work out why the window size won't reflect the designer
            Height += 75;
        }

        void CropPersonPhoto()
        {
            Image srcImg = MainWindow.Singleton.MainPictureBox.Image;
            // Crop image to bib
            Bitmap bmp = (Bitmap)srcImg;
            // Bounding area
            int left = Person.LeftmostPixelX - 200;
            int right = Person.RightmostPixelX + 200;
            // Ensure we don't overcompensate
            left = left < 0 ? 0 : left;
            right = right > srcImg.Width ? srcImg.Width : right;
            int width = right - left;
            int height = srcImg.Height;
            Rectangle crop = new Rectangle(left, 0, width, height);
            // Clone cropped image
            Bitmap croppedImage = bmp.Clone(crop, bmp.PixelFormat);
            // Present
            imgPersonCrop.Image = croppedImage;
        }

        void BindDataToControls()
        {
            pnlShirtColor.DataBindings.Add("BackColor", Person, "ShirtColor", false, DataSourceUpdateMode.OnPropertyChanged, SystemColors.Control);
            pnlShortsColor.DataBindings.Add("BackColor", Person, "ShortsColor", false, DataSourceUpdateMode.OnPropertyChanged, SystemColors.Control);
            pnlShoesColor.DataBindings.Add("BackColor", Person, "ShoeColor", false, DataSourceUpdateMode.OnPropertyChanged, SystemColors.Control);
            pnlHatColor.DataBindings.Add("BackColor", Person, "HatColor", false, DataSourceUpdateMode.OnPropertyChanged, SystemColors.Control);
        }

        void BindEvents()
        {
            imgPersonCrop.MouseClick += OnClickImage;
            imgPersonCrop.MouseDown += (sender, e) => _dragingModeEnabled = true;
            imgPersonCrop.MouseMove += (sender, e) => { if (_dragingModeEnabled) { OnClickImage(sender, e); } };
            imgPersonCrop.MouseUp += (sender, e) =>
            {
                _dragingModeEnabled = false;
                if (_isSettingShirtColor)
                {
                    rdoSettingShortsColor.Checked = true;
                }
                else if (_isSettingShortsColor)
                {
                    rdoSettingShoesColor.Checked = true;
                }
                else if (_isSettingShoeColor)
                {
                    rdoSettingHatColor.Checked = true;
                    btnSave.Focus();
                }
                else
                {
                    btnSave.Focus();
                }
            };

            // Manually bind radio change events
            rdoSettingShirtColor.CheckedChanged += (sender, e) =>
            {
                _isSettingShirtColor = !_isSettingShirtColor;
                UpdateInstructionsLabel();
            };
            rdoSettingShoesColor.CheckedChanged += (sender, e) =>
            {
                _isSettingShoeColor = !_isSettingShoeColor;
                UpdateInstructionsLabel();
            };
            rdoSettingShortsColor.CheckedChanged += (sender, e) =>
            {
                _isSettingShortsColor = !_isSettingShortsColor;
                UpdateInstructionsLabel();
            };
            rdoSettingHatColor.CheckedChanged += (sender, e) =>
            {
                _isSettingHatColor = !_isSettingHatColor;
                UpdateInstructionsLabel();
            };
            // Clear buttons
            btnClearShirtColor.Click += (sender, e) => Person.ShirtColor = Color.Empty;
            btnClearShortsColor.Click += (sender, e) => Person.ShortsColor = Color.Empty;
            btnClearShoesColor.Click += (sender, e) => Person.ShoeColor = Color.Empty;
            btnClearHatColor.Click += (sender, e) => Person.ShoeColor = Color.Empty;
        }

        void UpdateInstructionsLabel()
        {
            if (_isSettingShirtColor)
            {
                lblInstructions.Text = "Please click on the shirt of the runner to set the color, or skip if not applicable";
            }
            if (_isSettingShortsColor)
            {
                lblInstructions.Text = "Please click on the shorts of the runner to set the color, or skip if not applicable";
            }
            if (_isSettingShoeColor)
            {
                lblInstructions.Text = "Please click on the shoe of the runner to set the color, or skip if not applicable";
            }
            if (_isSettingHatColor)
            {
                lblInstructions.Text = "Please click on the hat of the runner to set the color, or skip if not applicable";
            }
        }

        private void OnClickImage(object sender, MouseEventArgs e)
        {
            Point pt = e.Location;
            // Ignore this point if outside bounds of pbx
            if (!imgPersonCrop.IsPointInImage(pt))
            {
                return;
            }
            Bitmap bmp = (Bitmap)(imgPersonCrop.Image);
            Point pixelPt = pt.ToPixelPoint(imgPersonCrop);
            Color pixelColor = bmp.GetPixel(pixelPt.X, pixelPt.Y);
            if (_isSettingShirtColor)
            {
                Person.ShirtColor = pixelColor;
            }
            else if (_isSettingShortsColor)
            {
                Person.ShortsColor = pixelColor;
            }
            else if (_isSettingShoeColor)
            {
                Person.ShoeColor = pixelColor;
            }
            else if (_isSettingHatColor)
            {
                Person.HatColor = pixelColor;
                // If not empty, then person must be wearing a hat
                Person.IsWearingHat = !pixelColor.IsEmpty;
            }
        }
    }
}
