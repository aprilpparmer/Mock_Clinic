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
    public partial class NWViewPatient : Form
    {
        NorthwindController _controller;
        private int _patientId ;
        private Patient _thepatient;
        public NWViewPatient(int thePatientId)
        {
            InitializeComponent();
            this._patientId = thePatientId;
            _controller = new NorthwindController();
            try
            {
                _thepatient = _controller.GetPatientsById(thePatientId);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"There was a problem loading this patient, please try again.");
                this.Close();
            }
        }

        private static NWViewPatient _NwViewPatientform;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>ClosedTickets Instance</returns>
        public static NWViewPatient GetChildInstance(int patientId)
        {
            if (_NwViewPatientform == null) //if not created yet, Create an instance
                _NwViewPatientform = new NWViewPatient(patientId);
            else
            {
                _NwViewPatientform.Dispose();
                _NwViewPatientform = new NWViewPatient(patientId);

            }
            return _NwViewPatientform;  //just created or created earlier.Return it
        }

        private void NWViewPatient_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = _thepatient.FirstName.Trim();
            middleInitialTextBox.Text = _thepatient.MiddleInitial.Trim();
            lastNameTextBox.Text = _thepatient.LastName.Trim();
            genderTextBox.Text = _thepatient.Gender.Trim();
            ssnTextBox.Text = _thepatient.Ssn.ToString().Trim();
            zipTextBox.Text = _thepatient.Zip.ToString().Trim();
            homePhoneTextBox.Text = _thepatient.HomePhone.Trim();
            workPhoneTextBox.Text = _thepatient.WorkPhone.Trim();
            dateTextBox.Text = _thepatient.Dob.ToShortDateString().Trim();
            addressTextBox.Text = _thepatient.Address.Trim();
            cityTextBox.Text = _thepatient.City.Trim();
            stateTextBox.Text = _thepatient.State.Trim();
        }


       
    }
}
