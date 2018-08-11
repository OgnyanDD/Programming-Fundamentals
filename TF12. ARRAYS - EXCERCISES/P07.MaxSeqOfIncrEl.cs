using System;
using System.Linq;

namespace P07.MaxSeqOfIncrEl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            int longSeqLength = 1;
            int longSeqStart = 0;
            int currentSeqLength = 1;
            int currentSeqStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currentSeqLength++;

                    if (currentSeqLength > longSeqLength)
                    {
                        longSeqLength = currentSeqLength;
                        longSeqStart = currentSeqStart;
                    }
                }
                else
                {
                    currentSeqLength = 1;
                    currentSeqStart = i;
                }
            }

            for (int i = longSeqStart; i < longSeqStart + longSeqLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
