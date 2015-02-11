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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpdateIncident_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'techSupportDataSet.Technicians' table.
            this.techniciansTableAdapter.Fill(this.techSupportDataSet.Technicians);

        }
    }
}
