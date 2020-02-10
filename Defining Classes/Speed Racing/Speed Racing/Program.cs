using System;
using System.Collections.Generic;
using System.Linq;
namespace Speed_Racing
{
  public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
       
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelamaount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                var car =new Car(model, fuelamaount, fuelConsumptionFor1km);
                cars.Add(car);

            }
            while (true)
            {
                string inputSecond = Console.ReadLine();
                if (inputSecond == "End")
                {
                    break;
                }
                string[] splitetInput = inputSecond.Split();
                string type = splitetInput[0];
                string driveModel = splitetInput[1];
                double distanceTraveled = double.Parse(splitetInput[2]);
                if(type=="Drive")
                {

                }
                Car newcar = new Car();
                
             
              
            }
        }
    }
}
