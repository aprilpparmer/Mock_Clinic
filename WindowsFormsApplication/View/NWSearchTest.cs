using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwSearchTest : Form
    {
        NorthwindController _controller = new NorthwindController();
        public NwSearchTest()
        {
            InitializeComponent();
        }
    }
}
