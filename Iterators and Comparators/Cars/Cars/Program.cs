using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Car carOne = new Car("Opel", 2000, 25000);
            Car CarTwo = new Car("Vw", 2005, 50000);
            Car CarThree = new Car("Ferrari", 2005, 500000);
            Car CarFour = new Car("BMW", 2015, 5000000);

            CarCatalog catalogOne = new CarCatalog(carOne,CarTwo,CarThree,CarFour);

            foreach (var item in catalogOne)
            {
                Console.Write($"{item.Model} {item.Year} {item.Price}");
                Console.WriteLine();
            }

           

        }
    }
}
