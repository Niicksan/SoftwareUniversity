using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double result = 0;

            foreach (var word in words)
            {
                char first = word[0];
                char last = word[word.Length - 1];

                double number = double.Parse(word.Substring(1, word.Length - 2));

                if (char.IsUpper(first))
                {
                    number /= first - 64;
                }
                else
                {
                    number *= first - 96;
                }

                if (char.IsUpper(last))
                {
                    number -= (last - 64);
                }
                else
                {
                    number += (last - 96);
                }
                result += number;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
