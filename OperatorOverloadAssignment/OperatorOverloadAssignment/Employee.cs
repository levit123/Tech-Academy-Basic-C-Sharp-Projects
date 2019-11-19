using System;

namespace OperatorOverloadAssignment
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

        /*override for Person's SayName function, which displays the full name of the person/employee*/
        public override void SayName()
        {
            base.SayName();
            Console.WriteLine("EMPLOYEE ID: " + Id + "\n");
        }

        /*overloads the == operator to compare two employees by Id number*/
        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool result;

            if (employee1.Id == employee2.Id)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        /*overloads the != to compare two employees by Id number*/
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool result;

            if (employee1.Id != employee2.Id)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}