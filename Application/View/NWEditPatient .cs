using System;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwEditPatient : Form
    {
        NorthwindController _controller;
        private static int _patientId;
        private Patient _thepatient;

        public NwEditPatient(int thePatientId)
        {
            InitializeComponent();
            
            _controller = new NorthwindController();
            try
            {
                _patientId = thePatientId;
                _thepatient = _controller.GetPatientsById(thePatientId);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"There was a problem loading this patient, please try again.");
                this.Close();
            }
        }
        private static NwEditPatient _NwEditPatientform;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>ClosedTickets Instance</returns>
        public static NwEditPatient GetChildInstance(int thePatientId)
        {
            if (_NwEditPatientform == null) //if not created yet, Create an instance
                _NwEditPatientform = new NwEditPatient(thePatientId);
            else
            {
                _NwEditPatientform.Dispose();
                _NwEditPatientform = new NwEditPatient(thePatientId);

            }
            return _NwEditPatientform;  //just created or created earlier.Return it
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();
            int ssn, zip;

            if ((femaleRadioButton.Checked == false) & (maleRadioButton.Checked == false))
            {
                MessageBox.Show(
                            @"Please select gender.");
            }
            else
            {
                String gender;
                if ((femaleRadioButton.Checked == true))
                {
                    gender = "F";
                }
                else
                {
                    gender = "M";
                }

                if ((int.TryParse(ssnTextBox.Text, out ssn)) & (ssnTextBox.Text.Length == 9))
                {
                    if ((int.TryParse(zipTextBox.Text, out zip)) & (zipTextBox.Text.Length == 5))
                    {

                        if ((firstNameTextBox.Text != "") & (lastNameTextBox.Text != "") & (ssn != 0) & (zip != 0) &
                            (homePhoneTextBox.Text != "") &
                            (addressTextBox.Text != "") & (cityTextBox.Text != "") & (stateTextBox.Text != ""))
                        {
                            //Check Details
                            newPatient.FirstName = firstNameTextBox.Text;
                            newPatient.MiddleInitial = middleInitialTextBox.Text;
                            newPatient.LastName = lastNameTextBox.Text;
                            newPatient.Gender = gender;
                            newPatient.Ssn = ssn;
                            newPatient.Zip = zip;
                            newPatient.HomePhone = homePhoneTextBox.Text;
                            newPatient.WorkPhone = workPhoneTextBox.Text;
                            newPatient.Dob = dateTimePicker.Value.Date;
                            newPatient.Address = addressTextBox.Text;
                            newPatient.City = cityTextBox.Text;
                            newPatient.State = stateTextBox.Text;
                            try
                            {
                                _controller.AddPatients(newPatient);
                                MessageBox.Show(@"The patient has been added.");
                                this.Close();

                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(
                                    @"There was a problem adding the Patient into the Database, please contact the admin with this message." +
                                    exception);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                @"Please check all the required fields and make sure you entered the proper information.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            @"Please enter Zip as a number and that you have entered the right amount of numbers. Please check.");
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"Please enter Social as a number with no dashes, or you may not have entered the right amount of numbers. Please check.");
                }
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        private void maleRadioButton_Clicked(object sender, EventArgs e)
        {
            femaleRadioButton.Checked = false;
            maleRadioButton.Checked = true;
        }

        private void femaleRadioButton_Clicked(object sender, EventArgs e)
        {
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = true;
        }

        private void NWEditPatient_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = _thepatient.FirstName.Trim();
            middleInitialTextBox.Text = _thepatient.MiddleInitial.Trim();
            lastNameTextBox.Text = _thepatient.LastName.Trim();
            //genderTextBox.Text = _thepatient.Gender.Trim();
            ssnTextBox.Text = _thepatient.Ssn.ToString().Trim();
            zipTextBox.Text = _thepatient.Zip.ToString().Trim();
            homePhoneTextBox.Text = _thepatient.HomePhone.Trim();
            workPhoneTextBox.Text = _thepatient.WorkPhone.Trim();
            //dateTextBox.Text = _thepatient.Dob.ToShortDateString().Trim();
            addressTextBox.Text = _thepatient.Address.Trim();
            cityTextBox.Text = _thepatient.City.Trim();
            stateTextBox.Text = _thepatient.State.Trim();
        }

       


        
       

        

       
      
    }
}
 