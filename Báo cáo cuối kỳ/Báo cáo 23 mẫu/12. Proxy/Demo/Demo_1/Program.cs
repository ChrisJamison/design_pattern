using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxyObject = new Proxy();

            proxyObject.PerformAction();

            Console.ReadKey();
        }
    }

    public interface Subject
    {
        void PerformAction();
    }

    public class RealSubject : Subject
    {
        public void PerformAction()
        {
            Console.WriteLine("RealSubject action performed.");
        }
    }

    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public void PerformAction()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();

            _realSubject.PerformAction();
        }
    }
}
