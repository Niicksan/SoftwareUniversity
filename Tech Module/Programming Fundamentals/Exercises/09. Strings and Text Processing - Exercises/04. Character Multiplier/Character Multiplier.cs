using System;
using System.Linq;
using System.Text;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string first = words[0];
            string second = words[1];

            double sum = 0;
            int minLength = Math.Min(first.Length, second.Length);
            int maxLength = Math.Max(first.Length, second.Length);

            first = first.PadRight(maxLength, '\x0001');
            second = second.PadRight(maxLength, '\x0001');

            for (int i = 0; i < maxLength; i++)
            {
                sum += first[i] * second[i];
            }

            Console.WriteLine(sum);
        }
    }
}