using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] digit = Console.ReadLine()
                                .Split()
                                .Select(double.Parse)
                                .ToArray();


            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();



            for (int i = 0; i < digit.Length; i++)
            {
                if (counts.ContainsKey(digit[i]) == false)
                {
                    counts[digit[i]] = 1;
                    continue;
                }
                counts[digit[i]]++;
            }
            foreach (var result in counts)
            {
                Console.WriteLine($"{result.Key} -> {result.Value}");
            }
        }
    }
}
