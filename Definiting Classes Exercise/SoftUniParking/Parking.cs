using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SoftUniParking
{
   public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }
        public int Count
        {
            get
            {
                return this.cars.Count;
            }
        }

        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber.Contains(car.RegistrationNumber)))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }
        
            else
            {
                this.cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
          
        }
        public string RemoveCar(string RegistrationNumber)
        {
            if (!cars.Any(x => x.RegistrationNumber.Contains(RegistrationNumber)))
            {
               return "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.RemoveAll(x => x.RegistrationNumber == RegistrationNumber);
                return $"Successfully removed {RegistrationNumber}";
            
            }
        }
        public Car GetCar(string RegistrationNumber)
        {
            return cars.Where(x => x.RegistrationNumber == RegistrationNumber).FirstOrDefault();
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var item in RegistrationNumbers)
            {
                cars.RemoveAll(x => x.RegistrationNumber == item);
            }
        }

    }
}
