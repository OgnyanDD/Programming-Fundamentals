using System;

namespace P01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputDayNumber = int.Parse(Console.ReadLine());

            string result = GetDayOfWeek(inputDayNumber);

            Console.WriteLine(result);
        }

        private static string GetDayOfWeek(int inputDayNumber)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (inputDayNumber >= 1 && inputDayNumber <= 7)
            {
                return daysOfWeek[inputDayNumber - 1];
            }
            else
            {
                return "Invalid Day!";
            }
        }
    }
}
