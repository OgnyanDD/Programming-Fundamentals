using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList(); // read List of string and split by '|'
            List<string> result = new List<string>(); // create new List of string

            input.Reverse(); // reverse input List

            for (int i = 0; i < input.Count; i++)
            {
                string text = input[i]; // create new string and add input[i]

                string[] splitted = text.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries); // create new string[] and split by " "

                string merged = string.Join(" ", splitted); // create new string and join splited[] elements with " "

                result.Add(merged); // add merged string to result List
            }

            Console.WriteLine(string.Join(" ", result)); // print result List
        }
    }
}
