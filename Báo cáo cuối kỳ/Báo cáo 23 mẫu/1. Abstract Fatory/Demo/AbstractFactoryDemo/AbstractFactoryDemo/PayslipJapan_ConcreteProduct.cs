using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// The 'Product A2 to be returned from Factory A' class
    /// </summary> 
    class PayslipJapan_ConcreteProduct : ExcelDocument_AbstractProduct
    {
        public override void PrintExcel()
        {
            Console.WriteLine(this.GetType().Name + ": Here are the details for 'Salary-Japan' in Excel");
        }
    }
}
