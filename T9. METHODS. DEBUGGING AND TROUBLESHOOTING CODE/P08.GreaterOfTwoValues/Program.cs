using System;

namespace P08.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine(TypeInt(a, b));
            }
            else if (input == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                Console.WriteLine(TypeChar(a, b));
            }
            else if (input == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                Console.WriteLine(TypeString(a, b));
            }

        }
        static int TypeInt(int a, int b)
        {
            if (a >= b)
            {
                return (a);
            }
            else
            {
                return (b);
            }
        }
        static char TypeChar(char a, char b)
        {
            if (a >= b)
            {
                return (a);
            }
            else
            {
                return (b);
            }
        }
        static string TypeString(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return (a);
            }
            else
            {
                return (b);
            }
        }
    }
}