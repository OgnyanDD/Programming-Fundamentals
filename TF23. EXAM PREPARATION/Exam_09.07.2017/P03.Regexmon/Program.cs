using System;
using System.Text.RegularExpressions;

namespace P03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex bojoRegex = new Regex(@"[A-Za-z]+\-[A-Za-z]+");
            Regex didiRegex = new Regex(@"[^A-Za-z\-]+");

            string text = Console.ReadLine();

            while (true)
            {
                Match didiMatch = didiRegex.Match(text);

                if (didiMatch.Success == false)
                {
                    break;
                }

                int didiIndex = didiMatch.Index + didiMatch.Length;
                text = text.Substring(didiIndex);

                Console.WriteLine(didiMatch.Value);

                Match bojoMatch = bojoRegex.Match(text);

                if (bojoMatch.Success == false)
                {
                    break;
                }

                int bojoIndex = bojoMatch.Index + bojoMatch.Length;
                text = text.Substring(bojoIndex);

                Console.WriteLine(bojoMatch.Value);
            }
        }
    }
}
