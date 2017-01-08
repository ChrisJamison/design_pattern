using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    sealed class StaticInitializedSingleton
    {
        private static readonly StaticInitializedSingleton _instance
            = new StaticInitializedSingleton();

        private StaticInitializedSingleton ()
        {
            Console.WriteLine("Initialize new instance using static initialization!");
        }

        // get object by using property
        public static StaticInitializedSingleton Instance 
        {
            get
            {
                return _instance;
            }
        }

        public void Foo()
        {
            Console.WriteLine("This instance is fooing!");
        }
    }
}
