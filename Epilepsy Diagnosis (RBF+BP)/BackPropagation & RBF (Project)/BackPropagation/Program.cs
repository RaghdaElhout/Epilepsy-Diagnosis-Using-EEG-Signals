using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackPropagation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static WELCOME Main_Form;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main_Form = new WELCOME();
            Application.Run(Main_Form);
        }
    }
}