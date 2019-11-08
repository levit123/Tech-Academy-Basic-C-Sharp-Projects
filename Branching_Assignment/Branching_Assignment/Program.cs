using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            
            /*user enters package weight*/
            Console.Write("\nEnter the weight of the package in pounds: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            /*if the weight is greater than 50, display an error message and end the program*/
            if (weight > 50)
            {
                Console.WriteLine("\nThe package is too heavy to be shipped via Package Express. Have a good day.");
            }
            /*otherwise, continue with the rest of the program*/
            else
            {
                /*user enters package width, height, and length*/
                Console.Write("\nEnter the package width in inches: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the package height in inches: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the package length in inches: ");
                int length = Convert.ToInt32(Console.ReadLine());

                /*calculates the sum of the package dimensions*/
                int sumDimensions = width + height + length;
                
                /*if the sum of the dimensions is over 50, display an error message and end the program*/
                if (sumDimensions > 50)
                {
                    Console.WriteLine("\nThe package is too big to be shipped via Package Express. Have a good day.");
                }
                /*otherwise, continue with the rest of the program*/
                else
                {
                    /*calculates the cost to ship the package*/
                    float cost = (sumDimensions * weight) / 100;
                    Console.WriteLine("\nEstimated cost to ship: $" + cost);
                }
            }

            Console.Read();
        }
    }
}
