using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod
{
    class CreateSach : Creator
    {
        public CreateSach()
        {
            danhsach = new List<Sach>();
        }
        public override Sach createSach(Sach loaisach)
        {
            if (loaisach != null)
            {
                danhsach.Add(loaisach);
            }
            return loaisach;
        }
        public void Show()
        {
            MessageBox.Show("Danh sách sách:" + this.danhsach);
        }
    }
}
