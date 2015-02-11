using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport2.TechSupport.View;

namespace TechSupport2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Form2 f2;
        TechSupport2.View.OpenIncidents f3;
        UpdateIncident f4;

        /// <summary>
        /// deals with the open incidents form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
           
        }

        private void displayOpenIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void displayOpenIncidentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Opens the open incident form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayOpenIncidentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
                f2.FormClosed += f2_FormClosed;
            }
            else
                f2.Activate();
        }

        /// <summary>
        /// Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Opens the create incident form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new TechSupport2.View.OpenIncidents();
                f3.MdiParent = this;
                f3.Show();
                f3.FormClosed +=f3_FormClosed;
            }
            else
                f3.Activate();
        }

/// <summary>
/// Deals with the new incident form
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
void f3_FormClosed(object sender, FormClosedEventArgs e)
{
 	f3 = null;
}

private void updateIncidentToolStripMenuItem_Click(object sender, EventArgs e)
{
    if (f4 == null)
    {
        f4 = new UpdateIncident();
        f4.MdiParent = this;
        f4.Show();
        f4.FormClosed += f4_FormClosed;
    }
    else
        f4.Activate();
}

private void f4_FormClosed(object sender, FormClosedEventArgs e)
{
    f4 = null;
}
        
       
        }
    
}
