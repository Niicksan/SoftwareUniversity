using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stackOfParenthesis = new Stack<char>();

            string parenthesis = Console.ReadLine();

            char[] openParenthesis = new char[] { '(', '[', '{'};

            bool isValid = true;

            for (int i = 0; i < parenthesis.Length; i++)
            {
                char currentBracket = parenthesis[i];

                if (openParenthesis.Contains(currentBracket))
                {
                    stackOfParenthesis.Push(currentBracket);
                    continue;
                }

                if (stackOfParenthesis.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParenthesis.Peek() == '(' && currentBracket == ')')
                {
                    stackOfParenthesis.Pop();
                }
                else if (stackOfParenthesis.Peek() == '[' && currentBracket == ']')
                {
                    stackOfParenthesis.Pop();
                }
                else if (stackOfParenthesis.Peek() == '{' && currentBracket == '}')
                {
                    stackOfParenthesis.Pop();
                }
            }

            if (isValid && stackOfParenthesis.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
