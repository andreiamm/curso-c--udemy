using ex16_classes_abstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex16_classes_abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CI);

                if (payerType == 'i' || payerType == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CI);

                    list.Add(new Individual(name, income, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, income, employees));
                }
            }

            double totalTaxes = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer payer in list)
            {
                Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CI)}");
                totalTaxes += payer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: {totalTaxes.ToString("F2", CI)}");
        }
    }
}
