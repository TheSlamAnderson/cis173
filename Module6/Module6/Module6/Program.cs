using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Module6
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
            Splash aSplash = new Splash();
            aSplash.ShowDialog();
            Application.Run(new Main());
        }
    }
}