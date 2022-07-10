using System;
using System.Globalization;

namespace ex07_conversor_moeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            double exchangeRate = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantos dólares você vai comprar? ");
            double exchangeAmount = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Valor a ser pago em reais = " + CurrencyConverter.Convert(exchangeRate, exchangeAmount).ToString("F2", CI));

        }
    }
}
