using System;
using System.Linq;

namespace P09.ExtractMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();


            if (arr.Length == 1)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else if (arr.Length % 2 == 0)
            {
                int[] evenArr = new int[2];


                evenArr[0] = arr[(arr.Length / 2) - 1];

                evenArr[1] = arr[arr.Length / 2];

                Console.WriteLine(string.Join(" ", evenArr));
            }
            else if (arr.Length % 2 != 0)
            {
                int[] oddArr = new int[3];

                oddArr[0] = arr[(arr.Length / 2) - 1];

                oddArr[1] = arr[arr.Length / 2];

                oddArr[2] = arr[(arr.Length / 2) + 1];

                Console.WriteLine(string.Join(" ", oddArr));
            }
        }
    }
}