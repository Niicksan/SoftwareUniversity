using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            int k = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[array.Length];
            long[] sumArray = new long[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                numbersArray[i] = int.Parse(array[i]);
            }

            for (int i = 1; i <= k; i++)
            {
                if (i == 1)
                {
                    numbersArray = RotateArray(numbersArray);
                    sumArray = CopyArray(numbersArray, sumArray);

                }
                else
                {
                    numbersArray = RotateArray(numbersArray);
                    sumArray = SumArrays(numbersArray, sumArray);
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }

        static long[] CopyArray(int[] numbersArray, long[] sumArray)
        {
            for (int index = 0; index < sumArray.Length; index++)
            {
                sumArray[index] = numbersArray[index];
            }

            return sumArray;
        }

        static long[] SumArrays(int[] numbersArray, long[] summedArray)
        {
            for (int index = 0; index < numbersArray.Length; index++)
            {
                summedArray[index] += numbersArray[index];
            }
            return summedArray;
        }

        static int[] RotateArray(int[] arrayNumbers)
        {
            int lastElement = arrayNumbers[arrayNumbers.Length - 1];
            int[] rotatedElement = new int[arrayNumbers.Length];
            rotatedElement[0] = lastElement;

            for (int index = 1; index < arrayNumbers.Length; index++)
            {
                rotatedElement[index] = arrayNumbers[index - 1];

            }

            return rotatedElement;
        }
    }
}