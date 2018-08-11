using System;

namespace P02._ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double priceDrink;

            switch (profession)
            {
                case "Athlete":
                    priceDrink = 0.70;
                    Console.WriteLine($"The {profession} has to pay {quantity * priceDrink:f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    priceDrink = 1.00;
                    Console.WriteLine($"The {profession} has to pay {quantity * priceDrink:f2}.");
                    break;
                case "SoftUni Student":
                    priceDrink = 1.70;
                    Console.WriteLine($"The {profession} has to pay {quantity * priceDrink:f2}.");
                    break;
                default:
                    priceDrink = 1.20;
                    Console.WriteLine($"The {profession} has to pay {quantity * priceDrink:f2}.");
                    break;
            }
        }
    }
}
