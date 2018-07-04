using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Invoice
{

   

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            ClientInformation clientInformation =  ClientInformation.Instance();
            clientInformation.Load();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainmenu());

          
            clientInformation.Save();
        }
    }
}
