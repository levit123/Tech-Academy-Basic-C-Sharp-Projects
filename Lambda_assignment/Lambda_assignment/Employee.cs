using System;

namespace Lambda_assignment
{
    /*class that is inherited from Person*/
    public class Employee : Person
    {
        /*Properties*/
        public int Id { get; set; }

        /*constructor for the inherited class*/
        public Employee(string fname, string lname, int ident) : base(fname, lname)
        {
            Id = ident;
        }

        /*override for Person's SayName function, which displays the info of the person/employee*/
        public override void SayName()
        {
            /*displays the full name and employee ID*/
            base.SayName();
            Console.WriteLine("EMPLOYEE ID: " + Id);
        }
    }
}