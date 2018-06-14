using System;

namespace P02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToLower();
            string searchString = Console.ReadLine().ToLower();

            int counter = 0;
            int index = inputString.IndexOf(searchString);

            while (index != - 1)
            {
                counter++;

                index = inputString.IndexOf(searchString, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
