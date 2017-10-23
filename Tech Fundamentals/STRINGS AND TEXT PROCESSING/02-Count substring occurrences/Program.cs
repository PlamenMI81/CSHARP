using System;

namespace _02_Count_substring_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStrin = Console.ReadLine().ToLower();
            var strToFind= Console.ReadLine().ToLower();
            int count = 0;
            var index = inputStrin.IndexOf(strToFind);
            while (index!=-1)
            {
                count++;
                index = inputStrin.IndexOf(strToFind,index+1);
            }
            Console.WriteLine(count);
        }
    }
}
