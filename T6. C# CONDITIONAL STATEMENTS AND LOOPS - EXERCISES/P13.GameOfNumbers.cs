using System;

namespace P13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            int counterMatch = 0;


            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {

                    sum = i + j;
                    counter++;

                    if (sum == magicNumber)
                    {

                        Console.WriteLine("Number found! {0} + {1} = {2}", i, j, magicNumber);
                        counterMatch++;
                        return;
                    }
                }
            }

            if (counterMatch == 0)
            {

                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            }
        }
    }
}
