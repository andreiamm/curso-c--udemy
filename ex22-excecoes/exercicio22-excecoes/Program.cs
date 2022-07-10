using exercicio22_excecoes.Entities;
using exercicio22_excecoes.Entities.Exceptions;
using System;
using System.Globalization;

namespace exercicio22_excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CI);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CI);

                Account acc = new Account(number, holder, initialBalance, limit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CI);
                acc.Withdraw(amount);
                Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CI)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
