using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex10_listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CI);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            
            Console.Write("Enter the employee id that will have salary increase: ");
            int empId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == empId);
            if (emp == null)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CI);

                emp.IncreaseSalary(percent);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee e in list) {
                Console.WriteLine(e);
            }
        }
    }
}
