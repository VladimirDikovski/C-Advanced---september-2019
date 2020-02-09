using System;

namespace CarManufacturer
{
   public class StartUp
    {
     public static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuontity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            var car = new Car(make, model, year,fuelQuontity,fuelConsumption);
            car.Drive(200);
            Console.WriteLine(car.WhoAmI());

        }
    }
}
