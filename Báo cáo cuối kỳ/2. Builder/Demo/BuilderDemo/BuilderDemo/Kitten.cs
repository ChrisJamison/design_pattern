using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class Kitten : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Since I am Kitten, I like to eat kitten food");
        }
    }
}
