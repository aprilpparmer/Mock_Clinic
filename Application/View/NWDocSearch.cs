using System.Windows.Forms;
using WindowsFormsApplication.Controller;

namespace WindowsFormsApplication.View
{
    public partial class NwDocSearch : Form
    {
        NorthwindController _controller = new NorthwindController();

        public NwDocSearch()
        {
            InitializeComponent();
        }
    }
}
