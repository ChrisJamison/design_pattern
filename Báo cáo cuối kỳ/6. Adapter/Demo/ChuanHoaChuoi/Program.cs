using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanHoaChuoi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> listString = new List<string>();
            listString.Add("Hello!");
            listString.Add("There");
            listString.Add("How");
            listString.Add("Are");
            listString.Add("You");

            AdapterStringFormat adapterStringFormat = new AdapterStringFormat();
            //adapterStringFormat.FormatString(listString);
            MessageBox.Show(adapterStringFormat.FormatString(listString).ToString());
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
