using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_assignment
{
    class Program
    {
        static void Main()
        {
            string fname = "Sample";
            string lname = "Student";

            Employee emp1 = new Employee(fname, lname);

            emp1.SayName();

            Console.Read();
        }
    }
}
