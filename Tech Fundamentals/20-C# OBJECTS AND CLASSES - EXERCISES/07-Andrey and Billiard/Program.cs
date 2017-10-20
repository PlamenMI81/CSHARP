using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace _07_Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numArticleInfo = int.Parse(Console.ReadLine());
            Dictionary<string, double> storeDatabase = new Dictionary<string, double>();
            for (int i = 0; i < numArticleInfo; i++)
            {
                ReadArticles(storeDatabase);
            }

            Dictionary<string, Dictionary<string, int>> customer = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var currentCustomer = Console.ReadLine().Split('-').ToArray();
                if (currentCustomer[0].Contains("end of clients"))
                {
                    break;
                }
                var customerName = currentCustomer[0];
                var articleArgs = currentCustomer[1].Split(',').ToArray();
                string article = articleArgs[0];
                int quantity = int.Parse(articleArgs[1]);
                FillCustomersOrders(customer, storeDatabase, customerName, article, quantity);
            }
        }

        private static void FillCustomersOrders(Dictionary<string, Dictionary<string, int>> customer, Dictionary<string, double> storeDatabase, string customerName, string article, int quantity)
        {


            if (storeDatabase.ContainsKey(article))
            {
                if (!customer.ContainsKey(customerName))
                {
                    customer.Add(customerName, new Dictionary<string, int>());
                    if (!customer[customerName].ContainsKey(article))
                    {
                        customer[customerName].Add(article, quantity);
                    }
                }
            }
        }


        private static void ReadArticles(Dictionary<string, double> storeDatabase)
        {
            string[] articleArgs =
                Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string article = articleArgs[0];
            double price = double.Parse(articleArgs[1]);
            if (!storeDatabase.ContainsKey(article))
            {
                storeDatabase.Add(article, price);
            }
            else
            {
                storeDatabase[article] = price;
            }

        }
    }
}
