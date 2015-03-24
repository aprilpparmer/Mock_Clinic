using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwNurseSearch : Form
    {
        NorthwindController _controller = new NorthwindController();

        public NwNurseSearch()
        {
            InitializeComponent();
        }
    }
}
