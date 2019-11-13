using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_assignment
{
    class Program
    {
        static void Main()
        {
            /*user enters a number*/
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            /*creates an instance of the "mathematics" class and defines it's property based on the user-defined integer above*/
            mathematics math1 = new mathematics(num);

            /*calls the Add method and gets the result*/
            int result1 = Add(math1);
            /*calls the Multiply method and gets the result*/
            int result2 = Multiply(math1);
            /*calls the Divide method and gets the result*/
            int result3 = Divide(math1);

            /*spacing*/
            Console.WriteLine("\n");

            /*outputs the result of the Add method*/
            Console.WriteLine("Result of the Add method: " + result1);
            /*outputs the result of the Multiply method*/
            Console.WriteLine("Result of the Multiplty method: " + result2);
            /*outputs the result of the Divide method*/
            Console.WriteLine("Result of the Divide method: " + result3);

            Console.Read();
        }

        /*methods that the class has*/
        /*takes in an instance of the class, and performs addition on the integer property of it*/
        public static int Add(mathematics num)
        {
            /*user enters a number*/
            Console.Write("Enter a number to add to " + num.Number + ": ");
            int input = Convert.ToInt32(Console.ReadLine());

            /*adds the user-defined number to the class instance's integer property, and returns the result*/
            num.Number = num.Number + input;
            return num.Number;
        }

        /*takes in an instance of the class, and performs multiplication on the integer property of it*/
        public static int Multiply(mathematics num)
        {
            /*user enters a number*/
            Console.Write("Enter a number to multiply " + num.Number + " by: ");
            int input = Convert.ToInt32(Console.ReadLine());

            /*multiplies the class instance's integer property by the user-defined number*/
            num.Number = num.Number * input;
            return num.Number;
        }

        /*takes in an instance of the class, and performs division on the integer property of it*/
        public static int Divide(mathematics num)
        {
            /*user enters a number*/
            Console.Write("Enter a number to divide " + num.Number + " by: ");
            int input = Convert.ToInt32(Console.ReadLine());

            /*divides the class instance's integer property by the user-defined number*/
            num.Number = num.Number / input;
            return num.Number;
        }
    }
}
