using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> stack = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
               int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

               int opr = nums[0];

               if (opr == 1)
               {
                   int element = nums[1];
                   stack.Enqueue(element);
               }
               else if (opr == 2)
               {
                   stack.Dequeue();
               }
               else if (opr == 3)
               {
                   Console.WriteLine(stack.Max());
               }
            }
        }
    }
}
