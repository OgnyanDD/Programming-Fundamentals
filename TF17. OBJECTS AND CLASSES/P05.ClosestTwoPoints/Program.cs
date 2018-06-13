using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = GetPoints();

            PrintClosestTwoPointsData(points);
        }

        private static void PrintClosestTwoPointsData(List<Point> points)
        {
            List<Point> minDistancePints = new List<Point>(2);

            double minDistance = GetMinDisnatce(points, ref minDistancePints);

            Console.WriteLine($"{minDistance:f3}");

            foreach (var point in minDistancePints)
            {
                Console.WriteLine($"({point.X}, {point.Y})");
            }
        }

        static double GetMinDisnatce(List<Point> allPoints, ref List<Point> closestTwoPoints)
        {
            double minDistance = double.MaxValue;
            int pointsCount = allPoints.Count;

            for (int p1 = 0; p1 < pointsCount - 1; p1++)
            {
                for (int p2 = p1 + 1; p2 < pointsCount; p2++)
                {
                    double currentDistance = GetDistance(allPoints[p1], allPoints[p2]);

                    if (minDistance > currentDistance)
                    {
                        closestTwoPoints.Clear();
                        minDistance = currentDistance;
                        closestTwoPoints.Add(allPoints[p1]);
                        closestTwoPoints.Add(allPoints[p2]);
                    }
                }
            }

            return minDistance;
        }

        static List<Point> GetPoints()
        {
            int pointsCount = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>(pointsCount);

            for (int i = 0; i < pointsCount; i++)
            {
                List<int> pointList = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                points.Add(
                    new Point
                    {
                        X = pointList[0],

                        Y = pointList[1]
                    }
                );
            }
            return points;
        }

        static double GetDistance(Point point1, Point point2)
        {
            return point1.DistanceTo(point2);
        }
    }

    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public double DistanceTo(Point point)
        {
            double sideA = Math.Abs(X - point.X);
            double sideB = Math.Abs(Y - point.Y);
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            return distance;
        }
    }
}
