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
        private int patientID;
        private PatientVisit patientVisit;
        private PatientVisitVitals vitals;
        private PatientVisitSymptoms symptoms;
        //Variable for diagnoses to be added to symptoms
        private PatientVisitSymptoms dsymptoms;
        private PatientVisitNotes note;

        public NWNewVisit(int patientID)
        {
            InitializeComponent();
            this.patientID = patientID;
        }

        private void NWNewVisit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet1.doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.FillDoctors(this.employeesDataSet1.doctors);
            this.doctorsComboBox.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'diagnosesDataSet.diagnoses' table. You can move, or remove it, as needed.
            this.diagnosesTableAdapter.Fill(this.diagnosesDataSet.diagnoses);
            // TODO: This line of code loads data into the 'patientsDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.patientsDataSet.patients);
            this.patientsTableAdapter.FillPatientInfo(this.patientsDataSet.patients, this.patientID);
            this.saveButton.Enabled = true;
        }
        //Saves patient visit info to database
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsValidDataVisit())
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
                    saveButton3.Enabled = true;
                    saveButton5.Enabled = true;
                    
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
        //Saves the visit data
        private void PutPatientVisitData(PatientVisit patientVisit)
        {
            patientVisit.PatientId = int.Parse(patientIDLabel.Text);
            patientVisit.VisitDate = visitDateBox.Value;
            patientVisit.ApptDate = appointmentDateBox.Value;
            patientVisit.DoctorId = (int)doctorsComboBox.SelectedValue;
            patientVisit.NurseId = NwLogin.employeeUser.EmployeeId;
        }

        private void visitDateBox_ValueChanged(object sender, EventArgs e) { editButton.Enabled = true; }
        private void appointmentDateBox_ValueChanged(object sender, EventArgs e) { editButton.Enabled = true; }
        private void doctorsComboBox_SelectedIndexChanged(object sender, EventArgs e) { editButton.Enabled = true; }
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
            if (IsValidDataVitals())
            {
                vitals = new PatientVisitVitals();
                this.PutPatientVisitVitalsData(vitals);
                try
                {
                    vitals.VitalsId = NorthwindController.AddPatientVisitVitals(vitals);
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
            if (IsValidDataSymptoms())
            {
                symptoms = new PatientVisitSymptoms();
                note = new PatientVisitNotes();
                this.PutPatientVisitSymptomsData(symptoms, note);
                try
                {
                    symptoms.SymptomId = NorthwindController.AddPatientVisitSymptoms(symptoms);
                    if (note.Note != "")
                    {
                        note.NotesId = NorthwindController.AddPatientVisitNotes(note);
                    }
                    saveButton3.Visible = false;
                    editButton3.Visible = true;
                    editButton3.Enabled = false;
                    saveButton4.Enabled = true;
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
        //Saves the symptoms/notes data
        private void PutPatientVisitSymptomsData(PatientVisitSymptoms symptoms, PatientVisitNotes note)
        {
            symptoms.VisitId = patientVisit.VisitId;
            symptoms.SymptomName = txtBoxSymptoms.Text;
            note.Note = txtBoxNotes.Text;
            note.EmployeeId = NwLogin.employeeUser.EmployeeId;
            note.VisitId = patientVisit.VisitId;
        }
        //Saves info in the symptoms table for the diagnoses
        private void saveButton4_Click(object sender, EventArgs e)
        {
            if (IsValidDataDiagnoses())
            {
                dsymptoms = new PatientVisitSymptoms();
                note = new PatientVisitNotes();
                this.PutPatientVisitDiagnosesData(dsymptoms, note);
                try
                {
                    NorthwindController.UpdatePatientDiagnoses(dsymptoms);
                    if (note.Note != null)
                    {
                        note.NotesId = NorthwindController.AddPatientVisitNotes(note);
                    }
                    saveButton4.Visible = false;
                    editButton4.Visible = true;
                    editButton4.Enabled = false;
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
        //Saves the diagnoses for the symptoms/notes data
        private void PutPatientVisitDiagnosesData(PatientVisitSymptoms dsymptoms, PatientVisitNotes note)
        {
            dsymptoms.VisitId = patientVisit.VisitId;
            dsymptoms.SymptomId = symptoms.SymptomId;
            dsymptoms.DiagnosesID = (int)diagnosesComboBox.SelectedValue;
            note.Note = notesBox2.Text;
            note.EmployeeId = NwLogin.employeeUser.EmployeeId;
            note.VisitId = patientVisit.VisitId;
        }

        private void saveButton5_Click(object sender, EventArgs e)
        {
            if (IsValidDataNotes())
            {
                note = new PatientVisitNotes();
                this.PutPatientVisitNotesData(note);
                try
                {
                    note.NotesId = NorthwindController.AddPatientVisitNotes(note);
                    saveButton5.Visible = false;
                    editButton5.Visible = true;
                    editButton5.Enabled = false;
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
        //Saves the diagnoses for the symptoms/notes data
        private void PutPatientVisitNotesData(PatientVisitNotes note)
        {
            note.Note = notesBox3.Text;
            note.EmployeeId = NwLogin.employeeUser.EmployeeId;
            note.VisitId = patientVisit.VisitId;
        }

        //Updates the visit info
        private void editButton_Click(object sender, EventArgs e)
        {
            if (IsValidDataVisit())
            {
                PatientVisit updateVisit = new PatientVisit();
                this.PutPatientVisitData(updateVisit);
                updateVisit.VisitId = patientVisit.VisitId;
                try
                {
                    NorthwindController.UpdatePatientVisit(updateVisit);
                    editButton.Enabled = false;
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
        //
        private void editButton2_Click(object sender, EventArgs e)
        {
            if (IsValidDataVitals())
            {
                PatientVisitVitals updateVitals = new PatientVisitVitals();
                this.PutPatientVisitVitalsData(updateVitals);
                updateVitals.VitalsId = vitals.VitalsId;
                try
                {
                    NorthwindController.UpdatePatientVisitVitals(updateVitals);
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
        }

        private void editButton3_Click(object sender, EventArgs e)
        {
            if (IsValidDataSymptoms())
            {
                PatientVisitSymptoms updateSymptoms = new PatientVisitSymptoms();
                PatientVisitNotes updateNote = new PatientVisitNotes();
                this.PutPatientVisitSymptomsData(updateSymptoms, updateNote);
                updateSymptoms.SymptomId = symptoms.SymptomId;
                updateNote.NotesId = note.NotesId;
                try
                {
                    NorthwindController.UpdatePatientSymptoms(updateSymptoms);
                    if (updateNote.Note != note.Note)
                    {
                        NorthwindController.UpdatePatientNotes(updateNote);
                    }
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
        }

        private void editButton4_Click(object sender, EventArgs e)
        {
            if (IsValidDataDiagnoses())
            {
                PatientVisitSymptoms updateDiagnoses = new PatientVisitSymptoms();
                PatientVisitNotes updateNote = new PatientVisitNotes();
                this.PutPatientVisitDiagnosesData(updateDiagnoses, updateNote);
                updateNote.NotesId = note.NotesId;
                try
                {
                    NorthwindController.UpdatePatientDiagnoses(updateDiagnoses);
                    if (updateNote.Note != note.Note)
                    {
                        NorthwindController.UpdatePatientNotes(updateNote);
                    }
                    editButton4.Enabled = false;
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

        private void txtBoxPulse_TextChanged(object sender, EventArgs e) { editButton2.Enabled = true; }
        private void txtBoxBloodPressure_TextChanged(object sender, EventArgs e) { editButton2.Enabled = true; }
        private void txtBoxTemperature_TextChanged(object sender, EventArgs e) { editButton2.Enabled = true; }
        private void txtBoxHeight_TextChanged(object sender, EventArgs e) { editButton2.Enabled = true; }
        private void txtBoxWeight_TextChanged(object sender, EventArgs e) { editButton2.Enabled = true; }
        private void txtBoxSymptoms_TextChanged(object sender, EventArgs e) { editButton3.Enabled = true; }
        private void txtBoxNotes_TextChanged(object sender, EventArgs e) { editButton3.Enabled = true; }
        private void diagnosesComboBox_SelectedIndexChanged(object sender, EventArgs e) { editButton4.Enabled = true; }
        private void notesBox2_TextChanged(object sender, EventArgs e) { editButton4.Enabled = true; }

        //Checks for valid data on the visit info tab
        private bool IsValidDataVisit()
        {
            if (Validator.IsPresent(doctorsComboBox))
                return true;
            else
                return false;
        }
        //Checks for valid data on the vitals tab
        private bool IsValidDataVitals()
        {
            if (Validator.IsPresent(txtBoxPulse) &&
                Validator.IsPresent(txtBoxBloodPressure) &&
                Validator.IsPresent(txtBoxTemperature) &&
                Validator.IsPresent(txtBoxHeight) &&
                Validator.IsPresent(txtBoxWeight))
                return true;
            else
                return false;
        }

        //Checks for valid data on the symptoms tab
        private bool IsValidDataSymptoms()
        {
            if (Validator.IsPresent(txtBoxSymptoms))
                return true;
            else
                return false;
        }

        //Checks for valid data on the diagnoses tab
        private bool IsValidDataDiagnoses()
        {
            if (Validator.IsPresent(diagnosesComboBox))
                return true;
            else
                return false;
        }

        //Checks for valid data on the notes tab
        private bool IsValidDataNotes()
        {
            if (Validator.IsPresent(notesBox3))
                return true;
            else
                return false;
        }

        private void notesBox3_TextChanged(object sender, EventArgs e)
        {
            this.editButton5.Enabled = true;
        }

        private void editButton5_Click(object sender, EventArgs e)
        {
            if (IsValidDataNotes())
            {
                PatientVisitNotes updateNote = new PatientVisitNotes();
                this.PutPatientVisitNotesData(updateNote);
                updateNote.NotesId = note.NotesId;
                try
                {
                    NorthwindController.UpdatePatientNotes(updateNote);
                    editButton5.Enabled = false;
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

    }
}


