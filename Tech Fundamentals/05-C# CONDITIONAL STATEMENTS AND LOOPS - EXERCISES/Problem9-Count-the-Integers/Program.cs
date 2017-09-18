using System;

namespace Problem9_Count_the_Integers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int countInt = 0;
            while (true)
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    countInt++;
                }
                catch (Exception)
                {
                    Console.WriteLine(countInt);
                    break;
                }
        }
    }
}