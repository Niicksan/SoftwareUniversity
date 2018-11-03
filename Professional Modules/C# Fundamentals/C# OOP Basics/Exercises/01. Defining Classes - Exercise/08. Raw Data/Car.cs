﻿using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public bool IsFragile()
        {
            return this.cargo.CargoType == "fragile" &&
                this.tires.Any(t => t.TirePressure < 1);
        }

        public bool IsFlamable()
        {
            return this.cargo.CargoType == "flamable" &&
                this.engine.EnginePower > 250;
        }
        public string Model
        {
            get { return this.model; }
        }
    }
}
