using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Kuas
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //It initialize every Player object and It map Image object to corresponding name
            Controller.GetEverythingReady();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LandingPage());
        }
    }
}
