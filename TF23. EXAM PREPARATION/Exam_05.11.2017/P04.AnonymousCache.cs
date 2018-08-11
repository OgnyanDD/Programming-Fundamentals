using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> dataInfo = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cashInfo = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> sumInfo = new Dictionary<string, long>();

            while (command != "thetinggoesskrra")
            {
                string[] data = command
                    .Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (data.Length == 1)
                {
                    string dataSet = data[0];
                    dataInfo[dataSet] = new Dictionary<string, long>();
                    sumInfo.Add(dataSet, 0);

                    if (cashInfo.ContainsKey(dataSet))
                    {
                        dataInfo[dataSet] = cashInfo[dataSet];

                        foreach (var pair in dataInfo[dataSet])
                        {
                            sumInfo[dataSet] += pair.Value;
                        }
                        cashInfo.Remove(dataSet);
                    }
                }
                else
                {
                    var dataSet = data[2];
                    var dataKey = data[0];
                    var dataSize = long.Parse(data[1]);

                    if (dataInfo.ContainsKey(dataSet))
                    {
                        dataInfo[dataSet].Add(dataKey, dataSize);
                        sumInfo[dataSet] += dataSize;
                    }
                    else
                    {
                        if (cashInfo.ContainsKey(dataSet) == false)
                        {
                            cashInfo.Add(dataSet, new Dictionary<string, long>());
                        }
                        cashInfo[dataSet].Add(dataKey, dataSize);
                    }
                }

                command = Console.ReadLine();
            }

            if (dataInfo.Count > 0)
            {
                var bestSet = sumInfo.OrderByDescending(x => x.Value).Select(x => x.Key).ToList().First();
                var bestSum = sumInfo.OrderByDescending(x => x.Value).Select(x => x.Value).ToList().First();

                Console.WriteLine($"Data Set: {bestSet}, Total Size: {bestSum}");
                foreach (var key in dataInfo[bestSet])
                {
                    Console.WriteLine($"$.{key.Key}");
                }
            }
        }
    }
}
