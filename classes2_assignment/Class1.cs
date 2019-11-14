using System;

namespace classes2_assignment
{
    class Class1
    {
        /*constructor for class*/
        public Class1(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }

        /*properties*/
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        /*methods*/
        public void Math1(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.Write(num1 + " + " + num2 + " = " + num3);
        }
    }
}
