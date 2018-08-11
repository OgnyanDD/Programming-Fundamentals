using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string pattern = @"\b[a-zA-Z]\w{2,24}\b";
            List<string> validUsers = new List<string>();

            foreach (var word in input)
            {
                Match match = Regex.Match(word, pattern);
                if (match.Success)
                {
                    validUsers.Add(word);
                }
            }

            int bestIndex = 0;
            int bestCount = 0;
            int count = 0;

            for (int i = 0; i < validUsers.Count - 1; i++)
            {
                count = validUsers[i].Length + validUsers[i + 1].Length;

                if (count > bestCount)
                {
                    bestCount = count;
                    bestIndex = i;
                }
            }

            Console.WriteLine(validUsers[bestIndex]);
            Console.WriteLine(validUsers[bestIndex + 1]);
        }
    }
}