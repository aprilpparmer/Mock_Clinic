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
    public partial class NWViewTests : Form
    {
        
        NorthwindController _controller;
        
        public NWViewTests()
        {
            InitializeComponent();
            _controller = new NorthwindController();
        }

        private static NWViewTests _NWViewTestsForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NWViewTests GetChildInstance()
        {
            if (_NWViewTestsForm == null) //if not created yet, Create an instance
                _NWViewTestsForm = new NWViewTests();
            else
            {
                _NWViewTestsForm.Dispose();
                _NWViewTestsForm = new NWViewTests();

            }
            return _NWViewTestsForm;  //just created or created earlier.Return it
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            NWNewTest NWNewTestForm = NWNewTest.GetChildInstance();
            NWNewTestForm.MdiParent = MdiParent;
            NWNewTestForm.Show();
            NWNewTestForm.BringToFront();
        }

        private void loadTests(object sender, EventArgs e)
        {
            loadTestData();
        }

        private void loadTestData()
        {

            List<Test> testList;
            listViewTests.Items.Clear();
            try
            {
                testList = _controller.GetAllTests();
                if (testList.Count > 0)
                {
                    Test test;
                    for (int i = 0; i < testList.Count; i++)
                    {
                        test = testList[i];
                        listViewTests.Items.Add(test.TestId.ToString());
                        listViewTests.Items[i].SubItems.Add(test.TestName);
                    }
                }
            }
            catch
            {
                MessageBox.Show(@"There are no tests at this time!");
            }

        }

        private void buttonDeleteTest_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewTests.SelectedItems[0];
                int testId = int.Parse(item.SubItems[0].Text); 
                string testName = item.SubItems[1].Text;
                DialogResult confirmDeleteReturn = MessageBox.Show(@"To avoid errors, please delete only tests that are not referenced." +
                    Environment.NewLine + Environment.NewLine + " Are you sure you want to Delete: " + testName, @"Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmDeleteReturn == DialogResult.Yes)
                {
                    int deleteSuccess = _controller.DeleteTest(testId);
                    if (deleteSuccess == 1)
                    {
                        MessageBox.Show(testName + @" was deleted from database!");
                    }
                    else
                    {
                        MessageBox.Show(testName + @" was not deleted from database!");
                    }
                    loadTestData();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(@"There was a problem deleting the test. " 
                    + Environment.NewLine + Environment.NewLine + "Please check if: " 
                    + Environment.NewLine + "  - you highlighted in blue the test ID that you want to delete!"
                    + Environment.NewLine + "  - the test that you want to delete is not referenced in another table "); 
                    
            }
        }

        private void buttonUpdateTest_Click(object sender, EventArgs e)
        {
            NwUpdateTest NWUpdateTestForm = NwUpdateTest.GetChildInstance();
            NWUpdateTestForm.MdiParent = MdiParent;
            NWUpdateTestForm.Show();
            NWUpdateTestForm.BringToFront();
        }

    }
}
