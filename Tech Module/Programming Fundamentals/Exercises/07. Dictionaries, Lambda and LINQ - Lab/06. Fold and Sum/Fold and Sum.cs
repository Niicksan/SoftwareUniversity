using System;
using System.Linq;

namespace _06._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] leftPart = numbers.Take(k).Reverse().ToArray();
            int[] rigthPart = numbers.Reverse().Take(k).ToArray();

            leftPart = leftPart.Concat(rigthPart).ToArray();

            int[] midElements = numbers.Skip(k).Take(k * 2).ToArray();

            Console.WriteLine(
                    string.Join(" ",
                    midElements.Select((el, i) => 
                    el += leftPart[i])
                ));
        }
    }
}
