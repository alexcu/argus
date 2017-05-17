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
        public string BibNumber { get; private set; }
        
        public BibNumberDialog(Image srcImage, TaggedPerson.BibSheet bibSheet)
        {
            InitializeComponent();

            // Crop image to bib
            Bitmap bmp = new Bitmap(srcImage);
            // Bounding area
            // TODO: I HAVE NO IDEA WHY X AND Y ARE INVERTED!
            int top = bibSheet.PixelPoints.Min(pt => pt.X) - 10;
            int btm = bibSheet.PixelPoints.Max(pt => pt.X) + 10;
            int left = bibSheet.PixelPoints.Min(pt => pt.Y) - 10;
            int right = bibSheet.PixelPoints.Max(pt => pt.Y) + 10;
            int height = right - left;
            int width = btm - top;
            Rectangle crop = new Rectangle(top, left, width, height);
            // Clone cropped image
            Bitmap croppedImage = bmp.Clone(crop, bmp.PixelFormat);
            bmp.Dispose();
            // Present
            imgBibCrop.Image = croppedImage;

            BindEvents();
        }

        void BindEvents()
        {
            // Prevent form from closing if empty text
            FormClosing += (sender, e) =>
            {
                if (String.IsNullOrWhiteSpace(txtBibNumber.Text))
                {
                    e.Cancel = true;
                }
                else
                {
                    BibNumber = txtBibNumber.Text;
                }
            };

            txtBibNumber.TextChanged += (sender, e) =>
            {
                btnEnterBibNumber.Enabled = !String.IsNullOrWhiteSpace(txtBibNumber.Text);
            };

            btnEnterBibNumber.Click += (sender, e) => Close();

            txtBibNumber.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Close();
                }
            };
        }
    }
}
