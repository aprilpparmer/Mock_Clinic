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
    public partial class NWNewTest : Form
    {
        NorthwindController _controller;

        public NWNewTest()
        {
            InitializeComponent();
            _controller = new NorthwindController();
        }

        private static NWNewTest _NWNewTestForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NWNewTest GetChildInstance()
        {
            if (_NWNewTestForm == null) //if not created yet, Create an instance
                _NWNewTestForm = new NWNewTest();
            else
            {
                _NWNewTestForm.Dispose();
                _NWNewTestForm = new NWNewTest();

            }
            return _NWNewTestForm;  //just created or created earlier.Return it
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            
            textBoxName.Text = textBoxName.Text.Trim();
        
            if ((textBoxName.Text.Length > 1))
            {
                test.TestName = textBoxName.Text;
                
                try
                {
                    _controller.AddTest(test);
                    MessageBox.Show(@"Test Added.");
                    Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"There was a problem adding the test." + exception);

                }
            }
            else
            {
                MessageBox.Show(@"Test Name is required field!. Please provide the information and try again!");
   
            }

        }


    }
}
