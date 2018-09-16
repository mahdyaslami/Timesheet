using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makh.Timesheet
{
    static class Program
    {
        /// <summary>
        /// یوزر نیم یوزر جاری که برنامه باهاش باز شده است
        /// </summary>
        /// <value>Shortcut for 'Environment.Username'</value>
        internal static string Username
        {
            get
            {
                return Environment.UserName;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
