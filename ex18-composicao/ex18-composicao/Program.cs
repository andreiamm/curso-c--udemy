using ex18_composicao.Entities;
using ex18_composicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex18_composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            Enum.TryParse(Console.ReadLine(), out WorkerLevel level);
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CI);

            Worker worker = new Worker(name, level, salary, new Department(department));

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());          

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CI);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                worker.AddContract( new HourContract(date, value, hours));
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime incomeDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {incomeDate.ToString("MM/yyyy")}: {worker.Income(incomeDate.Year, incomeDate.Month).ToString("F2", CI)}");
        }
    }
}
