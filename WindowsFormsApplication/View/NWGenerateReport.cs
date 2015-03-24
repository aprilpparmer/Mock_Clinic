using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwGenerateReport : Form
    {
        NorthwindController _controller = new NorthwindController();

        public NwGenerateReport()
        {
            InitializeComponent();
        }
    }
}
