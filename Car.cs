using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipWithUnitTesting
{
    public class Car
    {
        public string Brand { get; private set; }
        public string RegNum { get; private set; }
        public int Year { get; private set; }
        public int Kilometers { get; private set; }

        public Car(string brand, string regNum, int year, int kilometers)
        {
            Brand = brand;
            RegNum = regNum;
            Year = year;
            Kilometers = kilometers;
        }
    }
}
