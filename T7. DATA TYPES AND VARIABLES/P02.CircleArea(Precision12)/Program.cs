using System;

namespace P02.CircleArea_Precision12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * circleRadius * circleRadius;

            Console.WriteLine($"{circleArea:f12}");
        }
    }
}
