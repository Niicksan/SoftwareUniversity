using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = GetEngines();

            List<Car> cars = GetCars(engines);

            PrintCars(cars);
        }

        private static void PrintCars(List<Car> cars)
        {
            cars.ForEach(c => Console.Write(c.ToString()));
        }

        private static List<Car> GetCars(List<Engine> engines)
        {
            List<Car> cars = new List<Car>();

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                Engine engine = engines.FirstOrDefault(e => e.Model == carInfo[1]);
                Car car = new Car(model, engine);

                if (carInfo.Length > 3)
                {
                    car.Weight = carInfo[2];
                    car.Color = carInfo[3];
                }
                else if (carInfo.Length > 2)
                {
                    string weightOrColor = carInfo[2];

                    double result;
                    bool isNumber = double.TryParse(weightOrColor, out result);

                    if (isNumber)
                    {
                        car.Weight = weightOrColor;
                    }
                    else
                    {
                        car.Color = weightOrColor;
                    }
                }
                
                cars.Add(car);
            }

            return cars;
        }

        private static List<Engine> GetEngines()
        {
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                Engine engine = new Engine(model, power);

                if (engineInfo.Length > 3)
                {
                    engine.Displacement = engineInfo[2];
                    engine.Efficiency = engineInfo[3];
                }
                else if (engineInfo.Length > 2)
                {
                    string displacementOrEfficiency = engineInfo[2];

                    double result;
                    bool IsNumber = double.TryParse(displacementOrEfficiency, out result);

                    if (IsNumber)
                    {
                        engine.Displacement = displacementOrEfficiency;
                    }
                    else
                    {
                        engine.Efficiency = displacementOrEfficiency;
                    }
                }
               
                engines.Add(engine);
            }
            return engines;
        }
    }
}
