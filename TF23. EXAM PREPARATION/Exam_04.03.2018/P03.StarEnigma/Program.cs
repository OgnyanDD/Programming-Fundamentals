using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int countAttacked = 0;
            int countDestroyed = 0;


            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int count = 0;

                string decryptRegex = @"S|T|A|R|s|t|a|r";
                MatchCollection matches = Regex.Matches(encryptedMessage, decryptRegex);

                foreach (Match m in matches)
                {
                    count++;
                }

                char[] decryptedMessageArr = encryptedMessage
                     .Select(x => x -= (char)count)
                     .ToArray();

                string decryptedMessage = new string(decryptedMessageArr);

                string pattern = @"\@([a-zA-Z]+)[^@\-!:>]*\:([0-9]+)[^@\-!:>]*\!(A|D)\![^@\-!:>]*\-\>[0-9]+";

                Match match = Regex.Match(decryptedMessage, pattern);

                if (match.Success == false)
                {
                    continue;
                }

                string planetName = match.Groups[1].Value;
                string attackType = match.Groups[3].Value;

                if (attackType == "A")
                {
                    countAttacked++;
                    attackedPlanets.Add(planetName);
                }
                else
                {
                    countDestroyed++;
                    destroyedPlanets.Add(planetName);
                }
            }
            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {countAttacked}");
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {countDestroyed}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
