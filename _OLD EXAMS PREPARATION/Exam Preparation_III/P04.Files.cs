using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> filePaths = new List<string>();
            Dictionary<string, long> fileRegister = new Dictionary<string, long>();

            for (int i = 0; i < n; i++)
            {
                string filePath = Console.ReadLine();
                filePaths.Add(filePath);
            }

            string[] searchedFile = Console.ReadLine()
                .Split(' ').ToArray();

            string searchedExtention = searchedFile[0];
            string searchedRoot = searchedFile[2];

            foreach (var file in filePaths)
            {
                string[] path = file.Split(new char[] { '\\', ';' })
                    .Select(x => x.Trim())
                    .ToArray();

                string root = path[0];
                string fileKey = path[path.Length - 2];
                string[] extentionArr = fileKey.Split('.')
                    .Select(x => x.Trim())
                    .ToArray();

                string extention = extentionArr.Last();

                if (root == searchedRoot && extention == searchedExtention)
                {
                    long size = long.Parse(path[path.Length - 1]);

                    if (fileRegister.ContainsKey(fileKey) == false)
                    {
                        fileRegister.Add(fileKey, size);
                    }
                    else
                    {
                        fileRegister[fileKey] = size;
                    }
                }
            }

            if (fileRegister.Any())
            {
                foreach (var file in fileRegister.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
