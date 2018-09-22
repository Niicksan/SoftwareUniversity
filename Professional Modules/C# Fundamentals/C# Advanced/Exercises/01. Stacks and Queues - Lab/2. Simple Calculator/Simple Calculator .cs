using System;
using System.Collections.Generic;
using System.Linq;
namespace _2._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ').ToArray();

            Stack<string> stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int firstOperand = int.Parse(stack.Pop());
                string operetor = stack.Pop();
                int secondOperand = int.Parse(stack.Pop());

                switch (operetor)
                {
                    case "+":
                        stack.Push((firstOperand + secondOperand).ToString());
                        break;
                    case "-":
                        stack.Push((firstOperand - secondOperand).ToString());
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
