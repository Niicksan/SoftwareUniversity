using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Entertrain
{
    class Entertrain
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            List<int> wagons = new List<int>();
            while (command != "All ofboard!")
            {
                wagons.Add(int.Parse(command));

                if (wagons.Sum() > locomotivePower)
                {
                    int average = wagons.Sum() / wagons.Count;
                    int closest = wagons.OrderBy(item => Math.Abs(average - item)).First();

                    //int closest = int.MaxValue;

                    //for (int i = ; i < wagons.Count; i++)
                    //{
                    //    if (Math.Abs(wagons[i] - average) < closest)
                    //    {
                    //        closest = Math.Abs(wagons[i] - average);
                    //    }
                    //}

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] == closest)
                        {
                            wagons.RemoveAt(i);
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            wagons.Reverse();
            wagons.Add(locomotivePower);

            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
