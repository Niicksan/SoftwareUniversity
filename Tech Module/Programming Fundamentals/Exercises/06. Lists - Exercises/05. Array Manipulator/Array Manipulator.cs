using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {   // Work but 50/100
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> sumPair = new List<int>();
            string input = Console.ReadLine();

            while(true)
            {
                if (input == "print")
                {
                    break;
                }

                string[] commandsArr = input.Split();

                string command = commandsArr[0];

                if (command == "add")
                {
                    int index = int.Parse(commandsArr[1]);
                    int num = int.Parse(commandsArr[2]);

                    inputList.Insert(index, num);
                }

                else if (command == "addMany")
                {
                    int index = int.Parse(commandsArr[1]);
                    List<int> elementsToInsert = new List<int>();

                    for (int i = 2; i < commandsArr.Length; i++)
                    {
                        elementsToInsert.Add(int.Parse(commandsArr[i]));
                    }

                    List<int> currentResult = new List<int>();

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] != index)
                        {
                            currentResult.Add(inputList[i]);
                        }
                        else
                        {
                            currentResult.AddRange(elementsToInsert); 
                        }
                    }
                    inputList = currentResult;
                }

                else if (command == "contains")
                {
                    if (!inputList.Contains(int.Parse(commandsArr[1])))
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        for (int i = 0; i < inputList.Count; i++)
                        {
                            if (inputList.Contains(int.Parse(commandsArr[i])))
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                }

                else if (command == "remove")
                {
                    inputList.RemoveAt(int.Parse(commandsArr[1]));
                }

                else if (command == "shift")
                {
                    for (int i = 0; i < int.Parse(commandsArr[1]); i++)
                    {
                        ShiftElements(inputList);
                    }
                }

                else if (command == "sumPairs")
                {
                    int sum = 0;
                    

                    if (inputList.Count % 2 == 0)
                    {
                        for (int i = 0; i < inputList.Count - 1; i += 2)
                        {
                            sum += inputList[i] + inputList[i + 1];
                            sumPair.Add(sum);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < inputList.Count - 2; i += 2)
                        {
                            sum += inputList[i] + inputList[i + 1];
                            sumPair.Add(sum);
                        }
                        sumPair.Add(inputList[inputList.Count - 1]);
                        inputList = sumPair;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", inputList) + "]");
        }

        static void ShiftElements(List<int> inputList)
        {
            int[] array = new int[inputList.Count];
            array[array.Length - 1] = inputList[0];

            for (int i = array.Length - 2; i >= 0; i--)
            {
                array[i] = inputList[i + 1];
            }

            for (int i = 0; i < array.Length; i++)
            {
                inputList[i] = array[i];
            }
        }
    }
}
