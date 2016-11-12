using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// Abstract Class/Interface : it defines the method that how the actual product will be created
    /// </summary>
    abstract class PDFDocument_AbstractProduct
    {
        public abstract void PrintPDF();
    }
}
