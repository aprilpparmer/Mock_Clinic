using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwUpdateDoc : Form
    {
        NorthwindController _controller = new NorthwindController();
        public NwUpdateDoc()
        {
            InitializeComponent();
        }
    }
}
