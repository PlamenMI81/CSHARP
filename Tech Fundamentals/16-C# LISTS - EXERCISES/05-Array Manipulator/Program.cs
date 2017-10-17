using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            List<int> sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] manipulation = command
                    .ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string operation = manipulation[0];
                switch (operation)
                {
                    case "add": AddElementToIndex(sequence, int.Parse(manipulation[1]), int.Parse(manipulation[2])); break;
                    case "addmany": AddMany(sequence, manipulation); break;
                    case "contains": PrintIndexOfGivenElement(sequence, int.Parse(manipulation[1])); break;
                    case "remove": RemoveElementAtIndex(sequence, int.Parse(manipulation[1])); break;
                    case "shift": ShiftArreyLeft(sequence, int.Parse(manipulation[1])); break;
                    case "sumpairs": SumPairs(sequence); break;

                }
                command = Console.ReadLine();
            }
            PrintArray(sequence);
        }

        private static void SumPairs(List<int> sequence)
        {
            for (int i = 0; i < sequence.Count-1; i++)
            {
                var sum = sequence[i] + sequence[i + 1];
                sequence[i] = sum;
                sequence.RemoveAt(i+1);
            }
        }

        private static void ShiftArreyLeft(List<int> sequence, int positions)
        {
            positions = positions % sequence.Count;
            for (int i = 0; i < positions; i++)
            {
                sequence.Add(sequence[0]);
                sequence.RemoveAt(0);
            }
            //var rem = sequence.Take(positions).ToArray();
            //sequence.RemoveRange(0, positions);
            //sequence.AddRange(rem);

        }

        private static void AddMany(List<int> sequence, string[] manipulation)
        {
            int index = int.Parse(manipulation[1]);
            var range = manipulation.Skip(2).Select(int.Parse).ToArray();
            sequence.InsertRange(index, range);
        }

        private static void RemoveElementAtIndex(List<int> sequence, int index)
        {
            sequence.RemoveAt(index);
        }

        private static void PrintIndexOfGivenElement(List<int> sequence, int digit)
        {
            Console.WriteLine(sequence.IndexOf(digit));
        }

        private static void AddElementToIndex(List<int> sequence, int index, int digit)
        {
            sequence.Insert(index, digit);
        }

        private static void PrintArray(List<int> sequence)
        {
            Console.WriteLine($"[{string.Join(", ", sequence)}]");
        }
    }
}
