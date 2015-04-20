using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwOrderTest : Form
    {
        NorthwindController _controller = new NorthwindController();
        private int visitID;
        private int patientID;

        public NwOrderTest(int visitID, int patientID)
        {
            InitializeComponent();
            this.visitID = visitID;
            this.patientID = patientID;
        }

        private void NwOrderTest_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientsDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.FillPatientInfo(this.patientsDataSet.patients, this.patientID);
            // TODO: This line of code loads data into the 'patientVisitSummaryReport.tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.patientVisitSummaryReport.tests);
            // TODO: This line of code loads data into the 'patientVisitDataSet.patient_tests' table. You can move, or remove it, as needed.
            this.patient_testsTableAdapter.Fill(this.patientVisitDataSet.patient_tests);
            textBoxVisitID.Text = this.visitID.ToString();
        }

        private static NwOrderTest _NWOrderTestForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NwOrderTest GetChildInstance(int visitID, int patientID)
        {
            if (_NWOrderTestForm == null) //if not created yet, Create an instance
                _NWOrderTestForm = new NwOrderTest(visitID, patientID);
            else
            {
                _NWOrderTestForm.Dispose();
                _NWOrderTestForm = new NwOrderTest(visitID, patientID);

            }
            return _NWOrderTestForm;  //just created or created earlier.Return it
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonSubmit_Click(object sender, System.EventArgs e)
        {
            PatientTests patientTest = new PatientTests();

            patientTest.VisitId = Int32.Parse(textBoxVisitID.Text);
            patientTest.TestId = Int32.Parse(comboBoxTest.SelectedValue.ToString());
            patientTest.TestOrdered = DateTime.Now;
            try
            {
                _controller.OrderTest(patientTest);
                MessageBox.Show(@"Test Added.");
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"There was a problem adding the test." + exception);

            }

        }
    }
}
