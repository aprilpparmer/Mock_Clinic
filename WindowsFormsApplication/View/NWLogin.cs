using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwLogin : Form
    {
        NorthwindController _controller;

        public NwLogin()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller = new NorthwindController();
            String name = NameBox.Text;
            String password = PasswordBox.Text;
            try
            {
                String user = _controller.LogIn(name, password);
                Boolean valid = _controller.ValidLogIn(name, password);
                if (valid == true) {
                NorthwindAdmin home = new NorthwindAdmin(user);
                    home.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(@"No valid user found, please try your user name and password again");
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

        private void NwLogin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
