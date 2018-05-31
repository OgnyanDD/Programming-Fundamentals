using System;

namespace P01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello, {NameMethod(inputName)}!");
        }

        static string NameMethod(string name)
        {
            return name;
        }
    }
}
