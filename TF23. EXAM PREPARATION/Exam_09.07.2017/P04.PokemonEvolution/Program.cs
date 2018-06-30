using System;
using System.Collections.Generic;

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
                        pokemons.Add(pokemonName, new List<string>( ));
                    }

                    sr

                }
                else
                {

                }
            }



        }
    }
}
