using System;
using System.Collections.Generic;

namespace _05._Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<long> queue = new Queue<long>();

            long n = long.Parse(Console.ReadLine());

            queue.Enqueue(n);

            int count = 0;

            while (queue.Count > 0)
            {
                if (count == 50)
                {
                    break;
                }

                count++;
                long current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + 1);
                queue.Enqueue(current * 2 + 1);
                queue.Enqueue(current + 2);
            }
        }
    }
}
