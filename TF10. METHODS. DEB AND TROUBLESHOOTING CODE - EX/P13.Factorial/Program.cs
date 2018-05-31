using System;
using System.Numerics;

namespace P13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger result = Factorial(input);

            Console.WriteLine(result);

        }

        private static BigInteger Factorial(int input)
        {
            BigInteger result = 1;

            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
