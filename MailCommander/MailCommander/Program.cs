using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MailCommander
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;
            var mutex = new System.Threading.Mutex(true, "9470e41b-810c-4f73-bae8-050a18d0a6c9", out result);

            if (!result)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            GC.KeepAlive(mutex);                // mutex shouldn't be released - important line
        }
    }
}
