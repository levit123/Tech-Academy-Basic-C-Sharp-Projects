using System;

namespace Income_Comparison_Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ANONYMOUS INCOME COMPARISON PROGRAM\n" +
                "======================================================\n");

            /*gets info for person 1*/
            Console.WriteLine("PERSON 1\n" +
                "===============");
            Console.Write("Enter hourly earning rate: ");
            double person1Rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hours worked per week: ");
            double person1Hours = Convert.ToDouble(Console.ReadLine());

            /*gets info for person 2*/
            Console.WriteLine("\nPERSON 2\n" +
                "===============");
            Console.Write("Enter hourly earning rate: ");
            double person2Rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hours worked per week: ");
            double person2Hours = Convert.ToDouble(Console.ReadLine());

            /*calculates their weekly salary*/
            double person1Salary = person1Rate * person1Hours;
            double person2Salary = person2Rate * person2Hours;

            Console.WriteLine("Weekly salary of person 1: " + person1Salary);
            Console.WriteLine("Weekly salary of person 2: " + person2Salary);

            bool person1More = person1Salary > person2Salary;
            Console.WriteLine("Does person 1 make more money than person 2? " + person1More);

            Console.Read();
        }
    }
}
