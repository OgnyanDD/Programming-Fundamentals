using System;
using System.Numerics;
using System.Text;

namespace P01.ConvertFromBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            long toBase = long.Parse(input[0]);

            BigInteger numberBaseTen = BigInteger.Parse(input[1]);

            StringBuilder result = new StringBuilder();

            while (numberBaseTen > 0)
            {
                BigInteger remainder = numberBaseTen % toBase;
                result.Insert(0, remainder.ToString());
                numberBaseTen /= toBase;
            }
            Console.WriteLine(result);
        }
    }
}
