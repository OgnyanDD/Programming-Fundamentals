using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] input = line.Split(' ', '=');

                string ip = input[1];
                string user = input[5];

                if (userLogs.ContainsKey(user) == false)
                {
                    userLogs[user] = new Dictionary<string, int>();
                }
                if (userLogs[user].ContainsKey(ip) == false)
                {
                    userLogs[user][ip] = 0;
                }
                userLogs[user][ip]++;
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
