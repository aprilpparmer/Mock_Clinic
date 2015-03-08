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
using TechSupport2.TechSupport.Model;

namespace TechSupport2.TechSupport.View
{
    public partial class ViewIncidentsByTech : Form
    {
        public ViewIncidentsByTech()
        {
            InitializeComponent();

        }

        private Incidents incident;
        private List<Incidents> incidentList;
        private List<Technician> techList;
        private IncidentController inController;

       

        private void ViewIncidentsByTech_Load(object sender, EventArgs e)
        {
            this.GetTechList();

       
        }

        private void GetTechList()
        {
            inController = new IncidentController();
            try
            {
                // Get the list of Technican objects
                // and bind the combo box to the list
                techList = inController.GetTechnicians();
                nameComboBox.DataSource = techList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetTechIncidents()
        {
            int techID = (int)nameComboBox.SelectedValue;
            
            inController = new IncidentController();
            techniciansBindingSource.Clear();
            //techniciansBindingSource.Add();
            try
            {
                incidentList = inController.GetTechIncident(techID);
                incidentsDataGridView.DataSource = incidentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }




        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetTechIncidents();


        }
    }
}
