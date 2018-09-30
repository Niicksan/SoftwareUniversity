using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] opr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();           

            int size = opr[0];
            int remove = opr[1];
            int element = opr[2];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < size; i++)
            {
                queue.Enqueue(nums[i]);
            }

            for (int i = 0; i < remove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count != 0)
            {
                if (queue.Contains(element))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(queue.Count);
            }
        }
    }
}
