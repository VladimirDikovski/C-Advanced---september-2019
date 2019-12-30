using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int durationGreenLight = int.Parse(Console.ReadLine());
            int holdValueOfGreenLight = durationGreenLight;
            int FreeWindows = int.Parse(Console.ReadLine());
            var cars = new Queue<string>();
            int passedCars = 0;
            bool isCrashHappen = false;
            char ch = ' ';
            string crashCars = string.Empty;

            while (true)
            {
                if (isCrashHappen)
                {
                    break;
                }
                string carsOrCommand = Console.ReadLine();
                if (carsOrCommand == "END")
                {
                    break;
                }
                if (carsOrCommand != "green")
                {
                      
                  cars.Enqueue(carsOrCommand);                   
                  
                }
                else if (carsOrCommand == "green")
                {
                   durationGreenLight = holdValueOfGreenLight;
                      while (cars.Count>0)
                    {
                        var currentCar = cars.Peek();

                        if (currentCar.Length <= durationGreenLight + FreeWindows)
                        {
                            passedCars++;
                            durationGreenLight -= currentCar.Length;
                            cars.Dequeue();
                        }
                        else
                        {
                            if (durationGreenLight < 1)
                            {
                                break;
                            }
                            else
                            {
                                var sum = durationGreenLight + FreeWindows;
                                crashCars = currentCar;
                                isCrashHappen = true;
                                 ch = currentCar[sum];

                                break;
                            }
                        }
                      
                    }
                
                }
            }
            if (isCrashHappen)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{crashCars} was hit at {ch}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }

        }
    }
}
