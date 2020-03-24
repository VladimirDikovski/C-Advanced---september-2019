using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
   public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double Travelleddistance { get; set; }

        public Car()
        {

        }
        public Car(string model,double fuelAmount, double fuelcosumptionperkilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelcosumptionperkilometer;
        }
        public void DriveDistance(double amountOfKilometer )
        {
            if (this.FuelAmount < amountOfKilometer * this.FuelConsumptionPerKilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= amountOfKilometer * this.FuelConsumptionPerKilometer;
                this.Travelleddistance += amountOfKilometer;
            }
        }
    }
}
