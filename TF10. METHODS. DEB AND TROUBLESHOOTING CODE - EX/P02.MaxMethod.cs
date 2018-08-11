using System;

namespace P02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxTotal = Math.Max(c, GetMax(a, b));

            Console.WriteLine(maxTotal);
        }

        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);
            return max;
        }
    }
}
