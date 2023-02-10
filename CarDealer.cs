using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipWithUnitTesting
{
    public class CarDealer
    {
        private string Name;
        private string Address;
        public List<Car> Cars = new() { };

        public CarDealer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(string regNum)
        {
            foreach (Car car in Cars.ToList())  // Without ToList: "Collection was modified; enumeration operation may not execute." ??
            {
                if (car.RegNum == regNum) Cars.Remove(car);
            }           
        }

        public List<Car> GetOldCars(int year)
        {
            Console.WriteLine($"Cars made before {year}:\n"); // could move to a ShowOldCars();
            var oldCars = new List<Car>();
            foreach (Car car in Cars)
            {
                if (car.Year < year) oldCars.Add(car);
            }
            return oldCars;
        }

        public List<Car> GetHighKmCars(int km)
        {
            Console.WriteLine($"Over {km}km:\n");  // could move to a ShowHighKmCars();
            var highKmCars = new List<Car>();
            foreach (Car car in Cars)
            {
                if (car.Kilometers > km) highKmCars.Add(car);
            }
            return highKmCars;
        }

        public string ShowCars(List<Car> cars)
        {
            string carInfo = "";
            foreach (Car car in cars)
            {
                carInfo += $"- {car.Brand}\nRegistration number: {car.RegNum}\nYear made: {car.Year}\nKilometers: {car.Kilometers}\n";
            }
            return carInfo;
        }
    }
}
