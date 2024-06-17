using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystemApp
{
    public class Car : Vehicle
    {
        public int SafetyRating { get; set; }

        public Car(string brand, string model, decimal value, int safetyRating)
            : base(brand, model, value)
        {
            SafetyRating = safetyRating;
        }

        public override decimal CalculateRentalCost(int rentalDays)
        {
            decimal dailyCost = rentalDays > 7 ? 15m : 20m;
            return dailyCost * rentalDays;
        }
        public override decimal CalculateInsuranceCost(int rentalDays)
        {
            decimal dailyInsurance = Value * 0.0001m;
            if (SafetyRating >= 4)
            {
                dailyInsurance *= 0.9m;
            }
            return dailyInsurance * rentalDays;
        }
    }
}
