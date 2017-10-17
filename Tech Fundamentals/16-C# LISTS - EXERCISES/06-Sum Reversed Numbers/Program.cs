using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Lists
{
    static void Main()
    {
        List<string> nums = Console.ReadLine().Split().ToList();
        List<int> reversed = new List<int>();

        for (int i = 0; i < nums.Count; i++)
        {
            string currentElement = nums[i];
            string reversedElement = reverseTheString(currentElement);
            int num = int.Parse(reversedElement);
            reversed.Add(num);
        }
        Console.WriteLine(reversed.Sum());
    }

    private static string reverseTheString(string number)
    {
        //char[] arr = number.ToCharArray();
        char[] reversed = number.Reverse().ToArray();
        string reversedElement = string.Join("", reversed);
        return reversedElement;
    }
}