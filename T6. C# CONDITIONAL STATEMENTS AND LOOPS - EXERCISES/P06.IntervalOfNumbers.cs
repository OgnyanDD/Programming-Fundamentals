using System;

namespace P06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                for (int i = secondNumber; i <= firstNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    Console.WriteLine(j);
                }
            }

        }
    }
}
