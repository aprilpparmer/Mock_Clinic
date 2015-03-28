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

        public NWNewVisit()
        {
            InitializeComponent();
        }

        private void NWNewVisit_Load(object sender, EventArgs e)
        {
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

        /// <summary>
        /// Closes the Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                patientVisit = new PatientVisit();
                this.PutPatientVisitData(patientVisit);
                try
                {
                    NorthwindController.AddPatientVisit(patientVisit);
                    saveButton.Visible = false;
                    editButton.Visible = true;
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

        private void PutPatientVisitData(PatientVisit patientVisit)
        {
            patientVisit.PatientId = int.Parse(patientIDLabel.Text);
            patientVisit.VisitDate = visitDateBox.Value;
            patientVisit.ApptDate = appointmentDateBox.Value;
            patientVisit.DoctorId = (int)doctorsComboBox.SelectedValue;
            patientVisit.NurseId = NwLogin.employeeUser.EmployeeId;
        }

        private void visitDateBox_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void appointmentDateBox_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void doctorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checks if any fields are left blank
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (Validator.IsPresent(patientIDLabel) &&
                Validator.IsPresent(visitDateBox) &&
                Validator.IsPresent(doctorsComboBox)) {
                return true;
            }
            else
                return false;
        }

    }
}
