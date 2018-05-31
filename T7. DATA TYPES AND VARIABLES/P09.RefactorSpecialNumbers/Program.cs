using System;

namespace P09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                int sumOfDigits = 0;
                int digits = i;
                bool special = false;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits /= 10;
                }

                special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
