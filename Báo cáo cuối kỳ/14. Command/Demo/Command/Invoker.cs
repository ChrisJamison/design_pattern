using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Invoker
    {
        public void executeCommand(ICommand command)
        {
            command.execute();
        }
    }
}
