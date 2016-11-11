using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating & Initializing the ConcreteFactory class to get the instance of its parent class AbstractFactory return
            Document_AbstractFactory oAbstractFactory_AsiaPayslip = new AsiaPayslip_ConcreteFactory();
            Document_AbstractFactory oAbstractFactory_EuropePayslip = new EuropePayslip_ConcreteFactory();

            // Instantiating & Initializing the Client class 
            // in order to delegate the responsibility of invoking the method(s) defined inside the AbstractFactory
            PrintClient oPrintClientAsia = new PrintClient(oAbstractFactory_AsiaPayslip);
            PrintClient oPrintClientEurope = new PrintClient(oAbstractFactory_EuropePayslip);

            // Invoke the method to get the actual product using object of Client  
            oPrintClientAsia.Print();
            oPrintClientEurope.Print();

            Console.ReadKey();
        }
    }
}
