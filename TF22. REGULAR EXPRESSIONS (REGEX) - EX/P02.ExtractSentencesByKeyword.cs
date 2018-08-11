using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string search = Console.ReadLine();

            string pattern = $@"\b{search}\b";

            Regex regex = new Regex(pattern);


            string[] arr = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim()).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                MatchCollection match = regex.Matches(arr[i]);

                foreach (Match item in match)
                {
                    if (item.Value.Contains(search))
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }
    }
}
