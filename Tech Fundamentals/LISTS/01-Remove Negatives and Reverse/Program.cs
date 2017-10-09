using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums=new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            List<int> result=new List<int>();
            for (int i = inputNums.Count-1; i >= 0; i--)
            {
                if (inputNums[i] >=0)
                {
                    result.Add(inputNums[i]);
                }
            }
            Console.WriteLine(result.Count > 0 ? string.Join(" ", result) : "empty");
        }
    }
}
