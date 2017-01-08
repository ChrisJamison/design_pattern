using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class Client
    {
        static void Main(string[] args)
        {
            Product product = new Product("Laptop Toshiba 14 inch");

            Customer linh = new Customer("Linh");
            Customer khoa = new Customer("Khoa");

            product.AddCustomer(linh);
            product.AddCustomer(khoa);

            product.ObserverInfo();

            Console.ReadKey();
        }
    }
}
