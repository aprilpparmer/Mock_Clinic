using System;
using System.Windows.Forms;
using WindowsFormsApplication.View;

namespace WindowsFormsApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NwLogin login = new NwLogin();
            login.Show();
            Application.Run();
        }
    }
}
