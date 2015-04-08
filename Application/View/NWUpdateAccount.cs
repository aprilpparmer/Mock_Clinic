using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NWUpdateAccount : Form
    {
        NorthwindController _controller = new NorthwindController();
        public NWUpdateAccount()
        {
            InitializeComponent();
        }

        
        int roleID;

        private void button1_Click(object sender, System.EventArgs e)
        {
            int ssn, zip;
            int homePhone;
            string gender;
            Employee employee = new Employee();

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
                        if ((int.TryParse(homePhoneTextBox.Text, out homePhone)) & (homePhoneTextBox.Text.Length >= 10))
                        {

                            if ((firstNameTextBox.Text != "") & (lastNameTextBox.Text != "") & (ssn != 0) & (zip != 0) &
                                (homePhoneTextBox.Text != "") &
                                (addressTextBox.Text != "") & (cityTextBox.Text != "") & (stateTextBox.Text != ""))
                            {
                                //Check Details
                                employee.FirstName = firstNameTextBox.Text;
                                employee.MiddleInitial = middleInitialTextBox.Text;
                                employee.LastName = lastNameTextBox.Text;
                                employee.Gender = gender;
                                employee.Ssn = ssn;
                                employee.Zip = zip;
                                employee.PositionId = roleID;
                                employee.Phone = homePhoneTextBox.Text;
                                employee.Dob = dateTimePicker.Value.Date;
                                employee.Address = addressTextBox.Text;
                                employee.City = cityTextBox.Text;
                                employee.State = stateTextBox.Text;
                                try
                                {
                                    _controller.AddEmployee(employee);
                                    MessageBox.Show(@"The employee has been added.");
                                    this.Close();

                                }
                                catch (Exception exception)
                                {
                                    MessageBox.Show(
                                        @"There was a problem adding the Patient into the Database, please contact the admin with this message." +
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

        private void JobBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {           
            if(JobBox.Text == "Nurse") {
                roleID = 1;
            }
            if(JobBox.Text == "Doctor") {
                roleID = 2;
            }
            if(JobBox.Text == "Administrator") {
                roleID = 3;
            }
        }

      

        }
    }
