using System;
using System.Linq;

namespace _01_Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var min = input.Min();
            var max = input.Max();
            var sum = input.Sum();
            var aver = input.Average();

            Console.WriteLine($@"Min = {min}
Max = {max}
Sum = {sum}
Average = {aver}");
        }
    }
}
