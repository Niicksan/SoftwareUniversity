using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<long> cups = new Queue<long>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse));
            Stack<long> bottles = new Stack<long>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse));

            long wastedWater = 0;

            while (true)
            {
                if (cups.Count == 0)
                {
                    break;
                }

                if (bottles.Count == 0)
                {
                    break;
                }

                long currentCup = cups.Peek();
                long currentBottle = bottles.Peek();

                if (currentCup <= currentBottle)
                {
                    wastedWater += (currentBottle - currentCup);

                    cups.Dequeue();
                    bottles.Pop();
                }
                else if (currentCup > currentBottle)
                {
                    currentCup -= currentBottle;
                    bottles.Pop();

                    while (currentCup > 0)
                    {
                        long nextBottle = bottles.Peek();

                        if (currentCup <= nextBottle)
                        {
                            wastedWater += (nextBottle - currentCup);

                            cups.Dequeue();
                            bottles.Pop();
                            break;
                        }
                        else
                        {
                            currentCup -= nextBottle;
                            bottles.Pop();
                        }

                    }
                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine("Cups: " + string.Join(" ", cups));
            }
            else if (bottles.Count > 0)
            {
                Console.WriteLine("Bottles: " + string.Join(" ", bottles));
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
