using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwNewVisit : Form
    {
        NorthwindController _controller = new NorthwindController();

        public NwNewVisit()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NwNewVisit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CS6232_g7DataSet.doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this._CS6232_g7DataSet.doctors);
            this.comboBoxDoctorName.SelectedIndex = -1;
            // TODO: This line of code loads data into the '_CS6232_g7DataSet.nurses' table. You can move, or remove it, as needed.
            this.nursesTableAdapter.Fill(this._CS6232_g7DataSet.nurses);
            this.comboBoxNurseName.SelectedIndex = -1;
        }
    }
}
