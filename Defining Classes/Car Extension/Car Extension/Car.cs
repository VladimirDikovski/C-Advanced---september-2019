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

        public void Drive(double distance)
        {
            double expenceFuel = this.FuelQuantity * distance / 100;
            if (expenceFuel>this.FuelQuantity)
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
