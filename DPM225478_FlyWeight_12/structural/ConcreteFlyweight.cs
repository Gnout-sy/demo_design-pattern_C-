using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_FlyWeight_12.structural
{
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
}
