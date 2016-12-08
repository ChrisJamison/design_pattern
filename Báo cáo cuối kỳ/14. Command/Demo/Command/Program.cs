using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ICommand command = new ConcreteCommand();
            command.setReceiver(new Receiver("LinhPham"));
            Invoker invoker = new Invoker();
            invoker.executeCommand(command);
        }
    }
}
