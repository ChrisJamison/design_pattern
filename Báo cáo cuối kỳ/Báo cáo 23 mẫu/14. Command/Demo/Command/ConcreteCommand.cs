using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ConcreteCommand : ICommand
    {
        private Receiver receiver;
        //public void setReceiver(Receiver receiver){
        //    this.receiver = receiver;
        //}
        //public Receiver getReceiver(){
        //    return this.receiver;
        //}

        public override void execute (){
            receiver.doAction();
        }
    }
}
