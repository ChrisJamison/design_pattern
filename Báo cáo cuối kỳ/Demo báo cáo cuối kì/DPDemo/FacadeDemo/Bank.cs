using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    class Bank
    {
        public bool isValidCustomer(Customer c)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
