using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sigfree_demo_
{
    static class Program
    {
        public static Login t;
        public static string currentURL = "";
        static string conn = @"Data Source=.\;Initial Catalog=SigFreeDB;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            t = new Login();
            Application.Run(new Login  ());
        }
        
    }
}
