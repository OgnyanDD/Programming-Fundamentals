using System;

namespace P04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal peopleNumber = decimal.Parse(Console.ReadLine());
            decimal elevatorCapacity = decimal.Parse(Console.ReadLine());

            decimal result = Math.Ceiling(peopleNumber / elevatorCapacity);

            Console.WriteLine(result);
        }
    }
}
