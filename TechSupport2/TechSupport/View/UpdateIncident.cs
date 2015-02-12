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
    public partial class UpdateIncident : Form
    {
        public UpdateIncident()
        {
            InitializeComponent();
        }

        private OpenIncidents.Controller.IncidentController inController;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateIncident_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'techSupportDataSet.Technicians' table.
            this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inController = new OpenIncidents.Controller.IncidentController();
            string incidentID = IncidentIDText.Text;
            int inID = Convert.ToInt32(incidentID);
           
            try
            {
               List<PayablesData.model.Incidents> List = inController.GetIncident(inID);
               PayablesData.model.Incidents incidents = List[0];
               customerText.Text = incidents.customer;
               productText.Text = incidents.productCode;
               technicianBox.Text = incidents.technician;
               titleText.Text = incidents.title;
               dateOpenedText.Text = incidents.openDate.ToString();
               descriptionText.Text = incidents.description;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
            MessageBox.Show("Incident updated");
            this.Close();
        }
    }
}
