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

            string[] manipulation = Console.ReadLine()
                .ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string operation = manipulation[0];

            while (operation != "print")
            {
                switch (operation)
                {
                    case "add": AddElementToIndex(sequence, manipulation[1], manipulation[2]); break;
                    case "addmany": AddMany(sequence, manipulation); break;
                    case "contains": PrintIndexOfGivenElement(sequence, manipulation[1]); break;
                    case "remove": RemoveElementAtIndex(sequence, manipulation[1]); break;
                    case "shift": ShiftArreyLeft(sequence, manipulation[1]); break;
                    case "sumpairs": sequence= SumPairs(sequence); break;

                }
                manipulation = Console.ReadLine()
                    .ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                operation = manipulation[0];
            }
            PrintArray(sequence);
        }

        private static List<int> SumPairs(List<int> sequence)
        {
            List<int> temp=new List<int>();
            if (sequence.Count%2==0)
            {
                for (int i = 0; i < sequence.Count - 1; i += 2)
                {
                    temp.Add(sequence[i] + sequence[i + 1]);
                }
            }else
            {
                for (int i = 0; i < sequence.Count - 1; i += 2)
                {
                    temp.Add(sequence[i] + sequence[i + 1]);
                }
                temp.Add(sequence[sequence.Count - 1]);
            }
            sequence = temp;
            return sequence;
        }

        private static void ShiftArreyLeft(List<int> sequence, string s)
        {
            int positions = int.Parse(s);
            int[] temp = new int[positions];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = sequence[i];
            }
            sequence.RemoveRange(0, positions);
            sequence.AddRange(temp);

        }

        private static void AddMany(List<int> sequence, string[] manipulation)
        {
            int index = int.Parse(manipulation[1]);
            var range = manipulation.Skip(2).Select(int.Parse).ToArray();
            sequence.InsertRange(index, range);
        }

        private static void RemoveElementAtIndex(List<int> sequence, string s)
        {
            int index = int.Parse(s);
            sequence.RemoveAt(index);
        }

        private static void PrintIndexOfGivenElement(List<int> sequence, string s)
        {
            int digit = int.Parse(s);
            if (sequence.Contains(digit))
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == digit)
                    {
                        //Console.WriteLine(string.Join("", (sequence.Where(x => digit == sequence[x]))));
                        Console.WriteLine(i); break;
                    }
                }
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        private static void AddElementToIndex(List<int> sequence, string s, string sign)
        {
            int index = int.Parse(s);
            int digit = int.Parse(sign);
            sequence.Insert(index, digit);
        }

        private static void PrintArray(List<int> sequence)
        {
            Console.WriteLine($"[{string.Join(", ", sequence)}]");
        }
    }
}
