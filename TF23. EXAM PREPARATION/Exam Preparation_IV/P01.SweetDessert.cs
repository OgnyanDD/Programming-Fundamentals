using System;

namespace P01.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ammountCash = decimal.Parse(Console.ReadLine());
            long guestCount = long.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPriceKg = decimal.Parse(Console.ReadLine());

            decimal portions = Math.Ceiling(guestCount / 6.0M);

            decimal neededMoney = (portions * (2 * bananasPrice) + portions * (4 * eggsPrice) + portions * (0.2M * berriesPriceKg));

            if (ammountCash >= neededMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney - ammountCash:f2}lv more.");
            }
        }
    }
}
