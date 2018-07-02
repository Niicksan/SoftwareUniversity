using System;
using System.Linq;

namespace _02._Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            long element = arr[entryPoint];
            string commandOne = Console.ReadLine();
            string commandTwo = Console.ReadLine();

            long[] left = arr.Take(entryPoint).ToArray();
            long[] right = arr.Skip(entryPoint + 1).ToArray();

            switch (commandOne)
            {
                case "cheap":
                    left = left.Where(x => x < element).ToArray();
                    right = right.Where(x => x < element).ToArray();
                    break;
                case "expensive":
                    left = left.Where(x => x >= element).ToArray();
                    right = right.Where(x => x >= element).ToArray();
                    break;
                default:
                    break;
            }

            switch (commandTwo)
            {
                case "positive":
                    left = left.Where(x => x > 0).ToArray();
                    right = right.Where(x => x > 0).ToArray();
                    break;
                case "negative":
                    left = left.Where(x => x < 0).ToArray();
                    right = right.Where(x => x < 0).ToArray();
                    break;
                default:
                    break;
            }

            string winnerr = left.Sum() >= right.Sum() ? "Left" : "Right";
            long winner = left.Sum() >= right.Sum() ? left.Sum() : right.Sum();

            Console.WriteLine($"{winnerr} - {winner}");
        }
    }
}