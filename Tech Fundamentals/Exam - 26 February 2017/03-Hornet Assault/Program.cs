using System;
using System.Linq;

namespace _03_Hornet_Assault
{
    class Program
    {
        static void Main()
        {
            var beeHives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            for (int currHive = 0; currHive < beeHives.Count; currHive++)
            {
                long hornetPower = hornets.Sum();
                if (hornetPower==0)
                {
                    break;
                }
                if (beeHives[currHive]>hornetPower)
                {
                    hornets.RemoveAt(0);
                    beeHives[currHive] -= hornetPower;
                }
                else if(beeHives[currHive] == hornetPower)
                {
                    hornets.RemoveAt(0);
                    beeHives[currHive]=0;
                }
                else if(beeHives[currHive] < hornetPower)
                {
                    beeHives[currHive] = 0;
                }
            }
            long beeHiveSum = beeHives.Sum();
            if (beeHiveSum>0)
            {
                var beeHivesLive = beeHives.Where(x => x > 0).ToArray();
                Console.WriteLine(string.Join(" ",beeHivesLive));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
