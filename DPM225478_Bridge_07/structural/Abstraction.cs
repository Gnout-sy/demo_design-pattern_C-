using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_Bridge_07.structural
{
    public class Abstraction
    {
        protected Implementor implementor;
        // Property
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public virtual void Operation()
        {
            implementor.Operation();
        }

    }
}
