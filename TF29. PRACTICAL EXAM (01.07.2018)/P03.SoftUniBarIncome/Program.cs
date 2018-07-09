using System;
using System.Text.RegularExpressions;

namespace P03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patern = new Regex(@"^([^|$%\.]*?%([A-Z][a-z]+)%[^|$%.]*?<(\w+)>[^.|$%]*?\|(\d+)\|[^.|$%]*?(\d+\.?\d+)\$)$");

            string input = Console.ReadLine();
            double totalIncome = 0.0;

            while (input != "end of shift")
            {
                if (patern.IsMatch(input))
                {
                    Match extrudeData = patern.Match(input);
                    string name = extrudeData.Groups[2].Value;
                    string product = extrudeData.Groups[3].Value;
                    int count = int.Parse(extrudeData.Groups[4].Value);
                    double price = double.Parse(extrudeData.Groups[5].Value);

                    Console.WriteLine($"{name}: {product} - {price * count:f2}");
                    totalIncome += (price * count);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
