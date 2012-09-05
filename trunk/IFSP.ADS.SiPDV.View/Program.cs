using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IFSP.ADS.SiPDV.View
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
            Application.Run(new FormSplash());
            Application.Run(new FormLogin());
            Application.Run(new FormMain());
        }
    }
}
