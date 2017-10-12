using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string[] command = Console.ReadLine()
                .ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (true)
            {
                if (command.Contains("delete"))
                {
                    int arg = int.Parse(command[1]);
                    inputNumbers.RemoveAll(item => item == arg);
                }
                else if (command.Contains("insert"))
                {
                    int argElement = int.Parse(command[1]);
                    int argPosition = int.Parse(command[2]);
                    inputNumbers.Insert(argPosition, argElement);
                }
                else if (command.Contains("odd"))
                {
                    Console.WriteLine(string.Join(" ", inputNumbers.Where(item => item % 2 != 0)));
                    break;
                    
                }else if (command.Contains("even"))
                {
                    Console.WriteLine(string.Join(" ", inputNumbers.Where(item => item % 2 == 0)));
                    break;
                }
                command = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
