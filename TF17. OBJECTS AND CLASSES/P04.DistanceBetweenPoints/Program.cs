using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)

        {
            Point[] points = GetPoints();

            double distance = GetDistance(points[0], points[1]);

            Console.WriteLine($"{distance:f3}");
        }

        static double GetDistance(Point point1, Point point2)
        {
            return point1.DistanceTo(point2);
        }

        static Point[] GetPoints()

        {
            int pointsCount = 2;
            Point[] points = new Point[pointsCount];

            for (int i = 0; i < pointsCount; i++)
            {

                List<int> pointList = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                points[i] = new Point

                {
                    X = pointList[0],

                    Y = pointList[1]
                };
            }

            return points;
        }
    }

    class Point

    {
        public int X { get; set; }

        public int Y { get; set; }

        public double DistanceTo(Point point)

        {

            int sideA = Math.Abs(X - point.X);

            int sideB = Math.Abs(Y - point.Y);

            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            return distance;
        }
    }
}
