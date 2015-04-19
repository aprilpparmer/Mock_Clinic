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
    public partial class NWViewAllergies : Form
    {

        NorthwindController _controller;
        int allergyId;
        string allergyName;

        public NWViewAllergies()
        {
            InitializeComponent();
            _controller = new NorthwindController();
        }

        private static NWViewAllergies _NWViewAllergiesForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NWViewAllergies GetChildInstance()
        {
            if (_NWViewAllergiesForm == null) //if not created yet, Create an instance
                _NWViewAllergiesForm = new NWViewAllergies();
            else
            {
                _NWViewAllergiesForm.Dispose();
                _NWViewAllergiesForm = new NWViewAllergies();

            }
            return _NWViewAllergiesForm;  //just created or created earlier.Return it
        }

        private void loadAllergies(object sender, EventArgs e)
        {
            loadAllergyData();
        }

        private void loadAllergyData()
        {
            List<Allergy> allergyList;
            listViewAllergies.Items.Clear();
            try
            {
                allergyList = _controller.GetAllAllergies();
                if (allergyList.Count > 0)
                {
                    Allergy allergy;
                    for (int i = 0; i < allergyList.Count; i++)
                    {
                        allergy = allergyList[i];
                        listViewAllergies.Items.Add(allergy.AllergyID.ToString());
                        listViewAllergies.Items[i].SubItems.Add(allergy.AllergyName);
                        listViewAllergies.Items[i].SubItems.Add(allergy.Enabled.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show(@"There are no allergies at this time!");
            }
        }
    }
}
