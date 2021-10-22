using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Connect4Graphic
{
    // $G$ RUL-004 (-20) The folder name isn't correct
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSettings());
        }
    }
}
