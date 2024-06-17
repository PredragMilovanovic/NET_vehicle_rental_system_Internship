using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystemApp
{
    public class Van : Vehicle
    {
        public int DriverExperience { get; set; }

        public Van(string brand, string model, decimal value, int driverExperience)
            : base(brand, model, value)
        {
            DriverExperience = driverExperience;
        }

        public override decimal CalculateRentalCost(int rentalDays)
        {
            decimal dailyCost = rentalDays > 7 ? 40m : 50m;
            return dailyCost * rentalDays;
        }

        public override decimal CalculateInsuranceCost(int rentalDays)
        {
            decimal dailyInsurance = Value * 0.0003m;
            if (DriverExperience > 5)
            {
                dailyInsurance *= 0.85m;
            }
            return dailyInsurance * rentalDays;
        }
    }
}
