using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwUpdateTest : Form
    {
        NorthwindController _controller;
        
        public NwUpdateTest()
        {
            InitializeComponent();
            _controller = new NorthwindController();
        }

        private static NwUpdateTest _NWUpdateTestForm;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>NewDiag Instance</returns>
        public static NwUpdateTest GetChildInstance()
        {
            if (_NWUpdateTestForm == null) //if not created yet, Create an instance
                _NWUpdateTestForm = new NwUpdateTest();
            else
            {
                _NWUpdateTestForm.Dispose();
                _NWUpdateTestForm = new NwUpdateTest();

            }
            return _NWUpdateTestForm;  //just created or created earlier.Return it
        }
    }
}
