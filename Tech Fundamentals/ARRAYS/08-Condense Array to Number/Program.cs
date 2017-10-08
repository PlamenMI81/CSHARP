using System;
using System.Linq;

namespace _08_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stringInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (stringInput.Length>0)
            {
                int[] condensed=new int[stringInput.Length-1];
                for (int i = 0; i < stringInput.Length-1; i++)
                {
                    condensed[i] = stringInput[i] + stringInput[i + 1];
                }

                //How ------>  stringInput[] = condensed[]



                foreach (int i in condensed)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
