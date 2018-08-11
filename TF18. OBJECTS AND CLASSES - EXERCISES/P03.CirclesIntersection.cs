using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstLine = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> secondLine = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            Circle circle1 = new Circle() { Center = GetPoint(firstLine[0], firstLine[1]), Radius = firstLine[2] };

            Circle circle2 = new Circle() { Center = GetPoint(secondLine[0], secondLine[1]), Radius = secondLine[2] };

            bool areIntercest = Intercest(circle1, circle2);

            Console.WriteLine(areIntercest ? "Yes" : "No");
        }

        static Point GetPoint(double v1, double v2)
        {
            return new Point
            { X = v1, Y = v2 };
        }

        public static double DistanceBetweenCenters(Circle circle1, Circle circle2)
        {
            double sideA = circle1.Center.X - circle2.Center.X;
            double sideB = circle1.Center.Y - circle2.Center.Y;
            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }

        public static bool Intercest(Circle circle1, Circle circle2)
        {
            double distance = DistanceBetweenCenters(circle1, circle2);
            bool areIntercest = false;

            if (distance <= circle1.Radius + circle2.Radius)
                areIntercest = true;

            return areIntercest;
        }
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
