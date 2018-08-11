using System;
using System.Collections.Generic;
using System.Text;

namespace P02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> oddOccurrences = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {

                if (oddOccurrences.ContainsKey(input[i]) == false)
                {
                    oddOccurrences[input[i]] = 1;
                    continue;
                }
                oddOccurrences[input[i]]++;
            }

            var print = new StringBuilder();

            foreach (var result in oddOccurrences)
            {
                if (result.Value % 2 != 0)
                {
                    print.Append($"{result.Key}, ");
                }
            }

            Console.WriteLine(print.ToString().Trim(' ', ','));
        }
    }
}
