using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NWViewEmployee : Form
    {
        NorthwindController _controller;
        private int employeeId;
        private Employee employee;
        public NWViewEmployee(int theEmployeeId)
        {
            InitializeComponent();  
            _controller = new NorthwindController();
            try
            {
                this.employeeId = theEmployeeId;
                employee = _controller.GetEmployeeByID(theEmployeeId);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"There was a problem loading this patient, please try again.");
                this.Close();
            }
        }

        private static NWViewEmployee _NwViewPEmployeeform;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>View Employee Instance</returns>
        public static NWViewEmployee GetChildInstance(int employeeId)
        {
            if (_NwViewPEmployeeform == null) //if not created yet, Create an instance
                _NwViewPEmployeeform = new NWViewEmployee(employeeId);
            else
            {
                _NwViewPEmployeeform.Dispose();
                _NwViewPEmployeeform = new NWViewEmployee(employeeId);

            }
            return _NwViewPEmployeeform;  //just created or created earlier.Return it
        }

        private static NWUpdateAccount _updateEmployeeForm;

        public static NWUpdateAccount GetChildInstanceAccount(int employeeId)
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
        
        private void NWViewEmployee_Load(object sender, EventArgs e)
        {
            loadEmployeeData();
        }

        private void activatedFom(object sender, EventArgs e)
        {
            loadEmployeeData();
        }

        private void loadEmployeeData()
        {
            this.Text = String.Concat("Viewing Employee - ", employee.FirstName.Trim(), " ", employee.LastName.Trim());
            firstNameTextBox.Text = employee.FirstName.Trim();
            middleInitialTextBox.Text = employee.MiddleInitial.Trim();
            lastNameTextBox.Text = employee.LastName.Trim();
            genderTextBox.Text = employee.Gender.Trim();
            ssnTextBox.Text = employee.Ssn.ToString().Trim();
            zipTextBox.Text = employee.Zip.ToString().Trim();
            phoneTextBox.Text = employee.Phone.Trim();
            dateTextBox.Text = employee.Dob.ToShortDateString().Trim();
            addressTextBox.Text = employee.Address.Trim();
            cityTextBox.Text = employee.City.Trim();
            stateTextBox.Text = employee.State.Trim();
        }

    }
}
