using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class NorthwindAdmin : Form
    {
        NWLogin loginScreen;

        public NorthwindAdmin(string username)
        {
            
            InitializeComponent();          
            UserLabel.Text = "Welcome " + username;
            NWmenuStrip.Enabled = true;
            UserLabel.Visible = true;
        }

        

        private void Northwind_Load(object sender, EventArgs e)
        {
            
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginScreen = new NWLogin();
            loginScreen.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Environment.Exit(0);
        }
    }
}
