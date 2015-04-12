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

    }
}
