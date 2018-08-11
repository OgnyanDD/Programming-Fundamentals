using System;
using System.Numerics;

namespace P01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            string[] websiteNames = new string[n];

            BigInteger securityToken = BigInteger.Pow(securityKey, n);

            decimal totalLoss = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] info = line.Split();

                string website = info[0];
                long visits = long.Parse(info[1]);
                decimal price = decimal.Parse(info[2]);

                decimal loss = visits * price;

                totalLoss += loss;
                websiteNames[i] = website;

            }
            Console.WriteLine(string.Join(Environment.NewLine, websiteNames));
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
