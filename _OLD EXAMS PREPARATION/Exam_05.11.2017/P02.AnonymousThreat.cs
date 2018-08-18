using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P02.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            while (true)
            {
                string line = Console.ReadLine().ToLower();

                if (line == "3:1")
                {
                    break;
                }
                string[] data = line.Split();

                string command = data[0];

                switch (command)
                {
                    case "merge":
                        {
                            int startIndex = int.Parse(data[1]);
                            int endIndex = int.Parse(data[2]);

                            if (startIndex < 0)
                            {
                                startIndex = 0;
                            }
                            if (startIndex > input.Count - 1)
                            {
                                startIndex = input.Count - 1;
                            }
                            if (endIndex < 0)
                            {
                                endIndex = 0;
                            }
                            if (endIndex > input.Count - 1)
                            {
                                endIndex = input.Count - 1;
                            }

                            int count = endIndex - startIndex + 1;

                            List<string> tempList = input.Skip(startIndex).Take(count).ToList();

                            string tempString = string.Join("", tempList);

                            input.RemoveRange(startIndex, count);
                            input.Insert(startIndex, tempString);

                        }
                        break;

                    case "divide":
                        {
                            int index = int.Parse(data[1]);
                            int partition = int.Parse(data[2]);
                            string word = input[index];

                            List<string> tempList = new List<string>();

                            int part = word.Length / partition;

                            for (int i = 0; i < word.Length; i += part)
                            {
                                if (tempList.Count < partition - 1)
                                {
                                    string tempString = word.Substring(i, part);
                                    tempList.Add(tempString);
                                }
                                else
                                {
                                    string tempString = word.Substring(i, word.Length - i);
                                    tempList.Add(tempString);
                                    break;
                                }
                            }
                            input.RemoveAt(index);
                            input.InsertRange(index, tempList);
                        }
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
