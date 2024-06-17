using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystemApp
{
    public class Motorcycle : Vehicle
    {
        public int RiderAge { get; set; }

        public Motorcycle(string brand, string model, decimal value, int riderAge)
            : base(brand, model, value)
        {
            RiderAge = riderAge;
        }

        public override decimal CalculateRentalCost(int rentalDays)
        {
            decimal dailyCost = rentalDays > 7 ? 10m : 15m;
            return dailyCost * rentalDays;
        }

        public override decimal CalculateInsuranceCost(int rentalDays)
        {
            decimal dailyInsurance = Value * 0.0002m;
            if (RiderAge < 25)
            {
                dailyInsurance *= 1.2m;
            }
            return dailyInsurance * rentalDays;
        }
    }
}
