using System;

namespace P17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());

            for (int i = firstDigit; i <= secondDigit; i++)
            {
                if (i < secondDigit)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
                else
                {
                    Console.Write(Convert.ToChar(i));
                }
            }
            Console.WriteLine();
        }
    }
}
