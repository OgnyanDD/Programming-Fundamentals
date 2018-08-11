using System;
using System.Text.RegularExpressions;

namespace P01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var validNames = Regex.Matches(names, pattern);

            foreach (Match name in validNames)
            {
                Console.Write($"{name.Value} ");
            }
            Console.WriteLine();
        }
    }
}
