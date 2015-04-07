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
    public partial class NwViewVisits : Form
    {
        private int patientID;

        public NwViewVisits(int patientID)
        {   
            this.patientID = patientID;
            InitializeComponent();

        }

        private void NwViewVisits_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientVisitDataSet.patient_visit' table. You can move, or remove it, as needed.
            this.patient_visitTableAdapter.Fill(this.patientVisitDataSet.patient_visit, this.patientID);
            this.patientsTableAdapter.FillPatientInfo(this.patientsDataSet.patients, this.patientID);
        }

        private static NwViewVisits _NwViewVisitsform;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>View Visit Instance</returns>
        public static NwViewVisits GetChildInstance(int patientId)
        {
            if (_NwViewVisitsform == null) //if not created yet, Create an instance
                _NwViewVisitsform = new NwViewVisits(patientId);
            else
            {
                _NwViewVisitsform.Dispose();
                _NwViewVisitsform = new NwViewVisits(patientId);

            }
            return _NwViewVisitsform;  //just created or created earlier.Return it
        }
    }
}
