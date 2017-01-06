using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    interface IAbstractIterator
    {
        Book First();
        Book Next();
        bool IsDone { get; }
        Book CurrentItem { get; }
    }
}
