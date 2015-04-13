using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class NwUpdateTest : Form
    {
        NorthwindController _controller;
        int testId;
        string testName;
        
        public NwUpdateTest(int testId, string testName)
        {
            InitializeComponent();
            _controller = new NorthwindController();
            this.testId = testId;
            this.testName = testName;
        }

        private static NwUpdateTest _NWUpdateTestForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NwUpdateTest GetChildInstance(int testId, string testName)
        {
            if (_NWUpdateTestForm == null) //if not created yet, Create an instance
                _NWUpdateTestForm = new NwUpdateTest(testId, testName);
            else
            {
                _NWUpdateTestForm.Dispose();
                _NWUpdateTestForm = new NwUpdateTest(testId, testName);

            }
            return _NWUpdateTestForm;  //just created or created earlier.Return it
        }

        private void NwUpdateTest_Load(object sender, System.EventArgs e)
        {
            textBoxCurrentID.Text = this.testId.ToString();
            textBoxCurrentName.Text = this.testName;
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonUpdateTest_Click(object sender, System.EventArgs e)
        {


            Test updatedTest = new Test();

            if (textBoxUpdatedName.Text.Length > 0)
            {
                updatedTest.TestName = textBoxUpdatedName.Text.Trim(); 
                bool updateFlag = _controller.UpdateTest(testId, textBoxUpdatedName.Text);
            
                if (updateFlag)
                {
                    MessageBox.Show(this, "Test was updated Successfuly", "Message");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Could not update the test", "Message");
                }
            }
            else
            {
                MessageBox.Show("Please provide a new name for the test!");
            }
             

           

        }
    }
}
