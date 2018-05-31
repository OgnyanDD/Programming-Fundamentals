using System;

namespace P08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientsNumber = int.Parse(Console.ReadLine());
            int caloriesCounter = 0;
            int totalCalories = 0;


            for (int i = 0; i < ingredientsNumber; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                switch (ingredients)
                {
                    case "cheese":
                        caloriesCounter = 500;
                        break;
                    case "tomato sauce":
                        caloriesCounter = 150;
                        break;
                    case "salami":
                        caloriesCounter = 600;
                        break;
                    case "pepper":
                        caloriesCounter = 50;
                        break;
                    default:
                        caloriesCounter = 0;
                        break;
                }
                totalCalories += caloriesCounter;
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
