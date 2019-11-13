using System;
using System.Collections.Generic;

namespace exception_assignment
{
    class Program
    {
        static void Main()
        {
            /*creates and defines a list of integers*/
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(15);
            intList.Add(17);
            intList.Add(20);
            intList.Add(23);
            intList.Add(25);
            intList.Add(26);
            intList.Add(28);
            intList.Add(30);

            try
            {
                /*user enters a number*/
                Console.Write("Enter a number: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                /*divides each number in the list by the user-defined divisor and displays the result*/
                foreach (int element in intList)
                {
                    int result = element;
                    result = result / divisor;
                    Console.WriteLine(element + " / " + divisor + " = " + result);
                }
            }
            /*gives an error message if the wrong type of input is given (such as a string)*/
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            /*gives an error message if the user inputs zero and it tries to divide by zero*/
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero, we don't what will happen if you do, the universe might break");
            }
            /*any other exception not explicitly listed*/
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*performs this regardless of what exception occurs; in this case, we want to be able to read the error message
             * before the console window closes, so we use the Read command*/
            finally
            {
                Console.WriteLine("Program has finished the try/catch block");
                Console.Read();
            }
        }
    }
}
