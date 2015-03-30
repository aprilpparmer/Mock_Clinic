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
            _thepatient = _controller.GetPatientsById(thePatientId);
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
            firstNameTextBox.Text = _thepatient.FirstName;
            middleInitialTextBox.Text = _thepatient.MiddleInitial;
            lastNameTextBox.Text = _thepatient.LastName;
            genderTextBox.Text = _thepatient.Gender;
            ssnTextBox.Text = _thepatient.Ssn.ToString();
            zipTextBox.Text = _thepatient.Zip.ToString();
            homePhoneTextBox.Text = _thepatient.HomePhone;
            workPhoneTextBox.Text = _thepatient.WorkPhone;
            dateTextBox.Text = _thepatient.Dob.ToShortDateString();
            addressTextBox.Text = _thepatient.Address;
            cityTextBox.Text = _thepatient.City;
            stateTextBox.Text = _thepatient.State;
        }


       
    }
}
