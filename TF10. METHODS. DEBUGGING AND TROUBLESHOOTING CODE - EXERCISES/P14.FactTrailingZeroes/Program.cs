using System;
using System.Numerics;

namespace P14.FactTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger result = GetFactorial(n);
            Console.WriteLine(GetTrailingZeroes(result));
        }

        static BigInteger GetFactorial(BigInteger n)
        {
            BigInteger fact = 1;

            do
            {
                fact = fact * n;
                n--;
            } while (n > 1);

            return fact;
        }

        static BigInteger GetTrailingZeroes(BigInteger num)
        {

            BigInteger countZero = 0;

            while (num % 10 == 0)
            {
                num = num / 10;
                countZero++;
            }
            return countZero;
        }
    }
}
