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
    public partial class NWNewAllergy : Form
    {

        NorthwindController _controller;

        public NWNewAllergy()
        {
            InitializeComponent();
            _controller = new NorthwindController();
        }

        private static NWNewAllergy _NWNewAllergyForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NWNewAllergy GetChildInstance()
        {
            if (_NWNewAllergyForm == null) //if not created yet, Create an instance
                _NWNewAllergyForm = new NWNewAllergy();
            else
            {
                _NWNewAllergyForm.Dispose();
                _NWNewAllergyForm = new NWNewAllergy();

            }
            return _NWNewAllergyForm;  //just created or created earlier.Return it
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
