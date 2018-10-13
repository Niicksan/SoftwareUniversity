using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hit_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> information = new Dictionary<string, Dictionary<string, string>>();

            int targetIndex = int.Parse(Console.ReadLine());

            string personInfo = Console.ReadLine();

            while (personInfo != "end transmissions")
            {
                string[] info = personInfo.Split(";", StringSplitOptions.RemoveEmptyEntries);

                string name = "";

                for (int i = 0; i < info.Length; i++)
                {
                    string[] currentPersonInfo = info[i].Split(new char[] { '=', ':' }, StringSplitOptions.RemoveEmptyEntries);

                    if (currentPersonInfo.Length > 2)
                    {
                        string currName = currentPersonInfo[0];
                        string key = currentPersonInfo[1];
                        string value = currentPersonInfo[2];

                        name = currName;

                        if (!information.ContainsKey(currName))
                        {
                            information.Add(currName, new Dictionary<string, string>());
                        }

                        if (!information[currName].ContainsKey(key))
                        {
                            information[currName].Add(key, string.Empty);
                        }

                        information[currName][key] = value;
                    }
                    else
                    {
                        string key = currentPersonInfo[0];
                        string value = currentPersonInfo[1];

                        if (!information[name].ContainsKey(key))
                        {
                            information[name].Add(key, string.Empty);
                        }

                        information[name][key] = value;
                    }
                }

                personInfo = Console.ReadLine();
            }

            string[] kill = Console.ReadLine().Split();
            int index = 0;

            foreach (var person in information)
            {
                if (person.Key == kill[1])
                {
                    Console.WriteLine($"Info on {person.Key}:");

                    foreach (var item in person.Value.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"---{item.Key}: {item.Value}");

                        index += item.Key.Length;
                        index += item.Value.Length;
                    }
                }
            }

            Console.WriteLine($"Info index: {index}");

            if (index >= targetIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {targetIndex - index} more info.");
            }
        }
    }
}