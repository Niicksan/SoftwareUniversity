using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfTheGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] lockSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletSize);
            Queue<int> locks = new Queue<int>(lockSize);

            int counter = 0;
            int bulletsCounter = 0;

            while (locks.Count > 0)
            {
                if (bullets.Count == 0)
                {
                    break;
                }

                int bullet = bullets.Peek();
                int lockk = locks.Peek();

                if (bullet > lockk)
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();

                    bulletsCounter++;                   
                }
                else
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                   
                    bulletsCounter++;
                }

                counter++;

                if (counter == sizeOfTheGunBarrel && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }
            }

            double earned = intelligence - (bulletsCounter * bulletPrice);
            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
