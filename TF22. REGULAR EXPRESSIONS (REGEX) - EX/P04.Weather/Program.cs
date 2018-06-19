using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([A-Z][A-Z])(\d+\.\d+)([A-Za-z]+)(\|)";

            Dictionary<string, string> forecastWeather = new Dictionary<string, string>();
            Dictionary<string, double> forecastTemperature = new Dictionary<string, double>();

            while (input != "end")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string town = match.Groups[1].Value;
                    double temerature = double.Parse(match.Groups[2].Value);
                    string weather = match.Groups[3].Value;

                    if (forecastWeather.ContainsKey(town) == false)
                    {
                        forecastWeather.Add(town, weather);
                        forecastTemperature.Add(town, temerature);
                    }
                    else
                    {
                        forecastWeather[town] = weather;
                        forecastTemperature[town] = temerature;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var town in forecastTemperature.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{town.Key} => {town.Value:f2} => {forecastWeather[town.Key]}");
            }
        }
    }
}
