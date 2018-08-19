using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<Dwarf>> colorsDwarfs = new Dictionary<string, List<Dwarf>>();

            List<Dwarf> allDwarfs = new List<Dwarf>();

            while (command != "Once upon a time")
            {
                string[] dwarfInfo = command
                    .Split(new char[] { ' ', '<', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = dwarfInfo[0];
                string color = dwarfInfo[1];
                int physics = int.Parse(dwarfInfo[2]);

                if (!colorsDwarfs.ContainsKey(color))
                {
                    colorsDwarfs[color] = new List<Dwarf>();
                }

                List<Dwarf> dwarfsByCurrentCoulor = colorsDwarfs[color];
                Dwarf foundDwarf = dwarfsByCurrentCoulor.FirstOrDefault(d => d.Name == name);

                if (foundDwarf != null)
                {
                    foundDwarf.Physics = Math.Max(physics, foundDwarf.Physics);
                }
                else
                {
                    Dwarf dwarf = new Dwarf
                    {
                        Name = name,
                        Color = color,
                        Physics = physics
                    };

                    dwarfsByCurrentCoulor.Add(dwarf);
                    allDwarfs.Add(dwarf);
                }

                command = Console.ReadLine();
            }

            List<Dwarf> result = allDwarfs.OrderByDescending(x => x.Physics).ThenByDescending(d => colorsDwarfs[d.Color].Count()).ToList();

            foreach (var dwarf in result)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    public class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
    }
}