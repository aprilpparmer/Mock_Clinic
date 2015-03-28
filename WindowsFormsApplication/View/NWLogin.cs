using System;
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
            
            String name = NameBox.Text;
            String password = PasswordBox.Text;
            try
            {
                Employee employee = _controller.ValidNurseLogIn(name, password);
               
                if (employee == null )
                {
                  MessageBox.Show(@"No valid user found, please try your user name and password again");
                } else if (employee.PositionId == 1 && employee.Enabled == 1)
                {
                    MessageBox.Show(@"Valid login. Welcome " + employee.FirstName + " " + employee.LastName);
                    employeeUser = employee;
                    NorthwindAdmin home = new NorthwindAdmin(employee);
                    home.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show(@"Only Nurses May login at this time.");
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

        
    }
}
