using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();

            List<string> sentence = new List<string>();

            string startPattern = @"^([A-Za-z]+)[|<\\]";
            string endPattern = @"[|<\\]([A-Za-z]+)$";

            Match startMatch = Regex.Match(keyString, startPattern);
            Match endMatch = Regex.Match(keyString, endPattern);

            string startWord = startMatch.Groups[1].Value;
            string endWord = endMatch.Groups[1].Value;

            string matchPattern = $@"({startWord})([a-zA-z]*?)({endWord})";
            MatchCollection matches = Regex.Matches(textString, matchPattern);

            foreach (Match match in matches)
            {
                string word = match.Groups[2].Value;

                if (word != string.Empty)
                {
                    sentence.Add(word);
                }
            }

            if (sentence.Any())
            {
                Console.WriteLine(string.Join("", sentence));
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
