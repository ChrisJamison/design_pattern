using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    abstract class Expression
    {
        public void Interpreter(Context context)
        {
            if (context.input.Length == 0) return;
            if (context.input.StartsWith(Nine()))
            {
                context.output += 9 * Multiplier();
                context.input = context.input.Substring(2);
            }
            if (context.input.StartsWith(Four()))
            {
                context.output += 4 * Multiplier();
                context.input = context.input.Substring(2);
            }
            if (context.input.StartsWith(One()))
            {
                context.output += 1 * Multiplier();
                context.input = context.input.Substring(1);
            }

            if (context.input.StartsWith(Five()))
            {
                context.output += 5 * Multiplier();
                context.input = context.input.Substring(1);
            }
        }
        abstract public string One();
        abstract public string Four();
        abstract public string Five();
        abstract public string Nine();
        abstract public int Multiplier();
    }
}
