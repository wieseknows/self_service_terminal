using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_ServiceTerminal
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

            loading_form load = new loading_form();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3); //поменять тут на количество секунд
            load.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            load.Close();
            load.Dispose();
            Application.Run(new terminalMain_form());
        }
    }
}
