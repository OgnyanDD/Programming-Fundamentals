using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SearchForANumb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToList();

            int[] arr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            List<int> result = new List<int>();

            int numbTake = arr[0];
            int numbDelete = arr[1];
            int numbCheck = arr[2];

            for (int i = 0; i < numbTake; i++)
            {
                result.Add(input[i]);
            }

            for (int j = 0; j < numbDelete; j++)
            {
                result.RemoveAt(0);
            }

            for (int i = 0; i <= result.Count; i++)
            {
                if (result.Contains(numbCheck))
                {
                    Console.WriteLine("YES!");
                    break;
                }
                else
                {
                    Console.WriteLine("NO!");
                    break;
                }
            }
        }
    }
}
