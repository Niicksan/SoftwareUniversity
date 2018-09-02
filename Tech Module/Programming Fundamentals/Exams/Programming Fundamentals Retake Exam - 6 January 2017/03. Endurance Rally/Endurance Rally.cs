using System;
using System.Linq;

namespace _03._Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] driverNames = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double[] zones = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] checkpoints = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            foreach (var driver in driverNames)
            {
                double driverFuel = (int)driver[0];
                int checkPointsCounter = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    bool isEqual = false;

                    for (int j = 0; j < checkpoints.Length; j++)
                    {
                        if (i == checkpoints[j])
                        {
                            isEqual = true;
                            break;
                        }
                    }

                    if (isEqual)
                    {
                        driverFuel += zones[i];
                    }
                    else
                    {
                        driverFuel -= zones[i];
                    }

                    if (driverFuel > 0)
                    {
                        checkPointsCounter++;
                    }
                    else
                    {
                        Console.WriteLine($"{driver} - reached {checkPointsCounter}");
                        break;
                    }
                }

                if (driverFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {driverFuel:f2}");
                }
            }
        }
    }
}
