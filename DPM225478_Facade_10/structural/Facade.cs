using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_Facade_10.structural
{
    public class Facade
    {
SubSystemOne one;
        SubSystemTwo two;
        SubsystemThree three;
        SubSystemFour four;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubsystemThree();
            four = new SubSystemFour();
        }
        public void MethodA()
        {

            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
