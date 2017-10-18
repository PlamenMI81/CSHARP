using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> resources=new Dictionary<string, int>();
            resources.Add("aaaa",1111);
            resources.Add("bbbb",2222);
            resources.Add("cccc",3333);
            resources.Add("eeee",8888);
            resources.Add("gggg",3333);

            var finalResources = resources.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var kvp in finalResources)
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);

        }
    }
}
