using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_Bridge_07.structural
{
    public class ConcreateImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("Called ConcreteImplementorA's Operation()");
        }
    }
}
