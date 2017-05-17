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
    public partial class TaggingToolbox : Form
    {
        PhotoManager Model = PhotoManager.SharedManager;

        public TaggingToolbox()
        {
            InitializeComponent();
            BindEvents();
            BindDataToControls();
            PopulateStepList();
        }

        void BindDataToControls()
        {
            imgPhoto.DataBindings.Add("ImageLocation", Model, "CurrentPhoto.Filename", false, DataSourceUpdateMode.OnPropertyChanged);
            lblFilename.DataBindings.Add("Text", Model, "CurrentPhoto.Identifier", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        void PopulateStepList()
        {
            List<string> resultingList = new List<string>();
            Array stepArray = Enum.GetValues(typeof(StepType));
            for (int i = 0; i < stepArray.Length; i++)
            {
                StepType step = (StepType)stepArray.GetValue(i);
                string stepLabel = $"[Step {i+1}] {step.ToActionLabel()}";
                resultingList.Add(stepLabel);
            }
            lstSteps.DataSource = resultingList;
            lstSteps.DataBindings.Add("SelectedIndex", Model, "CurrentPhoto.TaggingStep", false, DataSourceUpdateMode.OnPropertyChanged);
            lstSteps.SelectedIndexChanged += (sender, e) => Model.CurrentPhoto.TaggingStep = (StepType)lstSteps.SelectedIndex;
        }

        void BindEvents()
        {
            // Prevent form from closing
            FormClosing += (sender, e) => e.Cancel = true;
        }
    }
}
