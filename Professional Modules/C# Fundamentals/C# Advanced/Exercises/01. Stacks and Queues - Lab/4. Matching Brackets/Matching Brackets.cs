﻿using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            List<string> expressions = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = indexes.Pop();

                    string expr = input.Substring(startIndex, i - startIndex + 1);
                    expressions.Add(expr);
                }
            }

            Console.WriteLine(string.Join("\n", expressions));
        }
    }
}
