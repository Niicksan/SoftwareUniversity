using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {   // Works 100/100
            List<int> inputNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] elements = command.Split().ToArray();
                string operation = elements[0];

                if (operation == "add")
                {
                    int index = int.Parse(elements[1]);
                    int item = int.Parse(elements[2]);

                    inputNums.Insert(index, item);
                }
                else if (operation == "addMany")
                {
                    int index = int.Parse(elements[1]);
                    List<int> addNums = new List<int>();

                    for (int i = 2; i < elements.Length; i++)
                    {
                        addNums.Add(int.Parse(elements[i]));
                    }

                    inputNums.InsertRange(index, addNums);
                }
                else if (operation == "contains")
                {
                    int index = inputNums.IndexOf(int.Parse(elements[1]));

                    Console.WriteLine(index);
                }
                else if (operation == "remove")
                {
                    int index = int.Parse(elements[1]);

                    inputNums.RemoveAt(index);
                }
                else if (operation == "shift")
                {
                    int positionsToMove = int.Parse(elements[1]);

                    for (int j = 0; j < positionsToMove; j++)
                    {
                        int firstElement = inputNums[0];

                        for (int i = 1; i < inputNums.Count; i++)
                        {
                            inputNums[i - 1] = inputNums[i];
                        }

                        inputNums[inputNums.Count - 1] = firstElement;
                    }
                }
                else if (operation == "sumPairs")
                {
                    for (int i = 0; i < inputNums.Count - 1; i += 2)
                    {
                        inputNums[i] += inputNums[i + 1];
                        inputNums[i + 1] = -1;
                    }

                    inputNums.RemoveAll(x => x == -1);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", inputNums) + "]");
        }
    }
}
