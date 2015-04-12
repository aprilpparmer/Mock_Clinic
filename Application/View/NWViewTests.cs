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
            buttonDeleteTest.Enabled = false;
            buttonUpdateTest.Enabled = false;

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

    }
}
