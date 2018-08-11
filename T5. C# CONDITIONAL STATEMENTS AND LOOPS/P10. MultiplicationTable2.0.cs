using System;

namespace P10._MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int result = n * i;
                    Console.WriteLine($"{n} X {i} = {result}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
            }
        }
    }
}
