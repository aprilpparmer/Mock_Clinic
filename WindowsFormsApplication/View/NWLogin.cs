using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

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
                Employee employee = _controller.LogIn(name, password);
               
                if (employee == null)
                {
                    MessageBox.Show(@"No valid user found, please try your user name and password again");
                } else if (employee.PositionId == 1)
                {
                    MessageBox.Show(@"Valid Account.");
                    NorthwindAdmin home = new NorthwindAdmin(employee);
                    home.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show(@"Only Nurses May login at this time.");
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString() + "Something happened");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NwLogin_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Environment.Exit(0);
        }

        
    }
}
