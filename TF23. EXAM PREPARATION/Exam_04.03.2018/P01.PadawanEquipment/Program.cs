using System;

namespace P01.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLSabre = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            double reserve = Math.Ceiling(students * 1.10);

            double costSabres = reserve * priceLSabre;
            double costRobes = students * priceRobe;
            double costBelts = students * priceBelt;

            double totalCost = costSabres + costRobes + costBelts;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    totalCost -= priceBelt;
                }
            }
            if (totalCost <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalCost - money):F2}lv more.");
            }

        }
    }
}
