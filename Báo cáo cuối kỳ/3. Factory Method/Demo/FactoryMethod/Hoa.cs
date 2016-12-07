using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    class Hoa : Sach
    {
        public override void Show()
        {
            MessageBox.Show("Sách Hóa");
        }
    }
}
