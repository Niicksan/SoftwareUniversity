using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Snowwhite
    {
        static void Main(string[] args)
        {
            string snowWhite = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();
            while (snowWhite != "Once upon a time")
            {
                string[] dwartData = snowWhite.Split(new string[] { " <:> " }, StringSplitOptions.None).ToArray();

                string dwarfName = dwartData[0];
                string dwarfHatColor = dwartData[1];
                int dwarfPhysics = int.Parse(dwartData[2]);

                if (!dwarfs.ContainsKey(dwarfHatColor))
                {
                    dwarfs.Add(dwarfHatColor, new Dictionary<string, int>());
                }

                if (!dwarfs[dwarfHatColor].ContainsKey(dwarfName))
                {
                    dwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                }

                if (dwarfs[dwarfHatColor][dwarfName] < dwarfPhysics)
                {
                    dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                }

                snowWhite = Console.ReadLine();
            }

            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
            foreach (var hatColor in dwarfs.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in hatColor.Value)
                {
                    sortedDwarfs.Add($"({hatColor.Key}) {dwarf.Key} <-> ", dwarf.Value);
                }
            }

            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
        }
    }
}
