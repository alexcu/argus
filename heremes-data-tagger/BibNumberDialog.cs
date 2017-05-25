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
    public partial class BibNumberDialog : Form
    {
        public string EnteredBibNumber { get; private set; }
        public TaggedPerson Person { get; }

        public BibNumberDialog(TaggedPerson person)
        {
            Person = person;
            InitializeComponent();
            CropBibPhoto();
            BindEvents();
        }

        void CropBibPhoto()
        {
            TaggedPerson.BibSheet bibSheet = Person.Bib;
            Image srcImg = MainWindow.Singleton.MainPictureBox.Image;
            // Crop image to bib
            Bitmap bmp = (Bitmap)srcImg;
            // Bounding area
            int startX = bibSheet.PixelPoints.Min(pt => pt.X) - 10;
            int startY = bibSheet.PixelPoints.Min(pt => pt.Y) - 10;
            int endX = bibSheet.PixelPoints.Max(pt => pt.X) + 10;
            int endY = bibSheet.PixelPoints.Max(pt => pt.Y) + 10;
            // Ensure we don't overcompensate
            startX = startX < 0 ? 0 : startX;
            startY = startY < 0 ? 0 : startY;
            endX = endX > srcImg.Width ? srcImg.Width : endX;
            endY = endY > srcImg.Height ? srcImg.Height : endY;
            int width = endX - startX;
            int height = endY - startY;
            Rectangle crop = new Rectangle(startX, startY, width, height);
            // Clone cropped image
            Bitmap croppedImage = bmp.Clone(crop, bmp.PixelFormat);
            // Present
            imgBibCrop.Image = croppedImage;
        }

        void BindEvents()
        {
            txtBibNumber.TextChanged += (sender, e) =>
            {
                btnEnterBibNumber.Enabled = !String.IsNullOrWhiteSpace(txtBibNumber.Text);
                EnteredBibNumber = txtBibNumber.Text;
            };
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Escape to cancel
            if (keyData == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
