using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Var_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*declares a constant*/
            const string constantString = "Potato";

            /*user enters anything, and it is saved to the var*/
            Console.Write("Enter something here: ");
            var var1 = Console.ReadLine();

            /*creates a var and defines as the result of concatenating the constant and user-defined var together*/
            var result = constantString + var1;
            Console.WriteLine(result);

            /*creates an employee that uses the default constructor, which uses constructor chaining (see "Employee.cs")*/
            Employee emp1 = new Employee();
            emp1.SayName();

            Console.Read();
        }
    }
}
