using exercicio24.Entities;
using exercicio24.Services;
using System;
using System.Globalization;

namespace exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CI);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(contract, installments);

            Console.WriteLine("Installments:");
            foreach (Installment inst in contract.Installments)
            {
                Console.WriteLine(inst);
            }
        }
    }
}
