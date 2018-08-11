using System;
using System.Linq;

namespace P04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            bool notFound = true;
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");

                        if (notFound)
                        {
                            notFound = false;
                        }
                    }
                }
            }

            if (notFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
