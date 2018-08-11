using System;

namespace P14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            for (char i = firstChar; i <= secondChar; i++)
            {
                for (char j = firstChar; j <= secondChar; j++)
                {
                    for (char k = firstChar; k <= secondChar; k++)
                    {

                        if (!(i.Equals(thirdChar)) && !(j.Equals(thirdChar)) && !(k.Equals(thirdChar)))
                        {

                            Console.Write("{0}{1}{2} ", i, j, k);
                        }
                    }
                }
            }
        }
    }
}

