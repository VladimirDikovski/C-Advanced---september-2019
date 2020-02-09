using System;

namespace CarManufacturer
{
  public class StartUp
    {
      static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "VW";
            car.Model = "GOLF";
            car.Year = 2000;
            car.FuelQuantity = 200;
            car.FuelConsumption = 2;
            car.Drive(200);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
