﻿using System;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NWUpdateAccount : Form
    {
        NorthwindController _controller = new NorthwindController();
        public NWUpdateAccount(int EmployeeID)
        {
            InitializeComponent();
        }
       
            int roleID;
            int ssn, zip;
            string gender;
            Employee employee = new Employee();

        private void button1_Click(object sender, System.EventArgs e)
        {
                     

            if ((femaleRadioButton.Checked == false) & (maleRadioButton.Checked == false))
            {
                MessageBox.Show
        (
                            @"Please select gender.");
            }
            else
            {
                
                if ((femaleRadioButton.Checked == true))
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }

                if ((int.TryParse(ssnTextBox.Text, out ssn)) & (ssnTextBox.Text.Length == 9))
                {
                    if ((int.TryParse(zipTextBox.Text, out zip)) & (zipTextBox.Text.Length == 5))
                    {
                        if (PhoneTextBox.Text.Length >= 10)
                        {

                            if ((firstNameTextBox.Text != "") & (lastNameTextBox.Text != "") & (ssn != 0) & (zip != 0) &
                                (PhoneTextBox.Text != "") &
                                (addressTextBox.Text != "") & (cityTextBox.Text != "") & (StateComboBox.Text != ""))
                            {
                                //Check Details
                                employee.FirstName = firstNameTextBox.Text;
                                employee.MiddleInitial = middleInitialTextBox.Text;
                                employee.LastName = lastNameTextBox.Text;
                                employee.Gender = gender;
                                employee.Ssn = ssn;
                                employee.Zip = zip;
                                employee.PositionId = JobBox.SelectedIndex + 1;
                                employee.Phone = PhoneTextBox.Text;
                                employee.Dob = dateTimePicker.Value.Date;
                                employee.Address = addressTextBox.Text;
                                employee.City = cityTextBox.Text;
                                employee.State = StateComboBox.Text;
                                try
                                {
                                    _controller.AddEmployee(employee);
                                    MessageBox.Show(@"The employee has been added.");
                                    this.Close();

                                }
                                catch (Exception exception)
                                {
                                    MessageBox.Show(
                                        @"There was a problem adding the Employee into the Database, please contact the admin with this message." +
                                        exception);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    @"Phone number needs to be numbers only, remove any non digit characters like -'s or ()'s.");
                            }

                        }
                        else
                        {
                            MessageBox.Show(
                                @"Please check all the required fields and make sure you entered the proper information.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            @"Please enter Zip as a number and that you have entered the right amount of numbers. Please check.");
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"Please enter Social as a number with no dashes, or you may not have entered the right amount of numbers. Please check.");
                }
            }
        }
         

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void maleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            femaleRadioButton.Checked = false;
            maleRadioButton.Checked = true;
        }

        private void femaleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            maleRadioButton.Checked = false;

        }


        private void NWUpdateAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CS6232_g7DataSet.positions' table. You can move, or remove it, as needed.
            this.positionsTableAdapter.Fill(this._CS6232_g7DataSet.positions);
            loadEmployeeData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            roleID = Int32.Parse(JobBox.ValueMember);

            if ((femaleRadioButton.Checked == false) & (maleRadioButton.Checked == false))
            {
                MessageBox.Show
        (
                            @"Please select gender.");
            }
            else
            {

                if ((femaleRadioButton.Checked == true))
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }
  
                if ((int.TryParse(ssnTextBox.Text, out ssn)) & (ssnTextBox.Text.Length == 9))
                {
                    if ((int.TryParse(zipTextBox.Text, out zip)) & (zipTextBox.Text.Length == 5))
                    {
                        if(PhoneTextBox.Text.Length >= 10)
                        {

                            if ((firstNameTextBox.Text != "") & (lastNameTextBox.Text != "") & (ssn != 0) & (zip != 0) &
                                (PhoneTextBox.Text != "") &
                                (addressTextBox.Text != "") & (cityTextBox.Text != "") & (StateComboBox.Text != ""))
                            {
                              

                                //Check Details
                                employee.FirstName = firstNameTextBox.Text;
                                employee.MiddleInitial = middleInitialTextBox.Text;
                                employee.LastName = lastNameTextBox.Text;
                                employee.Gender = gender;
                                employee.Ssn = ssn;
                                employee.Zip = zip;
                                employee.PositionId = roleID;
                                employee.Phone = PhoneTextBox.Text;
                                employee.Dob = dateTimePicker.Value.Date;
                                employee.Address = addressTextBox.Text;
                                employee.City = cityTextBox.Text;
                                employee.State = StateComboBox.Text;
                                try
                                {
                                    _controller.UpdateEmployee(employee);
                                    MessageBox.Show(@"The employee has been added.");
                                    this.Close();

                                }
                                catch (Exception exception)
                                {
                                    MessageBox.Show(
                                        @"There was a problem adding the Employee into the Database, please contact the admin with this message." +
                                        exception);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    @"Phone number needs to be numbers only, remove any non digit characters like -'s or ()'s.");
                            }

                        }
                        else
                        {
                            MessageBox.Show(
                                @"Please check all the required fields and make sure you entered the proper information.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            @"Please enter Zip as a number and that you have entered the right amount of numbers. Please check.");
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"Please enter Social as a number with no dashes, or you may not have entered the right amount of numbers. Please check.");
                }
            }
        }

        private void loadEmployeeData()
        {
            this.Text = String.Concat("Viewing Employee - ", employee.FirstName.Trim(), " ", employee.LastName.Trim());
            firstNameTextBox.Text = employee.FirstName.Trim();
            middleInitialTextBox.Text = employee.MiddleInitial.Trim();
            lastNameTextBox.Text = employee.LastName.Trim();
            ssnTextBox.Text = employee.Ssn.ToString().Trim();
            zipTextBox.Text = employee.Zip.ToString().Trim();
            PhoneTextBox.Text = employee.Phone.Trim();
            dateTimePicker.Text = employee.Dob.ToShortDateString().Trim();
            addressTextBox.Text = employee.Address.Trim();
            cityTextBox.Text = employee.City.Trim();
            StateComboBox.Text = employee.State.Trim();
        }

      

        }
    }
