using System;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxStart = 0;
            int maxLen = 0;
            int currentStart = 0;
            int currentLen = 0;

            for (int i = 1; i < inputArr.Length; i++)
            {
                if (inputArr[i] - inputArr[i - 1] >= 1)
                {
                    currentLen++;
                    currentStart = i - currentLen;

                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentLen = 0;
                }
            }

            for (int k = maxStart; k <= maxStart + maxLen; k++)
            {
                Console.Write("{0} ", inputArr[k]);
            }
            Console.WriteLine();
        }
    }
}
