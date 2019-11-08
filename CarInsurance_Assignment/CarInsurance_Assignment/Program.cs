using System;

namespace CarInsurance_Assignment
{
    class Program
    {
        static void Main()
        {
            /*gets the users age, if they had a DUI, and how many speeding tickets they have*/
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter \"yes\" or \"no\"");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            /*determines if the user qualifies for car insurance and displays the result*/
            bool qualify = (age > 15 && dui != "yes" && tickets <= 3);
            Console.WriteLine("Do you qualify for car insurance? " + qualify);

            Console.Read();
        }
    }
}
