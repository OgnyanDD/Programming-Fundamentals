using System;

namespace P05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            Console.WriteLine(FibonacciNumber(input));

        }

        static long FibonacciNumber(long n)
        {
            long a = 1;
            long b = 1;

            for (long i = 0; i < n - 1; i++)
            {
                long c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
