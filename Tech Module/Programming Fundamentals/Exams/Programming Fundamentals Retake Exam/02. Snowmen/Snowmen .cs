using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowman = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (snowman.Count != 1)
            {
                List<int> snowmanToRemove = new List<int>();
                for (int i = 0; i < snowman.Count; i++)
                {
                    int attacker = i;
                    
                    if (snowman[i].Equals(-1))
                    {
                        continue;
                    }

                    int target = snowman[attacker] % snowman.Count;
                    int losserIndex = -1;

                    if (attacker == target)
                    {
                        losserIndex = attacker;
                        Console.WriteLine($"{attacker} performed harakiri");
                    }
                    else
                    {
                        int difference = Math.Abs(attacker - target);
                        
                        int winnewIndex = -1;
                        if (difference % 2 == 0)
                        {
                            winnewIndex = attacker;
                            losserIndex = target;
                        }
                        else
                        {
                            winnewIndex = target;
                            losserIndex = attacker;
                        }

                        Console.WriteLine($"{attacker} x {target} -> {winnewIndex} wins");
                    }

                    if (!snowman[losserIndex].Equals(-1))
                    {
                        snowman[losserIndex] = -1;
                    }

                    if (snowman.Count == snowman.Where(m => m.Equals(-1)).Count() + 1)
                    {
                        break;
                    }
                }

                snowman = snowman.Where(m => !m.Equals(-1)).ToList();
            }
        }
    }
}