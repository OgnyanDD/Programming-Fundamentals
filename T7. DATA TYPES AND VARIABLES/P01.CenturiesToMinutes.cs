using System;

namespace P01.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = Math.Round(years * 365.2422);
            double hours = Math.Round(days * 24);
            double minutes = Math.Round(hours * 60);

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
        }
    }
}
