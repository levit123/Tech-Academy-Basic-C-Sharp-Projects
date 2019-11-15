using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes5_assignment
{
    class Program
    {
        static void Main()
        {
            /*creates an instance of Class1*/
            Class1 class1Instance = new Class1();

            /*user enters a number*/
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            /*calls the method that divides the user-defined number by 2*/
            class1Instance.Divide(num1);

            /*user enters a second number*/
            Console.Write("Enter a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            /*calls the method that divides the first user-defined number by the second*/
            class1Instance.Divide(num1, num2);

            /*creates an undefined integer and passes it to Class2's Double method*/
            int num3;
            Class2.Double(out num3);

            Console.Read();
        }

        /*static class*/
        public static class Class2
        {
            /*method that takes in an out parameter*/
            public static void Double(out int num)
            {
                num = 5;
                int result = num * 2;
                Console.WriteLine(num + " * 2 = " + result);
            }
        }
    }
}
