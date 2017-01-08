using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protection_Proxy
{
    class ThongTinProxy : IThongTin
    {
        private bool is_Admin = false;

        public ThongTinProxy(bool _is_admin)
        {
            this.is_Admin = _is_admin;
        }

        public override string getName()
        {
            if (this.is_Admin == true)
            {
                ThongTin a = new ThongTin("Linh");
                return a.getName();
            }
            return "";
        }
    }
}
