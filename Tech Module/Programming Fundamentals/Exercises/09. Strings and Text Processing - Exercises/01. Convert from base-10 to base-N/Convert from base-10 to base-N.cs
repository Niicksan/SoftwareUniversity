using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01._Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger @base = input[0];
            BigInteger number = input[1];

            StringBuilder sb = new StringBuilder();

            BigInteger rem = 0;
            while (number > 0)
            {
                rem = number % @base;
                sb.Append(rem);
                number /= @base;
            }

            string output = new string(sb.ToString().Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}
