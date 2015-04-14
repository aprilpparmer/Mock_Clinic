using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwUpdatePatientTest : Form
    {
        private PatientTests newPatientTests;
        private PatientTests oldPatientTests;
        

        
        public NwUpdatePatientTest(PatientTests patientTestParam)
        {
            InitializeComponent();
            this.oldPatientTests = patientTestParam;
        }


        private void testsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientVisitSummaryReport);

        }

        private void NwUpdatePatientTest_Load(object sender, EventArgs e)
        {

            this.patient_testsTableAdapter.Fill(this.patientVisitInfoDataSet.patient_tests, this.oldPatientTests.VisitId);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.newPatientTests = new PatientTests();
            this.PutTestData(this.newPatientTests);
            try
            {
                if (NorthwindController.UpdatePatientTest(this.oldPatientTests, this.newPatientTests))
                {
                    MessageBox.Show("The test has been updated.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong. The test data was not saved.");
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

        private void PutTestData(PatientTests patientTests)
        {
            //Check if date entered is a date
            string dateString = this.testTakenBox.Text;
	        DateTime dateTime;
	        if (DateTime.TryParse(dateString, out dateTime))
            {
                patientTests.TestTaken = dateTime;
            }
            else
            {
                patientTests.TestTaken = null;
            }

            //Check if date entered is a date
            dateString = this.testCompletedBox.Text;
            if (DateTime.TryParse(dateString, out dateTime))
            {
                patientTests.TestCompleted = dateTime;
            }
            else
            {
                patientTests.TestCompleted = null;
            }
            patientTests.Results = this.testResultsBox.Text;
            patientTests.PatientTestsId = this.oldPatientTests.PatientTestsId;
        }
    }
}
