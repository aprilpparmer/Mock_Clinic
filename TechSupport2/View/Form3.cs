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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private IncidentController inController;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.techSupportDataSet.Products);
            // TODO: This line of code loads data into the 'techSupportDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);
        
            
        }

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
