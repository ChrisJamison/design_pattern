using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class Customer : Observer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public override void ObserverInfo()
        {
            Console.WriteLine("Hi " + this.name + ". You have 3 message from...");
        }
    }
}
