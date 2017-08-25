using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softuniCamp
{
    class softuniCamp
    {
        static void Main(string[] args)
        {
            int countOfGroups = int.Parse(Console.ReadLine());
            double allPeople;
            int avtomobil = 0;
            int microbus = 0;
            int malakAvtobus = 0;
            int golqmAvtobus = 0;
            int vlak = 0;
            for (int i = 1; i <=countOfGroups; i++)
            {
                int countOfPeople = int.Parse(Console.ReadLine());
                

                if (countOfPeople<=5)
                {
                    avtomobil += countOfPeople;
                }else if (countOfPeople>=6 && countOfPeople<=12)
                {
                    microbus += countOfPeople;
                }
                else if (countOfPeople >= 13 && countOfPeople <= 25)
                {
                    malakAvtobus += countOfPeople;
                }
                else if (countOfPeople >= 26 && countOfPeople <= 40)
                {
                    golqmAvtobus += countOfPeople;
                }
                else if (countOfPeople >= 41 )
                {
                    vlak += countOfPeople;
                }
                
            }
            allPeople = avtomobil + microbus + malakAvtobus + golqmAvtobus + vlak;
            Console.WriteLine($"{avtomobil/allPeople*100:f2}%");
            Console.WriteLine($"{microbus / allPeople * 100:f2}%");
            Console.WriteLine($"{malakAvtobus / allPeople * 100:f2}%");
            Console.WriteLine($"{golqmAvtobus / allPeople * 100:f2}%");
            Console.WriteLine($"{vlak / allPeople * 100:f2}%");
            
        }
    }
}
