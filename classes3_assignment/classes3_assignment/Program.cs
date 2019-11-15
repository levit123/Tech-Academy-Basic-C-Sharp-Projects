using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes3_assignment
{
    class Program
    {
        static void Main()
        {
            Class1 math1 = new Class1();

            Console.WriteLine("12 / 2 = " + math1.Halve(12));
            Console.WriteLine("8 * 2 = " + math1.Double(8));
            Console.WriteLine("3 ^ 2 = " + math1.Square("3"));

            /*tests the Square method by passing a non-number as a string*/
            if (math1.Square("tr") == -1)
            {
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
