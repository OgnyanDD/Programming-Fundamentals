using System;

namespace P03._MilesToKilometers
{
    class Program
    {
        const double MILE_KM = 1.60934;
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double convMileToKm = input * MILE_KM;

            Console.WriteLine($"{convMileToKm:f2}");
        }
    }
}
