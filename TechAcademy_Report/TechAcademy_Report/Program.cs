/***************************************************************
 * TECH ACADEMY EXERCISE/ASSIGNMENT
 * gives a daily report for students of The Tech Academy.
 * user inputs answers to the following questions and the
 * answers are saved to variables:
 *      1: What course are you on?
 *      2: What page number are you on?
 *      3: Do you need help with anything? "true" or "false"
 *      4: were there any positive experiences you'd like to
 *          share? Be specific.
 *      5: Is there any other feedback you'd like to provide?
 *          Be specific.
 *      6: How many hours did you study today?
 **************************************************************/
using System;

namespace TechAcademy_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\n" +
                "Student Daily Report\n" +
                "========================================\n");
            /*question 1*/
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            /*question 2*/
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();

            /*question 3*/
            Console.WriteLine("Do you need help with anything? Enter \"true\" or \"false\"");
            string help = Console.ReadLine();
            
            bool needHelp;

            /*sets the boolean value to it's equivalent in the string that the user input into*/
            switch (help)
            {
                /*if string is "true", set boolean to true*/
                case "true":
                    needHelp = true;
                    break;
                /*if string is "false", set boolean to false*/
                case "false":
                    needHelp = false;
                    break;
                /*if string is neither "true" or "false", defaults boolean to false*/
                default:
                    Console.WriteLine("Error! Invalid input, assuming answer is \"false\"");
                    needHelp = false;
                    break;
            }

            /*question 4*/
            Console.WriteLine("Were there any experiences you'd like to share? Be specific");
            string experiences = Console.ReadLine();

            /*question 5*/
            Console.WriteLine("Is there any feedback you'd like to provide? Be specific");
            string feedback = Console.ReadLine();

            /*question 6*/
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();

            /*outputs all the users answers*/
            Console.WriteLine("\nYOUR ANSWERS\n" +
                "===================================\n" +
                "COURSE: " + courseName + "\n" +
                "PAGE NUMBER: " + pageNumber + "\n" +
                "NEED HELP: " + needHelp + "\n" +
                "EXPERIENCES: " + experiences + "\n" +
                "FEEDBACK: " + feedback + "\n" +
                "HOURS STUDIED: " + hours + "\n");

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
