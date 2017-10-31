using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                var command = Console.ReadLine();
                var commandArgs = command.Split();
                if (command == "end")
                {
                    break;
                }
                if (commandArgs[0] == "exchange")
                {
                    var index = int.Parse(commandArgs[1]);
                    inputArray = ExchangeArr(inputArray, index);
                }
                else if (commandArgs[0] == "max")
                {
                    var evenOrOdd = commandArgs[1];
                    IndexEvenOddMax(inputArray, evenOrOdd);
                }
                else if (commandArgs[0] == "min")
                {
                    var evenOrOdd = commandArgs[1];
                    IndexEvenOddMin(inputArray, evenOrOdd);
                }
                else if (commandArgs[0] == "first")
                {
                    var count = int.Parse(commandArgs[1]);
                    var evenOrOdd = commandArgs[2];
                    FirstEvenOdd(inputArray, count, evenOrOdd);
                }
                else if (commandArgs[0] == "last")
                {
                    var count = int.Parse(commandArgs[1]);
                    var evenOrOdd = commandArgs[2];
                    LastEvenOdd(inputArray, count, evenOrOdd);
                }
            }
            Console.Write("[");
            Console.Write(string.Join(", ", inputArray));
            Console.WriteLine("]");


        }

        private static void LastEvenOdd(List<int> inputArray, int count, string evenOrOdd)
        {
            if (count > inputArray.Count)
            {
                Console.WriteLine($"Invalid count");
            }
            else
            {
                if (evenOrOdd == "even")
                {
                    inputArray.Reverse();
                    var last = inputArray.Where(x => (x % 2) == 0).Take(count).ToList();
                    inputArray.Reverse();
                    last.Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", last));
                    Console.WriteLine("]");
                }
                if (evenOrOdd == "odd")
                {
                    inputArray.Reverse();
                    var last = inputArray.Where(x => (x % 2) != 0).Take(count).ToList();
                    inputArray.Reverse();
                    last.Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", last));
                    Console.WriteLine("]");
                }

            }
        }

        private static void FirstEvenOdd(List<int> inputArray, int count, string evenOrOdd)
        {
            if (count > inputArray.Count)
            {
                Console.WriteLine($"Invalid count");
            }
            else
            {
                if (evenOrOdd == "even")
                {
                    var first = inputArray.Where(x => (x % 2) == 0).Take(count).ToList();
                    Console.Write("[");
                    Console.Write(string.Join(", ", first));
                    Console.WriteLine("]");
                }
                if (evenOrOdd == "odd")
                {
                    var first = inputArray.Where(x => (x % 2) != 0).Take(count).ToList();
                    Console.Write("[");
                    Console.Write(string.Join(", ", first));
                    Console.WriteLine("]");
                }

            }
        }

        private static void IndexEvenOddMin(List<int> inputArray, string evenOrOdd)
        {
            var indexMinElement = 0;
            int min = 0;
            if (evenOrOdd == "even")
            {
                try
                {
                    min = inputArray.Where(x => (x % 2) == 0).Min();
                }
                catch (Exception)
                {
                    Console.WriteLine($"No matches");
                    return;
                }
                indexMinElement = inputArray.LastIndexOf(min);
                Console.WriteLine($"{indexMinElement}");
            }
            if (evenOrOdd == "odd")
            {
                try
                {
                    min = inputArray.Where(x => (x % 2) != 0).Min();
                }
                catch (Exception)
                {
                    Console.WriteLine($"No matches");
                    return;
                }
                indexMinElement = inputArray.LastIndexOf(min);
                Console.WriteLine($"{indexMinElement}");
            }
        }

        private static void IndexEvenOddMax(List<int> inputArray, string evenOrOdd)
        {
            var indexMaxElement = 0;
            int max = 0;
            if (evenOrOdd == "even")
            {
                try
                {
                    max = inputArray.Where(x => (x % 2) == 0).Max();
                }
                catch (Exception)
                {
                    Console.WriteLine($"No matches");
                    return;
                }
                indexMaxElement = inputArray.LastIndexOf(max);
                Console.WriteLine($"{indexMaxElement}");
            }

            if (evenOrOdd == "odd")
            {
                try
                {
                    max = inputArray.Where(x => (x % 2) != 0).Max();
                }
                catch (Exception)
                {
                    Console.WriteLine($"No matches");
                    return;
                }
                indexMaxElement = inputArray.LastIndexOf(max);
                Console.WriteLine($"{indexMaxElement}");
            }

        }

        public static List<int> ExchangeArr(List<int> inputArray, int index)
        {
            if (index > inputArray.Count - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
                return inputArray;
            }
            else
            {
                var subArr = inputArray.Take(index + 1).ToList();
                inputArray.RemoveRange(0, index + 1);
                inputArray.InsertRange(inputArray.Count, subArr);
                return inputArray;
            }
        }
    }
}
