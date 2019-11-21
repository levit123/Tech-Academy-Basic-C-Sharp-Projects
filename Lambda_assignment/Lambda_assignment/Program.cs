using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*creates and defines a list of employees*/
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee("Joe", "Swanson", 1));
            empList.Add(new Employee("Mayor", "Quimby", 3));
            empList.Add(new Employee("Adam", "West", 4));
            empList.Add(new Employee("Steven", "Griffin", 6));
            empList.Add(new Employee("Groundskeeper", "Willy", 8));
            empList.Add(new Employee("Joe", "Lamp", 2));
            empList.Add(new Employee("Liam", "Neeson", 7));
            empList.Add(new Employee("Homie", "Simp", 0));
            empList.Add(new Employee("Margarine", "Simp", 9));
            empList.Add(new Employee("Lizzy", "Simp", 5));

            /*creates an empty list of employees whose name is Joe*/
            List<Employee> joeList = new List<Employee>();
            
            /*copies each employee whose name is Joe to the joeList, by using a foreach loop*/
            foreach(Employee element in empList)
            {
                if (element.FirstName == "Joe")
                {
                    joeList.Add(element);
                }
            }

            /*displays each employee in joeList*/
            foreach(Employee element in joeList)
            {
                element.SayName();
            }

            /*spacing*/
            Console.WriteLine("\n");


            /*copies each employee whose name is Joe to the joeList2, by using a lambda expression*/
            List<Employee> joeList2 = empList.Where(x => x.FirstName == "Joe").ToList();

            /*displays each employee in joeList2*/
            foreach (Employee element in joeList2)
            {
                element.SayName();
            }

            /*spacing*/
            Console.WriteLine("\n");

            /*copies each employee with an ID greater than 5 to the fiveList, by using a lambda expression*/
            List<Employee> fiveList = empList.Where(x => x.Id > 5).ToList();

            /*displays each employee in fiveList*/
            foreach (Employee element in fiveList)
            {
                element.SayName();
            }

            Console.Read();
        }
    }
}
