using OpenIncidents.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport2.View
{
    public partial class OpenIncidents : Form
    {
        public OpenIncidents()
        {
            InitializeComponent();
        }

        private IncidentController inController;

        /// <summary>
        /// Closes the object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        /// <summary>
        /// Loads the data to the combo boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
           
            this.productsTableAdapter.Fill(this.techSupportDataSet.Products);
            
            this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);
        
            
        }

        /// <summary>
        /// Adds a new incident to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            inController = new IncidentController();
            string name = comboBox1.Text;
            string product = comboBox2.Text;
            string title = textBox2.Text;
            string description = textBox1.Text;
            try
            {
                inController.AddIncident(name, product, title, description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
            MessageBox.Show("Incident added to the database");
            this.Close();
        }



    }
}
