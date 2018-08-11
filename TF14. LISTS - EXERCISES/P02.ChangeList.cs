using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
               List<int> input = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Delete")
                {
                    input.RemoveAll(x => x == int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    input.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            Console.Write($"{input[i]} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (command[0] == "Odd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 != 0)
                        {
                            Console.Write($"{input[i]} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
