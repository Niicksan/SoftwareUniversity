using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            int k = numbersArray.Length / 4;

            int[] upperArr = new int[k * 2];
            int[] lowerArray = new int[k * 2];

            upperArr = GetPartOneArray(numbersArray, k, upperArr);
            lowerArray = GetPartTwoArray(numbersArray, k, lowerArray);

            int[] sumArray = SumArrays(k, upperArr, lowerArray);

            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static int[] GetPartOneArray(int[] numbersArray, int k, int[] upperArr)
        {
            for (int index = 0; index < k; index++)
            {
                upperArr[index] = numbersArray[k - index - 1];
                upperArr[k + index] = numbersArray[numbersArray.Length - 1 - index];

            }

            return upperArr;
        }

        private static int[] GetPartTwoArray(int[] numbersArray, int k, int[] lowerArray)
        {
            for (int index = 0; index < 2 * k; index++)
            {
                lowerArray[index] = numbersArray[k + index];
            }

            return lowerArray;
        }

        static int[] SumArrays(int k, int[] upperArr, int[] lowerArray)
        {
            int[] sumArray = new int[2 * k];

            for (int index = 0; index < 2 * k; index++)
            {
                sumArray[index] = upperArr[index] + lowerArray[index];
            }

            return sumArray;
        }
    }
}
