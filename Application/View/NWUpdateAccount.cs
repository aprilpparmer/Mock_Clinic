using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NWUpdateAccount : Form
    {
        NorthwindController _controller = new NorthwindController();
        private int employeeId;
        int roleID;
        int ssn, zip;
        string gender;
        Employee employee = new Employee();
       
        public NWUpdateAccount(int theEmployeeID)
        {
            InitializeComponent();
            try
            {
                this.employeeId = theEmployeeID;
                if (employeeId != 0)
                {
                    employee = _controller.GetEmployeeByID(theEmployeeID);
                    int positionID = employee.PositionId;
                    UpdateButton.Enabled = true;
                }

                UpdateButton.Enabled = false;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"There was a problem loading this patient, please try again.");
                this.Close();
            }
        }
        
        private void NWUpdateAccount_Load(object sender, EventArgs e)
        {                                
            this.positionsTableAdapter.Fill(this._CS6232_g7DataSet.positions);
            if (employeeId != 0)
            {
                loadEmployeeData();
            }
        }
     
        private void activatedFom(object sender, EventArgs e)
        {
            loadEmployeeData();
           
        }
                  

        private void AddNewEmployee_Click(object sender, System.EventArgs e)
        {

            Employee tmpemployee = CreateEmployee();
            if (tmpemployee != null)
            {
                try
                {
                    _controller.AddEmployee(CreateEmployee());
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


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Employee tmpemployee = CreateEmployee();
            if (tmpemployee != null)
            {
                try
                {
                    _controller.UpdateEmployee(CreateEmployee());
                    MessageBox.Show(@"The employee has been updated.");
                    this.Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        @"There was a problem updating the Employee into the Database, please contact the admin with this message." +
                        exception);
                }
            }

        }

        private Employee CreateEmployee()
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
                // This is going to check if anything needs to be fixed
                Boolean loginInfoSet = false;

                if ((loginTextBox.Text.Trim().Length > 0) & (passwordTextBox.Text.Trim().Length > 0))
                {
                    Boolean uniqueLogin = true;
                    if (employee.Login.Trim() != loginTextBox.Text.Trim())
                    {
                        uniqueLogin = _controller.VerifyUniqueLogin(loginTextBox.Text);
                    }
                    if (uniqueLogin)
                    {
                        loginInfoSet = true;
                    }
                    else
                    {
                        MessageBox.Show(@"That Login is already in use.");
                    }
                }

                else if (loginTextBox.Text.Length == 0)
                {
                    loginInfoSet = true;
                }

                if (loginInfoSet)
                {
                    if ((int.TryParse(ssnTextBox.Text, out ssn)) & (ssnTextBox.Text.Length == 9))
                    {
                        if ((int.TryParse(zipTextBox.Text, out zip)) & (zipTextBox.Text.Length == 5))
                        {
                            int phone;
                            if ((int.TryParse(PhoneTextBox.Text.Trim(), out phone)) & (PhoneTextBox.Text.Trim().Length >= 10))
                            {

                                if ((firstNameTextBox.Text != "") & (lastNameTextBox.Text != "") & (ssn != 0) & (zip != 0) &
                                    (addressTextBox.Text != "") & (cityTextBox.Text != "") & (StateComboBox.Text != ""))
                                {
                                    //Check Details
                                    employee.FirstName = firstNameTextBox.Text;
                                    employee.MiddleInitial = middleInitialTextBox.Text;
                                    employee.LastName = lastNameTextBox.Text;
                                    if (loginTextBox.Text != "")
                                    {
                                        employee.Login = loginTextBox.Text;
                                        SimpleAES encrypt = new SimpleAES();
                                        employee.Password = encrypt.EncryptToString(passwordTextBox.Text);
                                        if ((enabledCheckBox.Checked) & (loginTextBox.Text.Trim().Length > 0) & (passwordTextBox.Text.Trim().Length > 0))
                                        {
                                            employee.Enabled = 1;
                                        }
                                        else
                                        {
                                            employee.Enabled = 0;
                                        }
                                    }
                                    employee.Gender = gender;
                                    employee.Ssn = ssn;
                                    employee.Zip = zip;
                                    employee.PositionId = JobBox.SelectedIndex + 1;
                                    employee.Phone = phone.ToString();
                                    employee.Dob = dateTimePicker.Value.Date;
                                    employee.Address = addressTextBox.Text;
                                    employee.City = cityTextBox.Text;
                                    employee.State = StateComboBox.Text;

                                    return employee;
                                }
                                else
                                {
                                    MessageBox.Show(@"Please check all the required fields and make sure you entered the proper information.");

                                }

                            }
                            else
                            {
                                MessageBox.Show(
                                   @"Phone number needs to be numbers only, remove any non digit characters like -'s or ()'s and is at least 10 numbers.");
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
                else
                {
                    MessageBox.Show(@"You need to have a password when setting a login.");
                }
            }
            return null;
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

        private void loadEmployeeData()
        {
            this.Text = String.Concat("Viewing Employee - ", employee.FirstName.Trim(), " ", employee.LastName.Trim());
            firstNameTextBox.Text = employee.FirstName.Trim();
            middleInitialTextBox.Text = employee.MiddleInitial.Trim();
            lastNameTextBox.Text = employee.LastName.Trim();
            if ((employee.Gender == "F"))
            {

                femaleRadioButton.Checked = true;
            }
            else
            {
                maleRadioButton.Checked = true;
            }
            int position = employee.PositionId;
            ssnTextBox.Text = employee.Ssn.ToString().Trim();
            zipTextBox.Text = employee.Zip.ToString().Trim();
            PhoneTextBox.Text = employee.Phone.Trim();
            JobBox.SelectedIndex = employee.PositionId-1;
            dateTimePicker.Text = employee.Dob.ToShortDateString().Trim();
            addressTextBox.Text = employee.Address.Trim();
            cityTextBox.Text = employee.City.Trim();
            StateComboBox.Text = employee.State;
            loginTextBox.Text = employee.Login;
            if (employee.Enabled == 1)
            {
                enabledCheckBox.Checked = true;
            } 
            SimpleAES encrypt = new SimpleAES();
            if (employee.Password != null)
            {
                passwordTextBox.Text = encrypt.DecryptString(employee.Password.Trim());
            }
            AddNewButton.Enabled = false;
            UpdateButton.Enabled = true;
        }

        private static NWUpdateAccount _updateEmployeeForm;

        public static NWUpdateAccount GetChildInstance(int employeeId)
        {
            if (_updateEmployeeForm == null) //if not created yet, Create an instance
                _updateEmployeeForm = new NWUpdateAccount(employeeId);
            else
            {
                _updateEmployeeForm.Dispose();
                _updateEmployeeForm = new NWUpdateAccount(employeeId);

            }
            return _updateEmployeeForm;  //just created or created earlier.Return it
        }

        private void enableAccount(object sender, EventArgs e)
        {
            enabledCheckBox.Enabled = true;
        }       

        }
    }
