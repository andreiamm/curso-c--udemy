using System;
using System.Globalization;

namespace ex02_funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            emp1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            emp1.Salary = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            emp2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            emp2.Salary = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine($"Salário médio = {((emp1.Salary + emp2.Salary) / 2.0).ToString("F2", CI)}");
        }
    }
}
