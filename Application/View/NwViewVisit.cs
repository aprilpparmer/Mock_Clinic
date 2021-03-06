﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwViewVisit : Form
    {
        private int visitID;
        private NorthwindController _controller;
        private PatientVisitSymptoms symptoms = new PatientVisitSymptoms();
        private int patientID;
        public NwViewVisit(int _visitID, int _patientID)
        {
            _controller = new NorthwindController();
            InitializeComponent();
            this.visitID = _visitID;
            this.patientID = _patientID;
            
        }

        private void getTestData(object sender, EventArgs e)
        {
            try
            {
                //Get the visitID
                //Fill the data
                this.patient_visitTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit, this.visitID);
                this.patient_visit_vitalsTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit_vitals,
                    this.visitID);
                // Get symtpom / daigs
                

                try
                {
                    this.symptoms = _controller.GetAllPatientSymtomsByVisitId(this.visitID);
                    symptomtextBox.Text = this.symptoms.SymptomName;
                    if (this.symptoms.DiagnosesID != null)
                    {
                        Diagnoses diag = _controller.GetDiagnoses(this.symptoms.DiagnosesID);
                        diagtextBox.Text = diag.Name;
                        treatmenttextBox.Text = diag.Treatment;

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Something went wrong" + exception);
                }

                //this.patient_visit_symptomsTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit_symptoms,this.visitID);
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
            NwOrderTest NWOrderTestForm = NwOrderTest.GetChildInstance(this.visitID, this.patientID);
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
                DataGridViewCell cell = row.Cells[1];
                int patientTestID = (int) cell.Value;

                PatientTests test = new PatientTests();
                test = _controller.GetPatientTest(patientTestID);

                //Display the visit info form

                NwUpdatePatientTest testForm = new NwUpdatePatientTest(test);
                testForm.ShowDialog();
            }


            if (e.ColumnIndex == 8) //Delete patient test button is clicked
            {
                //Get the ID of the selected test
                int i = e.RowIndex;
                DataGridViewRow row = patient_testsDataGridView.Rows[i];
                DataGridViewCell cell = row.Cells[1];
                int patientTestID = (int)cell.Value;

                DialogResult confirmDeleteReturn = MessageBox.Show(@" Are you sure you want to delete " 
                    + row.Cells[2].Value.ToString().Trim() + @" test ordered on " + row.Cells[3].Value + @" ?", @"Confirm Delete", MessageBoxButtons.YesNo);
                String completed = this.patient_testsDataGridView[5, i].Value.ToString();
                if (completed == "") {
               
                    if (confirmDeleteReturn == DialogResult.Yes)
                    {
                        int success = _controller.DeletePatientTest(patientTestID);

                        if (success == 1)
                        {
                            MessageBox.Show("Ordered test deleted succesfully!");
                        }
                        else
                        {
                            MessageBox.Show("Ordered test could not be deleted!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This test has been completed and may not be deleted.");
                }

            }

        }

        private void ButtonUpdateDiagnoses_Click(object sender, EventArgs e)
        {
            NwUpdateDiagnoses NWNewTestForm = NwUpdateDiagnoses.GetChildInstance(visitID, diagtextBox.Text, symptomtextBox.Text);
            NWNewTestForm.MdiParent = MdiParent;
            NWNewTestForm.Show();
            NWNewTestForm.BringToFront();
        }
    }
}