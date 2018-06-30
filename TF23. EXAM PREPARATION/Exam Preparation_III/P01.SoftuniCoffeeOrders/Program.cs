using System;
using System.Globalization;

namespace P01.SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalSum = 0.00M;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

                long capsules = long.Parse(Console.ReadLine());

                int year = date.Year;
                int month = date.Month;
                int daysInMonth = DateTime.DaysInMonth(year, month);

                decimal price = (daysInMonth * capsules) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                totalSum += price;
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
