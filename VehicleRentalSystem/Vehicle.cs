using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystemApp
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }

        protected Vehicle(string brand, string model, decimal value)
        {
            Brand = brand;
            Model = model;
            Value = value;
        }

        public abstract decimal CalculateRentalCost(int rentalDays);
        public abstract decimal CalculateInsuranceCost(int rentalDays);
    }
}
