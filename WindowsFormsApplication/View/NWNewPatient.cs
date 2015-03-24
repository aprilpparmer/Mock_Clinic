using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwNewPatient : Form
    {
        NorthwindController _controller;
        public NwNewPatient()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();

            _controller.AddPatients(newPatient);
        }

      
    }
}
