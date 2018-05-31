using System;

namespace P03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                PrintLine(1, i);
            }

            PrintLine(1, inputNumber);

            for (int i = inputNumber - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }

        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}