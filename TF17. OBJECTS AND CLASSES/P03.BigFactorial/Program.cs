using System;
using System.Numerics;

namespace P03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = CalculateFactorial(n);

            Console.WriteLine(factorial);
        }

        private static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
