using System;
using System.Linq;

namespace _06_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            
            Console.WriteLine(string.Join(" ",numbers.Reverse()));
        }
    }
}
