using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HermesDataTagger
{
    public class KeyboardShortcutManager
    {
        private PhotoManager Model = PhotoManager.SharedManager;
        public static KeyboardShortcutManager SharedManager = new KeyboardShortcutManager();

        public void BindKeyboardShortcuts(Form form)
        {
            // Key Down Events
            form.KeyDown += HandlePhotoNavigationKeys;
            form.KeyDown += HandleStepKeys;
            form.KeyDown += HandleCrowded;
        }

        private void HandleCrowded(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                Model.CurrentPhoto.IsPhotoCrowded = !Model.CurrentPhoto.IsPhotoCrowded;
            }
        }

        private void HandleStepKeys(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                if (e.Shift)
                {
                    Model.CurrentPhoto.GoToPrevStep();
                }
                else
                {
                    Model.CurrentPhoto.GoToNextStep();
                }
            }
        }

        private void HandlePhotoNavigationKeys(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Oemcomma:
                    Model.GetPrevPhoto();
                    break;
                case Keys.OemPeriod:
                    Model.GetNextPhoto();
                    break;
            }
        }
    }
}
