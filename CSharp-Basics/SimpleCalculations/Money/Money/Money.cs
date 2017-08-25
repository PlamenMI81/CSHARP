using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            decimal yoans = decimal.Parse(Console.ReadLine());
            decimal comission = decimal.Parse(Console.ReadLine()) / 100.00m;

            decimal bitcoinToBgn = bitcoins * 1168;
            decimal yoansToUsd = yoans * 0.15m;
            decimal yoansToBgn = yoansToUsd * 1.76m;
            decimal sum = bitcoinToBgn + yoansToBgn;
            decimal sumToEur = (sum / 1.95m);
            sumToEur =sumToEur-(sumToEur*comission); //   <=>sumToEur -=(sumToEur*comission);

            Console.WriteLine("{0:f2}", sumToEur);

        }
    }
}
