using System;
using System.Windows.Forms;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NorthwindAdmin : Form
    {
        NwLogin _loginScreen;

        public NorthwindAdmin()
        {
            
        }

        /// <summary>
        /// Creates the main form for the application, displays a welcome to the user, makes sure the necessary parts are enabled
        /// </summary>
        /// <param name="employee">the employee object passed by login screen</param>
        public NorthwindAdmin(Employee employee)
        {
            InitializeComponent();
            String username = employee.FirstName + " " + employee.LastName;
            UserLabel.Text = "Welcome " + username;
            NWmenuStrip.Enabled = true;
            UserLabel.Visible = true;
        }

        

        private void Northwind_Load(object sender, EventArgs e)
        {
            
            
        }
        /// <summary>
        /// hides the home form and reopens the login form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginScreen = new NwLogin();
            _loginScreen.Show();
        }

        /// <summary>
        /// Exits teh program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       
        /// <summary>
        /// Makes sure the program closes when the form closes
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Environment.Exit(0);
        }

        /// <summary>
        /// Opens the register patient form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterPatient_Click(object sender, EventArgs e)
        {
            NwNewPatient NwNewPatientViewForm = NwNewPatient.GetChildInstance();
            NwNewPatientViewForm.MdiParent = this;
            NwNewPatientViewForm.Show();
            NwNewPatientViewForm.BringToFront();
        }

       
    }
}
