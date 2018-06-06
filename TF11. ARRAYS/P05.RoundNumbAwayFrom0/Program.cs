using System;
using System.Linq;

namespace P05.RoundNumbAwayFrom0
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                                .Split()
                                .Select(double.Parse)
                                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} => {number:F0}");
            }
        }
    }
}
