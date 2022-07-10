using ex13_polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace ex13_polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CI);

                if (outsourced == 'y' || outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double charge = double.Parse(Console.ReadLine(), CI);

                    list.Add(new OutsourcedEmployee(name, hours, value, charge));
                }
                else
                {
                    list.Add(new Employee(name, hours, value));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee e in list)
            {
                Console.WriteLine(e);
            }
        }
    }
}
