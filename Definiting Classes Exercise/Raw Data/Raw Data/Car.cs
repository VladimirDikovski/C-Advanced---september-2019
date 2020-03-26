using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        public string Model { get; set; }

        public Engine engine { get; set; }

        public Cargo cargo { get; set; }

        public List<Tire> Tires = new List<Tire>();

        public Car()
        {

        }
        
        public Car(string model,Engine engine,Cargo cargo,List<Tire>tires)
        {
            this.Model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.Tires = tires;
        }

        public override string ToString()
        {
            return $"{this.Model}";
        }

    }
}
