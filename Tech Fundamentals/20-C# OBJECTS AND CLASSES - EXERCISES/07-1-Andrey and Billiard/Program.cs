using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_1_Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            var entities = new Dictionary<string, decimal>();

            int entitiesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < entitiesCount; i++)
            {
                var newEntity = Console.ReadLine().Split('-').ToArray();
                string entityName = newEntity[0];
                decimal entityPrise = decimal.Parse(newEntity[1]);

                if (!entities.ContainsKey(entityName))
                {
                    entities.Add(entityName, entityPrise);
                }
                else
                {
                    entities[entityName] = entityPrise;
                }
            }

            List<Customer> allCustomers = new List<Customer>();

            string command = Console.ReadLine();
            while (command != "end of clients")
            {
                string[] commandArgs = command.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (entities.ContainsKey(commandArgs[1]))
                {
                    string product = commandArgs[1];
                    int quantity = int.Parse(commandArgs[2]);
                    decimal spent = decimal.Parse(commandArgs[2]) * entities[product];

                    Customer currentCustomer = new Customer();
                    currentCustomer.Name = commandArgs[0];
                    currentCustomer.ProductQuantity = new Dictionary<string, int>();
                    currentCustomer.ProductQuantity.Add(product, quantity);
                    currentCustomer.Bill = spent;

                    allCustomers.Add(currentCustomer);
                }

                command = Console.ReadLine();
                
            }

            decimal totalBill = 0;
            foreach (var customer in allCustomers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.ProductQuantity)
                {
                    Console.WriteLine("-- {0} - {1}",
                        product.Key, product.Value);
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);
                totalBill += customer.Bill;
            }
            Console.WriteLine("Total bill: {0:f2}", totalBill);

        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductQuantity { get; set; }
        public decimal Bill { get; set; }
    }
}
