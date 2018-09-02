using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Grains_of_Sands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "Mort")
            {
                string[] tokens = command.Split().ToArray();
                string operation = tokens[0];

                //Add
                if (operation == "Add")
                {
                    int add = int.Parse(tokens[1]);

                    numbers.Add(add);
                }
                //Remove
                else if (operation == "Remove")
                {
                    int remove = int.Parse(tokens[1]);
                    bool found = false;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == remove)
                        {
                            found = true;
                            numbers.RemoveAt(i);
                            break;
                        }
                    }

                    if (!found)
                    {
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if (j == remove)
                            {
                                numbers.RemoveAt(j);
                                break;

                            }
                        }
                    }
                }
                // Replace
                else if (operation == "Replace")
                {
                    int value = int.Parse(tokens[1]);
                    int replacement = int.Parse(tokens[2]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == value)
                        {
                            numbers[i] = replacement;
                            break;
                        }
                    }
                }
                // Increase
                else if (operation == "Increase")
                {
                    int value = int.Parse(tokens[1]);
                    int increase = 0;
                    bool found = false;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= value)
                        {
                            found = true;
                            increase = numbers[i];
                            break;
                        }
                    }

                    if (!found)
                    {
                        for (int i = numbers.Count - 1; i >= 0; i--)
                        {
                            increase = numbers[i];
                            break;
                        }
                    }

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] += increase;
                    }
                }
                // Collapse
                else if (operation == "Collapse")
                {
                    int value = int.Parse(tokens[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < value)
                        {
                            numbers.RemoveAt(i);
                            i = -1;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}