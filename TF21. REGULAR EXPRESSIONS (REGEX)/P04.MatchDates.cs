using System;
using System.Text.RegularExpressions;

namespace P04.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b(?<day>\d{2})([\/.-])(?<month>[A-Z][]a-z]{2})\1(?<year>\d{4})\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchedDates = regex.Matches(input);

            foreach (Match d in matchedDates)
            {
                string dayValue = d.Groups["day"].Value;
                string monthValue = d.Groups["month"].Value;
                string yearValue = d.Groups["year"].Value;

                Console.WriteLine($"Day: {dayValue}, Month: {monthValue}, Year: {yearValue}");
            }
        }
    }
}
