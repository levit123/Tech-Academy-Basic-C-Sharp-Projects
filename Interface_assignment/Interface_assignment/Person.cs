using System;

namespace Interface_assignment
{
    /*abstract base class*/
    public abstract class Person
    {
        /*properties*/
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /*constructor*/
        public Person(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        /*method that displays the person's full name*/
        public virtual void SayName()
        {
            Console.WriteLine("NAME: " + FirstName + " " + LastName);
        }
    }
}
