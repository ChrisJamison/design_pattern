using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protection_Proxy
{
    class ThongTin : IThongTin
    {
        private string name;

        public ThongTin()
        {
            this.name = "Nam";
        }

        public ThongTin(string _name)
        {
            this.name = _name;
        }

        public override string getName()
        {
            return this.name;
        }
    }
}
