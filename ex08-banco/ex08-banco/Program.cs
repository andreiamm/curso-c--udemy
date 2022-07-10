using System;
using System.Globalization;

namespace ex08_banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Account acc;

            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char deposit = char.Parse(Console.ReadLine());

            if (deposit == 's' || deposit == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CI);

                acc = new Account(number, holder, initialDeposit);
            }
            else
            {
                acc = new Account(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(acc);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double value = double.Parse(Console.ReadLine(), CI);
            acc.Deposit(value);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(acc);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            value = double.Parse(Console.ReadLine(), CI);
            acc.Withdraw(value);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(acc);
        }
    }
}
