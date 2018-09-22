using System;
using System.Collections.Generic;

namespace _6._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> queue = new Queue<string>();
            int count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;

                        if (queue.Count == 0)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
