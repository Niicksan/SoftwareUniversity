using System;
using System.Linq;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWordsOne = Console.ReadLine().Split(' ');
            string[] arrayOfWordsTwo = Console.ReadLine().Split(' ');

            int minLength = Math.Min(arrayOfWordsOne.Length, arrayOfWordsTwo.Length);

            int countLeft = FindCommonStart(arrayOfWordsOne, arrayOfWordsTwo, minLength);
            int countRight = FindCommonEnd(arrayOfWordsOne, arrayOfWordsTwo, minLength);

            Console.WriteLine(Math.Max(countLeft, countRight));
        }

        static int FindCommonStart(string[] arrayOfWordsOne, string[] arrayOfWordsTwo, int minLength)
        {
            int counterLeft = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (arrayOfWordsOne[i] == arrayOfWordsTwo[i])
                {
                    counterLeft++;
                }
            }

            return counterLeft;
        }

        static int FindCommonEnd(string[] arrayOfWordsOne, string[] arrayOfWordsTwo, int minLength)
        {
            int counterRight = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (arrayOfWordsOne[arrayOfWordsOne.Length - 1 - i] == arrayOfWordsTwo[arrayOfWordsTwo.Length - 1 - i])
                {
                    counterRight++;
                }
            }

            return counterRight;
        }
    }
}
