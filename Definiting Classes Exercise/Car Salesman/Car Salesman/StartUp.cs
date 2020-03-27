using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
  public class StartUp
    {
        static void Main(string[] args)
        {
            int nEngines = int.Parse(Console.ReadLine());
            var Engines = new List<Engine>();
            Engine newEngine = new Engine();
            for (int i = 0; i < nEngines; i++)
            {
                string[] inputEngine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = inputEngine[0];
                int power = int.Parse(inputEngine[1]);
                if (inputEngine.Length == 4)
                {
                    string displacemnt = inputEngine[2];
                    string efficiancy = inputEngine[3];
                    newEngine = new Engine(model, power, displacemnt, efficiancy);
                   
                }

                else if (inputEngine.Length == 3)
                {                  
                        char firstSymbol = inputEngine[2][0];
                        if (char.IsDigit(firstSymbol))
                        {
                            string displacemnt = inputEngine[2];
                            newEngine = new Engine(model, power, displacemnt);
                            newEngine.Efficiency = "n/a";                         
                        }
                        else
                        {
                            string eficency = inputEngine[2];
                            newEngine = new Engine(model, power,"n/a");
                            newEngine.Efficiency = eficency;                           
                        }         
                }

                else if (inputEngine.Length == 2)
                {
                    newEngine = new Engine(model, power);
                    newEngine.Displacement = "n/a";
                    newEngine.Efficiency = "n/a";
                }

                Engines.Add(newEngine);
            }
            int nCars = int.Parse(Console.ReadLine());
            Car NewCar = new Car();
            var Cars = new List<Car>();
            for (int i = 0; i < nCars; i++)
            {              
                string[] inputCar = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = inputCar[0];
                string engine = inputCar[1];
                Engine CurrentEngine = Engines.Where(x => x.Model == engine).FirstOrDefault();
                
                if (inputCar.Length == 4)
                {
                    string weight = inputCar[2];
                    string color = inputCar[3];
                    NewCar = new Car(model, CurrentEngine, weight, color);
                }
                else if (inputCar.Length == 3)
                {                
                        char firsSymbol = inputCar[2][0];
                        if (char.IsDigit(firsSymbol))
                        {
                            string weight = inputCar[2];
                            NewCar = new Car(model, CurrentEngine, weight);
                            NewCar.Color = "n/a";                        
                        }
                        else
                        {
                            string color = inputCar[2];
                           
                            NewCar = new Car(model, CurrentEngine,"n/a");
                            NewCar.Color = color;                       
                        }                                                                           
                }

                else if (inputCar.Length == 2)
                {
                    NewCar = new Car(model, CurrentEngine);
                    NewCar.Weight = "n/a";
                    NewCar.Color = "n/a";
                }
                Cars.Add(NewCar);
               
            }   
            
            foreach (var car in Cars)
            {
                Console.WriteLine(car.Model);
                Console.WriteLine(car.engines.Model);
                Console.WriteLine($"Power: {car.engines.Power}");
                Console.WriteLine($"Displacement: {car.engines.Displacement}");
                Console.WriteLine($"Efficiency: {car.engines.Efficiency}");
                Console.WriteLine($"Weight: {car.Weight}");
                Console.WriteLine($"Color: {car.Color}");
             
            }
        }
     
    }
}
