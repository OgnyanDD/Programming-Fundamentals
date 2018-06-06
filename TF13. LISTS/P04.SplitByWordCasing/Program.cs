using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].All(char.IsLower))
                {
                    lowerCaseWords.Add(text[i]);
                }
                else if (text[i].All(char.IsUpper))
                {
                    upperCaseWords.Add(text[i]);
                }
                else
                {
                    mixedCaseWords.Add(text[i]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
        }
    }
}
