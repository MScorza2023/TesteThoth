using System;
using System.Windows.Forms;
using ThothEntity;

namespace TesteThoth
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form form = new frmLogin();
            ApplicationContext applicationContext = new ApplicationContext()
            {
                MainForm = form
            };
            Application.Run(applicationContext);
        }
    }
}
