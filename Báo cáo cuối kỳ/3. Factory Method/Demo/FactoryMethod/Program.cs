using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateSach creator = new CreateSach();

            Sach toan = new Toan();
            toan.Show();

            Sach ly = new Ly();
            ly.Show();

            Sach hoa = new Hoa();
            hoa.Show();

            creator.createSach(toan);
            creator.createSach(ly);
            creator.createSach(hoa);

            // MessageBox.Show("Danh sách: " + creator.danhsach.ToString());
            creator.Show();

            LichSu lichsu = new LichSu();
            lichsu.Show();

            creator.createSach(lichsu);

            creator.Show();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
