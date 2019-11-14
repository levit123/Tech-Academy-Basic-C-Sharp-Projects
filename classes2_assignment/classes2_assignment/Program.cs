using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes2_assignment
{
    class Program
    {
        static void Main()
        {
            /*user enters a number*/
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            /*user enters a second number*/
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Class1 class1Instance = new Class1(num1, num2);

            class1Instance.Math1(class1Instance.Number1, class1Instance.Number2);

            Console.Read();
        }
    }
}
