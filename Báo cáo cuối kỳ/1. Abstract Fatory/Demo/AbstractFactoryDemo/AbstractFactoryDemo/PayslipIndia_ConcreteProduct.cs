using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// The 'Product A1 to be returned from Factory A' class
    /// Here the functionality of implementating actual product is defined.    
    /// </summary>
    class PayslipIndia_ConcreteProduct : PDFDocument_AbstractProduct
    {
        public override void PrintPDF()
        {
            Console.WriteLine(this.GetType().Name + ": Here are the details for 'Salary-India' in PDF");           
        }
    }
}
