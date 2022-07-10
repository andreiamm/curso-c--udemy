using System;
using System.Globalization;

namespace ex05_funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Employee emp = new Employee();

            Console.Write("Nome: ");
            emp.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            emp.GrossSalary = double.Parse(Console.ReadLine(), CI);
            Console.Write("Imposto: ");
            emp.Tax = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + emp);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentage = double.Parse(Console.ReadLine(), CI);
            emp.IncreaseSalary(percentage);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + emp);
        }
    }
}
