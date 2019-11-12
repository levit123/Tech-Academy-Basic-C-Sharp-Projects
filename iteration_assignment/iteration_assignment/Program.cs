using System;
using System.Collections.Generic;

namespace iteration_assignment
{
    class Program
    {
        static void Main()
        {
            /*creates an empty array of strings*/
            string[] strArray = new string[3];
            /*user defines each string in the array*/
            /*uses the < operator as the comparison*/
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write("Enter a string: ");
                strArray[i] = Console.ReadLine();
            }

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
            for (int i = 0; i < 5; i++)
            {
                if (strList[i] == input)
                {
                    Console.WriteLine("SUCCESS: Found string \"" + input + "\" at index " + i + " in the list");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR: Did not find string \"" + input + "\" at index " + i + " in the list");
                }
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
            for (int i = 0; i < 4; i++)
            {
                if (strList2[i] == input)
                {
                    Console.WriteLine("SUCCESS: Found string \"" + input + "\" at index " + i + " in the list");
                }
                else
                {
                    Console.WriteLine("ERROR: Did not find string \"" + input + "\" at index " + i + " in the list.");
                }
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
            int count = 0;

            /*iterates through the list and says whether or not the current item in the list is in an earlier entry in the list*/
            foreach (string element in strList3)
            {
                /*goes through the previous items in the list up to the current item in the foreach loop (marked as "element"), and compares the previous
                 * items in the list to the current item to see if the current item has been found earlier in the list*/
                for (int i = 0; i < count; i++)
                {
                    if (strList3[i] == element)
                    {
                        Console.WriteLine(element + " has appeared before in this list");
                    }
                }
                count++;
            }

            Console.Read();
        }
    }
}
