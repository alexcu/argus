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
    public partial class PersonClassificationsDialog : Form
    {
        public TaggedPerson Person { get; private set; }

        public PersonClassificationsDialog(TaggedPerson person)
        {
            InitializeComponent();
            Person = person;
            CropPersonPhoto();
        }

        void CropPersonPhoto()
        {
            Image srcImg = MainWindow.Singleton.MainPictureBox.Image;
            // Crop image to bib
            Bitmap bmp = new Bitmap(srcImg);
            // Bounding area
            int left = Person.LeftmostPixelX - 100;
            int right = Person.RightmostPixelX + 100;
            // Ensure we don't overcompensate
            left = left < 0 ? 0 : left;
            right = right > srcImg.Width ? srcImg.Width : right;
            int width = right - left;
            int height = srcImg.Height;
            Rectangle crop = new Rectangle(left, 0, width, height);
            // Clone cropped image
            Bitmap croppedImage = bmp.Clone(crop, bmp.PixelFormat);
            bmp.Dispose();
            // Present
            imgPersonCrop.Image = croppedImage;
        }

        void BindEvents()
        {
        }
    }
}
