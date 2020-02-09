using System;

namespace CarManufacturer
{
   public class StartUp
    {
     public static void Main(string[] args)
        {

            var tires = new Tire[4]
            {
                new Tire(1,2.1),
                new Tire(1,2.2),
                new Tire(2,2.5),
                new Tire(2,2.6)
            };
            var engine = new Engine(100, 1.9);
            var car = new Car("Vw", "golf", 2015, 200, 5, engine, tires);
          

        }
    }
}
