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

namespace TechSupport2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private IncidentController inController;

        public void OpenIncidentsForm()
        {
           
        }

        /// <summary>
        /// Displays the open incidents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            inController = new IncidentController();
            lvIncidents.Items.Clear();
            List<Incidents> incidentList;
            try
            {
                incidentList = this.inController.GetOpenIncidents();
                if (incidentList.Count > 0)
                {
                    Incidents incidents;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incidents = incidentList[i];
                        lvIncidents.Items.Add(incidents.productCode);
                        lvIncidents.Items[i].SubItems.Add(incidents.openDate.ToShortDateString());
                        lvIncidents.Items[i].SubItems.Add(incidents.customer);
                        lvIncidents.Items[i].SubItems.Add(incidents.technician);
                        lvIncidents.Items[i].SubItems.Add(incidents.title);
                     
                    }
                }
                else 
                {
                    MessageBox.Show("No incidents currently open");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }
        }
        
    
}
