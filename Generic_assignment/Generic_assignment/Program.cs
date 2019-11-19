using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_assignment
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

            /*creates a list of strings to pass to an employee*/
            List<string> strList = new List<string> { "Limp", "Left foot", "Stumble" };
            /*creates an employee with string as the generic type*/
            Employee<string> emp1 = new Employee<string>(fname1, lname1, 101, strList);
            
            /*creates a list of integers to pass to an employee*/
            List<int> intList = new List<int> { 3, 5, 7, 1, 8 };
            /*creates an employee with integer as the generic type*/
            Employee<int> emp2 = new Employee<int>(fname2, lname2, 102, intList);

            emp1.SayName();
            emp2.SayName();

            Console.Read();
        }
    }
}
