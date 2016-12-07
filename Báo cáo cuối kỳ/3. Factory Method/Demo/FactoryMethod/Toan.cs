using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    class Toan : Sach
    {
        public override void Show()
        {
            MessageBox.Show("Sách Toán");
        }
    }
}
