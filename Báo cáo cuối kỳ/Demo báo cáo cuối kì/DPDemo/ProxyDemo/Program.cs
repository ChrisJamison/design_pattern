using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protection_Proxy
{    
    class Client
    {
        static void Main(string[] args)
        {
            ThongTinProxy B = new ThongTinProxy(true);
            Console.WriteLine("Admin has Logged into system, Name: " + B.getName());

            Console.ReadLine();
        }
    }
}
