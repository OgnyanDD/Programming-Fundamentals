using System;
using System.Linq;

namespace P02.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int[] result = new int[dnaLength];

            int bestCount = 0;
            int bestIndex = 0;
            int bestSequence = 1;
            int sequence = 1;

            while (command != "Clone them!")
            {
                int[] dnaSequence = command
                                .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

                int counter = 0;
                int index = 0;

                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    if (dnaSequence[i] == 1)
                    {
                        counter++;

                        if (counter > bestCount)
                        {
                            result = dnaSequence;
                            bestCount = counter;
                            bestIndex = index;
                            bestSequence = sequence;
                        }
                        else if (counter == bestCount)
                        {
                            if (index < bestIndex)
                            {
                                result = dnaSequence;
                                bestCount = counter;
                                bestIndex = index;
                                bestSequence = sequence;
                            }
                            else if (index == bestIndex && dnaSequence.Sum() > result.Sum())
                            {
                                result = dnaSequence;
                                bestCount = counter;
                                bestIndex = index;
                                bestSequence = sequence;
                            }
                        }
                    }
                    else
                    {
                        counter = 0;
                        index = i + 1;
                    }
                }
                sequence++;
                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequence} with sum: {result.Sum()}.");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
