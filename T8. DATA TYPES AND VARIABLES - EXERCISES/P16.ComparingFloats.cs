using System;

namespace P16.ComparingFloats
{
    class Program
    {
        const double eps = 0.000001;
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double difference = Math.Abs(num1 - num2);

            bool result = difference < eps;
            Console.WriteLine(result);
        }
    }
}
