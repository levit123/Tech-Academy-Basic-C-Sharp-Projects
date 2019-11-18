using System;

namespace Inheritance_assignment
{
    public class Employee : Person
    {
        /*constructor that defines properties of inherited class*/
        public Employee(string fname, string lname) : base(fname, lname)
        {
        }

        /*properties*/
        public int Id { get; set; }
    }
}
