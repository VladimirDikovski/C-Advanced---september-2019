using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Car
    {
        public string Model { get; set; }
        public Engine engines { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        

        public Car()
        {

        }
        public Car(string model,Engine engine)
        {
            this.Model = model;
            this.engines = engine;
        }
        public Car(string model, Engine engine,string weight)
            :this(model,engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine,string weight ,string color)
            :this(model,engine,weight)
        {
          
            this.Color = color;
        }
    }
}
