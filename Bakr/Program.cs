using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakr
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
            bool loggedIn = false;
            foreach (String login in LoginList())
            {
                String[] info = login.Substring(login.IndexOf(':') + 1).Split(',');
                if (info[0] != "NA" && info[1] != "NA")
                {
                    loggedIn = true;
                }
            }

            if (loggedIn)
            {
                Application.Run(new BrowserForm());
            }
            else
            {
                Application.Run(new WelcomeForm());
            }
        }

        /// <summary>
        /// Returns a List of Login Data from Logins.txt
        /// </summary>
        public static List<String> LoginList()
        {
            return File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Logins.txt").Split('\n').ToList();

        }
    }
}
