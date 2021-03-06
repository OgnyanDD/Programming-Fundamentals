﻿using System;

namespace P15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int curNum = 2; curNum <= num; curNum++)
            {
                bool isPrime = true;
                for (int devider = 2; devider <= Math.Sqrt(curNum); devider++)
                {
                    if (curNum % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{curNum} -> {isPrime}");
            }
        }
    }
}
