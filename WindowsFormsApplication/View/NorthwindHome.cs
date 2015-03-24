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
            _loginScreen = new NwLogin();
            _loginScreen.Show();
        }

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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginScreen = new NwLogin();
            _loginScreen.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Environment.Exit(0);
        }
    }
}
