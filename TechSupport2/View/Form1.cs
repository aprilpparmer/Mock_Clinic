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

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       
        }
    
}
