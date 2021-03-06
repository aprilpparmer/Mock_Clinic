﻿using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwLogin : Form
    {
        NorthwindController _controller = new NorthwindController();
        public static Employee employeeUser;

        public NwLogin()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Logs in the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            SimpleAES encrypt = new SimpleAES();
            String name = NameBox.Text;
            String password = PasswordBox.Text;
            password = encrypt.EncryptToString(password); 
            try
            {
                Employee employee = _controller.EmployeeLogIn(name, password);
               
                if (employee == null )
                {
                  MessageBox.Show(@"No valid user found, please try your user name and password again");
                }
                else if (employee.PositionId == 1 && employee.Enabled == 1)
                {
                    MessageBox.Show(@"Valid login. Welcome Nurse " + employee.FirstName + " " + employee.LastName);
                    employeeUser = employee;
                    NorthwindAdmin homeN = new NorthwindAdmin(employee);
                    homeN.Show();
                    this.Hide();
                }
                else if (employee.PositionId == 3 && employee.Enabled == 1)
                {
                    MessageBox.Show(@"Valid login. Welcome Admin " + employee.FirstName + " " + employee.LastName);
                    employeeUser = employee;
                    NorthwindAdmin homeA = new NorthwindAdmin(employee);
                    homeA.Show();
                    this.Hide();

                } 
                else if ((employee.PositionId == 3 || employee.PositionId == 1) & employee.Enabled == 0)
                { 
                    MessageBox.Show(@"Your account is currently disabled, please contact an admin.");

                }
                else
                {
                     MessageBox.Show(@"Only Nurses Or Administrators May login at this time.");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString() + "Something happened");
            }

        }

        /// <summary>
        /// Closes the log in program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NwLogin_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Makes sure the program closes when the form is closed with the x button
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Environment.Exit(0);
        }

        private void NwLogin_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
