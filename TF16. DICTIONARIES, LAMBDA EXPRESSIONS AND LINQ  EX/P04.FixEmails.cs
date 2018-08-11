using System;
using System.Collections.Generic;

namespace P04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> namesAndEmails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                if (namesAndEmails.ContainsKey(name))
                {
                    namesAndEmails[name] = email;
                }
                else
                {
                    namesAndEmails.Add(name, email);
                }

                if (namesAndEmails[name].EndsWith("uk") || namesAndEmails[name].EndsWith("us"))
                {
                    namesAndEmails.Remove(name);
                }
            }
            foreach (var print in namesAndEmails)
            {
                Console.WriteLine($"{print.Key} -> {print.Value}");
            }
        }
    }
}
