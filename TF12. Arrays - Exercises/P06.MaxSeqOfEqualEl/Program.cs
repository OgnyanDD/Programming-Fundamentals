using System;
using System.Linq;

namespace P06.MaxSeqOfEqualEl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            int start = 0;
            int bestStart = 0;
            int counter = 0;
            int bestLength = 0;


            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[start] == arr[i])
                {
                    counter++;

                    if (counter > bestLength)
                    {
                        bestLength = counter;
                        bestStart = start;
                    }
                }
                else
                {
                    start++;
                    i = start;
                    counter = 0;
                }

            }
            for (int i = 0; i <= bestLength; i++)
            {
                Console.Write($"{arr[bestStart + i]} ");
            }
            Console.WriteLine();
        }
    }
}
