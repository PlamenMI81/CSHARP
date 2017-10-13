using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] commandsSecondRow = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> resultArr= new List<int>();
            for (int j = 0; j < commandsSecondRow[0]; j++)
            {
                resultArr.Add(inputNumbers[j]);
            }
            int removeSymbol = resultArr[commandsSecondRow[1]-1];
            resultArr.RemoveAll(item => item == removeSymbol);
            Console.WriteLine(resultArr.Contains(commandsSecondRow[2]) ? "YES!" : "NO!");
        }
    }
}
