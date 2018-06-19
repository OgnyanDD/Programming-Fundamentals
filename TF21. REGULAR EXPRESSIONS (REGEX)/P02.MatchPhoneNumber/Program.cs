using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();

            string pattern = @"\+359([ |-])2\1\d{3}\1\d{4}\b";

            Regex regex = new Regex(pattern);


            //for (int i = 0; i < phoneNumbers.Length; i++)
            //{
            //    string phoneNumber = phoneNumbers[i];

            //    Match match = regex.Match(phoneNumber);

            //    if (match.Success)
            //    {
            //        Console.Write(match + " ");
            //    }

            //}
            //Console.WriteLine();

            string[] matches = regex
                .Matches(phoneNumbers)
                .Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
