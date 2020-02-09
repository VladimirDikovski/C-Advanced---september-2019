using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
   public class Program
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();
            var cars = new List<Car>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input== "No more tires")
                {
                    break;
                }
                var splitInput = input.Split(" ");
                var curretTires = new Tire[4]
                {
                    new Tire(int.Parse(splitInput[0]),double.Parse(splitInput[1])),
                    new Tire(int.Parse(splitInput[2]),double.Parse(splitInput[3])),
                    new Tire(int.Parse(splitInput[4]),double.Parse(splitInput[5])),
                     new Tire(int.Parse(splitInput[6]),double.Parse(splitInput[7])),
                };
                tires.Add(curretTires);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Engines done")
                {
                    break;
                }
                var splitInput = input.Split(" ");
                for (int i = 0; i < splitInput.Length / 2; i++)
                {
                    var horsepower = int.Parse(splitInput[i + i]);
                    var cubicCapacity = double.Parse(splitInput[i + i + 1]);
                    var engine = new Engine(horsepower, cubicCapacity);
                    engines.Add(engine);

                }
               
            }

            while (true)
            {
                string input = Console.ReadLine();
                if(input== "Show special")
                {
                    break;
                }
                var splitInput = input.Split(" ");
                var make = splitInput[0];
                var model = splitInput[1];
                var year = int.Parse(splitInput[2]);
                var fuelquontity = double.Parse(splitInput[3]);
                var fuelfuelConsumption = double.Parse(splitInput[4]);
                var engineIndex = int.Parse(splitInput[5]);
                var tiresIndex = int.Parse(splitInput[6]);
                var car = new Car(make, model, year, fuelquontity, fuelfuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);

            }

            foreach (var currenCar in cars)
            {
                double totV = 0;
                bool pres = false;
                bool isyear = false;
                if (currenCar.Year >= 2017)
                {
                    isyear = true;
                }
                bool hp = false;
                if (currenCar.Engine.HorsePower >= 330)
                {
                    hp = true;
                }
                foreach (var currTires in currenCar.Tires)
                {
                    double value = currTires.Pressure;
                    totV = totV + value;
                }
                if (totV >= 9 && totV <= 10)
                {
                    pres = true;
                }
                if (isyear && hp && pres)
                {
                    currenCar.Drive(20);
                    Console.WriteLine($"Make: {currenCar.Make}\nModel: {currenCar.Model}\nYear: {currenCar.Year}\nHorsePowers: {currenCar.Engine.HorsePower}\nFuelQuantity: {currenCar.FuelQuantity}");
                }
            }

        }
            
        }
    }

