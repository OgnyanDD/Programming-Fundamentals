using System;

namespace P09.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            char thirdCh = char.Parse(Console.ReadLine());

            Console.WriteLine("{2}{1}{0}", firstCh, secondCh, thirdCh);
        }
    }
}
