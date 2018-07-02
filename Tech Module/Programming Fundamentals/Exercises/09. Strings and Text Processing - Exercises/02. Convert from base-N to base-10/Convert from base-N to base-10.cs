using System;
using System.Linq;
using System.Numerics;

namespace _02._Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int @base = int.Parse(input[0]);
            char[] number = input[1].Reverse().ToArray();

            BigInteger totalSum = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                BigInteger sum = int.Parse(number[i].ToString()) * BigInteger.Pow(@base, i);
                totalSum += sum;
            }

            Console.WriteLine(totalSum);
        }
    }
}
