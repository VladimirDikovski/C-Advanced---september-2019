using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
  public  class Car
    {
        private string make;
        private string model;
        private int horsepower;
        private string registretionNumber;

        public Car()
        {

        }
        public Car(string make,string model,int horsepower,string regnumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsepower;
            this.RegistrationNumber = regnumber;
        }
        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int HorsePower
        {
            get
            {
                return this.horsepower;
            }
            set
            {
                this.horsepower = value;
            }
        }
        public string RegistrationNumber
        {
            get
            {
                return this.registretionNumber;
            }
            set
            {
                this.registretionNumber = value;
            }
        }

        public override string ToString()
        {
            return $"Make: {Make}\nModel: {Model}\nHorsePower: {HorsePower}\nRegistrationNumber: {RegistrationNumber}";
          
        }
    }
}
