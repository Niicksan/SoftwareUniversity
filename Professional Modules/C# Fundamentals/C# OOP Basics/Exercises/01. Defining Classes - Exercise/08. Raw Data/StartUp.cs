using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = GetCars();
            PrintFilteredCars(cars);
        }

        private static void PrintFilteredCars(List<Car> cars)
        {
            string cargoTypeFilter = Console.ReadLine();

            switch (cargoTypeFilter)
            {
                case "fragile":
                    foreach (var car in cars.Where(c => c.IsFragile()))
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                    break;
                case "flamable":
                    foreach (var car in cars.Where(c => c.IsFlamable()))
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                    break;
                default:
                    break;
            }
        }

        private static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();

            int carsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsNumber; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];

                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                List<Tire> tires = new List<Tire>();
                for (int tireCount = 0; tireCount < 4; tireCount++)
                {
                    var tirePressure = double.Parse(carInfo[5 + tireCount]);
                    var tireAge = int.Parse(carInfo[6 + tireCount * 2]);
                    var tire = new Tire(tirePressure, tireAge);
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            return cars;
        }
    }
}
