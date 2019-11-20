using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the current day of the week: ");
            string input;
            Days currentDay;

            try
            {
                /*user enters a day of the week as a string*/
                input = Console.ReadLine();

                /*converts user-defined string to it's equivalent "Days" enum value, declares an instance of the "Days" enum, and sets
                 * the instance to the result of the conversion. Basically, converts a string to an enum*/
                currentDay = (Days)Enum.Parse(typeof(Days), input);

                Console.WriteLine("Current Day: " + currentDay);
            }
            /*displays an error message if the user enters something other than a day of the week*/
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            Console.Read();
        }
    }

    public enum Days
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }
}
