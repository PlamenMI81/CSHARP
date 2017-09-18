using System;

namespace cleverLiliy
{
    class cleverLiliy
    {
        static void Main(string[] args)
        {
            int lillyAge = int.Parse(Console.ReadLine());
            double pricePeralnq = double.Parse(Console.ReadLine());
            int priceIgrachka = int.Parse(Console.ReadLine());
            int money = 0;
            int igrachkaCounter = 0;
            int moneyCounter = 0;
            int indexMoney=1;
            for (int i = 1; i <= lillyAge; i++)
            {
                if (i % 2 != 0)
                {
                    igrachkaCounter++;
                }
                else
                {
                    
                    money = money + indexMoney*10;
                    indexMoney++;
                    moneyCounter++;
                }
            }
            int soldIgrachki = igrachkaCounter * priceIgrachka;
            int savedMoney = soldIgrachki + money - moneyCounter;
            if (savedMoney >= pricePeralnq)
            {
                Console.WriteLine($"Yes! {savedMoney-pricePeralnq:f2}");
            }
            else
            {
                Console.WriteLine($"No! {pricePeralnq-savedMoney:f2}");
            }
        }
    }
}
