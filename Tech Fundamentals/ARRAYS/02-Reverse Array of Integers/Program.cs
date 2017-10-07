using System;

namespace _02_Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers =int.Parse(Console.ReadLine());
            int[] numbers=new int[countOfNumbers];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] =int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
