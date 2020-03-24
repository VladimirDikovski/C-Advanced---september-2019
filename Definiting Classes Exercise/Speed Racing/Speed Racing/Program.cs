using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCars = int.Parse(Console.ReadLine());
            List<Car> CarList = new List<Car>();
            for (int i = 0; i < nCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerkilometer = double.Parse(input[2]);
                var newCar = new Car(model, fuelAmount, fuelConsumptionPerkilometer);
                CarList.Add(newCar);
            }
           
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] splitedInput = input.Split(" ").ToArray();              
                string model = splitedInput[1];
                double amountOfKM = double.Parse(splitedInput[2]);
                CarList.Where(x => x.Model == model).ToList().ForEach(x => x.DriveDistance(amountOfKM));
                
            }

            foreach (var item in CarList)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount} {item.Travelleddistance}");
            }
        }
    }
}
