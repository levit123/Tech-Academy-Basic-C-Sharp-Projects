using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2_assignment
{
    class Program
    {
        static void Main()
        {
            string fname = "Sample";
            string lname = "Student";

            /*creates an object of class Employee, which is derived from Person*/
            Employee emp1 = new Employee(fname, lname);

            emp1.SayName();

            Console.Read();
        }
    }
}
