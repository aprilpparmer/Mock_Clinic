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
using TechSupport2.TechSupport.Model;

namespace TechSupport2.TechSupport.View
{
    public partial class ViewIncidentsByTech : Form
    {
        public ViewIncidentsByTech()
        {
            InitializeComponent();
        }

        private List<Incidents> incidentList;
        private List<TechSupport2.TechSupport.Model.Technician> techList;
        private IncidentController inController;
        


        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.techniciansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.technician);

        }

        private void ViewIncidentsByTech_Load(object sender, EventArgs e)
        {          
            
            getTechs();
            GetTechIncidents();
            
           

        }

        private void getTechs()
        {
            inController = new IncidentController();
             try
            {
                techList = inController.GetTechnicians();
                nameComboBox.DataSource = techList;
                
            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, ex.GetType().ToString());
             }
                getTechPhoneandEmail();
            
        }

        private void getTechPhoneandEmail()
        {
            int techID = (int)nameComboBox.SelectedValue; 
            inController = new IncidentController();
            try
            {
           List<TechSupport2.TechSupport.Model.Technician> techList1 = inController.GetTechnicianPhoneAndEmail(techID);
           emailTextBox.Text = techList1[0].email;
           phoneTextBox.Text = techList1[0].phone;
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
            try
            {
                incidentList = inController.GetTechIncident(techID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            incidentsDataGrid.DataSource = incidentList;
            return;
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTechIncidents();
            getTechPhoneandEmail();
        }


    }
}
