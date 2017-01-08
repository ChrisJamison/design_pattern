using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Creator
    {
        public List<Sach> danhsach;
        public abstract Sach createSach(Sach sach);
    }
}
