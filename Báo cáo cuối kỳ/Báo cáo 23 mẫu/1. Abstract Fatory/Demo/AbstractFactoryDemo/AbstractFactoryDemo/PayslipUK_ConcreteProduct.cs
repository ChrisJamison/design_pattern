using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    // <summary>
    /// The 'Product B1 to be returned from Factory B' class
    /// </summary>
    class PayslipUK_ConcreteProduct : PDFDocument_AbstractProduct
    {
        public override void PrintPDF()
        {
            Console.WriteLine(this.GetType().Name + ": Here are the details for 'Salary-UK' in PDF");
        }
    }
}
