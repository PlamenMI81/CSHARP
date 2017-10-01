using System;

namespace _05_Boolean_Variable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool strBool = Convert.ToBoolean(str);
            Console.WriteLine(strBool ? "Yes" : "No");
        }
    }
}