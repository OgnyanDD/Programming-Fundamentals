using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P07.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPattern = @"([^&?]+)=([^&?]+)";
            string secondPatter = @"(%20|\+)+";

            string line = Console.ReadLine();

            while (line.Equals("END") == false)
            {
                MatchCollection matches = Regex.Matches(line, firstPattern);

                Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, secondPatter, word => " ").Trim();

                    string value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, secondPatter, word => " ").Trim();

                    if (!dictionary.ContainsKey(field))
                    {
                        dictionary[field] = new List<string>();
                    }

                    dictionary[field].Add(value);
                }

                foreach (var kvpResult in dictionary)
                {
                    Console.Write($"{kvpResult.Key}=[{string.Join(", ", kvpResult.Value)}]");
                }

                Console.WriteLine();

                line = Console.ReadLine();
            }
        }
    }
}
