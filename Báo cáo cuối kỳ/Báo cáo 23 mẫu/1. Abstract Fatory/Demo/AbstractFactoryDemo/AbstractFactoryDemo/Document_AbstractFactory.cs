using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// Here factory defines the AbstractProduct to be produced (could be in composition; decided by Client)
    /// but it does not know, what concrete product actually going to be produced.
    /// </summary>   
    abstract class Document_AbstractFactory
    {
        public abstract PDFDocument_AbstractProduct GetPDFObject_AbstractProduct();
        public abstract ExcelDocument_AbstractProduct GetExcelObject_AbstractProduct();
    }
}
