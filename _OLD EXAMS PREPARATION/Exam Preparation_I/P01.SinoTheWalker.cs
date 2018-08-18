using System;
using System.Linq;
using System.Numerics;

namespace P01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ver.01

            long[] leaveHour = Console.ReadLine()
            .Split(':')
            .Select(long.Parse)
            .ToArray();

            long hours = leaveHour[0];
            long minutes = leaveHour[1];
            long seconds = leaveHour[2];

            long numOfSteps = long.Parse(Console.ReadLine());
            long timeForStep = long.Parse(Console.ReadLine());

            BigInteger needTimeSec = (BigInteger)numOfSteps * timeForStep;

            needTimeSec += seconds;

            seconds = (long)needTimeSec % 60;
            minutes += (long)needTimeSec / 60;

            if (minutes > 59)
            {
                hours += minutes / 60;
                minutes %= 60;
            }
            if (hours > 23)
            {
                hours %= 24;
            }

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");

            //Ver.02

            //string time = Console.ReadLine();

            //DateTime leaveHour = DateTime.ParseExact(time, "HH:mm:ss", null);

            //int numbOfSteps = int.Parse(Console.ReadLine()) % 86400;
            //int timeForStep = int.Parse(Console.ReadLine()) % 86400;

            //DateTime result = leaveHour.AddSeconds(numbOfSteps * timeForStep);

            //TimeSpan endResult = result.TimeOfDay;

            //Console.WriteLine($"Time Arrival: {endResult}");
        }
    }
}
