using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Trainlands
{
    class Trainlands
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> trains = new Dictionary<string, Dictionary<string, long>>();
            while (input != "It's Training Men!")
            {
                string[] trainData = input.Split(new char[] { ' ', '-', '>', ':', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!input.Contains("="))
                {
                    string trainName = trainData[0];
                    string wagonName = trainData[1];

                    if (trainData.Length > 2)
                    {
                        long wagonPower = long.Parse(trainData[2]);

                        if (!trains.ContainsKey(trainName))
                        {
                            trains.Add(trainName, new Dictionary<string, long>());
                        }

                        if (!trains[trainName].ContainsKey(wagonName))
                        {
                            trains[trainName].Add(wagonName, wagonPower);
                        }
                        else
                        {
                            trains[trainName][wagonName] = wagonPower;
                        }
                    }
                    else
                    {
                        string otherTrainName = trainData[1];

                        //if (!trains.ContainsKey(trainName))
                        //{
                        //    trains[trainName] = new Dictionary<string, long>();
                        //}

                        //trains[trainName].Clear();

                        //foreach (var wagons in trains[otherTrainName])
                        //{
                        //    trains[trainName].Add(wagons.Key, wagons.Value);
                        //}

                        if (!trains.ContainsKey(trainName))
                        {
                            trains.Add(trainName, new Dictionary<string, long>());
                        }

                        Dictionary<string, long> otherTrain = trains[otherTrainName];
                        foreach (var trainNames in otherTrain)
                        {
                            trains[trainName].Add(trainNames.Key, trainNames.Value);
                        }
                        trains.Remove(otherTrainName);
                    }
                }
                else
                {
                    string trainName = trainData[0];
                    string otherTrainName = trainData[1];

                    //if (!trains.ContainsKey(trainName))
                    //{
                    //    trains.Add(trainName, new Dictionary<string, long>());
                    //}

                    //Dictionary<string, long> otherTrain = trains[otherTrainName];

                    //trains[trainName] = otherTrain;


                    if (!trains.ContainsKey(trainName))
                    {
                        trains[trainName] = new Dictionary<string, long>();
                    }

                    trains[trainName].Clear();

                    foreach (var wagons in trains[otherTrainName])
                    {
                        trains[trainName].Add(wagons.Key, wagons.Value);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var train in trains
                    .OrderByDescending(e => e.Value.Values.Sum())
                    .ThenBy(e => e.Value.Count()))
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value.OrderByDescending(e => e.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
