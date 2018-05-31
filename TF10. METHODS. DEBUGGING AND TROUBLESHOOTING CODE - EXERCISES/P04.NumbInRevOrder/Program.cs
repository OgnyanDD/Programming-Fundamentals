using System;

namespace P04.NumbInRevOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReverseOrder(input));
        }

        static string ReverseOrder(string n)
        {
            char[] digit = n.ToCharArray();
            string newDigit = "";

            for (int i = n.Length - 1; i >= 0; i--)
            {
                newDigit += digit[i];
            }
            return newDigit;
        }
    }
}
