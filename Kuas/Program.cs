using System;
using System.Windows.Forms;
namespace Kuas
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            /*Properties.Settings.Default.isLoggedBefore = false;
            Properties.Settings.Default.Save();*/
            Controller.GetEverythingReady();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.isLoggedBefore == true)
            {
                Application.Run(new LandingPage());
            }
            else Application.Run(new LoginPage());
        }
    }
}
