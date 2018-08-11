using System;

namespace P03.LastKNumbSumsSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long [] nums = new long[n];
            nums[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += nums[j];
                    }
                }

                nums[i] = sum;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
    }
}
