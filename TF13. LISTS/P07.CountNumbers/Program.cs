using System;
using System.Linq;

namespace P07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            Array.Sort(input);

            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == input[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(input[i - 1] + " -> " + count);
                    count = 1;
                }
            }
            Console.WriteLine(input[input.Length - 1] + " -> " + count);

        }
    }
}
