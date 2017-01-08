using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class LazyInitializedSingleton 
    {
        private static LazyInitializedSingleton _instance;

        private LazyInitializedSingleton()
        {
            Console.WriteLine("Initialize new instance using lazy initialization!");
        }

        public static LazyInitializedSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LazyInitializedSingleton();
                }
                return _instance;
            }
        }

        public void Foo()
        {
            Console.WriteLine("This instance is fooing!");
        }
    }
}
