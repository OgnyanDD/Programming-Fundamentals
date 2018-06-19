using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToArray();

            string inputLine = Console.ReadLine();


            int skipping = numbers[0];
            int taking = numbers[1];

            string pattern = $@"(\|<\w{{{skipping}}})(\w{{{1},{taking}}})";

            MatchCollection matches = Regex.Matches(inputLine, pattern);

            List<string> validPhotos = matches
                .Cast<Match>()
                .Select(x => x.Groups[2].Value)
                .ToList();

            Console.WriteLine(string.Join(", ", validPhotos));
        }
    }
}
