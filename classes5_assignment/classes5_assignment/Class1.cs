using System;

namespace classes5_assignment
{
	public class Class1
	{
        /*method that divides a number in 2*/
        public void Divide(int num)
        {
            int result = num / 2;
            Console.WriteLine(num + " / 2 = " + result);
        }

        /*overloaded Divide method*/
        /*this method takes in two numbers, and divides the first by the second*/
        public void Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + result);
        }
	}
}
