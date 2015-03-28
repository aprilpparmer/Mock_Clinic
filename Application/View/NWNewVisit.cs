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
    public partial class NWNewVisit : Form
    {
        private PatientVisit patientVisit;
        private PatientVisitVitals vitals;
        private PatientVisitSymptoms symptoms;
        private PatientVisitNotes note;

        public NWNewVisit()
        {
            InitializeComponent();
        }

        private void NWNewVisit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosesDataSet.diagnoses' table. You can move, or remove it, as needed.
            this.diagnosesTableAdapter.Fill(this.diagnosesDataSet.diagnoses);
            // TODO: This line of code loads data into the 'employeesDataSet1.doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.FillDoctors(this.employeesDataSet1.doctors);
            this.doctorsComboBox.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'patientsDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.patientsDataSet.patients);

        }

        private void fillPatientInfoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientsTableAdapter.FillPatientInfo(this.patientsDataSet.patients, ((int)(System.Convert.ChangeType(patientIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            patientVisit = new PatientVisit();
            this.PutPatientVisitData(patientVisit);
            try
            {
                patientVisit.VisitId = NorthwindController.AddPatientVisit(patientVisit);
                saveButton.Visible = false;
                editButton.Visible = true;
                editButton.Enabled = false;
                saveButton2.Enabled = true;
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
        //Saves the visit data
        private void PutPatientVisitData(PatientVisit patientVisit)
        {
            patientVisit.PatientId = int.Parse(patientIDLabel.Text);
            patientVisit.VisitDate = visitDateBox.Value;
            patientVisit.ApptDate = appointmentDateBox.Value;
            patientVisit.DoctorId = (int)doctorsComboBox.SelectedValue;
            patientVisit.NurseId = NwLogin.employeeUser.EmployeeId;
        }

        private void visitDateBox_ValueChanged(object sender, EventArgs e){editButton.Enabled = true;}
        private void appointmentDateBox_ValueChanged(object sender, EventArgs e){editButton.Enabled = true;}
        private void doctorsComboBox_SelectedIndexChanged(object sender, EventArgs e){editButton.Enabled = true;}

        private void editButton_Click(object sender, EventArgs e)
        {

        }
        //Visit Info Cancel Button - closes form
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        //Vitals Cancel Button - closes form
        private void cancelButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        //Symptoms Cancel Button - closes form
        private void cancelButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        //Diagnoses Cancel Button - closes form
        private void cancelButton4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        //Saves the vitals data to the database
        private void saveButton2_Click(object sender, EventArgs e)
        {
            vitals = new PatientVisitVitals();
            this.PutPatientVisitVitalsData(vitals);
            try
            {
                NorthwindController.AddPatientVisitVitals(vitals);
                saveButton2.Visible = false;
                editButton2.Visible = true;
                editButton2.Enabled = false;
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
        //Saves the vitals data
        private void PutPatientVisitVitalsData(PatientVisitVitals vitals)
        {
            vitals.VisitId = patientVisit.VisitId;
            vitals.BloodPressure = txtBoxBloodPressure.Text;
            vitals.Temp = txtBoxTemperature.Text;
            vitals.Pulse = txtBoxPulse.Text;
            vitals.Height = int.Parse(txtBoxHeight.Text);
            vitals.Weight = int.Parse(txtBoxWeight.Text);
        }
        //Saves the symptoms data, and notes data (if present)
        private void saveButton3_Click(object sender, EventArgs e)
        {
            symptoms = new PatientVisitSymptoms();
            note = new PatientVisitNotes();
            this.PutPatientVisitSymptomsData(symptoms, note);
            try
            {
                NorthwindController.AddPatientVisitSymptoms(symptoms);
                if (note.Note != null)
                {
                    NorthwindController.AddPatientVisitNotes(note);
                }
                saveButton3.Visible = false;
                editButton3.Visible = true;
                editButton3.Enabled = false;
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
        //Saves the symptoms/notes data
        private void PutPatientVisitSymptomsData(PatientVisitSymptoms symptoms, PatientVisitNotes note)
        {
            symptoms.VisitId = patientVisit.VisitId;
            symptoms.SymptomName = txtBoxSymptoms.Text;
            note.Note = txtBoxNotes.Text;
            note.EmployeeId = NwLogin.employeeUser.EmployeeId;
            note.VisitId = patientVisit.VisitId;
        }
    }
}
