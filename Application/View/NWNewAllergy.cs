using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NWNewAllergy : Form
    {

        NorthwindController _controller;

        public NWNewAllergy()
        {
            InitializeComponent();
            _controller = new NorthwindController();
        }

        private static NWNewAllergy _NWNewAllergyForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NWNewAllergy GetChildInstance()
        {
            if (_NWNewAllergyForm == null) //if not created yet, Create an instance
                _NWNewAllergyForm = new NWNewAllergy();
            else
            {
                _NWNewAllergyForm.Dispose();
                _NWNewAllergyForm = new NWNewAllergy();

            }
            return _NWNewAllergyForm;  //just created or created earlier.Return it
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddAllergy_Click(object sender, EventArgs e)
        {
            Allergy allergy = new Allergy();

            textBoxAllergyName.Text = textBoxAllergyName.Text.Trim();

            if ((textBoxAllergyName.Text.Length > 1))
            {
                allergy.AllergyName = textBoxAllergyName.Text;

                try
                {
                    _controller.AddAllergy(allergy);
                    MessageBox.Show(@"Allergy Added.");
                    Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"There was a problem adding the allergy." + exception);

                }
            }
            else
            {
                MessageBox.Show(@"Allergy Name is required field!. Please provide the information and try again!");

            }
        }

    }
}
