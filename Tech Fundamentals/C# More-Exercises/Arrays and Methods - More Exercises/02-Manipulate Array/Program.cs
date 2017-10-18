using System;
using System.Linq;

namespace _02_Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string commandStr = Console.ReadLine();
            while (commandStr!="END")
            {
                var command = commandStr.Split();
                if (command[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                else if (command[0] == "Distinct")
                {
                    var distArr = input.Distinct().ToArray();
                    input = distArr;

                }
                else if (command[0] == "Replace")
                {
                    var indexToReplace = int.Parse(command[1]);
                    var replaceWith = command[2];
                    if (indexToReplace<0 || indexToReplace>=input.Length)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        input[indexToReplace] = replaceWith;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                commandStr = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
