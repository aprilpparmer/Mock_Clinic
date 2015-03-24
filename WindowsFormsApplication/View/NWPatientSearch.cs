using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwPatientSearch : Form
    {
        NorthwindController _controller = new NorthwindController();
        public NwPatientSearch()
        {
            InitializeComponent();
        }
    }
}
