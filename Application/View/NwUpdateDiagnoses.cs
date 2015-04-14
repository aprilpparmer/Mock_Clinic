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
    public partial class NwUpdateDiagnoses : Form
    {
        NorthwindController _controller;
        string diagName;
        
        public NwUpdateDiagnoses(String diagName)
        {
            InitializeComponent();
            _controller = new NorthwindController();
            this.diagName = diagName;
        }

        private static NwUpdateDiagnoses _NWUpdateDiagnosesForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NwUpdateDiagnoses GetChildInstance(string diagName)
        {
            if (_NWUpdateDiagnosesForm == null) //if not created yet, Create an instance
                _NWUpdateDiagnosesForm = new NwUpdateDiagnoses(diagName);
            else
            {
                _NWUpdateDiagnosesForm.Dispose();
                _NWUpdateDiagnosesForm = new NwUpdateDiagnoses(diagName);

            }
            return _NWUpdateDiagnosesForm;  //just created or created earlier.Return it
        }
        
        private void NwUpdateDiagnoses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diagnosesDataSet.diagnoses' table. You can move, or remove it, as needed.
            this.diagnosesTableAdapter.Fill(this.diagnosesDataSet.diagnoses);
            textBoxCurrentDiagnoses.Text = this.diagName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdateDiagnoses_Click(object sender, EventArgs e)
        {

        }


    }
}
