using System;

namespace problem62
{ //Стопиращо число
    internal class Program
    {
        private static void Main(string[] args)
        {
            int fromNum = int.Parse(Console.ReadLine());
            int toNum = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            for (int i = toNum; i >= fromNum; i--)
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == stop)
                        return;
                    Console.Write($"{i} ");
                }
            Console.WriteLine();
        }
    }
}