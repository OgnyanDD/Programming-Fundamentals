using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P03.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine().ToUpper();

            string pattern = @"(\D+)(\d+)";

            StringBuilder tempMessage = new StringBuilder();
            MatchCollection matches = Regex.Matches(inputLine, pattern);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    char[] word = match.Groups[1].Value.ToCharArray();
                    int number = int.Parse(match.Groups[2].Value);

                    for (int i = 0; i < number; i++)
                    {
                        tempMessage.Append(word);
                    }
                }
            }

            string message = tempMessage.ToString();
            int uniqueSymbols = message.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(message);
        }
    }
}
