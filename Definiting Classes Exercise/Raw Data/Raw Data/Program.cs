using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                Engine NewEngine = GetEngine(engineSpeed, enginePower);
                int cargoWeight = int.Parse(input[3]);
                string type = input[4];
                Cargo NewCargo = GetCargo(cargoWeight, type);
                List<Tire> tires = new List<Tire>();
                for (int j = 5; j < input.Length; j+=2)
                {
                    double pressuare = double.Parse(input[j]);
                    int age = int.Parse(input[j+1]);
                    
                    Tire tire = GetTire(age, pressuare);
                    tires.Add(tire);
                    
                }
                Car newCar = new Car(model, NewEngine, NewCargo, tires);
                cars.Add(newCar);
            }
            string command = Console.ReadLine();
            List<Car> ResultCar = new List<Car>();
            if (command== "fragile")
            {
                ResultCar = cars.Where(c => c.cargo.Type == "fragile" && c.Tires.Any(p => p.Pressure < 1)).ToList();
            }
            else if (command=="flamable")
            {
                ResultCar = cars.Where(c => c.cargo.Type == "flamable" && c.engine.EnginePower > 250).ToList();
            }

            ;
            foreach (var item in ResultCar)
            {
                Console.WriteLine(item);
            }
        }

       static Engine GetEngine(int engineSpeed, int enginePower)
        {
            return new Engine(engineSpeed, enginePower);
        }
       static  Cargo GetCargo(int weight ,string type)
        {
            return new Cargo(weight, type);
        }
       static Tire GetTire(int age,double presssuare)
        {
            return new Tire(age, presssuare);
        }

    }
}
