using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<string> listArr = new List<string>();
            while (command != "course start")
            {
                if (command.Contains(','))
                {
                    string[] data = command.Split(", ").ToArray();

                    foreach (var item in data)
                    {
                        listArr.Add(item);
                    }
                }
                else if (command.Contains(':'))
                {
                    string[] data = command.Split(':').ToArray();

                    if (data[0] == "Add")
                    {
                        bool exist = false;
                        for (int i = 0; i < listArr.Count - 1; i++)
                        {
                            if (listArr[i] == data[1])
                            {
                                exist = true;
                            }
                        }
                        if (exist == false)
                        {
                            string add = data[1];
                            listArr.Add(add);
                        }
                    }
                    if (data[0] == "Insert")
                    {
                        bool exist = false;
                        for (int i = 0; i < listArr.Count - 1; i++)
                        {
                            if (listArr[i] == data[1])
                            {
                                exist = true;
                            }
                        }
                        if (exist == false)
                        {
                            string insertItem = data[1];
                            int index = int.Parse(data[2]);
                            listArr.Insert(index, insertItem);
                        }
                    }
                    if (data[0] == "Remove")
                    {
                        bool exist = true;
                        for (int i = 0; i < listArr.Count - 1; i++)
                        {
                            if (listArr[i] == data[1])
                            {
                                exist = false;
                            }
                        }
                        if (exist == false)
                        {

                            string removeItem = data[1];
                            listArr.Remove(removeItem);
                        }
                    }
                    if (data[0] == "Swap")
                    {
                        string swapItem1 = data[1];
                        string swapItem2 = data[2];

                        string swappedOne = "";
                        string swappedTwo = "";

                        for (int i = 0; i < listArr.Count; i++)
                        {
                            if (listArr[i] == swapItem1)
                            {
                                swappedOne = listArr[i];

                            }
                            if (listArr[i] == swapItem2)
                            {
                                swappedTwo = listArr[i];
                            }
                        }

                        for (int i = 0; i < listArr.Count; i++)
                        {
                            if (listArr[i] == swapItem1)
                            {
                                listArr[i] = swappedTwo;
                                continue;
                            }
                            else if (listArr[i] == swapItem2)
                            {
                                listArr[i] = swappedOne;
                            }
                        }

                    }
                    if (data[0] == "Exercise")
                    {
                        string exercise = data[0];
                        string lesson = data[1];

                        string exerciseLesson = $"{lesson}-{exercise}";

                        bool isFind = false;
                        int indexOfFInd = 0;
                        for (int i = 0; i < listArr.Count - 1; i++)
                        {
                            if (listArr[i] == lesson)
                            {
                                isFind = true;
                                indexOfFInd = i;
                            }
                        }

                        if (isFind)
                        {
                            listArr.Insert(indexOfFInd + 1, exerciseLesson);
                        }
                        else
                        {
                            listArr.Add(lesson);
                            listArr.Add(exerciseLesson);
                        }

                    }
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < listArr.Count; i++)
            {
                Console.Write(i + 1 + ".");
                Console.WriteLine(listArr[i]);
            }
        }

    }
}
