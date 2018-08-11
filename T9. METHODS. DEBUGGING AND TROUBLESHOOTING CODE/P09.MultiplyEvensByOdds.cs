using System;

namespace P09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            Console.WriteLine(OddEvenSum(Math.Abs(input)));
        }

        static int OddEvenSum(int number)
        {
            int sumEven = 0;
            int sumOdd = 0;

            while (number > 0)
            {
                int temp = number % 10;

                if (temp % 2 == 0)
                {
                    sumEven += temp;
                }
                else
                {
                    sumOdd += temp;
                }
                number /= 10;
            }
            return (sumEven * sumOdd);
        }
    }
}
