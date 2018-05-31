using System;

namespace P04._BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double energyVol = (volume * energy) / 100;
            double sugarVol = (volume * sugar) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyVol}kcal, {sugarVol}g sugars");
        }
    }
}
