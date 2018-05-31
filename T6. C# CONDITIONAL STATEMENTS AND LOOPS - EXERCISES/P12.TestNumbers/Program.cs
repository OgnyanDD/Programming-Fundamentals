using System;

namespace P12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumBoundary = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= sumBoundary)
                    {
                        break;
                    }

                    counter++;
                    sum += 3 * (i * j);
                }
            }
            if (sum >= sumBoundary)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {sumBoundary}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
