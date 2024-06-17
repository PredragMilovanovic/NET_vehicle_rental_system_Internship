using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystemApp
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        public Vehicle RentedVehicle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public int RentalDays => (EndDate - StartDate).Days;
        public int ActualRentalDays => (ActualReturnDate - StartDate).Days;

        public Invoice(string customerName, Vehicle rentedVehicle, DateTime startDate, DateTime endDate, DateTime actualReturnDate)
        {
            CustomerName = customerName;
            RentedVehicle = rentedVehicle;
            StartDate = startDate;
            EndDate = endDate;
            ActualReturnDate = actualReturnDate;
        }

        public void PrintInvoice()
        {
            decimal rentalCost = CalculateTotalRentalCost();
            decimal insuranceCost = RentedVehicle.CalculateInsuranceCost(ActualRentalDays);
            decimal totalCost = rentalCost + insuranceCost;

            Console.WriteLine("XXXXXXXXXXXX");
            Console.WriteLine($"Date: {ActualReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Rented Vehicle: {RentedVehicle.Brand} {RentedVehicle.Model}\n");

            Console.WriteLine($"Reservation start date: {StartDate:yyyy-MM-dd}");
            Console.WriteLine($"Reservation end date: {EndDate:yyyy-MM-dd}");
            Console.WriteLine($"Reserved rental days: {RentalDays} days\n");

            Console.WriteLine($"Actual return date: {ActualReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Actual rental days: {ActualRentalDays} days\n");

            Console.WriteLine($"Rental cost per day: {RentedVehicle.CalculateRentalCost(RentalDays)/RentalDays:C2}");
            // if (ActualRentalDays < RentalDays)
            //  {
            if (RentedVehicle is Car c) {
                Console.WriteLine($"Insurance  per day: {insuranceCost / RentalDays:C2}\n");
            }
            if(RentedVehicle is Motorcycle m)
            {
                decimal initialInsuranceForMotor = m.Value * 0.0002m;
                Console.WriteLine($"Initial insurance  per day: {initialInsuranceForMotor:C2}");

                decimal insuranceAdditionPerDay= (m.CalculateInsuranceCost(RentalDays) / RentalDays) -initialInsuranceForMotor;
                Console.WriteLine($"Insurance addition per day: {insuranceAdditionPerDay:C2}");
                Console.WriteLine($"Insurance per day: {(insuranceCost / RentalDays):C2}\n");
            }
            if(RentedVehicle is Van v)
            {
                decimal initialInsuranceForVan = v.Value * 0.0003m;
                Console.WriteLine($"Initial insurance  per day: {initialInsuranceForVan:C2}");
                Console.WriteLine($"Insurance discount per day: {initialInsuranceForVan-(insuranceCost/ActualRentalDays):C2}");
                Console.WriteLine($"Insurance per day: {(insuranceCost / ActualRentalDays):C2}\n");
            }
            if (ActualRentalDays < RentalDays)
            {
               
                Console.WriteLine($"Early return discount for rent: {CalculateDiscountedCost()}");
                
                Console.WriteLine($"Early discount for insurance: {RentedVehicle.CalculateInsuranceCost(RentalDays-ActualRentalDays):C2}\n");
              
            }



          
            Console.WriteLine($"Total Rental Cost: {rentalCost:C2}");
            Console.WriteLine($"Total Insurance Cost: {insuranceCost:C2}");
            Console.WriteLine($"Total Cost: {totalCost:C2}");
           
            Console.WriteLine("XXXXXXXXXXXX");
        }


  
        private decimal CalculateTotalRentalCost()
        {
            if (ActualRentalDays == RentalDays)
            {
                return RentedVehicle.CalculateRentalCost(ActualRentalDays);
            }
            else
            {
                decimal fullCost = RentedVehicle.CalculateRentalCost(ActualRentalDays);

                decimal dailyCost = RentalDays > 7 ? 40m : 50m;
                decimal halfCost = dailyCost * (RentalDays - ActualRentalDays) / 2;
                return fullCost + halfCost;
            }
        }

        private decimal CalculateDiscountedCost()
        {
            decimal dailyCost = RentalDays > 7 ? 40m : 50m;
            return dailyCost * (RentalDays - ActualRentalDays) / 2;
        }

     
    }
}