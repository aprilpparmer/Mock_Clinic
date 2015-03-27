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
    public partial class NWNewVisit : Form
    {
        public NWNewVisit()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientsDataSet);

        }

        private void patientsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.patientsDataSet);

        }

        private void NWNewVisit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientsDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.patientsDataSet.patients);

        }

        private void fillPatientInfoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientsTableAdapter.FillPatientInfo(this.patientsDataSet.patients, ((int)(System.Convert.ChangeType(patientIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void last_nameLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
