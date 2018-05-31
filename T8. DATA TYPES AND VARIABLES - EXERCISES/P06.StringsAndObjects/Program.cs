using System;

namespace P06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";

            object sumWord = word1 + " " + word2;

            string final = (string)sumWord;

            Console.WriteLine(final);
        }
    }
}
