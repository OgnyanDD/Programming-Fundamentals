using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Play!")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = data[0];

                switch (command)
                {
                    case "Install":
                        InstallGame(data, games);
                        break;
                    case "Uninstall":
                        UninstallGame(data, games);
                        break;
                    case "Update":
                        Update(data, games);
                        break;
                    case "Expansion":
                        AddExpansion(data, games);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", games));
        }

        private static void AddExpansion(string[] data, List<string> games)
        {
            string game = data[1].Split('-')[0];
            string expansion = data[1].Split('-')[1];

            string currentGame = games.FirstOrDefault(a => a == game);

            if (currentGame != null)
            {
                int indexOf = games.IndexOf(game) + 1;
                games.Insert(indexOf, game + ":" + expansion);
            }
        }

        private static void Update(string[] data, List<string> games)
        {
            string game = data[1];

            string currentGame = games.FirstOrDefault(a => a == game);

            if (currentGame != null)
            {
                games.Remove(currentGame);
                games.Add(game);
            }
        }

        private static void UninstallGame(string[] data, List<string> games)
        {
            string game = data[1];

            string currentGame = games.FirstOrDefault(a => a == game);

            if (currentGame != null)
            {
                games.Remove(currentGame);
            }
        }

        private static void InstallGame(string[] data, List<string> games)
        {
            string game = data[1];

            string currentGame = games.FirstOrDefault(a => a == game);

            if (currentGame == null)
            {
                games.Add(game);
            }
        }
    }
}
