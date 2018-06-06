using System;

namespace P01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            int counterLeft = 0;
            int counterRight = 0;

            int lenghtLoop = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < lenghtLoop; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    counterLeft++;
                }

                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    counterRight++;
                }
            }
            Console.WriteLine(Math.Max(counterLeft, counterRight));
        }
    }
}
