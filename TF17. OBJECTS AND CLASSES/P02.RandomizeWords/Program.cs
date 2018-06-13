using System;

namespace P02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int number = random.Next(0, words.Length);
                string oldValue = words[number];
                words[number] = words[i];
                words[i] = oldValue;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
