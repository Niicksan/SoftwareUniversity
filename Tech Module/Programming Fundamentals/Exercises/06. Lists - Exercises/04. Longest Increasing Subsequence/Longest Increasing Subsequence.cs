using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {   // Work but 66/100
            //input:
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var seq = new List<int>();
            var longestSeq = new List<int>();
            seq.Add(nums[0]);
            longestSeq.Add(nums[0]);

            int longestSeqMax = nums[0];
            int longestSeqMin = nums[0];
            int currentSeqMin = nums[0];
            int currentSeqMax = nums[0];

            for (int index = 1; index < nums.Count(); index++)
            {
                int current = nums[index];

                if (current > currentSeqMin)
                {
                    if (current > currentSeqMax)
                    {
                        seq.Add(current);
                        currentSeqMax = current;
                    }
                    else if (current < currentSeqMax && (seq.IndexOf(current) == -1))
                    {
                        seq = seq.Where(n => n < current).ToList();
                        seq.Add(current);
                        currentSeqMax = current;
                    }

                    if (current > longestSeqMax)
                    {
                        longestSeq.Add(current);
                        longestSeqMax = current;
                    }

                    if (seq.Count() > longestSeq.Count())
                    {
                        longestSeq.Clear();
                        longestSeq = seq.Skip(0).Take(seq.Count()).ToList();
                        longestSeqMin = longestSeq[0];
                        longestSeqMax = longestSeq[longestSeq.Count() - 1];
                    }

                }
                else
                {
                    if (seq.Count() > longestSeq.Count())
                    {
                        longestSeq.Clear();
                        longestSeq = seq.Skip(0).Take(seq.Count()).ToList();
                        longestSeqMax = longestSeq[longestSeq.Count() - 1];
                        longestSeqMin = longestSeq[0];
                    }

                    seq.Clear();
                    seq.Add(current);
                    currentSeqMin = current;
                    currentSeqMax = current;
                }
            }
           
            Console.WriteLine(string.Join(" ", longestSeq));

            //goto input;
        }

        static bool HasChanceToIncrease(int startIndex, int number, List<int> nums)
        {
            if (startIndex == nums.Count() - 1)
            {
                if (number < nums[startIndex])
                {
                    return true;
                }
            }
            for (int index = startIndex; index < nums.Count(); index++)
            {
                if (number < nums[index])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
