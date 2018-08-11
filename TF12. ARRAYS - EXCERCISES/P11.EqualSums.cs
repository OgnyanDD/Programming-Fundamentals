using System;
using System.Linq;

namespace P11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            int totalSum = 0;

            foreach (int numb in numbers)
            {
                totalSum += numb;
            }

            int leftSum = 0;
            int rightSum = totalSum;
            bool hasFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                rightSum -= currentNumber;


                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    hasFound = true;
                    break;
                }
                leftSum += currentNumber;
            }
            if (hasFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
