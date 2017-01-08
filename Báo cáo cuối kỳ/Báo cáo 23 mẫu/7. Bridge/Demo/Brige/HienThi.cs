using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brige
{
    //abstraction
    class HienThi
    {
        protected Ve _ve;
        public Ve Ve
        {
            set { _ve = value; }
        }
        public virtual void Show()
        {
            //_ve.HcnWin();
            MessageBox.Show("Hien thi");
        }
    }
}
