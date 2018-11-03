using System;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private int distance;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distance = 0;
        }

        public void Move(double fuelConsumption, int distance)
        {
            if (fuelConsumption * distance <= fuelAmount)
            {
                this.fuelAmount -= (fuelConsumption * distance);
                this.distance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public string Model
        {
            get { return this.model; }
        }

        public int Distance
        {
            get { return this.distance; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
        }
    }
}
