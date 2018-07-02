using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> newList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commandLine = Console.ReadLine();

            while (true)
            {
                if (commandLine == "Odd" || commandLine == "Even")
                {
                    break;
                }

                string[] commands = commandLine.Split();

                if (commandLine.Contains("Delete"))
                {
                    if (commands[0] == "Delete")
                    {
                        int elToDelete = int.Parse(commands[1]);
                        for (int i = 0; i < newList.Count; i++)
                        {
                            newList.Remove(elToDelete);
                        }
                    }
                }
 
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    int num = int.Parse(commands[1]);

                    newList.Insert(index, num);
                }

                commandLine = Console.ReadLine();
            }

            List<int> result = new List<int>();

            if (commandLine == "Odd")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i] % 2 != 0)
                    {
                        result.Add(newList[i]);
                    }
                }
            }
            else if (commandLine == "Even")
            {
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i] % 2 == 0)
                    {
                        result.Add(newList[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
