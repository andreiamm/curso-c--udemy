using exercicio23.Entities;
using exercicio23.Services;
using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            CultureInfo cultures = new CultureInfo("pt-BR");

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickupDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CI);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CI);

            CarRental cr = new CarRental(pickupDate, returnDate, new Vehicle(model));

            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CI);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CI);

            RentalService rs = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());
            rs.ProcessInvoice(cr);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(cr.Invoice);
        }
    }
}
