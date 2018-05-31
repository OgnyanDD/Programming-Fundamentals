using System;

namespace P07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                string inputCommand = Console.ReadLine();

                if (!(inputCommand.Equals("Bake!")))
                {
                    Console.WriteLine($"Adding ingredient {inputCommand}.");
                    counter++;
                }
                else if (inputCommand.Equals("Bake!") || counter > 20)
                {
                    break;
                }
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
