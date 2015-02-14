﻿using System;
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
            int inID = 0;
            try
            {
                inID = Convert.ToInt32(incidentID);
            }
            catch (Exception)
            {
                MessageBox.Show("Incident ID should be an whole number");
                return;
            }

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
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("That incident does not exist or is already closed");
                return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                
            }
            updateButton.Enabled = true;
            closeButton.Enabled = true;
            textToAddBox.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            inController = new OpenIncidents.Controller.IncidentController();
            string incidentID = IncidentIDText.Text;
            int inID = Convert.ToInt32(incidentID);
            String desText = descriptionText.Text;
            String tech = technicianBox.Text;
            String date = DateTime.Now.ToString();
            String text = textToAddBox.Text;

           desText = date + " " + text + Environment.NewLine;
  
            if (text.Length == 0)
            {
                desText = date + " Technician added/updated " + Environment.NewLine + descriptionText.Text;
            }

            while (desText.Length + text.Length > 200)
            {
                textToAddBox.Text = (desText);
                if ((MessageBox.Show("Description length exceedes 200 characters, description will be truncated", "Incident", MessageBoxButtons.OKCancel) == DialogResult.Cancel))
                {
                    return;
                }
                       
                desText = textToAddBox.Text.Substring(0,200);
                
            } 
            
            

           List<PayablesData.model.Incidents> aList = inController.GetIncident(inID);
           PayablesData.model.Incidents incident = aList[0];
           String desc = incident.description;
           if (desc != descriptionText.Text )
           {
                MessageBox.Show("Incident has been updated while you worked, please retrieve the new data and try again");
               return;
            }

           
           
            try
            {
                
                inController.UpdateIncident(desText, tech, inID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            MessageBox.Show("Incident Updated");
            List<PayablesData.model.Incidents> List = inController.GetIncident(inID);
            PayablesData.model.Incidents incidents = List[0];
            customerText.Text = incidents.customer;
            productText.Text = incidents.productCode;
            technicianBox.Text = incidents.technician;
            titleText.Text = incidents.title;
            dateOpenedText.Text = incidents.openDate.ToString();
            descriptionText.Text = incidents.description;
            textToAddBox.Text = "";

        }
    } 
}
