using System;

namespace Math_Assignment
{
    class Program
    {
        static void Main()
        {
            /*user inputs number, multiplies it by 50, and displays the result*/
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result1 = num1 * 50;
            Console.WriteLine(num1 + " * 50 = " + result1);

            /*user inputs a number, adds 25, and displays the result*/
            Console.WriteLine("\nEnter a number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result2 = num2 + 25;
            Console.WriteLine(num2 + " + 25 = " + result2);

            /*user inputs a number, divides it by 12.5, and displays the result*/
            Console.WriteLine("\nEnter a number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            float result3 = num3 / 12.5f;
            Console.WriteLine(num3 + " / 12.5 = " + result3);

            /*user inputs a number, checks if it is greater than 50, and displays the true or false result*/
            Console.WriteLine("\nEnter a number");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool result4 = num4 > 50;
            Console.WriteLine("Is " + num4 + " greater than 50? " + result4);

            /*user inputs a number, divides it by 7, and displays the remainder*/
            Console.WriteLine("\nEnter a number");
            int num5 = Convert.ToInt32(Console.ReadLine());
            float remainder = num5 % 7;
            Console.WriteLine(num5 + " / 7 has a remainder of " + remainder);

            Console.ReadLine();
        }
    }
}
