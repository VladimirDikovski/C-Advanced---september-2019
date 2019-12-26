using System;
using System.Collections.Generic;
using System.Linq;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCar = int.Parse(Console.ReadLine());
            var trafikLight = new Queue<string>();
            int counter = 0;
            PassedCars(countCar, trafikLight,counter);
           
        }

        private static void PassedCars(int countCar, Queue<string> trafikLight,int counter)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else if(input== "green")
                {
                    for (int i = 0; i < countCar; i++)
                    {
                        if (trafikLight.Count > 0)
                        {
                            var carPassed = trafikLight.Dequeue();
                            Console.WriteLine($"{carPassed} passed!");
                            counter++;
                        }
                       
                    }
                }
                else
                {
                    trafikLight.Enqueue(input);
                }
             
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
