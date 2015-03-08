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

        private void techniciansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.techniciansBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.technicanData);

        }

        private void ViewIncidentsByTech_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'incidentsData.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter.Fill(this.incidentsData.Incidents);
            // TODO: This line of code loads data into the 'technicanData.Technicians' table. You can move, or remove it, as needed.
            this.techniciansTableAdapter.Fill(this.technicanData.Technicians);

        }
    }
}
