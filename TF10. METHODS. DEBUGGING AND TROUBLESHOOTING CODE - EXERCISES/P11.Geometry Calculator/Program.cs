using System;

namespace P11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double result;

            switch (figureType)
            {
                case "triangle":

                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());

                    result = GetTriangleArea(a, b);
                    Console.WriteLine($"{result:f2}");
                    break;

                case "square":

                    double c = double.Parse(Console.ReadLine());

                    result = GetSquareArea(c);
                    Console.WriteLine($"{result:f2}");
                    break;

                case "rectangle":

                    double d = double.Parse(Console.ReadLine());
                    double e = double.Parse(Console.ReadLine());

                    result = GetRectangleArea(d, e);
                    Console.WriteLine($"{result:f2}");
                    break;

                case "circle":

                    double r = double.Parse(Console.ReadLine());

                    result = GetCircleArea(r);
                    Console.WriteLine($"{result:f2}");
                    break;

                default:

                    throw new ArgumentException();
            }

        }

        private static double GetCircleArea(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }

        private static double GetRectangleArea(double a, double b)
        {
            double area = a * b;
            return area;
        }

        private static double GetSquareArea(double a)
        {
            double area = Math.Pow(a, 2);
            return area;
        }

        private static double GetTriangleArea(double a, double b)
        {
            double area = (a * b) / 2;
            return area;
        }
    }
}
