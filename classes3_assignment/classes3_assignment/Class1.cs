using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace classes3_assignment
{
	class Class1
	{
        /*methods*/
        /*takes an int and divides it by 2 and returns the result*/
        public int Halve(int num)
        {
            int result = num / 2;
            return result;
        }

        /*takes a decimal, doubles it, and returns the result*/
        public int Double(decimal num)
        {
            int result = (int)num * 2;
            return result;
        }

        /*takes a string, converts it to an integer (if possible), multiplies it by itself, and returns the result*/
        public int Square(string str)
        {
            try
            {
                int num = Convert.ToInt32(str);
                num = num * num;
                return num;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
	}
}
