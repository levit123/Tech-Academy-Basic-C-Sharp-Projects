using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes4_assignment
{
    class Program
    {
        static void Main()
        {
            Class1 class1Instance = new Class1();

            int num1;
            int num2;

            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("OPTIONAL: Enter a second number, if you want; if not, just press enter: ");
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                num2 = 0;
            }

            class1Instance.Math1(num1, num2);

            Console.Read();
        }
    }
}
