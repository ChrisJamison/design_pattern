using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    class Receiver
    {
        private String name;
        public Receiver(String name){
            this.name = name;
        }
        public void doAction(){
            MessageBox.Show(this.name + " fulfill request!");
        }
    }
}
