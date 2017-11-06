using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROBLEM2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split().ToList();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "3:1")
                {
                    break;
                }
                var commArgs = command.Split();
                if (commArgs[0] == "merge")
                {
                    var startIndex = int.Parse(commArgs[1]);
                    var endIndex = int.Parse(commArgs[2]);
                    var currentString = "";
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > inputLine.Count - 1)
                    {
                        continue;
                    }
                    if (endIndex > inputLine.Count - 1)
                    {
                        endIndex = inputLine.Count - 1;
                    }
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        currentString = string.Concat(currentString, inputLine[i]);
                    }
                    inputLine.RemoveRange(startIndex, endIndex - startIndex + 1);
                    inputLine.Insert(startIndex, currentString);

                }
                if (commArgs[0] == "divide")
                {
                    var index = int.Parse(commArgs[1]);
                    var partitions = int.Parse(commArgs[2]);
                    var currentString = inputLine[index];
                    inputLine.RemoveAt(index);
                    if (currentString.Length % partitions == 0)
                    {
                        for (int i = 0; i < index; i=currentString.Length/partitions)
                        {
                            var slice=(currentString.Substring(0, currentString.Length / partitions));
                            currentString=currentString.Remove(0, currentString.Length / partitions);
                            inputLine.Insert(index+i,slice);
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
