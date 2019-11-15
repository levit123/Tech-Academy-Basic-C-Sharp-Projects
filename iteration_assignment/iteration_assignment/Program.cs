using System;
using System.Collections.Generic;

namespace iteration_assignment
{
    class Program
    {
        static void Main()
        {
            /*creates and defines an array of strings*/
            string[] strArray = new string[3];
            strArray[0] = "Pope";
            strArray[1] = "Bishop";
            strArray[2] = "Priest";
            
            /*user inputs a series of strings*/
            /*uses the < operator as the comparison*/
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write("Enter a string: ");
                strArray[i] = strArray[i] + Console.ReadLine();
                
            }

            /*infinite loop
            for (int i = 0; i < 1;)
            {
                Console.WriteLine("It goes on and on and on and on");
            }

            to terminate the loop above, we would have to add the part of the "for" loop that adjusts the counter, "i", each iteration.
            example:
            for (int i = 0; i < 1; i++)
            */

            /*spacing*/
            Console.WriteLine("\n");

            /*displays each string in the array*/
            /*uses the <= operator as the comparison*/
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(strArray[i]);
            }

            /*spacing*/
            Console.WriteLine("\n");

            /*creates a list of strings and defines the entries*/
            List<string> strList = new List<string>();
            strList.Add("Jamie");
            strList.Add("Levi");
            strList.Add("Alex");
            strList.Add("John");
            strList.Add("Jill");

            /*user enters a string to search the list for*/
            Console.Write("Enter a string to search for: ");
            string input = Console.ReadLine();

            /*spacing*/
            Console.WriteLine("\n");

            /*searches the list for the user-defined string*/
            int index = 0;
            for (index = 0; index < 5; index++)
            {
                if (strList[index] == input)
                {
                    Console.WriteLine("SUCCESS: Found string \"" + input + "\" at index " + index + " in the list");
                    break;
                }
            }
            if (index >= 5)
            {
                Console.WriteLine("ERROR: " + input + " is not in the list");
            }

            /*spacing*/
            Console.WriteLine("\n");

            /*creates and defines a list of strings with at least two identical strings*/
            List<string> strList2 = new List<string>();
            strList2.Add("Penguin");
            strList2.Add("Potato");
            strList2.Add("Waffle");
            strList2.Add("Potato");

            /*displays each entry in the list*/
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(strList2[i]);
            }

            /*spacing*/
            Console.WriteLine("\n");

            /*user enters a string to search the list for*/
            Console.Write("Enter a string from the above list to search for: ");
            input = Console.ReadLine();

            /*spacing*/
            Console.WriteLine("\n");

            /*searches the list for the user-defined string*/
            bool matchFound = false;
            for (int i = 0; i < 4; i++)
            {
                if (strList2[i] == input)
                {
                    Console.WriteLine("SUCCESS: Found string \"" + input + "\" at index " + i + " in the list");
                    matchFound = true;
                }
            }
            if (matchFound == false)
            {
                Console.WriteLine("ERROR: " + input + " is not in the list");
            }

            /*spacing*/
            Console.WriteLine("\n");

            /*creates and defines a list of strings with at least two identical strings*/
            List<string> strList3 = new List<string>();
            strList3.Add("Penguin");
            strList3.Add("Potato");
            strList3.Add("Penguin");
            strList3.Add("Waffle");
            strList3.Add("Penguin");

            /*functions as a counter*/
            int count = -1;

            /*iterates through the list and says whether or not the current item in the list is in an earlier entry in the list*/
            foreach (string element in strList3)
            {
                int i;
                for (i = 0; i <= count; i++)
                {
                    if (strList3[i] == element)
                    {
                        Console.WriteLine(element + " has appeared before in this list");
                        break;
                    }
                }
                if (i > count)
                {
                    Console.WriteLine(element + " has not appeared before in this list");
                }
                count++;
            }

            Console.Read();
        }
    }
}
