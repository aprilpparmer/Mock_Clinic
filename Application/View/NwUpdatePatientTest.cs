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
            this.oldPatientTests = patientTestParam;
            InitializeComponent();
            
        }


        private void testsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientVisitSummaryReport);

        }

        private void NwUpdatePatientTest_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@"Trying to load" + this.oldPatientTests.PatientTestsId);
            Test tempTest = NorthwindController.GetTest(this.oldPatientTests.TestId);
            testTextBox.Text = tempTest.TestName;
            dateTimePickerOrdered.Value = this.oldPatientTests.TestOrdered.GetValueOrDefault();
            if (this.oldPatientTests.Results != null)
            {
                resultTextBox.Text = this.oldPatientTests.Results;
            }
            if (this.oldPatientTests.TestTaken != null)
            {
                takenCheckBox.Checked = true;
                dateTimePickerTaken.Value = this.oldPatientTests.TestTaken.GetValueOrDefault();
            }
            else
            {
                takenCheckBox.Checked = false;
            }
            if (this.oldPatientTests.TestCompleted != null)
            {
                completedCheckBox.Checked = true;
                dateTimePickerCompleted.Value = this.oldPatientTests.TestCompleted.GetValueOrDefault();
            }
            else
            {
                completedCheckBox.Checked = false;
            } 
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.newPatientTests = new PatientTests();
            
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


        private void setCompletedTrue(object sender, EventArgs e)
        {
            completedCheckBox.Checked = true;
        }

        private void setTakenTrue(object sender, EventArgs e)
        {
            takenCheckBox.Checked = true;
        }

        
    }
}
