using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> forceRegister = new Dictionary<string, List<string>>();
            List<string> forceUsers = new List<string>();

            while (command != "Lumpawaroo")
            {
                if (command.Contains("|"))
                {
                    string[] input = command.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string forceSide = input[0];
                    string forceUser = input[1];

                    if (forceRegister.ContainsKey(forceSide) == false)
                    {
                        if (forceUsers.Contains(forceUser) == false)
                        {
                            forceRegister.Add(forceSide, new List<string>());
                            forceRegister[forceSide].Add(forceUser);
                            forceUsers.Add(forceUser);
                        }
                    }
                    else
                    {
                        if (forceUsers.Contains(forceUser) == false)
                        {
                            forceRegister[forceSide].Add(forceUser);
                            forceUsers.Add(forceUser);
                        }
                    }
                }

                if (command.Contains("->"))
                {
                    string[] input = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string forceSide = input[1];
                    string forceUser = input[0];

                    if (forceUsers.Contains(forceUser))
                    {
                        string otherSide = forceRegister.First(x => x.Value.Contains(forceUser)).Key;
                        forceRegister[otherSide].Remove(forceUser);

                        if (forceRegister.ContainsKey(forceSide) == false)
                        {
                            forceRegister.Add(forceSide, new List<string>());
                        }

                        forceUsers.Add(forceUser);
                        forceRegister[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        if (forceRegister.ContainsKey(forceSide) == false)
                        {
                            forceUsers.Add(forceUser);
                            forceRegister.Add(forceSide, new List<string>());
                        }

                        forceRegister[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var side in forceRegister.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (side.Value.Count == 0)
                {
                    continue;
                }
                else
                {
                    side.Value.Sort();
                }

                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
