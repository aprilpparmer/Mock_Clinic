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
            // TODO: This line of code loads data into the 'patientsDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.patientsDataSet.patients);
            // TODO: This line of code loads data into the 'patientVisitDataSet.patient_visit' table. You can move, or remove it, as needed.
            this.patient_visitTableAdapter.Fill(this.patientVisitDataSet.patient_visit);
            this.patientsTableAdapter.FillPatientInfo(this.patientsDataSet.patients, this.patientID);
        }
    }
}
