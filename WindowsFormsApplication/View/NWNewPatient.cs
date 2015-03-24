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
        private static NwNewPatient _NwNewPatientform;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>ClosedTickets Instance</returns>
        public static NwNewPatient GetChildInstance()
        {
            if (_NwNewPatientform == null) //if not created yet, Create an instance
                _NwNewPatientform = new NwNewPatient();
            else
            {
                _NwNewPatientform.Dispose();
                _NwNewPatientform = new NwNewPatient();

            }
            return _NwNewPatientform;  //just created or created earlier.Return it
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();
            //Check First Name

            
            _controller.AddPatients(newPatient);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
       

        

       
      
    }
}
