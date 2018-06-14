using System;
using System.Linq;
using System.Text;

namespace P01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reverse = input.Aggregate(new StringBuilder(), (x, y) => x.Insert(0, y)).ToString();

            //  char[] reverse = input.Reverse().ToArray();

            Console.WriteLine(reverse);
        }
    }
}
