using System;

namespace P01.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long marathonDays = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long maximumRunners = trackCapacity * marathonDays;

            if (runners > maximumRunners)
            {
                runners = maximumRunners;
            }

            long totalMeters = runners * laps * trackLength;
            decimal totalKm = totalMeters / 1000;

            decimal donation = moneyPerKm * totalKm;

            Console.WriteLine($"Money raised: {donation:f2}");
        }
    }
}
