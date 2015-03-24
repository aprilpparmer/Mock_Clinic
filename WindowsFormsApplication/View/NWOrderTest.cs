using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwOrderTest : Form
    {
        NorthwindController _controller = new NorthwindController();
        public NwOrderTest()
        {
            InitializeComponent();
        }
    }
}
