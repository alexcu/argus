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
    public partial class PersonBaseClassificationDialog : Form
    {
        public TaggedPerson Person { get; private set; }

        public PersonBaseClassificationDialog(TaggedPerson person)
        {
            InitializeComponent();
            Person = person;
            CropPersonPhoto();
            BindDataToControls();
            // TODO: Work out why the window size won't reflect the designer
            Height += 158;
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

        void BindDataToControls()
        {
            chbxFaceVisible.DataBindings.Add("Checked", Person.Face, "IsFaceVisible", false, DataSourceUpdateMode.OnPropertyChanged);
            chbxGlasses.DataBindings.Add("Checked", Person.Face, "IsWearingGlasses", false, DataSourceUpdateMode.OnPropertyChanged);
            chbxHat.DataBindings.Add("Checked", Person.Face, "IsWearingHat", false, DataSourceUpdateMode.OnPropertyChanged);
            chbxBlurry.DataBindings.Add("Checked", Person, "IsRunnerBlurred", false, DataSourceUpdateMode.OnPropertyChanged);
            // Manual binding of radio buttons :(
            rdoNotBuy.Checked = Person.LikelihoodOfPurchase == TaggedPerson.LikelihoodOfPurchaseType.No;
            rdoMaybeBuy.Checked = Person.LikelihoodOfPurchase == TaggedPerson.LikelihoodOfPurchaseType.Maybe;
            rdoWouldBuy.Checked = Person.LikelihoodOfPurchase == TaggedPerson.LikelihoodOfPurchaseType.Yes;
            rdoNotBuy.CheckedChanged += (sender, e) => LikelihoodOfPurchaseChanged(TaggedPerson.LikelihoodOfPurchaseType.No, rdoNotBuy.Checked);
            rdoMaybeBuy.CheckedChanged += (sender, e) => LikelihoodOfPurchaseChanged(TaggedPerson.LikelihoodOfPurchaseType.Maybe, rdoMaybeBuy.Checked);
            rdoWouldBuy.CheckedChanged += (sender, e) => LikelihoodOfPurchaseChanged(TaggedPerson.LikelihoodOfPurchaseType.Yes, rdoWouldBuy.Checked);
        }

        private void LikelihoodOfPurchaseChanged(TaggedPerson.LikelihoodOfPurchaseType type, bool newValue)
        {
            if (newValue)
            {
                switch (type)
                {
                    case TaggedPerson.LikelihoodOfPurchaseType.Yes:
                        Person.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.Yes;
                        break;
                    case TaggedPerson.LikelihoodOfPurchaseType.Maybe:
                        Person.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.Maybe;
                        break;
                    case TaggedPerson.LikelihoodOfPurchaseType.No:
                        Person.LikelihoodOfPurchase = TaggedPerson.LikelihoodOfPurchaseType.No;
                        break;
                }
            }
        }
    }
}
