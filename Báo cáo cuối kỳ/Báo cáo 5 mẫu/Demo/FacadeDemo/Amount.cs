using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    class Amount
    {
        public bool isValid(int amount)
        {
            if (amount < 100000)
            {
                Console.WriteLine("valid amount of money");
                return true;
            }
            else return false;
        }
    }
}
