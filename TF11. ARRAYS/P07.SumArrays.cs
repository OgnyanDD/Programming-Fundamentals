using System;
using System.Linq;

namespace P07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();

            int[] arr2 = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();

            if (arr1.Length <= arr2.Length)
            {
                int[] newArr2 = new int[arr2.Length];

                for (int i = 0; i < newArr2.Length; i++)
                {
                    newArr2[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];

                    if (i >= arr2.Length)
                    {
                        break;
                    }
                    Console.Write(newArr2[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                int[] newArr1 = new int[arr1.Length];

                for (int i = 0; i < newArr1.Length; i++)
                {
                    newArr1[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];

                    if (i >= arr1.Length)
                    {
                        break;
                    }
                    Console.Write(newArr1[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

