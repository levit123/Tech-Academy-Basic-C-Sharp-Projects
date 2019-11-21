using System;

namespace Var_exercise
{
    /*class that is inherited from Person*/
    public class Employee : Person
    {
        /*Properties*/
        public int Id { get; set; }

        /*default constructor; uses constructor chaining*/
        public Employee() : this("Sample", "Employee", 1)
        {
        }

        /*constructor for the Employee class*/
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