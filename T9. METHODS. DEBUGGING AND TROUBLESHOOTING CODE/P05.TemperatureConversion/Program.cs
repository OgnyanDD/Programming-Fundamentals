using System;

namespace P05.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputTemperature = double.Parse(Console.ReadLine());

            Console.WriteLine($"{ConverterFToC(inputTemperature):f2}");

        }
        static double ConverterFToC(double converter)
        {
            return (converter - 32) * 5 / 9;
        }
    }
}