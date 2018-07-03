using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P03.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<string> replaces = Console.ReadLine()
                .Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            StringBuilder decodedText = new StringBuilder();

            string pattern = @"([A-Za-z]+)(.+)(\1)";

            decodedText.Append(text);

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                if (replaces.Count < 1)
                {
                    break;
                }

                string decode = match.Groups[1] + replaces[0] + match.Groups[3];

                decodedText.Replace(match.Value, decode);
                replaces.RemoveAt(0);
            }

            Console.WriteLine(decodedText);
        }
    }
}
