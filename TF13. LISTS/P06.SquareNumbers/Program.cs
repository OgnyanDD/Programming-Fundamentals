using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();

            List<int> result = new List<int>();

            foreach (int digit in input)
            {
                if (Math.Sqrt(digit) == (int)Math.Sqrt(digit))
                {
                    result.Add(digit);
                }
            }

            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
