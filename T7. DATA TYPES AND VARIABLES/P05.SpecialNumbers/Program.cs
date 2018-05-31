using System;

namespace P05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputDigit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputDigit; i++)
            {
                int sum = 0;
                int digit = i;

                while (digit > 0)
                {

                    sum += digit % 10;
                    digit = digit / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {

                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
