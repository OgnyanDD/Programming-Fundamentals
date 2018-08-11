using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Dictionary -> countries and cityes
            // Create Dictionary -> countries and total population
            // Read input
            // Fill dictionaries
            // Sort countries
            // Country -> sort cityes
            // Print

            Dictionary<string, long> totalPopulation = new Dictionary<string, long>(); // For every country total sum of population in the cityes
            Dictionary<string, Dictionary<string, long>> countriesAndCityes = new Dictionary<string, Dictionary<string, long>>(); // key Country, value (key city, value population)

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "report")
                {
                    break;
                }

                string[] tokens = line.Split('|');

                string city = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);

                if (totalPopulation.ContainsKey(country) == false)
                {
                    totalPopulation.Add(country, 0);
                    countriesAndCityes.Add(country, new Dictionary<string, long>());
                }

                totalPopulation[country] += population;
                countriesAndCityes[country].Add(city, population);

            }
            foreach (var country in totalPopulation.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                Dictionary<string, long> cities = countriesAndCityes[country.Key]
                       .OrderByDescending(c => c.Value)
                       .ToDictionary(x => x.Key, x => x.Value);

                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
