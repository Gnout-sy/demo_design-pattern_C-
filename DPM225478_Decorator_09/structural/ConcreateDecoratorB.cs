using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_Decorator_09.structural
{
    public class ConcreateDecoratorB : Decorator
    {
        public ConcreateDecoratorB(Component component) : base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }
        void AddedBehavior()
        {
        }
    }
}
