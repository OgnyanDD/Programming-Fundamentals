using System;
using System.Linq;

namespace P06.SumRevNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int rev = 0;
                while (input[i] > 0)
                {

                    int digit = input[i] % 10;
                    rev = rev * 10 + digit;
                    input[i] = input[i] / 10;
                }
                sum += rev;
            }
            Console.WriteLine(sum);
        }
    }
}
