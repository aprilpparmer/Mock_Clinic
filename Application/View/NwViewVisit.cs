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
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwViewVisit : Form
    {
        private int visitID;

        public NwViewVisit(int _visitID)
        {
            try
            { 
                InitializeComponent();
                //Get the visitID
                this.visitID = _visitID;
                //Fill the data
                this.patient_visitTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit, this.visitID);
                this.patient_visit_vitalsTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit_vitals, this.visitID);
                this.patient_visit_symptomsTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit_symptoms, this.visitID);
                this.patient_testsTableAdapter.Fill(this.patientVisitInfoDataSet.patient_tests, this.visitID);
                this.patient_visit_notesTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit_notes, this.visitID);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("VisitID is not an integer.", "Property Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }   
        }

        private void buttonOrderTest_Click(object sender, EventArgs e)
        {
            NwOrderTest NWOrderTestForm = NwOrderTest.GetChildInstance(this.visitID);
            NWOrderTestForm.MdiParent = MdiParent;
            NWOrderTestForm.Show();
            NWOrderTestForm.BringToFront();
            
            
        }

        private void patient_testsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7) //Update patient test button is clicked
            {
                //Get the ID of the selected visit
                int i = e.RowIndex;
                DataGridViewRow row = patient_testsDataGridView.Rows[i];
                DataGridViewCell cell = row.Cells[0];
                int patientTestID = (int)cell.Value;
                cell = row.Cells[3];
                String dateString = cell.Value.ToString();
                DateTime? taken;
                DateTime? completed;
                DateTime dateTime;

                if (DateTime.TryParse(dateString, out dateTime))
                {
                    taken = dateTime;
                }
                else
                {
                    taken = null;
                }

                cell = row.Cells[4];
                dateString = cell.Value.ToString();
                if (DateTime.TryParse(dateString, out dateTime))
                {
                    completed = dateTime;
                }
                else
                {
                    completed = null;
                }

                cell = row.Cells[5];
                String results = cell.Value.ToString();

                PatientTests test = new PatientTests();
                test.PatientTestsId = patientTestID;
                test.TestCompleted = completed;
                test.TestTaken = taken;
                test.Results = results;
                test.VisitId = this.visitID;

                //Display the visit info form

                NwUpdatePatientTest testForm = new NwUpdatePatientTest(test);
                testForm.ShowDialog();
            }
        }
    }
}