using System;

namespace Loop_Assigment
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            bool condition = false;

            /*while boolean is set to false, perform the code in the loop*/
            /*increment the counter. if the counter is greater than 3, boolean is set to true, thus ending the loop*/
            while (condition == false)
            {
                Console.WriteLine("Counter: " + counter);
                counter++;
                condition = counter > 3;
                Console.ReadLine();
            }

            counter = 0;
            condition = false;

            /*increment the counter as long as the boolean is set to false*/
            /*when the counter is greater than 5, set the boolean to true, thus ending the loop*/
            do
            {
                Console.WriteLine("Counter: " + counter);
                counter++;
                condition = counter > 5;
                Console.ReadLine();
            }
            while (condition == false);
        }
    }
}
