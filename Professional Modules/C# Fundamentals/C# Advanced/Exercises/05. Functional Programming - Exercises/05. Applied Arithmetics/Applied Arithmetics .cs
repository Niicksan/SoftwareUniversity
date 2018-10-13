using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            Func<List<int>, List<int>> add = x => x.Select(y => y + 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(y => y * 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(y => y - 1).ToList();
            Func<List<int>, string> stringify = x => String.Join(" ", x);

            while (command != "end")
            {

                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command == "print")
                {
                    Console.WriteLine(stringify(numbers));
                }

                command = Console.ReadLine();
            }
        }
    }
}