using System;

namespace P09._MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int multiplication = n * i;
                Console.WriteLine($"{n} X {i} = {multiplication}");
            }
        }
    }
}
