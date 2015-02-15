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
using TechMaintinance;


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
            try
            {
                inController = new IncidentController();
                List<Incidents> customers = inController.GetCustomers();             
                customerBox.DataSource = customers;
                customerBox.DisplayMember = "customer";
                customerBox.ValueMember = "customer";

                List<Incidents> products = inController.GetProducts();
                productBox.DataSource = products;
                productBox.DisplayMember = "productCode";
                productBox.ValueMember = "productCode";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
           
            //this.productsTableAdapter.Fill(this.techSupportDataSet.Products);
            
           // this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);
        
            
        }

        /// <summary>
        /// Adds a new incident to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            inController = new IncidentController();
            string name = customerBox.Text;
            string product = productBox.Text;
            string title = titleText.Text;
            string description = descriptionText.Text;
            if (Validator.IsPresent(titleText) == false) {              
                return;
            }
            if (Validator.IsPresent(descriptionText) == false)
            {
                return;
            }
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
