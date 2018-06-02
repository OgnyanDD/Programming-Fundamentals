using System;

namespace P02.RevArrayOfInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintReverseArrayOfIntegers(input);
        }

        private static void PrintReverseArrayOfIntegers(int input)
        {
            int[] numbers = new int[input];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
