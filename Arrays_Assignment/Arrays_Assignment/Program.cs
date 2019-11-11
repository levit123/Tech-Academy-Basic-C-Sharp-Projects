using System;
using System.Collections.Generic;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main()
        {
            /*creates an array of strings*/
            string[] strArray = new string[5];
            strArray[0] = "word";
            strArray[1] = "pope";
            strArray[2] = "potato";
            strArray[3] = "waffle";
            strArray[4] = "penguin";

            /*user enters a number for the index of the array to display*/
            Console.Write("Insert a number between 1 and 5: ");
            int index = Convert.ToInt32(Console.ReadLine());

            /*if user-defined index is not between 1 and 5, gives an error message*/
            if (index > 5 || index < 1)
            {
                Console.WriteLine("Error! Invalid index number, must be from 1 to 5");
            }
            /*otherwise, displays the corresponding entry in the array*/
            else
            {
                Console.WriteLine(strArray[index - 1]);
            }    

            /*creates an array of integers*/
            int[] intArray = new int[5];
            intArray[0] = 1;
            intArray[1] = 5;
            intArray[2] = 17;
            intArray[3] = 21;
            intArray[4] = 58;

            /*resets the index variable*/
            index = 0;

            /*user enters a number for the index of the array to display*/
            Console.Write("Insert a number between 1 and 5: ");
            index = Convert.ToInt32(Console.ReadLine());

            /*if user-defined index is not between 1 and 5, gives an error message*/
            if (index > 5 || index < 1)
            {
                Console.WriteLine("Error! Invalid index number, must be from 1 to 5");
            }
            /*otherwise, displays the corresponding entry in the array*/
            else
            {
                Console.WriteLine(intArray[index - 1]);
            }

            /*creates a list of strings*/
            List<string> strList = new List<string>();
            strList.Add("These");
            strList.Add("are");
            strList.Add("words");
            strList.Add("in");
            strList.Add("a");
            strList.Add("list");

            /*resets the index variable*/
            index = 0;

            /*user enters a number for the index of the list to display*/
            Console.Write("Insert a number between 1 and 6: ");
            index = Convert.ToInt32(Console.ReadLine());

            /*if user-defined index is not between 1 and 6, gives an error message*/
            if (index > 6 || index < 1)
            {
                Console.WriteLine("Error! Invalid index number, must be from 1 to 6");
            }
            /*otherwise, displays the corresponding entry in the list*/
            else
            {
                Console.WriteLine(strList[index - 1]);
            }

            Console.Read();
        }
    }
}
