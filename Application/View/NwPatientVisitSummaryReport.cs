using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.View
{
    public partial class NwPatientVisitSummaryReport : Form
    {
        public NwPatientVisitSummaryReport()
        {
            InitializeComponent();
        }

        private void PatientVisitSummaryReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientVisitSummaryReport.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.patientVisitSummaryReport.patients);

            this.reportViewer1.RefreshReport();
        }
    }
}
