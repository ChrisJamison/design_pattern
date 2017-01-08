using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brige
{
    // "ConcreteImplementorA"
    class VeHcn : Ve
    {
        //ve hinh chu nhat tren win
        public override void HcnWin()
        {
            MessageBox.Show("Ve hcn tren Win");
        }
        //ve hinh chu nhat tren linux
        public override void HcnLinux()
        {
            MessageBox.Show("Ve hcn tren Linux");
        }
    }
}
