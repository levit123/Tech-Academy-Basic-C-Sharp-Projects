using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_assignment
{
    class Program
    {
        static void Main()
        {
            string fname = "Sample";
            string lname = "Employee";

            Employee emp1 = new Employee(fname, lname);

            emp1.SayName();

            emp1.Quit();

            Console.Read();
        }
    }
}
