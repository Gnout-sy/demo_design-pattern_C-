using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225478_Adapter_06.structural
{
    public class MainStructural
    {
        public static void Main(string[] args)
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
            // Wait for user
            Console.ReadKey();
        }

    }
}
