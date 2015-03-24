using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Controller;

namespace WindowsFormsApplication2
{
    public partial class NWLogin : Form
    {
        NorthwindController controller;
        public NWLogin()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller = new NorthwindController();
            String name = NameBox.Text;
            String password = PasswordBox.Text;
            try
            {
                String user = controller.LogIn(name, password);
                Boolean valid = controller.validLogIn(name, password);
                if (valid == true) {
                NorthwindAdmin home = new NorthwindAdmin(user);
                    home.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No valid user found, please try your user name and password again");
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
