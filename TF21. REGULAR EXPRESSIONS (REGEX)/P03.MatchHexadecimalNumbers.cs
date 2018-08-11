using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            Regex regex = new Regex(pattern);

            string[] matches = regex
                .Matches(hex)
                .Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
