using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._RemNegAndRev
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> positiveNumbers = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > 0)
                {
                    positiveNumbers.Add(input[i]);
                }
            }

            positiveNumbers.Reverse();

            if (positiveNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
