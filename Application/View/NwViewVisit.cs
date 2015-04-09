using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication.View
{
    public partial class NwViewVisit : Form
    {
        private int visitID;

        public NwViewVisit(int _visitID)
        {
            try
            { 
                InitializeComponent();
                //Get the visitID
                this.visitID = _visitID;
                //Fill the data
                this.patient_visitTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit, this.visitID);
                this.patient_visit_vitalsTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit_vitals, this.visitID);
                this.patient_visit_symptomsTableAdapter.Fill(this.patientVisitInfoDataSet.patient_visit_symptoms, this.visitID);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("VisitID is not an integer.", "Property Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }   
        }

    }
}
