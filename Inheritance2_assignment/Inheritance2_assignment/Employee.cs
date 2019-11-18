using System;

namespace Inheritance2_assignment
{
    /*class that is inherited from Person*/
    public class Employee : Person
    {
        /*constructor for the inherited class*/
        public Employee(string fname, string lname) : base(fname, lname)
        {
        }

        /*override for Person's SayName function, which displays the full name of the person/employee*/
        public override void SayName()
        {
            base.SayName();
        }
    }
}
