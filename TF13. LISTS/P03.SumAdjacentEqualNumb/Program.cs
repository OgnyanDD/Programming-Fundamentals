using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SumAdjacentEqualNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            //8 2 2 4 8 16 -> 8 4 4 8 16 -> 8 8 8 16 -> 16 8 16

            List<double> numbers = Console.ReadLine()
                       .Split()
                       .Select(double.Parse)
                       .ToList();

            int i = 0;

            while(i < numbers.Count - 1)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i--;

                    if (i < 0)
                    {

                        i = 0;
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
