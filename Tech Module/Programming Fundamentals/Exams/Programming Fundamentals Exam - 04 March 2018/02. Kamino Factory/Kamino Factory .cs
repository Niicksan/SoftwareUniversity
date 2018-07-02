using System;
using System.Linq;

namespace _02._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string sequence = Console.ReadLine();           

            int bestLen = -1;
            int startIndex = -1;
            int bestDnaSum = 0;
            int bestSampleIndex = 0;

            int currentSampleIndex = 0;

            int count = 0;
            string[] bestDna = null;
            while (sequence != "Clone them!")
            {
                string[] dna = sequence.Split('!', StringSplitOptions.RemoveEmptyEntries).ToArray();
                count++;

                int currentLength = 0;
                int maxLength = 0;
                int currentEndIndex = 0;

                for (int i = 0; i < dna.Length - 1; i++)
                {
                    if (dna[i] == "1")
                    {
                        currentLength++;
                        if (currentLength > maxLength)
                        {
                            currentEndIndex = i;
                            maxLength = currentLength;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                    }

                }

                int currentStartIndex = currentEndIndex - maxLength + 1;

                bool isCurrentDnaBetter = false;
                int currentDnaSum = dna.Select(int.Parse).Sum();

                if (maxLength > bestLen)
                {
                    isCurrentDnaBetter = true;
                }
                else if (maxLength == bestLen)
                {
                    if (currentStartIndex < startIndex)
                    {
                        isCurrentDnaBetter = true;
                    }
                    else if (currentStartIndex == startIndex)
                    {
                        if (currentDnaSum > bestDnaSum)
                        {
                            isCurrentDnaBetter = true;
                        }
                    }
                }

                currentSampleIndex++;

                if (isCurrentDnaBetter)
                {
                    bestDna = dna;
                    bestLen = maxLength;
                    startIndex = currentStartIndex;
                    bestDnaSum = currentDnaSum;
                    bestSampleIndex = currentSampleIndex;
                }

                sequence = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}
