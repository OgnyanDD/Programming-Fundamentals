using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P01.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;

            BigInteger snowballValueOut = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int snowballSnowInput = int.Parse(Console.ReadLine());
                int snowballTimeInput = int.Parse(Console.ReadLine());
                int snowballQualityInput = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnowInput / snowballTimeInput), snowballQualityInput);

                if (snowballValue > snowballValueOut)
                {
                    snowballSnow = snowballSnowInput;
                    snowballTime = snowballTimeInput;
                    snowballQuality = snowballQualityInput;
                    snowballValueOut = snowballValue;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValueOut} ({snowballQuality})");
        }
    }
}
