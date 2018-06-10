﻿using System;
using System.Collections.Generic;

namespace P02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] tokens = line.Split();

                string command = tokens[0];

                switch (command)
                {
                    case "A":

                        string name = tokens[1];
                        string phone = tokens[2];

                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = phone;
                        }
                        else
                        {
                            phonebook.Add(name, phone);
                        }
                        break;

                    case "S":

                        string searchName = tokens[1];

                        if (phonebook.ContainsKey(searchName))
                        {
                            string foundNumber = phonebook[searchName];

                            Console.WriteLine($"{searchName} -> {foundNumber}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {searchName} does not exist.");
                        }
                        break;

                    case "ListAll":

                        foreach (var print in phonebook)
                        {
                            Console.WriteLine($"{print.Key} -> {print.Value}");
                        }
                        break;
                }
            }
        }
    }
}
