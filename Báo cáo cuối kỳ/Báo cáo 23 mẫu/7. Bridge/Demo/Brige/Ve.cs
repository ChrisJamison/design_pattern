using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brige
{
    //implementor
    abstract class Ve
    {
        public abstract void HcnWin();
        public abstract void HcnLinux();
    }
    //refinedAbstration1
    class Win : HienThi
    {
        public override void Show()
        {
            _ve.HcnWin();
        }
    }
    //refinedAbstration2
    class Linux : HienThi
    {
        public override void Show()
        {
            _ve.HcnLinux();
        }
    }
}
