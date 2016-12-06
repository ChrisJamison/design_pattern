using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Table
    {
        public static Table Instance = new Table();
        private Table() { }
        public void Show()
        {
            Console.WriteLine("Hi there!");
        }
    }
}
