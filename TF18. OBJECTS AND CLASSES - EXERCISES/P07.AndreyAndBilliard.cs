using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> barPrices = GetPrices();
            List<Customer> customers = GetCustomersOrders(barPrices);
            PrintBillsAndTotalProfit(customers);
        }

        static void PrintBillsAndTotalProfit(List<Customer> customers)
        {
            decimal TotalBill = 0;
            foreach (var customer in customers)
            {
                TotalBill += customer.Bill;
                Console.WriteLine(customer.Name);
                Console.WriteLine(string.Join("\r\n", customer.Order.Select(p => $"-- {p.Key} - {p.Value}")));
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {TotalBill:f2}");
        }

        static List<Customer> GetCustomersOrders(Dictionary<string, decimal> barPrices)
        {
            SortedDictionary<string, Customer> customers = new SortedDictionary<string, Customer>();
            string command = Console.ReadLine();

            while (command != "end of clients")
            {
                List<string> commandList = command.Split(new char[] { '-', ',' }).ToList();
                string customerName = commandList[0];
                string product = commandList[1];
                int quantity = int.Parse(commandList[2]);

                if (!barPrices.ContainsKey(product))
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (!customers.ContainsKey(customerName))
                {
                    customers[customerName] = new Customer()
                    {
                        Name = customerName,
                        Order = new Dictionary<string, int>(),
                        Bill = 0M
                    };
                }
                if (!customers[customerName].Order.ContainsKey(product))
                {
                    customers[customerName].Order.Add(product, 0);
                }
                customers[customerName].Order[product] += quantity;
                customers[customerName].Bill += quantity * barPrices[product];

                command = Console.ReadLine();
            }

            return customers.Select(v => v.Value).ToList();
        }

        static Dictionary<string, decimal> GetPrices()
        {
            Dictionary<string, decimal> barPrices = new Dictionary<string, decimal>();
            int itemsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < itemsCount; i++)
            {
                string[] itemAndPrice = Console.ReadLine().Split('-').ToArray();
                string item = itemAndPrice[0];
                decimal price = decimal.Parse(itemAndPrice[1]);

                if (!barPrices.ContainsKey(item))
                {
                    barPrices[item] = 0;
                }
                barPrices[item] = price;
            }
            return barPrices;
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Order = new Dictionary<string, int>();
        public decimal Bill { get; set; }
    }
}
