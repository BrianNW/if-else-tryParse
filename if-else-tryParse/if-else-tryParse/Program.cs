using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_tryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if(numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            if(numTemp == 20)
            {
                Console.WriteLine("Pants and pull over should be fine");
            }

            if(numTemp > 20)
            {
                Consolee.WriteLine("Shorts are enough today");
            }
            Console.Read();
        }
    }
}
