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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = this.date1.Value;
            DateTime dt2 = this.date2.Value;
            this.patient_visitTableAdapter.Fill(this.patientVisitSummaryReport.patient_visit, dt1, dt2);
            this.reportViewer1.RefreshReport();

        }
    }
}
