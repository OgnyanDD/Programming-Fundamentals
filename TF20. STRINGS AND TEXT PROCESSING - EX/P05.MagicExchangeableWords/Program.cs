using System;
using System.Linq;

namespace P05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string first = input[0];
            string second = input[1];

            bool wordsAreExchangeable = first.Distinct().Count() == second.Distinct().Count();

            Console.WriteLine(wordsAreExchangeable.ToString().ToLower());
        }
    }
}
