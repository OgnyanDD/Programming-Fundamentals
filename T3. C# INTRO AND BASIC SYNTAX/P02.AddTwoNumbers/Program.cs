using System;

namespace P02.AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a + b;

            Console.WriteLine($"{a} + {b} = {c}");
        }
    }
}