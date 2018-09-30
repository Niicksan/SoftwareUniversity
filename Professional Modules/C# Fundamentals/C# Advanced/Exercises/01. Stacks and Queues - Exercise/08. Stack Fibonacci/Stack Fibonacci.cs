using System;
using System.Collections.Generic;

namespace _08._Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<long> fibonacci = new Stack<long>();
            int n = int.Parse(Console.ReadLine());

            fibonacci.Push(0);
            fibonacci.Push(1);
            
            for (int i = 0; i < n - 1; i++)
            {
                long lastNumber = fibonacci.Pop();
                long pastNumber = fibonacci.Peek();

                fibonacci.Push(lastNumber);
                fibonacci.Push(lastNumber + pastNumber);
            }

            Console.WriteLine(fibonacci.Peek());
        }
    }
}
