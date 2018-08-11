using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> users = new SortedDictionary<string, SortedDictionary<string, int>> ();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();

                string ip = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);

                if (users.ContainsKey(user) == false)
                {
                    users.Add(user, new SortedDictionary<string, int>());
                }
                if (users[user].ContainsKey(ip) == false)
                {
                    users[user].Add(ip, duration);
                }
                else
                {
                    users[user][ip] += duration; 
                }
            }
            foreach (var user in users)
            {
                int totalDurationOfUser = users[user.Key].Values.Sum();

                List<string> listOfIp = user.Value.Keys.ToList();

                Console.WriteLine($"{user.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIp)}]");
            }
        }
    }
}
