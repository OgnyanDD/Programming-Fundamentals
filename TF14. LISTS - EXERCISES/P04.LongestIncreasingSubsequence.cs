﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] length = new int[numbers.Length];
            int[] prev = new int[numbers.Length];

            int bestLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                length[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && length[j] >= length[i])
                    {
                        length[i] = 1 + length[j];
                        prev[i] = j;
                    }
                }

                if (length[i] > bestLength)
                {
                    bestLength = length[i];
                    lastIndex = i;
                }
            }

            List<int> sequence = new List<int>();
            for (int i = 0; i < bestLength; i++)
            {
                sequence.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            sequence.Reverse();
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}