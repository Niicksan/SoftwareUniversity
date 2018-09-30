using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> evenNumber = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!evenNumber.ContainsKey(number))
                {
                    evenNumber.Add(number, 0);
                }

                evenNumber[number]++;
            }

            foreach (var number in evenNumber.Where(num => num.Value % 2 == 0))
            {
                Console.WriteLine(number.Key);
            }
        }
    }
}
