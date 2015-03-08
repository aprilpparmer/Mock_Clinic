using OpenIncidents.Controller;
using PayablesData.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport2.TechSupport.View
{
    public partial class ViewIncidentsByTech : Form
    {
        public ViewIncidentsByTech()
        {
            InitializeComponent();
        }

        private List<Incidents> incidentList;
        private List<Technician> techList;
        private IncidentController inController;
        private Technician tech;


        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.techniciansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.technician);

        }

        private void ViewIncidentsByTech_Load(object sender, EventArgs e)
        {          
            this.techniciansTableAdapter.Fill(this.technician.Technicians);
            GetTechIncidents();

        }

        private void GetTechIncidents()
        {
            int techID = (int)nameComboBox.SelectedValue;            
            inController = new IncidentController();                     
            try
            {
                incidentList = inController.GetTechIncident(techID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            incidentsDataGrid.DataSource = incidentList;
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTechIncidents();
        }


    }
}
