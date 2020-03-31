using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
   public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public Car(string model,int year,int price)
        {
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }
    }
}
