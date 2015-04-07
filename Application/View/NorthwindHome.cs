﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NorthwindAdmin : Form
    {
        NwLogin _loginScreen;
        NWNewVisit newVisitForm;
        NwPatientSearch newPatientSearchForm;

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
            int id = employee.PositionId;          
            String username = employee.FirstName + " " + employee.LastName;
            UserLabel.Text = "Welcome " + username;
            if (id == 1) {
            NWNurseMenuStrip.Enabled = true;
            NWAdminMenuStrip.Enabled = false;
            NWAdminMenuStrip.Hide();
            }
            else if (id == 2)
            {
             NWAdminMenuStrip.Enabled = true;
             NWNurseMenuStrip.Enabled = false;
             NWNurseMenuStrip.Hide();
            }
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

        /// <summary>
        /// Sets the New Visit Form to closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void newVisitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            newVisitForm = null;
        }

        /// <summary>
        /// Loads the new Search Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (newPatientSearchForm == null)
                {
                    newPatientSearchForm = new NwPatientSearch();
                    newPatientSearchForm.MdiParent = this;
                    newPatientSearchForm.FormClosed +=newPatientSearchForm_FormClosed;
                    newPatientSearchForm.Show();
                }
                else
                    newPatientSearchForm.Activate();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        /// <summary>
        /// Sets the new Patient Search to closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void newPatientSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            newPatientSearchForm = null;
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NWNewDiag NWNewDiagForm = NWNewDiag.GetChildInstance();
            NWNewDiagForm.MdiParent = this;
            NWNewDiagForm.Show();
            NWNewDiagForm.BringToFront();

        }

        private void listDiagMenuItem_Click(object sender, EventArgs e)
        {
            nwListDiag NWListDiagForm = nwListDiag.GetChildInstance();
            NWListDiagForm.MdiParent = this;
            NWListDiagForm.Show();
            NWListDiagForm.BringToFront();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginScreen = new NwLogin();
            _loginScreen.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
