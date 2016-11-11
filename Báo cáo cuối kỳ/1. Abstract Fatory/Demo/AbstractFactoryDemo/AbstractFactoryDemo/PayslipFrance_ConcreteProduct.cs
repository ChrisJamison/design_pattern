using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// The 'Product B2 to be returned from Factory B' class
    /// </summary>    
    class PayslipFrance_ConcreteProduct : ExcelDocument_AbstractProduct
    {
        public override void PrintExcel()
        {
            Console.WriteLine(this.GetType().Name + ": Here are the details for 'Salary-France' in Excel");
        }
    }
}
