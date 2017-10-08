using System;
using System.Linq;

namespace _09_Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stringInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = stringInput.Length;
            if (length==1)
            {
                Console.WriteLine(stringInput[0]);
            }else if (length%2==0)
            {
                Console.WriteLine($"{{ {stringInput[length/2-1]} }}, {{ {stringInput[length/2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {stringInput[length / 2 - 1]} }}, {{ {stringInput[length / 2]} }}, {{ {stringInput[length / 2+1]} }}");
            }
        }
    }
}
