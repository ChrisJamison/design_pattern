using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanHoaChuoi
{
    public class AdapterStringFormat : IStringFormat
    {
        private List<string> listString;
        public AdapterStringFormat()
        {
            listString = new List<string>();
        }
        public override List<string> FormatString(List<string> listString)
        {
            CoreStringFormat coreStringFormat = new CoreStringFormat();
            foreach (string item in listString)
            {
                listString.Add(coreStringFormat.Format(item));
            }
            return listString;
        }
    }
}
