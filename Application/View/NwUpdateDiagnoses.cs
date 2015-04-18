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
    public partial class NwUpdateDiagnoses : Form
    {
        NorthwindController _controller;
        string diagName;
        int visitID;
        string symptom;
        
        public NwUpdateDiagnoses(int visitID, String diagName, string symptom)
        {
            InitializeComponent();
            _controller = new NorthwindController();
            this.diagName = diagName;
            this.visitID = visitID;
            this.symptom = symptom;
        }

        private static NwUpdateDiagnoses _NWUpdateDiagnosesForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NwUpdateDiagnoses GetChildInstance(int visitID, string diagName, string symptom)
        {
            if (_NWUpdateDiagnosesForm == null) //if not created yet, Create an instance
                _NWUpdateDiagnosesForm = new NwUpdateDiagnoses(visitID, diagName, symptom);
            else
            {
                _NWUpdateDiagnosesForm.Dispose();
                _NWUpdateDiagnosesForm = new NwUpdateDiagnoses(visitID, diagName, symptom);

            }
            return _NWUpdateDiagnosesForm;  //just created or created earlier.Return it
        }
        
        private void NwUpdateDiagnoses_Load(object sender, EventArgs e)
        {
            this.diagnosesTableAdapter.Fill(this.diagnosesDataSet.diagnoses);
            textBoxCurrentDiagnoses.Text = this.diagName;
            textBoxSymptom.Text = this.symptom;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdateDiagnoses_Click(object sender, EventArgs e)
        {
            PatientVisitSymptoms updatedDiag = new PatientVisitSymptoms();

             updatedDiag.DiagnosesID = Int32.Parse(comboBox1.SelectedValue.ToString());
             bool updateFlag = _controller.UpdateDiagnoses(visitID, updatedDiag.DiagnosesID, symptom);

             if (updateFlag)
                {
                    MessageBox.Show(this, "Diagnoses was updated successfuly!", "Message");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Could not update diagnoses!", "Message");
                }
            
            
        }


    }
}
