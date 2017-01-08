using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// The 'ConcreteFactory A' class : The 'ConcreteCreator'(in FactoryMetod)/'ConcreteFactory'(in AbstractFactory pattern)
    /// Object creation preocess of Concrete products takes place here 
    /// </summary>
    class AsiaPayslip_ConcreteFactory : Document_AbstractFactory
    {
        public override PDFDocument_AbstractProduct GetPDFObject_AbstractProduct()
        {
            return new PayslipIndia_ConcreteProduct();
        }

        public override ExcelDocument_AbstractProduct GetExcelObject_AbstractProduct()
        {
            return new PayslipJapan_ConcreteProduct();
        }
    }
}
