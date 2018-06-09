using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Largest3Numb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
           .Split(' ')
           .Select(int.Parse)
           .OrderByDescending(n => n)
           .Take(3)
           .ToList();

            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
