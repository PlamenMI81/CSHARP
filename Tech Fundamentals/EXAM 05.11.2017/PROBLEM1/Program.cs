using System;
using System.Collections.Generic;

namespace PROBLEM1
{
    class Program
    {
        static void Main()
        {
            {
                int numOfWebsites = int.Parse(Console.ReadLine());
                int securityKey = int.Parse(Console.ReadLine());
                List<string> sites = new List<string>();
                decimal siteLoss = 0;
                decimal totallLoss = 0;
                for (int i = 0; i < numOfWebsites; i++)
                {
                    var input = Console.ReadLine().Split();
                    var siteName = input[0];
                    var siteVisits = int.Parse(input[1]);
                    var siteCommercialprice = decimal.Parse(input[2]);
                    siteLoss = (siteVisits * siteCommercialprice);
                    totallLoss += siteLoss;
                    sites.Add(siteName);
                }
                decimal secTocen = (decimal) Math.Pow(securityKey, numOfWebsites);
                Console.WriteLine(string.Join("\n", sites));
                Console.WriteLine($"Total Loss: {totallLoss:f20}");
                Console.WriteLine($"Security Token: {secTocen}");
            }
        }
    }
}