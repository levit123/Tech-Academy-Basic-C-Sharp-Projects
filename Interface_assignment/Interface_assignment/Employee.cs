using System;

namespace Interface_assignment
{
    /*class that is inherited from Person*/
    public class Employee : Person, IQuittable
    {
        /*constructor for the inherited class*/
        public Employee(string fname, string lname) : base(fname, lname)
        {
        }

        public void Quit()
        {
            Console.Write("\nNow closing program. Press the \"Enter\" key to close...");
        }

        /*override for Person's SayName function, which displays the full name of the person/employee*/
        public override void SayName()
        {
            base.SayName();
        }
    }
}
