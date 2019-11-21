using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*gets the current date and time*/
            DateTime current = DateTime.Now;

            /*user enters a number*/
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            /*creates a "DateTime" variable that is set for a number of hours past the current time, the number
             * of hours being the number the user entered*/
            DateTime untilThen = current.AddHours(input);

            /*displays the current time and the speficied future time*/
            Console.WriteLine("CURRENT: " + current);
            Console.WriteLine("TIME IN " + input + " HOURS: " + untilThen);

            Console.Read();
        }
    }
}
