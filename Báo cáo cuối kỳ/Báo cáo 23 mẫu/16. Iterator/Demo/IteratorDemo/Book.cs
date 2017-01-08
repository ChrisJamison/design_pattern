using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    class Book
    {
        private String _name;
         
        public Book(String name)
        {
            this._name = name;
        }

        public String Name
        {
            get { return _name; }
        }
    }
}
