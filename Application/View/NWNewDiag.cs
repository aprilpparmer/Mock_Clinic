using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NWNewDiag : Form
    {
        NorthwindController _controller;

        public NWNewDiag()
        {
            InitializeComponent();
            _controller = new NorthwindController();

        }

        private static NWNewDiag _NWNewDiagform;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NWNewDiag GetChildInstance()
        {
            if (_NWNewDiagform == null) //if not created yet, Create an instance
                _NWNewDiagform = new NWNewDiag();
            else
            {
                _NWNewDiagform.Dispose();
                _NWNewDiagform = new NWNewDiag();

            }
            return _NWNewDiagform;  //just created or created earlier.Return it
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Diagnoses diag = new Diagnoses();
            nameTextBox.Text = nameTextBox.Text.Trim();
            DescTextBox.Text = DescTextBox.Text.Trim();
            treatmentTextBox.Text = treatmentTextBox.Text.Trim();
            if ((nameTextBox.Text.Length > 1) && (DescTextBox.Text.Length > 1) && (treatmentTextBox.Text.Length > 1))
            {
                diag.Name = nameTextBox.Text;
                diag.Description = DescTextBox.Text;
                diag.Treatment = treatmentTextBox.Text;
                try
                {
                    _controller.AddDiagnoses(diag);
                    MessageBox.Show(@"Diagnoses Added.");
                    Close();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"There was a problem adding the diagnoses. Please let the admin know." + exception);

                }
            }
            else
            {
                MessageBox.Show(@"You must fill in all the fields.");
   
            }

        }
    }
}
