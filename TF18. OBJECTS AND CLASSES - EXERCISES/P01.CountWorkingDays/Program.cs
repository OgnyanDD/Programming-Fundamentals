using System;
using System.Globalization;

namespace P01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDays = 0;

            DateTime[] hollydays = new DateTime[]
            {
                new DateTime(2000, 01, 01), new DateTime(2000, 03, 03), new DateTime(2000, 05, 01), new DateTime(2000, 05, 06),
                new DateTime(2000, 05, 24), new DateTime(2000, 09, 06), new DateTime(2000, 09, 22), new DateTime(2000, 11, 01),
                new DateTime(2000, 12, 24), new DateTime(2000, 12, 25),  new DateTime(2000, 12, 26)
            };

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                bool isHolliday = false;

                foreach (var holliday in hollydays)
                {
                    if (i.Day == holliday.Day && i.Month == holliday.Month)
                    {
                        isHolliday = true;
                        break;
                    }
                }

                if (!isHolliday && i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
