# Vehicle Rental System Console Application

**Overview**
This project implements a simple console application for managing a vehicle rental system. The application allows users to rent vehicles such as cars, motorcycles, and vans. It calculates rental costs, insurance costs, and generates an invoice based on specified business rules.

**Basic Functionality**
- Vehicle Types: Available vehicles include cars, motorcycles, and cargo vans.
- Rental Information: Required information includes vehicle brand, model, value, and specifics such as safety rating for cars, rider age for motorcycles, and driver experience for vans.
- Rental Period: Users specify the start and end dates of the rental period.
- Cost Calculation: The application calculates daily rental costs and insurance costs based on the vehicle type and specified business rules.
- Invoice Generation: An invoice is generated automatically at the end of the rental period, displaying all details and costs.

**Project Structure**
The project is organized into the following components:
- Program.cs: Main entry point of the application where vehicle rentals are initiated and invoices are generated.
- Invoice.cs: Defines the Invoice class responsible for generating and printing rental invoices.
- Vehicle.cs: Abstract base class for all vehicle types, containing common properties and methods.
- Car.cs, Motorcycle.cs, Van.cs: Concrete implementations of vehicle types with specific rental and insurance cost calculations.

**Installation**
To run this application locally, follow these steps:
1. Clone Repository:
git clone https://github.com/PredragMilovanovic/vehicle-rental-system.git
2. Navigate to Directory:
cd VehicleRentalSystemApp
3. Compile and Run:
dotnet build
dotnet run
Ensure you have .NET SDK installed on your machine.

**Usage**
1. Run the Application: Execute the compiled application using `dotnet run`.
2. Follow Instructions: Enter required information when prompted (e.g., customer name, rental dates).
3. View Invoice: After entering rental details, the application will generate and display the invoice with calculated costs.

**Example Output**
Example of the generated invoice:
XXXXXXXXXXXX
Date: 2024-06-13
Customer Name: John Doe
Rented Vehicle: Mitsubishi Mirage

Reservation start date: 2024-06-03
Reservation end date: 2024-06-13
Reserved rental days: 10 days

Actual return date: 2024-06-13
Actual rental days: 10 days

Rental cost per day: $15.00
Insurance  per day: $1.50

Total Rental Cost: $150.00
Total Insurance Cost: $15.00
Total Cost: $165.00
XXXXXXXXXXXX

XXXXXXXXXXXX
Date: 2024-06-13
Customer Name: Mary Johnson
Rented Vehicle: Triumph Tiger Sport 660

Reservation start date: 2024-06-03
Reservation end date: 2024-06-13
Reserved rental days: 10 days

Actual return date: 2024-06-13
Actual rental days: 10 days

Rental cost per day: $10.00
Initial insurance  per day: $2.00
Insurance addition per day: $0.40
Insurance per day: $2.40

Total Rental Cost: $100.00
Total Insurance Cost: $24.00
Total Cost: $124.00
XXXXXXXXXXXX

XXXXXXXXXXXX
Date: 2024-06-13
Customer Name: John Markson
Rented Vehicle: Citroen Jumper

Reservation start date: 2024-06-03
Reservation end date: 2024-06-18
Reserved rental days: 15 days

Actual return date: 2024-06-13
Actual rental days: 10 days

Rental cost per day: $40.00
Initial insurance  per day: $6.00
Insurance discount per day: $0.90
Insurance per day: $5.10

Early return discount for rent: 100
Early discount for insurance: $25.50

Total Rental Cost: $500.00
Total Insurance Cost: $51.00
Total Cost: $551.00
XXXXXXXXXXXX

**License**
This project is licensed under the MIT License. See the LICENSE file for details.

