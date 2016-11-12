using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// The 'ConcreteFactory B' class
    /// </summary>
    class EuropePayslip_ConcreteFactory : Document_AbstractFactory
    {
        public override PDFDocument_AbstractProduct GetPDFObject_AbstractProduct()
        {
            return new PayslipUK_ConcreteProduct();
        }

        public override ExcelDocument_AbstractProduct GetExcelObject_AbstractProduct()
        {
            return new PayslipFrance_ConcreteProduct();
        }
    }
}
