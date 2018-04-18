using System;
using System.Windows.Forms;

namespace ScaleCalculator
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
            Application.Run(new SplashBox());
            Application.Run(new Form1());
        }
    }
}
