using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        short numberOfSeq = short.Parse(Console.ReadLine());

        for (short i = 0; i < numberOfSeq; i++)
        {
            var numbers = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(short.Parse).ToList();
          
            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum == 0)
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