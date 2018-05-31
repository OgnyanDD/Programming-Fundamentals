using System;

namespace P10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            string cubeProperties = Console.ReadLine();

            double result = 0.0;


            switch (cubeProperties)

            {
                case "face":

                    result = GetFaceDiagonalsLenght(inputNumber);
                    Console.WriteLine($"{result:f2}");
                    break;

                case "space":

                    result = GetSpaceDiagonalsLenght(inputNumber);
                    Console.WriteLine($"{result:f2}");
                    break;

                case "volume":

                    result = GetVolume(inputNumber);
                    Console.WriteLine($"{result:f2}");
                    break;

                case "area":

                    result = GetSurfaceArea(inputNumber);
                    Console.WriteLine($"{result:f2}");
                    break;
            }


        }

        static double GetFaceDiagonalsLenght(double n)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(n, 2));
            return faceDiagonal;
        }

        static double GetSpaceDiagonalsLenght(double n)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(n, 2));
            return spaceDiagonal;
        }

        static double GetVolume(double n)
        {
            double volume = Math.Pow(n, 3);
            return volume;
        }

        static double GetSurfaceArea(double n)
        {
            double surfaceArea = 6 * Math.Pow(n, 2);
            return surfaceArea;
        }
    }
}