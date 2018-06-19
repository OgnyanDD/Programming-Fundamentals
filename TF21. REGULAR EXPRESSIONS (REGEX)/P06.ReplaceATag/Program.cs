using System;
using System.Text.RegularExpressions;

namespace P06.ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.*?href=(.+?)>(.+?)<\/a>";

            Regex regex = new Regex(pattern);

            string htmlText = Console.ReadLine();

            while (htmlText != "end")
            {
                string replacment = "[URL href=$1]$2[/URL]";

                string result = regex.Replace(htmlText, replacment);

                Console.WriteLine(result);

                htmlText = Console.ReadLine();
            }
        }
    }
}
