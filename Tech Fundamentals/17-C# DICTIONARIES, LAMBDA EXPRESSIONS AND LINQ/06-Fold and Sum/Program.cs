using System;
using System.Linq;

namespace _06_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = integers.Length / 4;
            var leftSide = integers.Take(k).Reverse().ToArray();
            var rightSide = integers.Skip(3 * k).Take(k).Reverse().ToArray();
            var upRow = leftSide.Concat(rightSide).ToArray();
            var middlePart = integers.Skip(k).Take(2 * k).ToArray();
            var sumArr = upRow.Select((x, index) => x + middlePart[index]);
            Console.WriteLine(string.Join(" ",sumArr));

        }
    }
}
