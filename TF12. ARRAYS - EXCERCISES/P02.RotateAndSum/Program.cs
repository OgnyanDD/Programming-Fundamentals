using System;
using System.Linq;

namespace P02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int iteration = int.Parse(Console.ReadLine());

            int[] sumArr = new int[arr.Length];

            for (int i = 0; i < iteration; i++)
            {
                Shift(arr);
                Sum(arr, sumArr);
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }

        private static void Sum(int[] arr, int[] sumArr)
        {
            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] += arr[i];
            }
        }

        private static void Shift(int[] arr)
        {
            int temp = arr[arr.Length - 1];

            for (int j = arr.Length - 1; j > 0; j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[0] = temp;
        }
    }
}