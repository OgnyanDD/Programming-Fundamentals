using System;

namespace P05.WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            string plural = "";

            if (noun.EndsWith("y"))
            {
                plural = noun.Remove(noun.Length - 1, 1);
                Console.WriteLine(plural + "ies");
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }

        }
    }
}
