using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_Bridge_07.structural
{
    public class ConcreateImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("Called ConcreteImplementorB's Operation()");
        }
    }
}
