using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*creates and defines strings for first employee*/
            string fname1 = "Jimmy";
            string lname1 = "TwoFeet";
            /*creates and defines strings for second employee*/
            string fname2 = "Johnny";
            string lname2 = "LooseLips";

            Employee emp1 = new Employee(fname1, lname1, 101);
            Employee emp2 = new Employee(fname2, lname2, 101);

            emp1.SayName();
            emp2.SayName();

            Console.WriteLine("\n");

            if (emp1 == emp2)
            {
                Console.Write("Employee 1 and Employee 2 have the same ID number of: " + emp1.Id);
            }
            else if (emp1 != emp2)
            {
                Console.WriteLine("Employee 1 and 2 do NOT have the same ID number; They have ID numbers of: " + emp1.Id + " and " + emp2.Id);
            }

            Console.Read();
        }
    }
}
