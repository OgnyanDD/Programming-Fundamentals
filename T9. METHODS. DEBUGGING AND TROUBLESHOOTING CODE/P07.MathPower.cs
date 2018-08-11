using System;

namespace P07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int numberPow = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPow(number, numberPow));
        }
        static double MathPow(double number, int pow)
        {
            return (Math.Pow(number, pow));
        }
    }
}