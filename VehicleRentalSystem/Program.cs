using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystemApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Vehicle car = new Car("Mitsubishi", "Mirage", 15000m, 3);
            Vehicle motorcycle = new Motorcycle("Triumph", "Tiger Sport 660", 10000m, 20);
            Vehicle van = new Van("Citroen", "Jumper", 20000m, 8);

            Invoice carInvoice = new Invoice("John Doe", car, new DateTime(2024, 06, 03), new DateTime(2024, 06, 13), new DateTime(2024, 06, 13));
            carInvoice.PrintInvoice();

            Console.WriteLine();

            Invoice motorcycleInvoice = new Invoice("Mary Johnson", motorcycle, new DateTime(2024, 06, 03), new DateTime(2024, 06, 13), new DateTime(2024, 06, 13));
            motorcycleInvoice.PrintInvoice();

            Console.WriteLine();

            Invoice vanInvoice = new Invoice("John Markson", van, new DateTime(2024, 06, 03), new DateTime(2024, 06, 18), new DateTime(2024, 06, 13));
            vanInvoice.PrintInvoice();
        }

    }
}
