using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Abandon_All_Hope
{
    static class Program
    {
        public static ViewerForm VForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VForm = new ViewerForm();
            Application.Run(VForm);
        }
    }
}
