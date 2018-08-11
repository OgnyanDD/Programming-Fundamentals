using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "wubbalubbadubdub")
                {
                    break;
                }
                string[] tokens = line.Split(" -> ");

                if (tokens.Length == 3)
                {
                    string pokemonName = tokens[0];
                    string evolutionName = tokens[1];
                    string evolutionIndex = tokens[2];

                    if (pokemons.ContainsKey(pokemonName) == false)
                    {
                        pokemons.Add(pokemonName, new List<string>());
                    }

                    string evolution = evolutionName + " <-> " + evolutionIndex;
                    pokemons[pokemonName].Add(evolution);
                }
                else
                {
                    string pokemonNameToPrint = tokens[0];

                    if (pokemons.ContainsKey(pokemonNameToPrint))
                    {
                        Console.WriteLine($"# {pokemonNameToPrint}");

                        List<string> evolutions = pokemons[pokemonNameToPrint];

                        foreach (var evolution in evolutions)
                        {
                            Console.WriteLine(evolution);
                        }
                    }
                }
            }
            foreach (var pokemon in pokemons)
            {
                string pokemonName = pokemon.Key;

                Console.WriteLine($"# {pokemonName}");

                List<string> orderedEvolutions = pokemon.Value.OrderByDescending(e =>
                {
                    int index = int.Parse(e.Split(" <-> ")[1]);
                    return index;
                }).ToList();

                foreach (var orderedEvolution in orderedEvolutions)
                {
                    Console.WriteLine(orderedEvolution);
                }
            }
        }
    }
}
