using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
        public class Monkey : Animal
        {
            //helper method to show monkey's property for demo purpose
            public override void Eat()
            {
                Console.WriteLine("Since I am Monkey, I like to eat banana");
            }
        }
}
