using System;
using System.Collections.Generic;

namespace P03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectorOfResourses = new Dictionary<string, int>();

            while (true)
            {
                string resourse = Console.ReadLine();

                if (resourse == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());



                if (!(collectorOfResourses.ContainsKey(resourse)))
                {
                    collectorOfResourses.Add(resourse, quantity);

                }
                else
                {
                    collectorOfResourses[resourse] += quantity;
                }
            }

            foreach (var print in collectorOfResourses)
            {
                Console.WriteLine($"{print.Key} -> {print.Value}");
            }
        }
    }
}
