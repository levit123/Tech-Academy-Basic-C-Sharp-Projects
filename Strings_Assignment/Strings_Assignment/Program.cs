using System;
using System.Text;

namespace Strings_Assignment
{
    class Program
    {
        static void Main()
        {
            /*creates 3 strings and concatenates them*/
            string str1 = "These";
            string str2 = "are";
            string str3 = "words";
            string fullSentence = str1 + " " + str2 + " " + str3;
            Console.WriteLine(fullSentence);

            /*spacing*/
            Console.WriteLine("\n");

            /*converts a string to upper case*/
            str3 = str3.ToUpper();
            Console.WriteLine(str3);

            /*spacing*/
            Console.WriteLine("\n");

            /*stringbuilder*/
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append("\"You're just gonna get older and harder and more alone.\n");
            strBuild.Append("And one day, you're gonna look around and realize that everybody loves you.\n");
            strBuild.Append("But nobody likes you.\n");
            strBuild.Append("And that is the loneliest feeling in the world.\"\n");
            strBuild.Append("- Bojack Horseman");

            Console.WriteLine(strBuild);

            Console.Read();
        }
    }
}
