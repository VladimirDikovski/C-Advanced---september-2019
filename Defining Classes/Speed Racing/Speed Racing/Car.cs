using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
   public class Car
    {
        public string Model { get; set; }
        public  double FuelAmount { get; set; }
        public  double FuelConsumptionPerKilometer { get; set; }
        public double Travelleddistance { get; set; }

        public Car(string model,double fuelAmount,double fuelconsumptionperkilometar)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelconsumptionperkilometar;
            this.Travelleddistance = 0;
        }
        public Car()
        {

        }
    
        public void Drive(string model, double amountKm)
        {

            double neededLitres = amountKm * this.FuelConsumptionPerKilometer;
            if (this.FuelAmount >= neededLitres)
            {
                this.FuelAmount -= neededLitres;
                this.Travelleddistance += amountKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
