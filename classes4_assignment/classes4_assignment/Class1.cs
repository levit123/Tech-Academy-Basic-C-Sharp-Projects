using System;

namespace classes4_assignment
{
	public class Class1
	{
        public int Math1(int num1, int num2 = 0)
        {
            int num3 = 0;
            if (num2 != 0)
            {
                num3 = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + num3);
            }
            else
            {
                num3 = num1 + 0;
                Console.WriteLine(num1 + " + 0 = " + num3);
            }

            return num3;
        }
	}
}
