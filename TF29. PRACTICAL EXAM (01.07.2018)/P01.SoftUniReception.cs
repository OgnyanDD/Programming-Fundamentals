using System;

namespace P01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmp = int.Parse(Console.ReadLine());
            int secondEmp = int.Parse(Console.ReadLine());
            int thirdEmp = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int sumEmp = firstEmp + secondEmp + thirdEmp;

            int counter = 0;

            while (students > 0)
            {
                students -= sumEmp;
                counter++;

                if (counter % 4 == 0)
                {
                    students += sumEmp;
                }
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}