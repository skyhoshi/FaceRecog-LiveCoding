using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facial_Recognition_Library.IO;

namespace Face_Recognition_Debug_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Wireup Event Handlers
            Application.ApplicationExit += ApplicationOnApplicationExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmSimplePlayer());
            Application.Run(new frmFaceDBData());
        }

        private static void ApplicationOnApplicationExit(object sender, EventArgs eventArgs)
        {
            FileSystemManager.ApplicaitonExitCleanup();
        }
    }
}
