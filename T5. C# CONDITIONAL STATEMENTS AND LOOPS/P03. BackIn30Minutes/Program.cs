using System;

namespace P03._BackIn30Minutes
{
    class Program
    {
        const int REST = 30;
        const int MINUTES = 60;
        const int HOURS = 24;

        static void Main(string[] args)
        {
            int hoursInput = int.Parse(Console.ReadLine());
            int minutesInput = int.Parse(Console.ReadLine());

            if (minutesInput + REST > MINUTES - 1)
            {
                hoursInput++;
                minutesInput += REST - MINUTES;
            }
            else
            {
                minutesInput += REST;
            }

            if (hoursInput > HOURS - 1)
            {
                hoursInput -= HOURS;
            }
            Console.WriteLine($"{hoursInput}:{minutesInput:d2}");
        }
    }
}
