using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            string[] intpit = Console.ReadLine().Split();

            int number = int.Parse(intpit[0]);
            int power = int.Parse(intpit[1]);

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == number)
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, nums.Count - 1);

                    int lenght = right - left + 1;
                    nums.RemoveRange(left, lenght);
                    i = 0;
                }
            }

            Console.WriteLine(nums.Sum());
        }
    }
}
