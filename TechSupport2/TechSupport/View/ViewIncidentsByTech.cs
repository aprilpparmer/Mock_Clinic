using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenIncidents.Controller;
using PayablesData.model;

namespace TechSupport2.TechSupport.View
{
    public partial class ViewIncidentsByTech : Form
    {
        public ViewIncidentsByTech()
        {
            InitializeComponent();
            
        }

        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.techniciansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.technicanData);

        }

        private void ViewIncidentsByTech_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'technicanData.Technicians' table. You can move, or remove it, as needed.
            this.techniciansTableAdapter.Fill(this.technicanData.Technicians);

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int techID;
           try {
                techID = Convert.ToInt32(nameComboBox.SelectedValue);
            }
             catch (Exception)
            {
                MessageBox.Show("Invalid Tech ID");
                return;
            }

       //     IncidentController inController = new IncidentController();
        //    List<Incidents> incidentList = inController.GetTechIncident(techID);
        //    incidentsDataGridView.DataSource = incidentList;
         //   foreach (DataGridViewRow row in incidentsDataGridView.Rows)
        //    {
         //       Incidents incedent = (Incidents)row.DataBoundItem;
        //    }
        }
    }
}
