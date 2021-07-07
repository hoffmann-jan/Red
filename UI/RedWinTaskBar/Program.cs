using System;
using System.Threading;
using System.Windows.Forms;

namespace RedTaskBar
{
    static class Program
    {
        private const string _MUTEX_NAME = "JanHoffmann.Red.UI.RedTaskBar";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = null;

            if (!Mutex.TryOpenExisting(_MUTEX_NAME, out mutex))
            {
                mutex = new Mutex(false, _MUTEX_NAME);
                Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RedApplicationContext());
                mutex.Close();

            }
        }
    }
}
