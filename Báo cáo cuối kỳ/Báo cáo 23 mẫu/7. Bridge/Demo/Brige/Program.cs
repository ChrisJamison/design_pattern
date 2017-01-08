using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brige
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HienThi _hienThiWin = new Win();
            _hienThiWin.Ve = new VeHcn();
            _hienThiWin.Show();

            HienThi _hienThiLinux = new Linux();
            _hienThiLinux.Ve = new VeHcn();
            _hienThiLinux.Show();
            Console.Read();

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
