using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponos
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
            // Resize to left
            Height = 900;
        }

        void CropPersonPhoto()
        {
            Image srcImg = MainWindow.Singleton.MainPictureBox.Image;
            // Crop image to bib
            Bitmap bmp = (Bitmap)srcImg;
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
            // Gender radio buttons
            rdoGenderMale.Checked = Person.Gender == TaggedPerson.GenderType.Male;
            rdoGenderFemale.Checked = Person.Gender == TaggedPerson.GenderType.Female;
            rdoGenderUnknown.Checked = Person.Gender == TaggedPerson.GenderType.Unknown;
            rdoGenderMale.CheckedChanged += (sender, e) => GenderChanged(TaggedPerson.GenderType.Male, rdoGenderMale.Checked);
            rdoGenderFemale.CheckedChanged += (sender, e) => GenderChanged(TaggedPerson.GenderType.Female, rdoGenderFemale.Checked);
            rdoGenderUnknown.CheckedChanged += (sender, e) => GenderChanged(TaggedPerson.GenderType.Unknown, rdoGenderUnknown.Checked);
        }

        void LikelihoodOfPurchaseChanged(TaggedPerson.LikelihoodOfPurchaseType type, bool newValue)
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

        void GenderChanged(TaggedPerson.GenderType type, bool newValue)
        {
            if (newValue)
            {
                switch (type)
                {
                    case TaggedPerson.GenderType.Male:
                        Person.Gender = TaggedPerson.GenderType.Male;
                        break;
                    case TaggedPerson.GenderType.Female:
                        Person.Gender = TaggedPerson.GenderType.Female;
                        break;
                    case TaggedPerson.GenderType.Unknown:
                        Person.Gender = TaggedPerson.GenderType.Unknown;
                        break;
                }
            }
        }
    }
}
