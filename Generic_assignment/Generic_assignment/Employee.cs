using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_assignment
{
    /*class that is inherited from Person*/
    public class Employee<T> : Person
    {
        /*Properties*/
        public int Id { get; set; }
        public List<T> Things { get; set; }

        /*constructor for the inherited class*/
        public Employee(string fname, string lname, int ident, List<T> list) : base(fname, lname)
        {
            Id = ident;
            Things = list;
        }

        /*override for Person's SayName function, which displays the info of the person/employee*/
        public override void SayName()
        {
            /*displays the full name and employee ID*/
            base.SayName();
            Console.WriteLine("EMPLOYEE ID: " + Id);

            /*displays each element in the generic Things list*/
            for (int i = 0; i < Things.Count(); i++)
            {
                Console.WriteLine(Things[i]);
            }
            Console.WriteLine("\n");
        }
    }
}