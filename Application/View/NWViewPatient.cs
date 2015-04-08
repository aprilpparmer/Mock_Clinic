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
            
            _controller = new NorthwindController();
            try
            {
                this._patientId = thePatientId;
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
        /// <returns>View Patient Instance</returns>
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
            loadPatientDate();
            loadVisits();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                NwEditPatient NwNWEditPatientForm = NwEditPatient.GetChildInstance(_patientId);
                NwNWEditPatientForm.MdiParent = MdiParent;
                NwNWEditPatientForm.Show();
                NwNWEditPatientForm.BringToFront();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Problem editing this Patient.");
            }
        }

        private void activatedFom(object sender, EventArgs e)
        {
            loadPatientDate();
        }

        private void loadPatientDate()
        {
            this.Text = String.Concat("Viewing Patient - ", _thepatient.FirstName.Trim(), " ", _thepatient.LastName.Trim());
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

        private void loadVisits()
        {
            this.patient_visitTableAdapter.Fill(this.patientVisitDataSet.patient_visit, this._patientId);
        }

        private void newVisitButton_Click(object sender, EventArgs e)
        {
            try
            {
                NWNewVisit newVisit = new NWNewVisit(_patientId);
                newVisit.MdiParent = MdiParent;
                newVisit.Show();
                newVisit.BringToFront();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Invalid Selection, Please make sure the patient Id is highlighted Blue.");
            }
        }

        private void patient_visitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) //Show visit button is clicked
            {
                //Get the ID of the selected visit
                int i = e.RowIndex;
                DataGridViewRow row = patient_visitDataGridView.Rows[i];
                DataGridViewCell cell = row.Cells[0];
                int visitID = (int)cell.Value;

                //Display the visit info form
                NwViewVisit viewVisitForm = new NwViewVisit(visitID);
                viewVisitForm.ShowDialog();
            }
        }

    }
}
