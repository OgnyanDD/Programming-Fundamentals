using System;

namespace P11._OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                inputNumber = Math.Abs(inputNumber);

                if (inputNumber % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {inputNumber}");
                    break;
                }
            }
        }
    }
}
