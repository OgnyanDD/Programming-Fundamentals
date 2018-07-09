using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished") { break; }

                string[] tokens = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string inputName = tokens[0];
                // Banning user
                if (tokens[1] == "banned")
                {
                    if (users.ContainsKey(inputName))
                    {
                        users.Remove(inputName);
                    }
                }
                // Normal input - language, points
                else
                {
                    string inputLanguage = tokens[1];
                    int inputPoints = int.Parse(tokens[2]);

                    // Add non-existing user
                    if (users.ContainsKey(inputName) == false)
                    {
                        users.Add(inputName, inputPoints);
                    }
                    // Update existing user only if better points
                    else
                    {
                        if (inputPoints > users[inputName])
                        {
                            users[inputName] = inputPoints;
                        }
                    }
                    // Add non-existing language
                    if (languages.ContainsKey(inputLanguage) == false)
                    {
                        languages.Add(inputLanguage, 1);
                    }
                    // Increment existing language submision count
                    else
                    {
                        languages[inputLanguage]++;
                    }
                }
            }
            // Sort
            var sortedUsers = users.OrderByDescending(u => u.Value).ThenBy(u => u.Key);
            var sortedLanguages = languages.OrderByDescending(u => u.Value).ThenBy(u => u.Key);
            // Print
            Console.WriteLine("Results:");
            foreach (var user in sortedUsers)
            {
                Console.WriteLine("{0} | {1}", user.Key, user.Value);
            }
            Console.WriteLine("Submissions:");
            foreach (var language in sortedLanguages)
            {
                Console.WriteLine("{0} - {1}", language.Key, language.Value);
            }
        }
    }
}
