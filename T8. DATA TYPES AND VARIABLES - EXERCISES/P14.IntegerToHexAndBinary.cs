using System;

namespace P14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string toHex = Convert.ToString(input, 16).ToUpper();
            string toBinary = Convert.ToString(input, 2).ToUpper();

            Console.WriteLine(toHex);
            Console.WriteLine(toBinary);
        }
    }
}
