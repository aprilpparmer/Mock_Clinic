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


    }
}
