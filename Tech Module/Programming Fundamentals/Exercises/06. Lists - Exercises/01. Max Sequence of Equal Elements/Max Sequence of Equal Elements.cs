using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
           
            int currentLenght = 1;
            int bestLenght = 1;
            int bestIndex = 0;

            for (int i = 1; i < inputList.Count; i++)
            {
                if (inputList[i] == inputList[i - 1])
                {
                    currentLenght++;
                    if (bestLenght < currentLenght)
                    {
                        bestLenght = currentLenght;

                        bestIndex = i;
                    }
                }
                else
                {
                    currentLenght = 1;
                }
            }

            for (int i = bestIndex; i > bestIndex - bestLenght; i--)
            {
                Console.Write(inputList[i] + " ");
            }
        }
    }
}
