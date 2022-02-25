using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Companies
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
            companiesForm compForm = new companiesForm();
            compForm.Size = new System.Drawing.Size(800, 700);
            compForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(compForm);

        } // End of  static void Main()
    } // End of  static class Program
}
