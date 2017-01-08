using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpreter
{
    static class Program
    {
        static void Main()
        {
            string str, select = "C";
            ArrayList parse = new ArrayList();

            while (select != "K" && select != "k")
            {
                Console.Write("Nhap vao so La Ma : ");
                str = Console.ReadLine();
                //str = str.ToUpper();
                Context context = new Context(str);

                parse.Add(new ThousandExpresssion());
                parse.Add(new HundredExpresssion());
                parse.Add(new TenExpresssion());
                parse.Add(new OneExpresssion());

                foreach (Expression exp in parse)
                    exp.Interpreter(context);
                Console.WriteLine("{0} = {1}", str, context.output);

                Console.WriteLine("Ban co muon tiep tuc ? (C/K)");
                select = Console.ReadLine();
            }
        }
    }
}
