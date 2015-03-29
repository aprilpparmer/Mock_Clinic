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
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Patient> patientList;
            listViewPatients.Items.Clear();

            try
            {
                if (textBoxFirstName.Text == "")
                {
                    MessageBox.Show("First Name is required! Please supply this information!");
                }
                else
                {
                    if (textBoxLastName.Text == "")
                    {
                        MessageBox.Show("Last Name is required! Please supply this information!");
                    }
                    else
                    {

                        patientList = this._controller.GetPatientsByFirstNameAndLastName(textBoxFirstName.Text, textBoxLastName.Text);

                        if (patientList.Count > 0)
                        {
                            listViewPatients.Enabled = true;
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
                        }
                        else
                        {
                            MessageBox.Show("There are no patients with this name registered at this time!");
                            textBoxFirstName.Text = "";
                            textBoxLastName.Text = "";
                        }
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
            listViewPatients.Items.Clear();
            listViewPatients.Enabled = false;
        }

    }
}
