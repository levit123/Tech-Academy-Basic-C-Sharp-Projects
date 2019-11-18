using System;

namespace Inheritance_assignment
{
	public class Person
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

        /*methods*/
        public void SayName()
        {
            Console.WriteLine("NAME: " + FirstName + " " + LastName);
        }
    }
}
