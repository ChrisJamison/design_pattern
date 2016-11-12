using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// This decides how the final product will be prepared.
    /// </summary>
    class PrintClient
    {
        PDFDocument_AbstractProduct oPDF_AbstractProduct;
        ExcelDocument_AbstractProduct oExcel_AbstractProduct;

        // Client Constructor        
        public PrintClient(Document_AbstractFactory oAbstractFactory)
        {
            oPDF_AbstractProduct = oAbstractFactory.GetPDFObject_AbstractProduct();
            oExcel_AbstractProduct = oAbstractFactory.GetExcelObject_AbstractProduct();
        }
        public void Print()
        {
            oPDF_AbstractProduct.PrintPDF();
            oExcel_AbstractProduct.PrintExcel();
        }
    }
}
