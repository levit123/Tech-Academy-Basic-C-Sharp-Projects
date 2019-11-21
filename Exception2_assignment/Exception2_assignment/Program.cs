using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception2_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*user enters their age*/
                Console.Write("Enter your age as a number: ");
                int age = Convert.ToInt32(Console.ReadLine());

                /*throws an exception if the user enters 0*/
                if (age == 0)
                {
                    throw new ArgumentException();
                }
                /*throws an exception if the user enters a negative number*/
                if (age < 0)
                {
                    throw new ArgumentException();
                }

                /*calculates the year the user was born*/
                int yearBorn = 2019 - age;

                Console.WriteLine("You were born in the year: " + yearBorn);
            }
            /*specific exceptions*/
            catch (ArgumentException ex)
            {
                Console.WriteLine("ERROR: age cannot be a negative number or zero");
            }
            /*generic exception*/
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message); 
            }

            Console.Read();
        }
    }
}
