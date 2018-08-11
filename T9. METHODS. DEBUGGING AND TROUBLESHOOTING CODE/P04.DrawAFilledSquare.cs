using System;

namespace P04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            TopBottomLine(input);
            BodyPart(input);
            TopBottomLine(input);
        }
        static void TopBottomLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void BodyPart(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');

                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}