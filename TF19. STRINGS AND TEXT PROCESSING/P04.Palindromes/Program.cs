using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine()
                .Split(new char[] { ',', '!', '?', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> text = new List<string>();

            foreach (var word in inputText)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    text.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", text.OrderBy(a => a).Distinct()));
        }
    }
}
