using System;
using System.Globalization;

namespace P01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string format = "d-M-yyyy";

            DateTime date = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
