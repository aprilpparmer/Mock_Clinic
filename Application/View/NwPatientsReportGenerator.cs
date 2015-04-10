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
    public partial class NwPatientsReportGenerator : Form
    {
        public NwPatientsReportGenerator()
        {
            InitializeComponent();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            NwPatientVisitSummaryReport report = new NwPatientVisitSummaryReport();
            report.Show();
            report.BringToFront();
        }
    }
}
