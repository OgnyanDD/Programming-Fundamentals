using System;
using System.Text.RegularExpressions;

namespace P03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surfaceRegex = @"^([^A-Za-z0-9]+)$";
            string mentaleRegex = @"^([0-9_]+)$";
            string coreRegex = @"^([^A-Za-z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$";

            int coreLength = 0;
            bool isValid = true;

            for (int i = 1; i <= 5; i++)
            {
                string snowflakePart = Console.ReadLine();

                if (i == 1 || i == 5)
                {
                    Match match = Regex.Match(snowflakePart, surfaceRegex);

                    if (match.Success == false)
                    {
                        isValid = false;
                        continue;
                    }
                }
                if (i == 2 || i == 4)
                {
                    Match match = Regex.Match(snowflakePart, mentaleRegex);

                    if (match.Success == false)
                    {
                        isValid = false;
                        continue;
                    }
                }
                if (i == 3)
                {
                    Match match = Regex.Match(snowflakePart, coreRegex);

                    if (match.Success == false)
                    {
                        isValid = false;
                        continue;
                    }
                    string core = match.Groups[3].Value;
                    coreLength = core.Length;
                }
            }
            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
