using System;

using System.IO;

namespace IO_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*user enters a number*/
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            /*converts number to a string so it can be saved to a text file*/
            string text = Convert.ToString(input);

            /*adds the "text" string to a new .txt document in the specified directory*/
            File.WriteAllText(@"C:\Users\Owner\Desktop\log.txt", text);

            /*displays the contents of the text file*/
            Console.WriteLine(File.ReadAllText(@"C:\Users\Owner\Desktop\log.txt"));

            Console.Read();
        }
    }
}
