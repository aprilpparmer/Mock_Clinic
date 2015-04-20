using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwAddPatientAllergy : Form
    {
        private int patientID;
        private PatientAllergies allergies;
        public NwAddPatientAllergy(int patientID)
        {
            this.patientID = patientID;
            this.allergies = new PatientAllergies();
            InitializeComponent();
        }

        private void NwAddPatientAllergy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CS6232_g7DataSet2.allergies' table. You can move, or remove it, as needed.
            this.allergiesTableAdapter.Fill(this._CS6232_g7DataSet2.allergies);
            this.allergyComboBox.SelectedIndex = -1;

        }

        private void addAllergyButton_Click(object sender, EventArgs e)
        {
            if (this.allergyComboBox.SelectedIndex > -1)
            {
                this.PutPatientAllergyInfo(this.allergies);
                try
                {
                    if (NorthwindController.AddPatientAllergy(this.allergies) > 0)
                    {
                        MessageBox.Show("The allergy was successfully added.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. The allergy was not saved.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void PutPatientAllergyInfo(PatientAllergies _allergies)
        {
            _allergies.PatientId = patientID;
            _allergies.AllergyName = this.allergyComboBox.Text;
            _allergies.AllergyId = (int)this.allergyComboBox.SelectedValue;
        }
    }
}
