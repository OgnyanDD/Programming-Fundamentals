using System;

namespace P03.EnNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());


            NumberToWord(Math.Abs(input));
        }

        static void NumberToWord(long n)
        {
            long lastDigit = n % 10;
            string word = "";

            string[] digitValue = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (int i = 0; i <= lastDigit; i++)
            {
                if (lastDigit == i)
                {
                    word = digitValue[i];
                }
            }
            Console.WriteLine(word);
        }
    }
}
