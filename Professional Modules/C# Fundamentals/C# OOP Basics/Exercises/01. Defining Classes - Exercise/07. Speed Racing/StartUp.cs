using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> vehicles = GetCars();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandInfo = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = commandInfo[1];
                int distance = int.Parse(commandInfo[2]);

                foreach (var car in vehicles.Where(x => x.Model == model))
                {
                    car.Move(car.FuelConsumption, distance);
                }

                command = Console.ReadLine();
            }

            Print(vehicles);
        }

        private static List<Car> GetCars()
        {
            List<Car> vehicles = new List<Car>();

            int cars = int.Parse(Console.ReadLine());

            for (int i = 0; i < cars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);

                vehicles.Add(car);
            }

            return vehicles;
        }

        private static void Print(List<Car> vehicles)
        {
            foreach (var car in vehicles)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }
        }
    }
}
