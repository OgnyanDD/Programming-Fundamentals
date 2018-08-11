using System;

namespace P08.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height, volume;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            volume = (length * width * height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
