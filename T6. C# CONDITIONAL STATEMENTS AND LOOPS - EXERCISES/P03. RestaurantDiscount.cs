using System;

namespace P03._RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int priceHall;
            int pricePackage;
            int totalPrice;
            double discount;
            double totalPriceWithDiscount;
            double pricePerPerson;

            if (groupSize <= 50)
            {
                priceHall = 2500;
                switch (package)
                {
                    case "Normal":
                        pricePackage = 500;
                        discount = 0.05;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Small Hall\nThe price per person is {pricePerPerson:f2}$");
                        break;
                    case "Gold":
                        pricePackage = 750;
                        discount = 0.10;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Small Hall\nThe price per person is {pricePerPerson:f2}$");
                        break;
                    case "Platinum":
                        pricePackage = 1000;
                        discount = 0.15;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Small Hall\nThe price per person is {pricePerPerson:f2}$");
                        break;
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                priceHall = 5000;
                switch (package)
                {
                    case "Normal":
                        pricePackage = 500;
                        discount = 0.05;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Terrace\nThe price per person is {pricePerPerson:f2}$");
                        break;
                    case "Gold":
                        pricePackage = 750;
                        discount = 0.10;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Terrace\nThe price per person is {pricePerPerson:f2}$");
                        break;
                    case "Platinum":
                        pricePackage = 1000;
                        discount = 0.15;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Terrace\nThe price per person is {pricePerPerson:f2}$");
                        break;
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                priceHall = 7500;
                switch (package)
                {
                    case "Normal":
                        pricePackage = 500;
                        discount = 0.05;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Great Hall\nThe price per person is {pricePerPerson:f2}$");
                        break;
                    case "Gold":
                        pricePackage = 750;
                        discount = 0.10;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Great Hall\nThe price per person is {pricePerPerson:f2}$");
                        break;
                    case "Platinum":
                        pricePackage = 1000;
                        discount = 0.15;
                        totalPrice = priceHall + pricePackage;
                        totalPriceWithDiscount = totalPrice - (totalPrice * discount);
                        pricePerPerson = totalPriceWithDiscount / groupSize;
                        Console.WriteLine($"We can offer you the Great Hall\nThe price per person is {pricePerPerson:f2}$");
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
