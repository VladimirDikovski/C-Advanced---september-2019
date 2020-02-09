using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string make, string model, int year, double fuelQuontity, double fuelconsumption, Engine engine, Tire[] tires)
            :this(make,model,year,fuelQuontity,fuelconsumption)
        {
            this.Engine = engine;
            this.Tires = tires;            
        }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make,string model,int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            
        }
        public Car(string make,string model,int year, double fuelQuontity ,double fuelconsumption)
            :this(make,model,year)
        {
            this.FuelQuantity = fuelQuontity;
            this.FuelConsumption = fuelconsumption;
        }

        public void Drive(double distance)
        {
            double expenceFuel = this.FuelConsumption * distance / 100;
            if (expenceFuel > this.FuelQuantity)
            {
                throw new ArgumentException("Not enough fuel to perform this trip!");

            }
            else
            {
                this.FuelQuantity -= distance / 100 * this.FuelConsumption;
            }
        }
        public string WhoAmI()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.Append($"Fuel: {this.FuelQuantity:F2}L");
            return result.ToString();

        }
    }
}
