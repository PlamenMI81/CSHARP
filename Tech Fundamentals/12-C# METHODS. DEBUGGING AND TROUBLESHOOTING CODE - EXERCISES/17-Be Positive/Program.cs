using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        byte countSequences = byte.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] currentSequence = Console.ReadLine().Trim().Split(' ');
            var numbers = new List<int>();

            for (int j = 0; j < currentSequence.Length; j++)
            {
                if (!currentSequence[j].Equals(string.Empty))
                {
                    int num = int.Parse(currentSequence[j]);
                    numbers.Add(num);
                }
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else
                {
                    if (j!=numbers.Count-1)
                    {
                        currentNum += numbers[j + 1];
                    }
                    

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    j++;
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            Console.WriteLine();
        }
        
    }
}