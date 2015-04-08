using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwPatientSearch : Form
    {
        NorthwindController _controller;

        public NwPatientSearch()
        {
            InitializeComponent();
            _controller = new NorthwindController();
        }


        private void NwPatientSearch_Load(object sender, System.EventArgs e)
        {
            listViewPatients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewPatients.Enabled = false;
            viewPatientButton.Enabled = false;
            editPatientButton.Enabled = false;
            viewVisitsButton.Enabled = false;
            addVisitButton.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            load_Patients();
        }

        private void load_Patients()
        {
            List<Patient> patientList;
            listViewPatients.Items.Clear();

            try
            {
                {

                    patientList = this._controller.GetPatientsByFirstNameAndLastName(textBoxLastName.Text, textBoxFirstName.Text, dateTimeDOB.Text);

                    if (patientList.Count > 0)
                    {
                        listViewPatients.Enabled = true;
                        viewPatientButton.Enabled = true;
                        editPatientButton.Enabled = true;
                        viewVisitsButton.Enabled = true;
                        addVisitButton.Enabled = true;
                        buttonClear.Enabled = true;

                        Patient patient;
                        for (int i = 0; i < patientList.Count; i++)
                        {
                            patient = patientList[i];
                            listViewPatients.Items.Add(patient.PatientId.ToString());
                            listViewPatients.Items[i].SubItems.Add(patient.Ssn.ToString());
                            listViewPatients.Items[i].SubItems.Add(patient.LastName.Trim());
                            listViewPatients.Items[i].SubItems.Add(patient.MiddleInitial);
                            listViewPatients.Items[i].SubItems.Add(patient.FirstName.Trim());
                            listViewPatients.Items[i].SubItems.Add(patient.Dob.ToString("MMM dd, yyyy"));
                            listViewPatients.Items[i].SubItems.Add(patient.Gender);
                            listViewPatients.Items[i].SubItems.Add(patient.Address.Trim());
                            listViewPatients.Items[i].SubItems.Add(patient.City.Trim());
                            listViewPatients.Items[i].SubItems.Add(patient.State.Trim());
                            listViewPatients.Items[i].SubItems.Add(patient.Zip.ToString());
                            listViewPatients.Items[i].SubItems.Add(patient.HomePhone.Trim());
                            listViewPatients.Items[i].SubItems.Add(patient.WorkPhone.Trim());
                            listViewPatients.Items[i].SubItems.Add(patient.Child.Trim());

                            listViewPatients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                            listViewPatients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                            if (patient.MotherId == -1)
                            {
                                listViewPatients.Items[i].SubItems.Add("");
                            }
                            else
                            {
                                listViewPatients.Items[i].SubItems.Add(patient.MotherId.ToString());
                            }


                            if (patient.FatherId == -1)
                            {
                                listViewPatients.Items[i].SubItems.Add("");
                            }
                            else
                            {
                                listViewPatients.Items[i].SubItems.Add(patient.FatherId.ToString());
                            }

                        }
                        listViewPatients.Items[0].Checked = true;
                        listViewPatients.Items[0].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("There are no patients with this information registered at this time. Please check your search criteria and try again");
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        dateTimeDOB.ResetText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }
        private void buttonCloseSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            dateTimeDOB.ResetText();
            listViewPatients.Items.Clear();
            listViewPatients.Enabled = false;
            viewPatientButton.Enabled = false;
            editPatientButton.Enabled = false;
            viewVisitsButton.Enabled = false;
            addVisitButton.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void viewPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewPatients.SelectedItems[0];
                int patientId = int.Parse(item.SubItems[0].Text);
                NWViewPatient NwNWViewPatientForm = NWViewPatient.GetChildInstance(patientId);
                NwNWViewPatientForm.MdiParent = MdiParent;
                NwNWViewPatientForm.Show();
                NwNWViewPatientForm.BringToFront();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Invalid Selection, Please make sure the patient Id is highlighted Blue.");
            }
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewPatients.SelectedItems[0];
                int patientId = int.Parse(item.SubItems[0].Text);
                NwEditPatient NwNWEditPatientForm = NwEditPatient.GetChildInstance(patientId);
                NwNWEditPatientForm.MdiParent = MdiParent;
                NwNWEditPatientForm.Show();
                NwNWEditPatientForm.BringToFront();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Invalid Selection, Please make sure the patient Id is highlighted Blue.");
            }
        }

        private void activatedForum(object sender, EventArgs e)
        {
            if (listViewPatients.Enabled)
            {
                load_Patients();
            }
                
        }

        private void addVisitButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewPatients.SelectedItems[0];
                int patientId = int.Parse(item.SubItems[0].Text);
                NWNewVisit newVisit = NWNewVisit.GetChildInstance(patientId);
                newVisit.MdiParent = MdiParent;
                newVisit.Show();
                newVisit.BringToFront();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Invalid Selection, Please make sure the patient Id is highlighted Blue.");
            }
        }

    }
}
