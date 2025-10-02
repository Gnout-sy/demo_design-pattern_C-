
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_Command_15.structural
{
    public class ConcreteCommand : Command
    {
        // Constructor
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }
        public override void Execute()
        {
            receiver.Action();
        }
    }
    {
    }
}
