using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsParking = new HashSet<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] splitInput = input.Split(", ");
                string command = splitInput[0];
                string cars = splitInput[1];
                if (command =="IN")
                {                   
                    PutcarInParking(carsParking,cars);
                }
                else if(command== "OUT")
                {
                    CutCarInParking(carsParking, cars);
                }
              
            }
            PrintCarsInParking(carsParking);
        }

        private static void PrintCarsInParking(HashSet<string> carsParking)
        {
            if (carsParking.Count > 0)
            {
                foreach (var car in carsParking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }

        private static void CutCarInParking(HashSet<string> carsParking, string cars)
        {
            carsParking.Remove(cars);
        }

        private static void PutcarInParking(HashSet<string> carsParking, string cars)
        {
            carsParking.Add(cars);
        }
    }
}
