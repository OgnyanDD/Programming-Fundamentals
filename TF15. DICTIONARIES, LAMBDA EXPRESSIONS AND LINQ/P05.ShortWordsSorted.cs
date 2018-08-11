using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> wordsList = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToList();

            Console.WriteLine(string.Join(", ", wordsList));
        }
    }
}
