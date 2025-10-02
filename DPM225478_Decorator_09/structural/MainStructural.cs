using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_Decorator_09.structural
{
    public class MainStructural
    {
        public static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreateDecoratorA d1 = new ConcreateDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();
            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();
            // Wait for user
            Console.ReadKey();
        }
    }
}
