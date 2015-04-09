using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwDocSearch : Form
    {
        NorthwindController _controller = new NorthwindController();

        public NwDocSearch()
        {
            InitializeComponent();
            _controller = new NorthwindController();
        }


        private void NwDocSearch_Load(object sender, System.EventArgs e)
        {
            listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewEmployee.Enabled = false;
            viewEmployeeButton.Enabled = false;
            updateEmployeeButton.Enabled = false;
            addEmployeeButton.Enabled = false;
            buttonClear.Enabled = false;
            DeleteButton.Enabled = false;

        }

        private void buttonSearch_Click(object sender, System.EventArgs e)
        {
            load_Employees();
        }

        private void load_Employees()
        {
            List<Employee> employeeList;
            listViewEmployee.Items.Clear();

            try
            {
                {

                    employeeList = _controller.SearchEmployees(textBoxLastName.Text, textBoxFirstName.Text);

                    if (employeeList.Count > 0)
                    {
                        listViewEmployee.Enabled = true;
                        viewEmployeeButton.Enabled = true;
                        updateEmployeeButton.Enabled = true;
                        addEmployeeButton.Enabled = true;
                        buttonClear.Enabled = true;
                        DeleteButton.Enabled = true;

                        Employee employee;
                        for (int i = 0; i < employeeList.Count; i++)
                        {
                           
                            employee = employeeList[i];
                            listViewEmployee.Items.Add(employee.EmployeeId.ToString());
                            listViewEmployee.Items[i].SubItems.Add(employee.LastName.Trim());
                            listViewEmployee.Items[i].SubItems.Add(employee.FirstName.Trim());
                            listViewEmployee.Items[i].SubItems.Add(this.getEmployeeRole(employee.PositionId));


                            listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                            listViewEmployee.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


                        }
                        listViewEmployee.Items[0].Checked = true;
                        listViewEmployee.Items[0].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("There are no patients with this information registered at this time. Please check your search criteria and try again");
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void buttonCloseSearch_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            listViewEmployee.Items.Clear();
            listViewEmployee.Enabled = false;
            viewEmployeeButton.Enabled = false;
            updateEmployeeButton.Enabled = false;
            addEmployeeButton.Enabled = false;
            buttonClear.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {

            try
            {
                ListViewItem item = listViewEmployee.SelectedItems[0];
                int employeeId = int.Parse(item.SubItems[0].Text);
                NWViewEmployee NwNWViewEmployeeForm = NWViewEmployee.GetChildInstance(employeeId);
                NwNWViewEmployeeForm.MdiParent = MdiParent;
                NwNWViewEmployeeForm.Show();
                NwNWViewEmployeeForm.BringToFront();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Invalid Selection, Please make sure the patient Id is highlighted Blue.");
            }
        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewEmployee.SelectedItems[0];
                int employeeId = int.Parse(item.SubItems[0].Text);
                NWUpdateAccount NwNWViewEmployeeForm = NWUpdateAccount.GetChildInstance(employeeId);
                NwNWViewEmployeeForm.MdiParent = MdiParent;
                NwNWViewEmployeeForm.Show();
                NwNWViewEmployeeForm.BringToFront();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Invalid Selection, Please make sure the patient Id is highlighted Blue.");
            }

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            int employeeId = 0;
            NWUpdateAccount NwNWViewEmployeeForm = NWUpdateAccount.GetChildInstance(employeeId);
            NwNWViewEmployeeForm.MdiParent = MdiParent;
            NwNWViewEmployeeForm.Show();
            NwNWViewEmployeeForm.BringToFront();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            ListViewItem item = listViewEmployee.SelectedItems[0];
            int employeeId = int.Parse(item.SubItems[0].Text);
            Employee deleteEmployee = _controller.GetEmployeeByID(employeeId);
            NWViewEmployee NwNWViewEmployeeForm = NWViewEmployee.GetChildInstance(employeeId);
            NwNWViewEmployeeForm.MdiParent = MdiParent;
            NwNWViewEmployeeForm.Show();
            NwNWViewEmployeeForm.BringToFront();
            DialogResult dialogResult = MessageBox.Show(@"Are you sure you wish to delete this employee?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    _controller.DeleteEmployee(deleteEmployee);
                    NwNWViewEmployeeForm.Close();
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    listViewEmployee.Items.Clear();
                    listViewEmployee.Enabled = false;
                    viewEmployeeButton.Enabled = false;
                    updateEmployeeButton.Enabled = false;
                    addEmployeeButton.Enabled = false;
                    buttonClear.Enabled = false;
                    DeleteButton.Enabled = false;
                    MessageBox.Show(@"Employee Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An exception has occured with your request" + ex);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(@"Employee was not removed");
            }

        }

        private string getEmployeeRole(int positionID)
        {
            string role = "";
            if (positionID == 1)
            {
                role = "nurse";
            }
            if (positionID == 2)
            {
                role = "doctor";
            }
            if (positionID == 3)
            {
                role = "administrator";
            }
            if (positionID == 4)
            {
                role = "physician";
            }
            if (positionID == 5)
            {
                role = "pharmacist";
            }
            if (positionID == 6)
            {
                role = "general manager";
            }
            if (positionID == 7)
            {
                role = "lab technician";
            }
            if (positionID == 8)
            {
                role = "driver";
            }                   
            return role;
        }
    }
}
