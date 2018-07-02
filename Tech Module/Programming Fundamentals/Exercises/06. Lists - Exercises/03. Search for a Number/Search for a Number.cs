using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] command = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> manipulatedList = new List<int>();

            int takeNums = command[0];
            int deletedNums = command[1];
            int searchNum = command[2];

            for (int i = 0; i < takeNums; i++)
            {
                manipulatedList.Add(inputList[i]);
            }

            for (int i = 0; i < deletedNums; i++)
            {
                manipulatedList.RemoveAt(0);
            }

            if (manipulatedList.Contains(searchNum))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
